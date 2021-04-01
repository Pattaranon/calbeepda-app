using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using System.Windows.Forms;
using Calbee.Infra.Helper.Message;
using Calbee.WMS.Services;
using Calbee.Infra.Shared;
using System.IO;
using System.Diagnostics;

namespace Calbee.WMS.UI.Authentication
{
    public partial class frmLogin : Form
    {
        #region Member

        private static AppContext appContext = AppContext.Instance;
        public AppContext AppContext
        {
            get { return appContext; }
        }
        public string currentVersion { get; set; }

        #endregion

        #region Constructor

        public frmLogin()
        {
            InitializeComponent();
        }

        #endregion

        #region Method

        private bool DoValidateLogin(string userName, string passWord)
        {
            if (string.IsNullOrEmpty(userName))
            {
                MsgBox.ShowExclamation("Please input username");
                txtUserName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(passWord))
            {
                MsgBox.ShowExclamation("Please input password");
                txtPassword.Focus();
                return false;
            }

            return true;
        }
        private void ForceExitApplication()
        {
            if (MessageBox.Show("Do you want to force exit program", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void RefreshConnection()
        {
            string ipConfig = Calbee.WMS.Services.Core.CoreServiceProxy.ReadConfig();
            Calbee.WMS.Services.Authorization.AuthorizeServiceProxy.IPAddress = ipConfig;
            Calbee.WMS.Services.Core.CoreServiceProxy.IPAddress = ipConfig;
            Calbee.WMS.Services.Core.DownloadCAB.IPAddress = ipConfig;
            Calbee.WMS.Services.Inbound.InboundServiceProxy.IPAddress = ipConfig;
            Calbee.WMS.Services.Inventory.InventoryServiceProxy.IPAddress = ipConfig;
            Calbee.WMS.Services.Masters.MasterServiceProxy.IPAddress = ipConfig;
            Calbee.WMS.Services.Outbound.OutboundServiceProxy.IPAddress = ipConfig;
            Calbee.WMS.Services.Count.CountServiceProxy.IPAddress = ipConfig;
            Calbee.WMS.Services.ServiceMode.Mode.IPAddress = ipConfig;


            /*
            Calbee.WMS.Services.Authorization.AuthorizeServiceProxy.IPAddress = AppContext.ReadConfig();
            Calbee.WMS.Services.Core.CoreServiceProxy.IPAddress = AppContext.ReadConfig();
            Calbee.WMS.Services.Inbound.InboundServiceProxy.IPAddress = AppContext.ReadConfig();
            Calbee.WMS.Services.Inventory.InventoryServiceProxy.IPAddress = AppContext.ReadConfig();
            Calbee.WMS.Services.Masters.MasterServiceProxy.IPAddress = AppContext.ReadConfig();
            Calbee.WMS.Services.Outbound.OutboundServiceProxy.IPAddress = AppContext.ReadConfig();
            Calbee.WMS.Services.Count.CountServiceProxy.IPAddress = AppContext.ReadConfig();
            Calbee.WMS.Services.ServiceMode.Mode.IPAddress = AppContext.ReadConfig();
            */
        }
        private void DownloadFile(string urlPath)
        {
            Process.Start(urlPath, null);
        }
        private void SignIn()
        {
            string messageResult = string.Empty;
            if (Calbee.WMS.Services.ServiceMode.Mode.IsOnline())
            {
                if (!DoValidateLogin(this.txtUserName.Text.Trim(), this.txtPassword.Text.Trim()))
                {
                    Cursor.Current = Cursors.Default;
                    return;
                }
                else
                {
                    if (AppContext.DoLogin(this.txtUserName.Text.Trim(), this.txtPassword.Text.Trim(), ref messageResult))
                    {
                        Cursor.Current = Cursors.Default;
                        // Success
                        Calbee.Infra.Common.Constants.WConstants.userName = this.txtUserName.Text.Trim();
                        using (MainMenu.frmSelectWAF fWAF = new Calbee.WMS.UI.MainMenu.frmSelectWAF())
                        {
                            fWAF.ShowDialog();
                            this.txtUserName.Text = string.Empty;
                            this.txtPassword.Text = string.Empty;
                            this.txtUserName.Focus();
                            this.txtUserName.Select(0, 0);
                        }
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        MsgBox.DialogError(messageResult);
                    }
                }
            }
            else
            {
                MsgBox.DialogError("Can not login because system offline mode");
                return;
            }
        }

        #endregion

        #region Event

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshConnection();
                Calbee.Infra.Common.Constants.WConstants.userName = string.Empty;
                lblVersion.Text = "Version : " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString().Trim();
                currentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString().Trim();

                string serverVersion = Calbee.WMS.Services.Core.CoreServiceProxy.WS.GetProgramVersion(Calbee.Infra.Common.Constants.WConstants.defaultProgramName);

                if (!currentVersion.Equals(serverVersion))
                {
                    if (MessageBox.Show("Do you want to updates program", "Confirm", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        // update program from server.
                        DownloadFile(Calbee.WMS.Services.Core.DownloadCAB.WS.Url);
                        Application.Exit();
                    }
                }

                this.txtUserName.Focus();
                this.txtUserName.Select(0, 0);
            }
            catch (Exception ex)
            {
                if (ex.Message.ToString().IndexOf("404") > 0)
                {
                    using (Authentication.frmConfigWebService fConfig = new frmConfigWebService())
                    {
                        fConfig.ShowDialog();
                        this.txtUserName.Focus();
                        this.txtUserName.Select(0, 0);
                    }
                }
                else
                {
                    MsgBox.DialogErrorTryCatch("Error FormLoad Login : ", ex);
                }
            }
        }
        private void frmLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (Calbee.Infra.Common.Constants.WConstants.eventForceExit == 122)
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.F11:
                        ForceExitApplication();
                        break;
                    default:
                        break;
                }
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtPassword.Focus();
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, new EventArgs());
            }
        }

        private void lnkSettingWeb_Click(object sender, EventArgs e)
        {
            using (Authentication.frmConfigWebService fConfig = new frmConfigWebService())
            {
                fConfig.ShowDialog();
                this.txtUserName.Focus();
                this.txtUserName.Select(0, 0);
            }
        }
        private void lnkCheckUpdates_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // check current versions.
                string serverVersion = Calbee.WMS.Services.Core.CoreServiceProxy.WS.GetProgramVersion(Calbee.Infra.Common.Constants.WConstants.defaultProgramName);

                if (currentVersion.Equals(serverVersion))
                {
                    // Matching version
                    MsgBox.DialogInfomation("There are currently no updates avaliable.");
                    return;
                }
                else
                {
                    if (MessageBox.Show("Do you want to updates program", "Confirm", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        // update program from server.
                        DownloadFile(Calbee.WMS.Services.Core.DownloadCAB.WS.Url);
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("System error" + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                RefreshConnection();
                string messageResult = string.Empty;
                if (!string.IsNullOrEmpty(Calbee.Infra.Common.Constants.WConstants.userName))
                {
                    if (Calbee.Infra.Common.Constants.WConstants.userName != this.txtUserName.Text.Trim())
                    {
                        MsgBox.DialogWarning("The user : " + Calbee.Infra.Common.Constants.WConstants.userName + " cannot access because it is being used by another user");
                        return;
                    }
                    else
                    {
                        SignIn();
                    }
                }
                else
                {
                    SignIn();
                }
            }
            catch (System.Net.WebException WebEx)
            {
                Cursor.Current = Cursors.Default;
                MsgBox.DialogError("Error test connection of web : " + WebEx.Message);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                if (ex.InnerException != null)
                {
                    MsgBox.DialogError(ex.InnerException.Message.ToString());
                }
                else
                {
                    if (Calbee.Infra.Common.Constants.IConstants.CatchFlag.Equals("Y"))
                    {
                        // Show error description detail
                        MsgBox.DialogError(ex.GetBaseException().ToString());
                    }
                    else
                    {
                        // Show message error
                        MsgBox.DialogError(ex.Message.ToString());
                    }
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (MessageBox.Show("Do you want to close program", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Calbee.Infra.Common.Constants.WConstants.userName = string.Empty;
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("System error" + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion
    }
}