using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calbee.Infra.Shared;
using Calbee.Infra.Helper.Message;

namespace Calbee.WMS.UI.Forms.Putaway
{
    public partial class frmPutawayStaging : Form
    {
        #region Member

        string pickingListNo = string.Empty;
        private static AppContext appContext = AppContext.Instance;
        public AppContext AppContext
        {
            get { return appContext; }
        }

        #endregion

        #region Constructor

        public frmPutawayStaging()
        {
            InitializeComponent();
        }
        public frmPutawayStaging(string paramPickingListNo)
        {
            InitializeComponent();
            this.pickingListNo = string.IsNullOrEmpty(paramPickingListNo) ? string.Empty : paramPickingListNo;
        }

        #endregion

        #region Method

        private void ForceExitApplication()
        {
            if (MessageBox.Show("Do you want to force exit program", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private bool DoValidate()
        {
            if (string.IsNullOrEmpty(this.txtToLocation.Text.Trim()))
            {
                MsgBox.DialogWarning("Please scan to location");
                this.txtToLocation.Focus();
                this.txtToLocation.SelectAll();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void DoSave()
        {
            try
            {
                Calbee.WMS.Services.OutboundService.PickItem putstaging = new Calbee.WMS.Services.OutboundService.PickItem();
                putstaging.Device = AppContext.DeviceName;
                putstaging.PickingListNumber = this.txtPickingListNo.Text.Trim();
                putstaging.WarehouseCode = Calbee.Infra.Common.Constants.WConstants.wareHouseDDL;
                putstaging.Location = Calbee.Infra.Common.Constants.WConstants.forkLiftDDL;
                putstaging.PickBy = Calbee.Infra.Common.Constants.WConstants.userName;
                putstaging.PickDate = Convert.ToDateTime(AppContext.GetDateTimeServerString(Calbee.Infra.Common.Constants.WConstants.formatDateString));
                putstaging.PickDateSpecified = true;
                putstaging.ToLocation = this.txtToLocation.Text.Trim();
                Calbee.WMS.Services.OutboundService.Response savePutToStaging = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.PutToStaging(putstaging);
                if (savePutToStaging != null)
                {
                    if (savePutToStaging.StatusCode == 0)
                    {
                        // Success = StatusCode 0
                        MsgBox.DialogInfomation(savePutToStaging.Message);
                    }
                    else
                    {
                        MsgBox.DialogError(savePutToStaging.Message);
                    }
                }
            }
            catch (Exception ex)
            {
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
        }

        #endregion

        #region Event

        private void frmPutawayStaging_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtPickingListNo.Text = string.IsNullOrEmpty(this.pickingListNo) ? string.Empty : this.pickingListNo;
                var pickingListNoResult = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetLocation(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, string.Empty, string.Empty, Calbee.Infra.Common.Constants.WConstants.putawayStagingLocationType);
                if (pickingListNoResult != null)
                {
                    this.txtToLocation.Text = string.IsNullOrEmpty(pickingListNoResult.LocationCode) ? string.Empty : pickingListNoResult.LocationCode;
                    this.txtToLocation.Focus();
                    this.txtToLocation.SelectAll();
                }
                else
                {
                    this.txtToLocation.Focus();
                    this.txtToLocation.SelectAll();
                }
            }
            catch (Exception ex)
            {
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
        }
        private void frmPutawayStaging_KeyUp(object sender, KeyEventArgs e)
        {
            if (Calbee.Infra.Common.Constants.WConstants.eventEnter == 112)
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.F1:
                        btnSave_Click(null, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
            else if (Calbee.Infra.Common.Constants.WConstants.eventEnter == 113)
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.F2:
                        btnSave_Click(null, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
            else if (Calbee.Infra.Common.Constants.WConstants.eventEnter == 114)
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.F3:
                        btnSave_Click(null, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
            else if (Calbee.Infra.Common.Constants.WConstants.eventEnter == 115)
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.F4:
                        btnSave_Click(null, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
            else if (Calbee.Infra.Common.Constants.WConstants.eventEnter == 116)
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.F5:
                        btnSave_Click(null, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
            else if (Calbee.Infra.Common.Constants.WConstants.eventEnter == 117)
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.F6:
                        btnSave_Click(null, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
            else if (Calbee.Infra.Common.Constants.WConstants.eventEnter == 118)
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.F7:
                        btnSave_Click(null, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
            else if (Calbee.Infra.Common.Constants.WConstants.eventEnter == 119)
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.F8:
                        btnSave_Click(null, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
            else if (Calbee.Infra.Common.Constants.WConstants.eventEnter == 120)
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.F9:
                        btnSave_Click(null, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
            else if (Calbee.Infra.Common.Constants.WConstants.eventEnter == 121)
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.F10:
                        btnSave_Click(null, new EventArgs());
                        break;
                    default:
                        break;
                }
            }

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

        private void txtToLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, new EventArgs());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            /* ถ้าต้องการให้ Refresh หน้า Control ให้เปิด Comment ออก
            Forms.Pickup.frmPickItem fPickItem = new Calbee.WMS.UI.Forms.Pickup.frmPickItem();
            fPickItem.Show();
            */

            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!DoValidate())
            {
                return;
            }
            else
            {
                DoSave();
            }
        }

        #endregion
    }
}