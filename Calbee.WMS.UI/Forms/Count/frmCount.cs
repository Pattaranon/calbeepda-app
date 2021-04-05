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
using Calbee.Infra.Helper.Objects;

namespace Calbee.WMS.UI.Forms.Count
{
    public partial class frmCount : Form
    {
        #region Member

        bool eventcomboCountNumner = false;
        private static AppContext appContext = AppContext.Instance;
        public AppContext AppContext
        {
            get { return appContext; }
        }

        #endregion

        #region Constructor

        public frmCount()
        {
            InitializeComponent();
            this.txtQuantity.KeyPress += new KeyPressEventHandler(EventControls.txtNumber_TextChanged);
        }

        #endregion

        #region Method

        private void countNumberBinding(string warehouseCode)
        {
            try
            {
                List<string> _listCountNumber = new List<string>();
                _listCountNumber = Calbee.WMS.Services.Count.CountServiceProxy.WS.GetCountNumbers(warehouseCode).ToList();
                if (_listCountNumber != null)
                {
                    if (_listCountNumber.Count() >= 1)
                    {
                        _listCountNumber.Insert(0, Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect);
                        ComboBoxBinding.BindLStringToCombobox(_listCountNumber, this.cmbCountNumner);
                    }
                    else
                    {
                        this.cmbCountNumner.DataSource = null;
                    }
                }
                else
                {
                    this.cmbCountNumner.DataSource = null;
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
        private void ForceExitApplication()
        {
            if (MessageBox.Show("Do you want to force exit program", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void defaultItemStatusBinding(string statusName)
        {
            try
            {
                List<Calbee.WMS.Services.MasterService.tbc_Status> _listItemStatus = new List<Calbee.WMS.Services.MasterService.tbc_Status>();
                Calbee.WMS.Services.MasterService.tbc_Status _master;
                _listItemStatus = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetStatus(Calbee.Infra.Common.Constants.WConstants.reciveItemStatusType).ToList();
                if (_listItemStatus != null)
                {
                    /*แสดงแบบ ถ้ามีข้อมูลเพียง Record เดียวให้ แสดงค่ามาเลย*/
                    if (string.IsNullOrEmpty(statusName))
                    {
                        if (_listItemStatus.Count() > 1)
                        {
                            _master = new Calbee.WMS.Services.MasterService.tbc_Status();
                            _master.StatusName = Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect;
                            _listItemStatus.Insert(0, _master);
                            ComboBoxBinding.BindEntityToCombobox(_listItemStatus, this.cmbItemStatus, "StatusName", "StatusName", "");
                        }
                        else
                        {
                            ComboBoxBinding.BindEntityToCombobox(_listItemStatus, this.cmbItemStatus, "StatusName", "StatusName", "");
                        }
                    }
                    else
                    {
                        ComboBoxBinding.BindEntityToCombobox(_listItemStatus, this.cmbItemStatus, "StatusName", "StatusName", "");
                        this.cmbItemStatus.Text = statusName;
                    }
                }
                else
                {
                    this.cmbItemStatus.DataSource = null;
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
        private void ItemStatusBinding()
        {
            try
            {
                List<Calbee.WMS.Services.MasterService.tbc_Status> _listItemStatus = new List<Calbee.WMS.Services.MasterService.tbc_Status>();
                _listItemStatus = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetStatus(Calbee.Infra.Common.Constants.WConstants.reciveItemStatusType).ToList();
                if (_listItemStatus != null)
                {
                    if (_listItemStatus.Count() > 0)
                    {
                        // Default value ReceiveNumber
                        ComboBoxBinding.BindEntityToCombobox(_listItemStatus, this.cmbItemStatus, "StatusName", "StatusName", "");
                    }
                    else
                    {
                        this.cmbItemStatus.DataSource = null;
                    }
                }
                else
                {
                    this.cmbItemStatus.DataSource = null;
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
        private bool DoValidate()
        {
            try
            {
                bool result = false;

                if (this.cmbCountNumner.DataSource != null)
                {
                    if (this.cmbCountNumner.SelectedValue.ToString() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect)
                    {
                        MsgBox.DialogWarning("Please select count no");
                        result = false;
                    }
                }
                if (this.cmbCountNumner.DataSource == null)
                {
                    MsgBox.DialogWarning("Please select count no");
                    result = false;
                }
                else if (string.IsNullOrEmpty(this.txtLocation.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please input location");
                    this.txtLocation.Focus();
                    this.txtLocation.SelectAll();
                    result = false;
                }
                else if (string.IsNullOrEmpty(this.txtLPN.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please input lpn");
                    this.txtLPN.Focus();
                    this.txtLPN.SelectAll();
                    result = false;
                }
                else if (string.IsNullOrEmpty(this.txtQuantity.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please input Quantity");
                    this.txtQuantity.Focus();
                    this.txtQuantity.SelectAll();
                    result = false;
                }
                else if (this.cmbUOM.DataSource != null)
                {
                    if (string.IsNullOrEmpty(this.cmbUOM.SelectedValue.ToString()) && this.cmbUOM.SelectedValue.ToString() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect)
                    {
                        MsgBox.DialogWarning("Please select uom");
                        result = false;
                    }
                }
                if (this.cmbUOM.DataSource == null)
                {
                    MsgBox.DialogWarning("Null select uom");
                    result = false;
                }

                else if (this.cmbItemStatus.DataSource != null)
                {
                    if (string.IsNullOrEmpty(this.cmbItemStatus.SelectedValue.ToString()) && this.cmbItemStatus.SelectedValue.ToString() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect)
                    {
                        MsgBox.DialogWarning("Please select item status");
                        result = false;
                    }
                }
                if (this.cmbItemStatus.DataSource == null)
                {
                    MsgBox.DialogWarning("Null select item status");
                    result = false;
                }
                else
                {
                    result = true;
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DoSave()
        {
            try
            {
                Calbee.WMS.Services.CountService.CountItem countItem = new Calbee.WMS.Services.CountService.CountItem();
                countItem.CountBy = Calbee.Infra.Common.Constants.WConstants.userName;
                countItem.CountDate = AppContext.GetDateTimeServerString(Calbee.Infra.Common.Constants.WConstants.formatDateString);
                countItem.CountNumber = this.cmbCountNumner.SelectedValue.ToString();
                countItem.CountQty = Convert.ToDouble(this.txtQuantity.Text.Trim());
                countItem.CountQtySpecified = true;
                countItem.Device = AppContext.DeviceName;
                countItem.ExpiryDate = this.txtExpiryDate.Text.Trim();
                countItem.ItemNumber = this.txtItemNumber.Text.Trim();
                countItem.LPN = this.txtLPN.Text.Trim();
                countItem.Location = this.txtLocation.Text.Trim();
                countItem.LotNumber = this.txtLotNumber.Text.Trim();
                countItem.Status = this.cmbItemStatus.SelectedValue.ToString();
                countItem.Uom = this.cmbUOM.SelectedValue.ToString();
                countItem.WarehouseCode = Calbee.Infra.Common.Constants.WConstants.wareHouseDDL;

                Calbee.WMS.Services.CountService.Response countSave = Calbee.WMS.Services.Count.CountServiceProxy.WS.SetCountItem(countItem);
                if (countSave != null)
                {
                    if (countSave.StatusCode == 0)
                    {
                        MsgBox.DialogInfomation(countSave.Message);

                        this.txtQuantity.Focus();
                        this.txtQuantity.SelectAll();
                    }
                    else
                    {
                        MsgBox.DialogError(countSave.Message);
                    }
                }
                else
                {
                    MsgBox.DialogError("Null result from CountService of SetCountItem");
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

        #endregion

        #region Event

        private void frmCount_Load(object sender, EventArgs e)
        {
            try
            {
                eventcomboCountNumner = true;
                ItemStatusBinding();
                countNumberBinding(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL);
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
        private void frmCount_KeyUp(object sender, KeyEventArgs e)
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

        private void cmbCountNumner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!eventcomboCountNumner) return;
            if (this.cmbCountNumner.SelectedIndex > 0)
            {
                this.txtLocation.Focus();
                this.txtLocation.SelectAll();
            }
        }

        private void txtLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (string.IsNullOrEmpty(this.txtLocation.Text.Trim()))
                    {
                        MsgBox.DialogWarning("Please scan location");
                        this.txtLocation.Focus();
                        this.txtLocation.SelectAll();
                        return;
                    }
                    else
                    {
                        var locationResult = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetLocation(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtLocation.Text.Trim(), string.Empty, string.Empty);
                        if (locationResult != null)
                        {
                            this.txtLPN.Enabled = locationResult.LpnControlled;
                            if (this.txtLPN.Enabled)
                            {
                                // True call service
                                this.txtLPN.Focus();
                                this.txtLPN.SelectAll();
                            }
                            else
                            {
                                // False
                                this.txtItemNumber.Focus();
                                this.txtItemNumber.SelectAll();
                            }
                        }
                        else
                        {
                            MsgBox.DialogWarning("Not found location : " + this.txtLocation.Text.Trim() + " in system");
                            this.txtLocation.Focus();
                            this.txtLocation.SelectAll();
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
        private void txtLPN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var lpnResult = Calbee.WMS.Services.Count.CountServiceProxy.WS.GetCountDetail(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.cmbCountNumner.SelectedValue.ToString(), this.txtLocation.Text.Trim(), this.txtLPN.Text.Trim(), string.Empty);
                    if (lpnResult != null)
                    {
                        if (lpnResult.Count() > 0)
                        {
                            this.txtItemNumber.Text = string.IsNullOrEmpty(lpnResult.FirstOrDefault().ItemNumber) ? string.Empty : lpnResult.FirstOrDefault().ItemNumber;
                            this.txtDescription.Text = string.IsNullOrEmpty(lpnResult.FirstOrDefault().ItemName) ? string.Empty : lpnResult.FirstOrDefault().ItemName;
                            this.txtLotNumber.Text = string.IsNullOrEmpty(lpnResult.FirstOrDefault().LotNumber) ? string.Empty : lpnResult.FirstOrDefault().LotNumber;
                            this.txtExpiryDate.Text = string.IsNullOrEmpty(lpnResult.FirstOrDefault().ExpiryDate) ? string.Empty : lpnResult.FirstOrDefault().ExpiryDate;
                            this.txtQuantity.Text = string.IsNullOrEmpty(lpnResult.FirstOrDefault().CountQty.ToString()) ? string.Empty : lpnResult.FirstOrDefault().CountQty.ToString();
                            ComboBoxBinding.BindEntityToCombobox(AppContext.UOMDDLBinding(this.txtItemNumber.Text.Trim()), this.cmbUOM, "Uom", "Uom", "");
                            this.cmbUOM.SelectedValue = string.IsNullOrEmpty(lpnResult.FirstOrDefault().Uom) ? string.Empty : lpnResult.FirstOrDefault().Uom;
                            defaultItemStatusBinding(string.IsNullOrEmpty(lpnResult.FirstOrDefault().ItemStatus) ? string.Empty : lpnResult.FirstOrDefault().ItemStatus);
                            string tampCountQty = string.IsNullOrEmpty(lpnResult.FirstOrDefault().CountQty.ToString()) ? "0" : lpnResult.FirstOrDefault().CountQty.ToString();
                            string tampStockQty = string.IsNullOrEmpty(lpnResult.FirstOrDefault().StockQty.ToString()) ? "0" : lpnResult.FirstOrDefault().StockQty.ToString();
                            //this.lblResultCounter.Text = tampCountQty + "/" + tampStockQty;
                            this.txtQuantity.Focus();
                            this.txtQuantity.SelectAll();
                        }
                        else
                        {
                            MsgBox.DialogWarning("Not found lpn : " + this.txtLPN.Text.Trim() + " in system");
                            this.txtLPN.Focus();
                            this.txtLPN.SelectAll();
                            return;
                        }
                    }
                    else
                    {
                        MsgBox.DialogWarning("Null lpn : " + this.txtLPN.Text.Trim() + " in system");
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
        private void txtItemNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var itemResult = Calbee.WMS.Services.Count.CountServiceProxy.WS.GetCountDetail(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.cmbCountNumner.SelectedValue.ToString(), this.txtLocation.Text.Trim(), this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim());
                    if (itemResult != null)
                    {
                        if (itemResult.Count() > 0)
                        {
                            this.txtDescription.Text = string.IsNullOrEmpty(itemResult.FirstOrDefault().ItemName) ? string.Empty : itemResult.FirstOrDefault().ItemName;
                            this.txtLotNumber.Text = string.IsNullOrEmpty(itemResult.FirstOrDefault().LotNumber) ? string.Empty : itemResult.FirstOrDefault().LotNumber;
                            this.txtExpiryDate.Text = string.IsNullOrEmpty(itemResult.FirstOrDefault().ExpiryDate) ? string.Empty : itemResult.FirstOrDefault().ExpiryDate;
                            this.txtQuantity.Text = string.IsNullOrEmpty(itemResult.FirstOrDefault().CountQty.ToString()) ? string.Empty : itemResult.FirstOrDefault().CountQty.ToString();
                            ComboBoxBinding.BindEntityToCombobox(AppContext.UOMDDLBinding(this.txtItemNumber.Text.Trim()), this.cmbUOM, "Uom", "Uom", "");
                            this.cmbUOM.SelectedValue = string.IsNullOrEmpty(itemResult.FirstOrDefault().Uom) ? string.Empty : itemResult.FirstOrDefault().Uom;
                            defaultItemStatusBinding(string.IsNullOrEmpty(itemResult.FirstOrDefault().ItemStatus) ? string.Empty : itemResult.FirstOrDefault().ItemStatus);
                        }
                        else
                        {
                            MsgBox.DialogWarning("Not found item number : " + this.txtItemNumber.Text.Trim() + " in system");
                            this.txtItemNumber.Focus();
                            this.txtItemNumber.SelectAll();
                            return;
                        }
                    }
                    else
                    {
                        MsgBox.DialogWarning("Not found item number : " + this.txtItemNumber.Text.Trim() + " in system");
                        this.txtItemNumber.Focus();
                        this.txtItemNumber.SelectAll();
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

        private void txtExpiryDate_SelectedIndexChangeds(object sender, EventArgs e)
        {

        }
        private void txtExpiryDate_KeyDowns(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void txtLotNumber_SelectedIndexChangeds(object sender, EventArgs e)
        {

        }
        private void txtLotNumber_KeyDowns(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

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
            try
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
            catch (Exception ex)
            {
                MsgBox.DialogError(ex.Message);
            }
        }

        #endregion
    }
}