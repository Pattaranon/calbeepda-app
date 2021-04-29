using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calbee.Infra.Helper.Objects;
using Calbee.Infra.Helper.Message;
using Calbee.Infra.Shared;

namespace Calbee.WMS.UI.Forms.Count
{
    public partial class frmCountLPN : Form
    {
        #region Member

        DataTable dtDetail = new DataTable();
        private static AppContext appContext = AppContext.Instance;
        public AppContext AppContext
        {
            get { return appContext; }
        }

        public string toLpn { get; set; }
        public string UOM { get; set; }
        public bool expiryDateControl { get; set; }

        #endregion

        #region Constuctor

        public frmCountLPN()
        {
            InitializeComponent();
        }

        #endregion

        #region Method

        private void DoAfterSave()
        {
            this.txtDescription.Text = string.Empty;
            this.txtCtcCode.Text = string.Empty;
            this.txtQuantity.Text = string.Empty;
            this.cmbUOM.DataSource = null;
            this.cmbItemStatus.DataSource = null;

            this.txtLocation.Focus();
            this.txtLocation.SelectAll();
        }
        private void UOMBinding(string itemNumber)
        {
            try
            {
                List<Calbee.WMS.Services.MasterService.ItemUom> _listUOM = new List<Calbee.WMS.Services.MasterService.ItemUom>();
                Calbee.WMS.Services.MasterService.ItemUom _master;
                _listUOM = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetItemUoms(itemNumber, string.Empty).ToList();
                if (_listUOM != null)
                {
                    _master = new Calbee.WMS.Services.MasterService.ItemUom();
                    _master.Uom = Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect;
                    _listUOM.Insert(0, _master);
                    ComboBoxBinding.BindEntityToCombobox(_listUOM, this.cmbUOM, "Uom", "ItemUomId", "");
                }
                else
                {
                    this.cmbUOM.DataSource = null;
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
        private void defaultItemStatusBinding(string itemNumber, string statusName)
        {
            try
            {
                List<string> _listItemStatus = new List<string>();
                _listItemStatus = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventoryStatuss(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtLocation.Text.Trim(), string.Empty, string.Empty, this.cmbItemNumber.SelectedValue.ToString()).ToList();
                if (_listItemStatus != null)
                {
                    /*แสดงแบบ ถ้ามีข้อมูลเพียง Record เดียวให้ แสดงค่ามาเลย*/
                    if (string.IsNullOrEmpty(statusName))
                    {
                        if (_listItemStatus.Count() > 1)
                        {
                            _listItemStatus.Insert(0, Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect);
                            ComboBoxBinding.BindLStringToCombobox(_listItemStatus, this.cmbItemStatus);
                        }
                        else
                        {
                            ComboBoxBinding.BindLStringToCombobox(_listItemStatus, this.cmbItemStatus);
                        }
                    }
                    else
                    {
                        ComboBoxBinding.BindLStringToCombobox(_listItemStatus, this.cmbItemStatus);
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
        private void itemNumberBinding(string warehouseCode, string countNumber, string locationCode)
        {
            try
            {
                List<string> _listItemNumber = new List<string>();
                _listItemNumber = Calbee.WMS.Services.Count.CountLocationServiceProxy.WS.GetCountItems(warehouseCode, countNumber, locationCode).ToList();
                if (_listItemNumber != null)
                {
                    if (_listItemNumber.Count() == 0)
                    {
                        this.cmbItemNumber.Text = string.Empty;
                        this.cmbItemNumber.DataSource = null;
                    }
                    else if (_listItemNumber.Count() > 1)
                    {
                        _listItemNumber.Insert(0, string.Empty); // Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect);
                        ComboBoxBinding.BindLStringToCombobox(_listItemNumber, this.cmbItemNumber);
                    }
                    else
                    {
                        ComboBoxBinding.BindLStringToCombobox(_listItemNumber, this.cmbItemNumber);
                    }
                }
                else
                {
                    this.cmbItemNumber.Text = string.Empty;
                    this.cmbItemNumber.DataSource = null;
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
        private void ScanItemNumber(string itemNumber)
        {
            try
            {
                // var itemResult = Calbee.WMS.Services.Count.CountLocationServiceProxy.WS.GetCountDetail(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.cmbCountNumner.SelectedValue.ToString(), this.txtLocation.Text.Trim(), string.Empty, itemNumber);
                var itemResult = Calbee.WMS.Services.Count.CountLocationServiceProxy.WS.GetCountDetail(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtCountNumber.Text.Trim(), this.txtLocation.Text.Trim(), string.Empty, itemNumber);
                if (itemResult != null)
                {
                    this.txtDescription.Text = string.IsNullOrEmpty(itemResult.FirstOrDefault().ItemName) ? string.Empty : itemResult.FirstOrDefault().ItemName;
                    this.txtCtcCode.Text = string.IsNullOrEmpty(itemResult.FirstOrDefault().CTCCode) ? string.Empty : itemResult.FirstOrDefault().CTCCode;
                    ComboBoxBinding.BindEntityToCombobox(AppContext.UOMDDLSingleBinding(this.cmbItemNumber.SelectedValue.ToString()), this.cmbUOM, "Uom", "Uom", "");
                    defaultItemStatusBinding(this.cmbItemNumber.SelectedValue.ToString(), string.Empty);

                    this.txtQuantity.Text = itemResult.FirstOrDefault().StockQty.HasValue == false ? "0" : itemResult.FirstOrDefault().StockQty.Value.ToString();

                    this.cmbUOM.Focus();
                }
                else
                {
                    this.cmbItemNumber.Text = string.Empty;
                    this.cmbItemNumber.DataSource = null;

                    this.cmbUOM.Text = string.Empty;
                    this.cmbUOM.DataSource = null;

                    this.cmbItemStatus.Text = string.Empty;
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

        private void ReadOnlyControls()
        {
            this.txtLocation.ReadOnly = true;
            this.txtDescription.ReadOnly = true;
        }
        private void countNumberBinding(string warehouseCode)
        {
            try
            {
                List<string> _listCountNumber = new List<string>();
                _listCountNumber = Calbee.WMS.Services.Count.CountLocationServiceProxy.WS.GetCountNumbers(warehouseCode).ToList();
                if (_listCountNumber != null)
                {
                    if (_listCountNumber.Count() >= 1)
                    {
                        _listCountNumber.Insert(0, Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect);
                        txtCountNumber.SetArrayItemsToCombobox(_listCountNumber.ToArray());
                    }
                    else
                    {
                        this.txtCountNumber.SetArrayItemsToCombobox(new string[] { "" });
                        this.txtCountNumber.Text = string.Empty;
                    }
                }
                else
                {
                    this.txtCountNumber.SetArrayItemsToCombobox(new string[] { "" });
                    this.txtCountNumber.Text = string.Empty;
                }

                txtCountNumber.customFocus();
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
            if (MessageBox.Show("Do you want to force exit program", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
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
            if (!string.IsNullOrEmpty(txtCountNumber.Text))
            {
                if (this.txtCountNumber.Text.Trim() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect)
                {
                    MsgBox.DialogWarning("Please select count no");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txtCountNumber.Text))
            {
                MsgBox.DialogWarning("Please select count no");
                return false;
            }

            else if (string.IsNullOrEmpty(this.cmbItemNumber.SelectedValue.ToString()))
            {
                MsgBox.DialogWarning("Please select item number");
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtLocation.Text.Trim()))
            {
                MsgBox.DialogWarning("Please scan location");
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtQuantity.Text.Trim()))
            {
                MsgBox.DialogWarning("Please input quantity");
                return false;
            }
            else if (this.cmbItemStatus.DataSource == null)
            {
                MsgBox.DialogWarning("item status not found data");
                return false;
            }
            else if (string.IsNullOrEmpty(this.cmbItemStatus.SelectedValue.ToString()))
            {
                MsgBox.DialogWarning("Please select item status");
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
                Calbee.WMS.Services.CountLocationService.CountItem countItem = new Calbee.WMS.Services.CountLocationService.CountItem();
                countItem.CountBy = Calbee.Infra.Common.Constants.WConstants.userName;
                countItem.CountDate = AppContext.GetDateTimeServerString(Calbee.Infra.Common.Constants.WConstants.formatDateString);
                //countItem.CountNumber = this.cmbCountNumner.SelectedValue.ToString();
                countItem.CountNumber = this.txtCountNumber.Text.Trim();
                countItem.CountQty = Convert.ToDouble(this.txtQuantity.Text.Trim());
                countItem.CountQtySpecified = true;
                countItem.Device = AppContext.DeviceName;
                countItem.ExpiryDate = string.Empty;
                countItem.ItemNumber = this.cmbItemNumber.SelectedValue.ToString();
                countItem.Location = this.txtLocation.Text.Trim();
                countItem.LotNumber = string.Empty;
                countItem.Status = this.cmbItemStatus.SelectedValue.ToString();
                countItem.Uom = this.cmbUOM.SelectedValue.ToString();
                countItem.WarehouseCode = Calbee.Infra.Common.Constants.WConstants.wareHouseDDL;

                Calbee.WMS.Services.CountLocationService.Response countSave = Calbee.WMS.Services.Count.CountLocationServiceProxy.WS.SetCountItem(countItem);
                if (countSave != null)
                {
                    if (countSave.StatusCode == 0)
                    {
                        MsgBox.DialogInfomation(countSave.Message);

                        DoAfterSave();
                    }
                    else
                    {
                        MsgBox.DialogError(countSave.Message);
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
                    MsgBox.DialogError(ex.GetBaseException().ToString());
                }
            }
        }

        #endregion

        #region Event

        private void frmChangeStatus_Load(object sender, EventArgs e)
        {
            countNumberBinding(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL);

            this.txtCountNumber.customFocus();
            this.txtCountNumber.customSelectAll();
        }
        private void frmChangeStatus_KeyUp(object sender, KeyEventArgs e)
        {
            if (Calbee.Infra.Common.Constants.WConstants.eventEnter == 112)
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.F1:
                        //btnSave_Click(null, new EventArgs());
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

        private void txtCountNumber_KeyDowns(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtCountNumber.Text))
                {
                    MsgBox.DialogWarning("Please scan count number");
                    this.txtCountNumber.customFocus();
                    return;
                }
                else if (this.txtCountNumber.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect)
                {
                    MsgBox.DialogWarning("Please select count number");
                    this.txtCountNumber.customFocus();
                    return;
                }
                else
                {
                    // Select accept
                    this.txtLocation.Focus();
                    this.txtLocation.SelectAll();
                }
            }
        }
        private void txtCountNumber_SelectedIndexChangeds(object sender, EventArgs e)
        {
            // Select accept
            this.txtLocation.Focus();
            this.txtLocation.SelectAll();
        }

        private void txtLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                    this.txtDescription.Text = string.Empty;
                    this.txtCtcCode.Text = string.Empty;
                    this.txtQuantity.Text = string.Empty;
                    //itemNumberBinding(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.cmbCountNumner.SelectedValue.ToString(), this.txtLocation.Text.Trim());
                    itemNumberBinding(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtCountNumber.Text, this.txtLocation.Text.Trim());

                    this.cmbItemNumber.Focus();
                }
            }
        }
        private void cmbItemNumber_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.cmbItemNumber.SelectedValue.ToString()))
            {
                // Scan accept
                ScanItemNumber(this.cmbItemNumber.SelectedValue.ToString());
            }
        }

        private void txtExpiryDate_SelectedIndexChangeds(object sender, EventArgs e)
        {
            this.txtQuantity.Focus();
            this.txtQuantity.SelectAll();
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, new EventArgs());
            }
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}