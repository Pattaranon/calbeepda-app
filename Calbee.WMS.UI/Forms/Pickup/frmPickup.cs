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

namespace Calbee.WMS.UI.Forms.Pickup
{
    public partial class frmPickup : Form
    {
        #region Member

        bool eventcomboItemNumber = false;
        bool eventcomboLotNumber = false;
        bool eventcomboExpiryDate = false;
        private static AppContext appContext = AppContext.Instance;
        public AppContext AppContext
        {
            get { return appContext; }
        }

        #endregion

        #region Constructor

        public frmPickup()
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
        private void ItemStatusBinding(string itemNumber)
        {
            try
            {
                List<string> _listItemStatus = new List<string>();
                _listItemStatus = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventoryStatuss(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtLocation.Text.Trim(), string.Empty, string.Empty, this.txtItemNumber.Text.Trim()).ToList();
                if (_listItemStatus != null)
                {
                    _listItemStatus.Insert(0, Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect);
                    ComboBoxBinding.BindLStringToCombobox(_listItemStatus, this.cmbItemStatus);
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
        private void defaultItemStatusBinding(string itemNumber, string statusName)
        {
            try
            {
                List<string> _listItemStatus = new List<string>();
                _listItemStatus = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventoryStatuss(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtLocation.Text.Trim(), string.Empty, string.Empty, this.txtItemNumber.Text.Trim()).ToList();
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
        private void appContextUOMBinding(string itemNumber)
        {
            try
            {
                ComboBoxBinding.BindEntityToCombobox(AppContext.UOMDDLBinding(itemNumber), this.cmbUOM, "Uom", "Uom", "");
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
        private void itemNumberBinding(string locationcCode, string lpn)
        {
            try
            {
                List<string> _listReceiveNumber = new List<string>();
                _listReceiveNumber = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventoryItemNumbers(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, locationcCode, string.Empty, lpn).ToList();
                if (_listReceiveNumber != null)
                {
                    _listReceiveNumber.Insert(0, string.Empty);
                    _listReceiveNumber.Insert(1, Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL);
                    txtItemNumber.SetArrayItemsToCombobox(_listReceiveNumber.ToArray());
                }
                else
                {
                    this.txtItemNumber.SetArrayItemsToCombobox(new string[] { "" });
                    this.txtItemNumber.Text = string.Empty;
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
        private bool checkLotNumber(string locationcCode, string lpn, string itemNumber, string lotNumber)
        {
            bool result = false;
            try
            {
                List<string> _listLotNumber = new List<string>();
                _listLotNumber = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventoryLotNumbers(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, locationcCode, string.Empty, lpn, itemNumber).ToList();
                if (_listLotNumber != null)
                {
                    foreach (var item in _listLotNumber)
                    {
                        if (item.ToString().Trim() == lotNumber.Trim())
                        {
                            result = true;
                            break;
                        }
                    }
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MsgBox.DialogError(ex.InnerException.Message.ToString());
                    result = false;
                }
                else
                {
                    if (Calbee.Infra.Common.Constants.IConstants.CatchFlag.Equals("Y"))
                    {
                        // Show error description detail
                        MsgBox.DialogError(ex.GetBaseException().ToString());
                        result = false;
                    }
                    else
                    {
                        // Show message error
                        MsgBox.DialogError(ex.Message.ToString());
                        result = false;
                    }
                }
            }

            return result;
        }
        private bool checkExpiryDate(string locationcCode, string lpn, string itemNumber, string expiryDate)
        {
            bool result = false;
            try
            {
                List<string> _listExpiryDate = new List<string>();
                _listExpiryDate = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventoryExpiryDates(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, locationcCode, string.Empty, lpn, itemNumber).ToList();
                if (_listExpiryDate != null)
                {
                    foreach (var item in _listExpiryDate)
                    {
                        if (item.ToString().Trim() == expiryDate.Trim())
                        {
                            result = true;
                            break;
                        }
                    }
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MsgBox.DialogError(ex.InnerException.Message.ToString());
                    result = false;
                }
                else
                {
                    if (Calbee.Infra.Common.Constants.IConstants.CatchFlag.Equals("Y"))
                    {
                        // Show error description detail
                        MsgBox.DialogError(ex.GetBaseException().ToString());
                        result = false;
                    }
                    else
                    {
                        // Show message error
                        MsgBox.DialogError(ex.Message.ToString());
                        result = false;
                    }
                }
            }

            return result;
        }
        private void lotNumberBinding(string locationcCode, string lpn, string itemNumber)
        {
            try
            {
                List<string> _listLotNumber = new List<string>();
                _listLotNumber = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventoryLotNumbers(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, locationcCode, string.Empty, lpn, itemNumber).ToList();
                if (_listLotNumber != null)
                {
                    _listLotNumber.Insert(0, string.Empty);
                    _listLotNumber.Insert(1, Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL);
                    txtLotNumber.SetArrayItemsToCombobox(_listLotNumber.ToArray());
                }
                else
                {
                    this.txtLotNumber.SetArrayItemsToCombobox(new string[] { "" });
                    this.txtLotNumber.Text = string.Empty;
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
        private void expiryDateBinding(string locationcCode, string lpn, string itemNumber)
        {
            try
            {
                List<string> _listExpiryDate = new List<string>();
                _listExpiryDate = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventoryExpiryDates(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, locationcCode, string.Empty, lpn, itemNumber).ToList();
                if (_listExpiryDate != null)
                {
                    _listExpiryDate.Insert(0, string.Empty);
                    _listExpiryDate.Insert(1, Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL);
                    txtExpiryDate.SetArrayItemsToCombobox(_listExpiryDate.ToArray());
                }
                else
                {
                    this.txtExpiryDate.SetArrayItemsToCombobox(new string[] { "" });
                    this.txtExpiryDate.Text = string.Empty;
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
        private void RefreshControl()
        {
            this.txtLPN.Text = string.Empty;
            this.txtItemNumber.SetArrayItemsToCombobox(new string[] { "" });
            this.txtItemNumber.Text = string.Empty;
            this.txtLotNumber.SetArrayItemsToCombobox(new string[] { "" });
            this.txtLotNumber.Text = string.Empty;
            this.txtExpiryDate.SetArrayItemsToCombobox(new string[] { "" });
            this.txtExpiryDate.Text = string.Empty;
            this.txtQuantity.Text = string.Empty;
            this.cmbUOM.DataSource = null;
            this.cmbUOM.SelectedValue = string.Empty;
            this.cmbItemStatus.DataSource = null;
            this.cmbItemStatus.SelectedValue = string.Empty;
            this.txtToLPN.Text = string.Empty;

            EnableControlAll();
        }
        private void EnableControlAll()
        {
            this.txtLPN.Enabled = true;
            this.txtItemNumber.Enabled = true;
            this.txtLotNumber.Enabled = true;
            this.txtExpiryDate.Enabled = true;
            this.txtQuantity.Enabled = true;
            this.cmbUOM.Enabled = true;
            this.cmbItemStatus.Enabled = true;
            this.txtToLPN.Enabled = true;
        }
        private void DisableControlByItem(string action)
        {
            if (action == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
            {
                this.txtLotNumber.Enabled = false;
                this.txtExpiryDate.Enabled = false;
                this.txtQuantity.Enabled = false;
                this.cmbUOM.Enabled = false;
                this.cmbItemStatus.Enabled = false;
                this.txtToLPN.Enabled = false;
            }
        }
        private void ScanItemNumber()
        {
            try
            {
                var itemResult = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventory(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtLocation.Text.Trim(), string.Empty, this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim());
                if (itemResult != null)
                {
                    this.txtLotNumber.Enabled = itemResult.LotControl;
                    if (itemResult.LotControl)
                    {
                        // Lotcontrol = true
                        lotNumberBinding(this.txtLocation.Text.Trim(), this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim());
                    }
                    this.txtExpiryDate.Enabled = itemResult.ExpiryDateControl;
                    if (itemResult.ExpiryDateControl)
                    {
                        // ExpiryDateControl = true
                        expiryDateBinding(this.txtLocation.Text.Trim(), this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim());
                    }

                    this.txtDescription.Text = string.IsNullOrEmpty(itemResult.ItemName) ? string.Empty : itemResult.ItemName;
                    ComboBoxBinding.BindEntityToCombobox(AppContext.UOMDDLBinding(this.txtItemNumber.Text.Trim()), this.cmbUOM, "Uom", "Uom", "");
                    this.cmbUOM.SelectedValue = itemResult.UOM;
                    defaultItemStatusBinding(this.txtItemNumber.Text.Trim(), itemResult.StatusName);
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
        private void DoAfterSave(string actionEvent)
        {
            if (actionEvent.Equals("ALL"))
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
                this.cmbItemStatus.DataSource = null;
                this.txtToLPN.Text = string.Empty;

                this.txtLPN.Focus();
                this.txtLPN.SelectAll();
            }
            else if (actionEvent.Equals("ITEMS"))
            {
                this.txtDescription.Text = string.Empty;
                this.txtLotNumber.Text = string.Empty;
                this.txtExpiryDate.Text = string.Empty;
                this.txtQuantity.Text = string.Empty;
                if (this.cmbUOM.DataSource != null)
                {
                    this.cmbUOM.SelectedIndex = 0;
                }
                if (this.cmbItemStatus.DataSource != null)
                {
                    this.cmbItemStatus.SelectedIndex = 0;
                }
                this.txtToLPN.Text = string.Empty;
                this.txtItemNumber.customFocus();
            }
        }
        private bool DoValidate()
        {
            if (this.txtItemNumber.Text.Trim() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
            {
                if (string.IsNullOrEmpty(this.txtItemNumber.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan item number");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.txtLocation.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan location");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.txtToLPN.Text.Trim()))
                {
                    if (this.txtToLPN.Enabled)
                    {
                        MsgBox.DialogWarning("Please scan to lpn");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(this.txtItemNumber.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please select item number");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.txtLocation.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan location");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.txtLPN.Text.Trim()))
                {
                    if (this.txtLPN.Enabled)
                    {
                        MsgBox.DialogWarning("Please scan LPN");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else if (string.IsNullOrEmpty(this.txtLotNumber.Text))
                {
                    MsgBox.DialogWarning("Please select lot number");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.txtExpiryDate.Text))
                {
                    MsgBox.DialogWarning("Please select expiry date");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.txtQuantity.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please input quantity");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.cmbUOM.SelectedValue.ToString()))
                {
                    MsgBox.DialogWarning("Please select uom");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.cmbItemStatus.SelectedValue.ToString()))
                {
                    MsgBox.DialogWarning("Please select item status");
                    return false;
                }
                //else if (string.IsNullOrEmpty(this.txtToLPN.Text.Trim()))
                //{
                //    MsgBox.DialogWarning("Please scan to lpn");
                //    return false;
                //}
                else
                {
                    return true;
                }
            }
        }
        private void DoSave()
        {
            try
            {
                Calbee.WMS.Services.InventoryService.InventoryItem pickup = new Calbee.WMS.Services.InventoryService.InventoryItem();
                pickup.AllLpn = false;
                pickup.AllLpnSpecified = true;
                pickup.Device = AppContext.DeviceName;
                pickup.PickBy = Calbee.Infra.Common.Constants.WConstants.userName;
                pickup.WarehouseCode = Calbee.Infra.Common.Constants.WConstants.wareHouseDDL;
                pickup.ToLocation = Calbee.Infra.Common.Constants.WConstants.forkLiftDDL;
                pickup.SubTranType = Calbee.Infra.Common.Constants.WConstants.PickupTranType;
                pickup.TransactionType = Calbee.Infra.Common.Constants.WConstants.PickupTranType;
                pickup.Lpn = this.txtLPN.Text.Trim();
                pickup.ToLpn = this.txtToLPN.Text.Trim();
                pickup.Location = this.txtLocation.Text.Trim();
                if (this.txtItemNumber.Text.Trim() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
                {
                    // Select item number ALL
                    pickup.AllItem = true;
                    pickup.AllItemSpecified = true;
                    pickup.ItemNumber = Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL;
                    pickup.PickDate = Convert.ToDateTime(AppContext.GetDateTimeServerString(Calbee.Infra.Common.Constants.WConstants.formatDateString));
                }
                else
                {
                    // Select item
                    pickup.AllItem = false;
                    pickup.AllItemSpecified = true;
                    pickup.ItemNumber = this.txtItemNumber.Text.Trim();
                    pickup.AllExp = this.txtExpiryDate.Text.Trim() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL ? true : false;
                    pickup.AllExpSpecified = true;
                    pickup.ExpiryDate = this.txtExpiryDate.Text.Trim();
                    pickup.AllLot = this.txtLotNumber.Text.Trim() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL ? true : false;
                    pickup.AllLotSpecified = true;
                    pickup.LotNumber = this.txtLotNumber.Text.Trim();
                    pickup.Quantity = Convert.ToDouble(this.txtQuantity.Text.Trim());
                    pickup.QuantitySpecified = true;
                    pickup.Uom = this.cmbUOM.SelectedValue.ToString();
                    pickup.Status = this.cmbItemStatus.SelectedValue.ToString();
                }

                Calbee.WMS.Services.InventoryService.Response saveRecevie = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.SetPickupPutawayItem(pickup);
                if (saveRecevie != null)
                {
                    if (saveRecevie.StatusCode == 0)
                    {
                        // Success = StatusCode 0
                        MsgBox.DialogInfomation(saveRecevie.Message);
                        if (this.txtItemNumber.Text.Trim() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
                        {
                            DoAfterSave("ALL");
                        }
                        else
                        {
                            DoAfterSave("ITEMS");
                        }
                    }
                    else
                    {
                        MsgBox.DialogError(saveRecevie.Message);
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
                    MsgBox.DialogError(ex.GetBaseException().ToString());
                }
            }
        }

        #endregion

        #region Event

        private void frmPickup_Load(object sender, EventArgs e)
        {
            eventcomboItemNumber = true;
            eventcomboLotNumber = true;
            eventcomboExpiryDate = true;
            this.txtLocation.Focus();
            this.txtLocation.SelectAll();
        }
        private void frmPickup_KeyUp(object sender, KeyEventArgs e)
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
                        RefreshControl();
                        var locationResult = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventory(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtLocation.Text.Trim(), string.Empty, string.Empty, string.Empty);
                        if (locationResult != null)
                        {
                            if (!locationResult.LpnControl)
                            {
                                // False
                                this.txtLPN.Enabled = locationResult.LpnControl;
                                itemNumberBinding(this.txtLocation.Text.Trim(), string.Empty);
                                this.txtItemNumber.customFocus();
                            }
                            else
                            {
                                // True
                                this.txtLPN.Enabled = locationResult.LpnControl;
                                this.txtLPN.Focus();
                                this.txtLPN.SelectAll();
                            }
                        }
                        else
                        {
                            Cursor.Current = Cursors.Default;
                            MsgBox.DialogWarning("Null location " + this.txtLocation.Text + " in system");
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
                    if (string.IsNullOrEmpty(this.txtLPN.Text.Trim()))
                    {
                        MsgBox.DialogWarning("Please scan LPN");
                        this.txtLPN.Focus();
                        this.txtLPN.SelectAll();
                        return;
                    }
                    else
                    {
                        var lpnResult = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventory(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtLocation.Text.Trim(), string.Empty, this.txtLPN.Text.Trim(), string.Empty);
                        if (lpnResult != null)
                        {
                            itemNumberBinding(this.txtLocation.Text.Trim(), this.txtLPN.Text.Trim());
                            this.txtItemNumber.customFocus();
                        }
                        else
                        {
                            MsgBox.DialogWarning("Null LPN " + this.txtLPN.Text + " in system");
                            this.txtLPN.Text = string.Empty;
                            this.txtLPN.Focus();
                            this.txtLPN.SelectAll();
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

        private void txtItemNumber_SelectedIndexChangeds(object sender, EventArgs e)
        {
            if (!eventcomboItemNumber) return;
            if (this.txtItemNumber.SelectedIndex == 0)
            {
                // Empty
                this.txtLotNumber.Enabled = true;
                this.txtExpiryDate.Enabled = true;
                this.txtQuantity.Enabled = true;
                this.cmbUOM.Enabled = true;
                this.cmbItemStatus.Enabled = true;
                this.cmbUOM.DataSource = null;
                this.cmbItemStatus.DataSource = null;
                this.txtToLPN.Enabled = true;
                this.txtToLPN.Text = string.Empty;
            }
            else if (this.txtItemNumber.SelectedIndex == 1)
            {
                // ALL
                DisableControlByItem(Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL);
                this.txtDescription.Text = string.Empty;
                this.txtLotNumber.Text = string.Empty;
                this.txtExpiryDate.Text = string.Empty;
                this.cmbUOM.DataSource = null;
                this.cmbItemStatus.DataSource = null;
                this.txtQuantity.Text = string.Empty;
                this.txtToLPN.Text = this.txtLPN.Text.Trim();
            }
            else if (this.txtItemNumber.SelectedIndex > 1)
            {
                // Value
                ScanItemNumber();
                this.txtLotNumber.Enabled = true;
                this.txtExpiryDate.Enabled = true;
                this.txtQuantity.Enabled = true;
                this.cmbUOM.Enabled = true;
                this.cmbItemStatus.Enabled = true;
                this.txtToLPN.Enabled = true;
                this.txtToLPN.Text = string.Empty;
                this.txtLotNumber.customFocus();
            }
        }
        private void txtItemNumber_KeyDowns(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtItemNumber.Text))
                {
                    // Empty
                    this.txtLotNumber.Enabled = true;
                    this.txtExpiryDate.Enabled = true;
                    this.txtQuantity.Enabled = true;
                    this.cmbUOM.Enabled = true;
                    this.cmbItemStatus.Enabled = true;
                    this.cmbUOM.DataSource = null;
                    this.cmbItemStatus.DataSource = null;
                    this.txtToLPN.Enabled = true;
                    this.txtToLPN.Text = string.Empty;
                }
                else if (this.txtItemNumber.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
                {
                    // ALL
                    DisableControlByItem(Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL);
                    this.txtDescription.Text = string.Empty;
                    this.txtLotNumber.Text = string.Empty;
                    this.txtExpiryDate.Text = string.Empty;
                    this.cmbUOM.DataSource = null;
                    this.cmbItemStatus.DataSource = null;
                    this.txtQuantity.Text = string.Empty;
                    this.txtToLPN.Text = this.txtLPN.Text.Trim();
                }
                else
                {
                    // Value
                    ScanItemNumber();
                    this.txtLotNumber.Enabled = true;
                    this.txtExpiryDate.Enabled = true;
                    this.txtQuantity.Enabled = true;
                    this.cmbUOM.Enabled = true;
                    this.cmbItemStatus.Enabled = true;
                    this.txtToLPN.Enabled = true;
                    this.txtToLPN.Text = string.Empty;
                    this.txtLotNumber.customFocus();
                }
            }
        }

        private void txtLotNumber_SelectedIndexChangeds(object sender, EventArgs e)
        {
            if (!eventcomboLotNumber) return;
            if (this.txtLotNumber.SelectedIndex == 0)
            {
                // Empty
                this.txtExpiryDate.SelectedIndex = 0;
                this.txtLotNumber.customFocus();
            }
            else if (this.txtLotNumber.SelectedIndex == 1)
            {
                // ALL
                this.txtExpiryDate.SelectedIndex = 1;
                this.txtQuantity.Focus();
            }
            else
            {
                // Value
                if (this.txtExpiryDate.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
                {
                    this.txtExpiryDate.Text = string.Empty;
                    this.txtExpiryDate.customFocus();
                }
                else
                {
                    this.txtExpiryDate.customFocus();
                }
            }
        }
        private void txtLotNumber_KeyDowns(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(this.txtLotNumber.Text.Trim()))
                {
                    // Empty
                    this.txtExpiryDate.SelectedIndex = 0;
                }
                else if (this.txtLotNumber.Text.Trim() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
                {
                    // ALL
                    this.txtExpiryDate.SelectedIndex = 1;
                    this.txtQuantity.Focus();
                }
                else
                {
                    // Value
                    if (!checkLotNumber(this.txtLocation.Text.Trim(), this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim(), this.txtLotNumber.Text.Trim()))
                    {
                        MsgBox.DialogWarning("Not found lot number : " + this.txtLotNumber.Text.Trim() + " in system");
                        this.txtLotNumber.Text = string.Empty;
                        this.txtLotNumber.customFocus();
                        return;
                    }
                    else
                    {
                        this.txtExpiryDate.customFocus();
                    }
                }
            }
        }

        private void txtExpiryDate_SelectedIndexChangeds(object sender, EventArgs e)
        {
            if (!eventcomboExpiryDate) return;
            if (this.txtExpiryDate.SelectedIndex == 0)
            {
                // Empty
                this.txtExpiryDate.customFocus();
            }
            else if (this.txtExpiryDate.SelectedIndex == 1)
            {
                // ALL
                this.txtLotNumber.SelectedIndex = 1;
                this.txtQuantity.Focus();
            }
            else
            {
                // Value
                if (this.txtLotNumber.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
                {
                    this.txtLotNumber.Text = string.Empty;
                    this.txtQuantity.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.txtLotNumber.Text.Trim()))
                    {
                        this.txtLotNumber.customFocus();
                    }
                    else
                    {
                        this.txtQuantity.Focus();
                    }
                }
            }
        }
        private void txtExpiryDate_KeyDowns(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtExpiryDate.SelectedIndex == 0)
                {
                    // Empty
                    this.txtExpiryDate.customFocus();
                }
                else if (this.txtExpiryDate.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
                {
                    // ALL
                    this.txtLotNumber.SelectedIndex = 1;
                    this.txtQuantity.Focus();
                }
                else
                {
                    // Value
                    if (!checkExpiryDate(this.txtLocation.Text.Trim(), this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim(), this.txtExpiryDate.Text.Trim()))
                    {
                        MsgBox.DialogWarning("Not found expiry date : " + this.txtExpiryDate.Text.Trim() + " in system");
                        this.txtExpiryDate.Text = string.Empty;
                        this.txtExpiryDate.customFocus();
                        return;
                    }
                    else
                    {
                        if (this.txtLotNumber.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
                        {
                            this.txtLotNumber.Text = string.Empty;
                            this.txtQuantity.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.txtLotNumber.Text.Trim()))
                            {
                                this.txtLotNumber.customFocus();
                            }
                            else
                            {
                                this.txtQuantity.Focus();
                            }
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