using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calbee.Infra.Shared;
using Calbee.Infra.Helper.Objects;
using Calbee.Infra.Helper.Message;

namespace Calbee.WMS.UI.Forms.Load
{
    public partial class frmLoad : Form
    {
        #region Member

        Calbee.WMS.Entities.Picks.PickItem entLoadItem = new Calbee.WMS.Entities.Picks.PickItem();
        private static AppContext appContext = AppContext.Instance;
        public AppContext AppContext
        {
            get { return appContext; }
        }

        #endregion

        #region Constructor

        public frmLoad()
        {
            InitializeComponent();
            this.txtQuantity.KeyPress += new KeyPressEventHandler(EventControls.txtNumber_TextChanged);
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
        private void DisableControl()
        {
            this.txtItemNumber.Enabled = false;
            this.txtLotNumber.Enabled = false;
            this.txtExpiryDate.Enabled = false;
            this.txtQuantity.Enabled = false;
            this.cmbUOM.Enabled = false;
            this.txtItemStatus.Enabled = false;

            this.txtDockDoor.Focus();
            this.txtDockDoor.SelectAll();
        }
        private bool DoValidate()
        {
            if (string.IsNullOrEmpty(this.txtQuantity.Text.Trim()))
            {
                MsgBox.DialogWarning("Please input quantity");
                this.txtQuantity.Focus();
                this.txtQuantity.SelectAll();
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtDockDoor.Text.Trim()))
            {
                MsgBox.DialogWarning("Please scan dock door");
                this.txtDockDoor.Focus();
                this.txtDockDoor.SelectAll();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void DoAfterSave()
        {
            this.txtItemNumber.SetArrayItemsToCombobox(new string[] { "" });
            this.txtItemNumber.Text = string.Empty;
            this.txtDescription.Text = string.Empty;
            this.txtLotNumber.SetArrayItemsToCombobox(new string[] { "" });
            this.txtLotNumber.Text = string.Empty;
            this.txtExpiryDate.SetArrayItemsToCombobox(new string[] { "" });
            this.txtExpiryDate.Text = string.Empty;
            this.txtQuantity.Text = string.Empty;
            this.cmbUOM.DataSource = null;
            this.txtItemStatus.Text = string.Empty;

            this.txtLPN.Focus();
            this.txtLPN.SelectAll();
        }
        private void DoSave()
        {
            try
            {
                Calbee.WMS.Services.OutboundService.PickItem loaditem = new Calbee.WMS.Services.OutboundService.PickItem();
                loaditem.CarLicense = this.txtCarLicense.Text.Trim();
                loaditem.ContainerNo = this.txtContanierNo.Text.Trim();
                loaditem.Device = AppContext.DeviceName;
                loaditem.ExpiryDate = this.txtExpiryDate.Text.Trim();
                loaditem.ExpiryDateControl = entLoadItem.expiryDateControl;
                loaditem.ExpiryDateControlSpecified = true;
                loaditem.ItemNumber = this.txtItemNumber.Text.Trim();
                loaditem.Location = this.txtStagingLocation.Text.Trim();
                loaditem.ToLocation = this.txtDockDoor.Text.Trim();
                loaditem.LotControl = entLoadItem.lotControl;
                loaditem.LotControlSpecified = true;
                loaditem.LotNumber = this.txtLotNumber.Text.Trim();
                loaditem.Lpn = this.txtLPN.Text.Trim();
                loaditem.ToLpn = this.txtLPN.Text.Trim();
                loaditem.OrderNumber = this.txtOrderNumber.Text.Trim();
                loaditem.QuantityLoad = Convert.ToDouble(this.txtQuantity.Text);
                loaditem.QuantityLoadSpecified = true;
                loaditem.Status = this.txtItemStatus.Text.Trim();
                loaditem.Uom = this.cmbUOM.SelectedValue.ToString();
                loaditem.PickBy = Calbee.Infra.Common.Constants.WConstants.userName;
                loaditem.PickDate = AppContext.GetDateTimeServer();
                loaditem.WarehouseCode = Calbee.Infra.Common.Constants.WConstants.wareHouseDDL;

                Calbee.WMS.Services.OutboundService.Response saveLoad = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.SetLoadItem(loaditem);
                if (saveLoad != null)
                {
                    if (saveLoad.StatusCode == 0)
                    {
                        // Success = StatusCode 0
                        MsgBox.DialogInfomation(saveLoad.Message);
                        string[] arrayCouter = this.lblResultCounter.Text.Split('/');
                        if (arrayCouter[1].ToString() == "0")
                        {
                            this.lblResultCounter.Text = "0/0";
                        }
                        else
                        {
                            string tempQuantity = string.IsNullOrEmpty(this.txtQuantity.Text) ? "0" : this.txtQuantity.Text.Trim();
                            string tempArray = string.IsNullOrEmpty(arrayCouter[0].ToString()) ? "0" : arrayCouter[0].ToString().Trim();
                            string tempTotal = string.IsNullOrEmpty(arrayCouter[1].ToString()) ? "0" : arrayCouter[1].ToString().Trim();
                            // string[] arrayCountInt = Convert.ToString(Convert.ToDecimal(tempArray) + Convert.ToDecimal(tempQuantity)).Split('.');
                            string[] arrayCountInt = Convert.ToString(Convert.ToDecimal(tempArray) + Convert.ToDecimal(1)).Split('.');
                            if (arrayCountInt.Length == 2)
                            {
                                if (arrayCountInt[1].ToString() == "0")
                                {
                                    this.lblResultCounter.Text = arrayCountInt[0].ToString() + "/" + tempTotal;
                                }
                                else
                                {
                                    this.lblResultCounter.Text = Convert.ToString(Convert.ToDecimal(tempArray) + Convert.ToDecimal(1)) + "/" + tempTotal;
                                }
                            }
                            else
                            {
                                this.lblResultCounter.Text = Convert.ToString(Convert.ToDecimal(tempArray) + Convert.ToDecimal(1)) + "/" + tempTotal;
                            }
                        }

                        DoAfterSave();
                    }
                    else
                    {
                        MsgBox.DialogError(saveLoad.Message);
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

        private void frmLoad_Load(object sender, EventArgs e)
        {
            this.lblResultCounter.Text = "0/0";
            this.txtOrderNumber.Focus();
            this.txtOrderNumber.SelectAll();
        }
        private void frmLoad_KeyUp(object sender, KeyEventArgs e)
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

        private void txtOrderNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    // default stagginLocation
                    var stagginLocationResult = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetLocation(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, string.Empty, string.Empty, Calbee.Infra.Common.Constants.WConstants.putawayStagingLocationType);
                    if (stagginLocationResult != null)
                    {
                        this.txtStagingLocation.Text = string.IsNullOrEmpty(stagginLocationResult.LocationCode) ? string.Empty : stagginLocationResult.LocationCode;
                        if (!string.IsNullOrEmpty(this.txtStagingLocation.Text.Trim()))
                        {
                            this.txtCarLicense.Focus();
                            this.txtCarLicense.SelectAll();
                        }
                        else
                        {
                            this.txtStagingLocation.Focus();
                            this.txtStagingLocation.SelectAll();
                        }
                    }
                    else
                    {
                        this.txtStagingLocation.Focus();
                        this.txtStagingLocation.SelectAll();
                    }

                    // default DockDoor
                    var dockDoorResult = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetLocation(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, string.Empty, string.Empty, Calbee.Infra.Common.Constants.WConstants.dockDoorLocationType);
                    if (dockDoorResult != null)
                    {
                        this.txtDockDoor.Text = string.IsNullOrEmpty(dockDoorResult.LocationCode) ? string.Empty : dockDoorResult.LocationCode;
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
        }
        private void txtStagingLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtCarLicense.Focus();
                this.txtCarLicense.SelectAll();
            }
        }
        private void txtCarLicense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (string.IsNullOrEmpty(this.txtCarLicense.Text.Trim()))
                    {
                        MsgBox.DialogWarning("Please scan car license");
                        this.txtCarLicense.Focus();
                        this.txtCarLicense.SelectAll();
                        return;
                    }
                    else
                    {
                        var truckResult = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundTruck(this.txtOrderNumber.Text.Trim(), this.txtCarLicense.Text.Trim());
                        if (truckResult != null)
                        {
                            /* Comment เนื่องจาก  ContanierNo ถูก Visable ออกไป
                            this.txtContanierNo.Focus();
                            this.txtContanierNo.SelectAll();
                            */

                            this.txtLPN.Focus();
                            this.txtLPN.SelectAll();
                        }
                        else
                        {
                            MsgBox.DialogWarning("Null found car license : " + this.txtCarLicense.Text.Trim() + " in system");
                            this.txtCarLicense.Focus();
                            this.txtCarLicense.SelectAll();
                            return;
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
        }
        private void txtContanierNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtLPN.Focus();
                this.txtLPN.SelectAll();
            }
        }
        private void txtLPN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var lpnResult = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundLoadLpn(this.txtOrderNumber.Text.Trim(), string.Empty, this.txtStagingLocation.Text.Trim(), string.Empty, this.txtLPN.Text.Trim());
                    if (lpnResult != null)
                    {
                        this.txtItemNumber.Text = string.IsNullOrEmpty(lpnResult.ItemNumber) ? string.Empty : lpnResult.ItemNumber;
                        entLoadItem.itemNumber = string.IsNullOrEmpty(lpnResult.ItemNumber) ? string.Empty : lpnResult.ItemNumber;
                        this.txtDescription.Text = string.IsNullOrEmpty(lpnResult.ItemName) ? string.Empty : lpnResult.ItemName;
                        this.txtLotNumber.Enabled = lpnResult.LotControl;
                        this.txtLotNumber.Text = string.IsNullOrEmpty(lpnResult.LotNumber) ? string.Empty : lpnResult.LotNumber;
                        entLoadItem.lotNumber = string.IsNullOrEmpty(lpnResult.LotNumber) ? string.Empty : lpnResult.LotNumber;
                        entLoadItem.lotControl = lpnResult.LotControl;
                        this.txtExpiryDate.Enabled = lpnResult.ExpiryDateControl;
                        this.txtExpiryDate.Text = string.IsNullOrEmpty(lpnResult.ExpiryDate) ? string.Empty : lpnResult.ExpiryDate;
                        entLoadItem.expiryDate = string.IsNullOrEmpty(lpnResult.ExpiryDate) ? string.Empty : lpnResult.ExpiryDate;
                        entLoadItem.expiryDateControl = lpnResult.ExpiryDateControl;
                        this.txtQuantity.Text = lpnResult.QuantityStage.ToString();
                        ComboBoxBinding.BindEntityToCombobox(AppContext.UOMDDLBinding(this.txtItemNumber.Text.Trim()), this.cmbUOM, "Uom", "Uom", "");
                        this.cmbUOM.SelectedValue = string.IsNullOrEmpty(lpnResult.Uom) ? string.Empty : lpnResult.Uom;
                        entLoadItem.uom = string.IsNullOrEmpty(lpnResult.Uom) ? string.Empty : lpnResult.Uom;
                        this.txtItemStatus.Text = string.IsNullOrEmpty(lpnResult.Status) ? string.Empty : lpnResult.Status;
                        entLoadItem.status = string.IsNullOrEmpty(lpnResult.Status) ? string.Empty : lpnResult.Status;

                        this.lblResultCounter.Text = lpnResult.CompletedPalletQty + "/" + lpnResult.PlanPalletQty;

                        this.DisableControl();
                    }
                    else
                    {
                        MsgBox.DialogWarning("Null data from lpn : " + this.txtLPN.Text.Trim());
                        this.txtLPN.Focus();
                        this.txtLPN.SelectAll();
                        return;
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
        }
        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, new EventArgs());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
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