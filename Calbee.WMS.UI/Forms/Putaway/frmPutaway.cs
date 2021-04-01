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

namespace Calbee.WMS.UI.Forms.Putaway
{
    public partial class frmPutaway : Form
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

        public frmPutaway()
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
                _listItemStatus = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventoryStatuss(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, Calbee.Infra.Common.Constants.WConstants.forkLiftDDL, string.Empty, string.Empty, this.txtItemNumber.Text.Trim()).ToList();
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
                _listItemStatus = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventoryStatuss(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, Calbee.Infra.Common.Constants.WConstants.forkLiftDDL, string.Empty, string.Empty, this.txtItemNumber.Text.Trim()).ToList();
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

                    /* แสดงแบบ show select index = 0
                    if (string.IsNullOrEmpty(statusName))
                    {
                        _listItemStatus.Insert(0, Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect);
                    }
                    ComboBoxBinding.BindLStringToCombobox(_listItemStatus, this.cmbItemStatus);
                    this.cmbItemStatus.Text = statusName;
                    */
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
                    if (_listReceiveNumber.Count() > 0)
                    {
                        _listReceiveNumber.Insert(0, string.Empty);
                        _listReceiveNumber.Insert(1, Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL);
                        txtItemNumber.SetArrayItemsToCombobox(_listReceiveNumber.ToArray());
                    }
                    else
                    {
                        this.txtItemNumber.SetArrayItemsToCombobox(new string[] { "" });
                        this.txtItemNumber.Text = string.Empty;
                        this.txtItemNumber.customFocus();
                    }
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
                var itemResult = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventory(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, Calbee.Infra.Common.Constants.WConstants.forkLiftDDL, string.Empty, this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim());
                if (itemResult != null)
                {
                    this.txtLotNumber.Enabled = itemResult.LotControl;
                    if (itemResult.LotControl)
                    {
                        // Lotcontrol = true
                        lotNumberBinding(Calbee.Infra.Common.Constants.WConstants.forkLiftDDL, this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim());
                    }
                    this.txtExpiryDate.Enabled = itemResult.ExpiryDateControl;
                    if (itemResult.ExpiryDateControl)
                    {
                        // ExpiryDateControl = true
                        expiryDateBinding(Calbee.Infra.Common.Constants.WConstants.forkLiftDDL, this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim());
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
            bool result = false;
            if (this.txtItemNumber.Text.Trim() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
            {
                if (string.IsNullOrEmpty(this.txtItemNumber.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan item number");
                    result = false;
                }
                else if (string.IsNullOrEmpty(this.txtToLocation.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan location");
                    result = false;
                }
                else if (string.IsNullOrEmpty(this.txtLPN.Text.Trim()))
                {
                    if (this.txtLPN.Enabled)
                    {
                        MsgBox.DialogWarning("Please scan LPN");
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                else if (string.IsNullOrEmpty(this.txtToLPN.Text.Trim()))
                {
                    if (this.txtToLPN.Enabled)
                    {
                        MsgBox.DialogWarning("Please scan to lpn");
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                else
                {
                    result = true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(this.txtItemNumber.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please select item number");
                    result = false;
                }
                else if (string.IsNullOrEmpty(this.txtToLocation.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan to location");
                    result = false;
                }
                else if (string.IsNullOrEmpty(this.txtLotNumber.Text))
                {
                    if (this.txtLotNumber.Enabled)
                    {
                        MsgBox.DialogWarning("Please select lot number");
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                else if (string.IsNullOrEmpty(this.txtExpiryDate.Text))
                {
                    if (this.txtExpiryDate.Enabled)
                    {
                        MsgBox.DialogWarning("Please select expiry date");
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                else if (string.IsNullOrEmpty(this.txtQuantity.Text.Trim()))
                {
                    if (this.txtQuantity.Enabled)
                    {
                        MsgBox.DialogWarning("Please input quantity");
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                else if (string.IsNullOrEmpty(this.cmbUOM.SelectedValue.ToString()))
                {
                    if (this.cmbUOM.Enabled)
                    {
                        MsgBox.DialogWarning("Please select uom");
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                else if (string.IsNullOrEmpty(this.txtToLPN.Text.Trim()))
                {
                    if (this.txtLPN.Enabled)
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
                    result = true;
                }
            }

            return result;
        }
        private void DoSave()
        {
            try
            {
                Calbee.WMS.Services.InventoryService.InventoryItem putaway = new Calbee.WMS.Services.InventoryService.InventoryItem();
                putaway.AllLpn = false;
                putaway.AllLpnSpecified = true;
                putaway.Device = AppContext.DeviceName;
                putaway.PickBy = Calbee.Infra.Common.Constants.WConstants.userName;
                putaway.WarehouseCode = Calbee.Infra.Common.Constants.WConstants.wareHouseDDL;
                putaway.Location = Calbee.Infra.Common.Constants.WConstants.forkLiftDDL;
                putaway.ToLocation = this.txtToLocation.Text.Trim();
                putaway.SubTranType = Calbee.Infra.Common.Constants.WConstants.PutawayTranType;
                putaway.TransactionType = Calbee.Infra.Common.Constants.WConstants.PutawayTranType;
                putaway.Lpn = this.txtLPN.Text.Trim();
                putaway.ToLpn = this.txtToLPN.Text.Trim();
                if (this.txtItemNumber.Text.Trim() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
                {
                    // Select item number ALL
                    putaway.AllItem = true;
                    putaway.AllItemSpecified = true;
                    putaway.ItemNumber = Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL;
                    putaway.PickDate = Convert.ToDateTime(AppContext.GetDateTimeServerString(Calbee.Infra.Common.Constants.WConstants.formatDateString));
                }
                else
                {
                    // Select item
                    putaway.AllItem = false;
                    putaway.AllItemSpecified = true;
                    putaway.ItemNumber = this.txtItemNumber.Text.Trim();
                    putaway.AllExp = this.txtExpiryDate.Text.Trim() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL ? true : false;
                    putaway.AllExpSpecified = true;
                    putaway.ExpiryDate = this.txtExpiryDate.Text.Trim();
                    putaway.AllLot = this.txtLotNumber.Text.Trim() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL ? true : false;
                    putaway.AllLotSpecified = true;
                    putaway.LotNumber = this.txtLotNumber.Text.Trim();
                    putaway.Quantity = Convert.ToDouble(this.txtQuantity.Text.Trim());
                    putaway.QuantitySpecified = true;
                    putaway.Uom = this.cmbUOM.SelectedValue.ToString();
                    putaway.Status = this.cmbItemStatus.SelectedValue.ToString();
                }

                Calbee.WMS.Services.InventoryService.Response saveRecevie = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.SetPickupPutawayItem(putaway);
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
                        MsgBox.DialogWarning(saveRecevie.Message);
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

        #endregion

        #region Event

        private void frmPutaway_Load(object sender, EventArgs e)
        {
            try
            {
                // Suggest location
                eventcomboItemNumber = true;
                eventcomboLotNumber = true;
                eventcomboExpiryDate = true;
                string suggestLocationResult = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetSuggestLocation(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, Calbee.Infra.Common.Constants.WConstants.forkLiftDDL);
                this.txtSuggestLocation.Text = string.IsNullOrEmpty(suggestLocationResult) ? string.Empty : suggestLocationResult.Trim();
                this.txtToLocation.Focus();
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
        private void frmPutaway_KeyUp(object sender, KeyEventArgs e)
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
                try
                {
                    if (string.IsNullOrEmpty(this.txtToLocation.Text.Trim()))
                    {
                        MsgBox.DialogWarning("Please scan location");
                        this.txtToLocation.Focus();
                        this.txtToLocation.SelectAll();
                        return;
                    }
                    else
                    {
                        RefreshControl();
                        var lpnResults = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetLocation(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtToLocation.Text.Trim(), string.Empty, string.Empty);
                        if (lpnResults != null)
                        {
                            this.txtLPN.Enabled = lpnResults.LpnControlled;
                            if (this.txtLPN.Enabled)
                            {
                                // LPN = True
                                this.txtLPN.Focus();
                                this.txtLPN.SelectAll();
                            }
                            else
                            {
                                // LPN = false
                                itemNumberBinding(Calbee.Infra.Common.Constants.WConstants.forkLiftDDL, string.Empty);
                                this.txtItemNumber.customFocus();
                            }
                        }
                        else
                        {
                            Cursor.Current = Cursors.Default;
                            MsgBox.DialogWarning("Null location " + this.txtToLocation.Text + " in system");
                            this.txtToLocation.Focus();
                            this.txtToLocation.SelectAll();
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
                    /*
                    if (string.IsNullOrEmpty(this.txtLPN.Text.Trim()))
                    {
                        MsgBox.DialogWarning("Please scan LPN");
                        this.txtLPN.Focus();
                        this.txtLPN.SelectAll();
                        return;
                    }
                    else
                    {
                        itemNumberBinding(Calbee.Infra.Common.Constants.WConstants.forkLiftDDL, this.txtLPN.Text.Trim());
                        if (this.txtItemNumber.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
                        {
                            this.txtToLPN.Text = this.txtLPN.Text.Trim();
                        }
                        else
                        {
                            this.txtItemNumber.customFocus();
                        }
                    }
                    */

                    itemNumberBinding(Calbee.Infra.Common.Constants.WConstants.forkLiftDDL, this.txtLPN.Text.Trim());
                    if (this.txtItemNumber.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
                    {
                        this.txtToLPN.Text = this.txtLPN.Text.Trim();
                    }
                    else
                    {
                        this.txtItemNumber.customFocus();
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
                    ScanItemNumber();
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
                    // // Value
                    if (!checkLotNumber(Calbee.Infra.Common.Constants.WConstants.forkLiftDDL, this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim(), this.txtLotNumber.Text.Trim()))
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
                    if (!checkExpiryDate(Calbee.Infra.Common.Constants.WConstants.forkLiftDDL, this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim(), this.txtExpiryDate.Text.Trim()))
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