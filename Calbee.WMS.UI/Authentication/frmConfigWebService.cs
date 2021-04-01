using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calbee.Infra.Helper.Message;
using Calbee.Infra.Shared;

namespace Calbee.WMS.UI.Authentication
{
    public partial class frmConfigWebService : Form
    {
        #region Member

        private static AppContext appContext = AppContext.Instance;
        public AppContext AppContext
        {
            get { return appContext; }
        }

        #endregion

        #region Constructor

        public frmConfigWebService()
        {
            InitializeComponent();
        }

        #endregion

        #region Method

        private bool VeriflyData()
        {
            if (string.IsNullOrEmpty(txtURLWebService.Text.Trim()))
            {
                MsgBox.DialogWarning("Please input URL Web service or IPServername !");
                txtURLWebService.Focus();
                return false;
            }
            else
            {
                string messageResult = string.Empty;
                if (!AppContext.DoValidateServiceName(this.txtURLWebService.Text, ref messageResult))
                {
                    MsgBox.DialogWarning("Server Name/IP incorrect format");
                    txtURLWebService.Focus();
                    return false;
                }
            }

            return true;
        }
        private void SaveConfig()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Calbee.WMS.Services.Core.CoreServiceProxy.SaveConfig(this.txtURLWebService.Text.Trim());
                MsgBox.DialogInfomation("Save Server Name/IP success");
                Calbee.WMS.Services.Core.CoreServiceProxy.IPAddress = txtURLWebService.Text.Trim();
                this.Close();

                Calbee.WMS.Services.Core.CoreServiceProxy.IPAddress = Calbee.WMS.Services.Core.CoreServiceProxy.ReadConfig();
                Calbee.WMS.Services.Core.CoreServiceProxy.WS.Timeout = Calbee.Infra.Common.Constants.IConstants.timeOut;
                DateTime OutputResult; bool OutputSpacial;
                Calbee.WMS.Services.Core.CoreServiceProxy.WS.GetCurrentDateTime(out OutputResult, out OutputSpacial);
                if (OutputResult != null)
                {
                    // Connect success : Online.
                    Cursor.Current = Cursors.Default;
                    MsgBox.DialogInfomation("Save successfully -> Please open program again");
                    Application.Exit();
                }
            }
            catch (System.Net.WebException WebEx)
            {
                MsgBox.DialogError("Can't connect to server : " + WebEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("System warning " + ex.Message);
                this.txtURLWebService.Focus();
                this.txtURLWebService.SelectAll();
                return;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void ForceExitApplication()
        {
            if (MessageBox.Show("Do you want to force exit program", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion

        #region Event

        private void frmConfigWebService_Load(object sender, EventArgs e)
        {
            try
            {
                //แสดง IP ที่ได้เก็บไว้ที่ textfile
                Cursor.Current = Cursors.Default;
                txtURLWebService.Text = Calbee.WMS.Services.Core.CoreServiceProxy.ReadConfig().Trim();
                this.txtURLWebService.Focus();
                this.txtURLWebService.ReadOnly = false;
                this.btnSave.Visible = false;
            }
            catch (System.Net.WebException WebEx)
            {
                MsgBox.DialogError("Error form load of web : " + WebEx.Message);
            }
            catch (Exception ex)
            {
                MsgBox.DialogError("Error form load : " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void frmConfigWebService_KeyUp(object sender, KeyEventArgs e)
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

        private void txtURLWebService_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTestConnection_Click(null, new EventArgs());
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (!VeriflyData())
                {
                    return;
                }
                else
                {
                    using (Calbee.WMS.Services.CoreService.CoreService wsTest = new Calbee.WMS.Services.CoreService.CoreService())
                    {
                        wsTest.Url = "http://" + txtURLWebService.Text.Trim() + "/coreservice.svc";
                        DateTime OutputResult; bool OutputSpacial;
                        wsTest.GetCurrentDateTime(out OutputResult, out OutputSpacial);
                        if (OutputResult != null)
                        {
                            Cursor.Current = Cursors.Default;
                            MsgBox.DialogInfomation("Connection server complete");
                            this.txtURLWebService.ReadOnly = true;
                            this.btnSave.Visible = true;
                        }
                        else
                        {
                            this.txtURLWebService.ReadOnly = false;
                            this.btnSave.Visible = false;
                        }
                    }
                }
            }
            catch (System.Net.WebException WebEx)
            {
                MsgBox.DialogError("Error test connection of web : " + WebEx.Message);
                this.txtURLWebService.ReadOnly = false;
                this.btnSave.Visible = false;
                this.txtURLWebService.Focus();
                this.txtURLWebService.SelectAll();
            }
            catch (Exception ex)
            {
                MsgBox.DialogError("Error test connection : " + ex.Message);
                this.txtURLWebService.ReadOnly = false;
                this.btnSave.Visible = false;
                this.txtURLWebService.Focus();
                this.txtURLWebService.SelectAll();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtURLWebService.Text))
            {
                MsgBox.DialogWarning("Please insert Server Name/IP"); 
                txtURLWebService.Focus(); 
                return;
            }
            else
            {
                string messageResult = string.Empty;
                if (!AppContext.DoValidateServiceName(this.txtURLWebService.Text, ref messageResult))
                {
                    MsgBox.DialogWarning("Server Name/IP incorrect format"); 
                    return;
                }
                else
                {
                    SaveConfig();
                }
            }
        }

        #endregion
    }
}