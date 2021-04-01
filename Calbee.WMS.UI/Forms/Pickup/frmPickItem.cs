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

namespace Calbee.WMS.UI.Forms.Pickup
{
    public partial class frmPickItem : Form
    {
        #region Member

        bool eventcomboItemNumber = false;
        bool eventcomboLotNumber = false;
        bool eventcomboExpiryDate = false;
        string refErrorMsg = string.Empty;
        private static AppContext appContext = AppContext.Instance;
        public AppContext AppContext
        {
            get { return appContext; }
        }
        DataTable dt = new DataTable();

        #endregion

        #region Constuctor

        public frmPickItem()
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
        private void RefreshControl()
        {
            try
            {
                string SuggestLocationValue = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundPickSuggestLocation(string.Empty, this.txtPickingListNo.Text.Trim(), string.Empty);
                this.txtSuggestLocation.Text = string.IsNullOrEmpty(SuggestLocationValue) ? string.Empty : SuggestLocationValue;
                // Binding Gridview
                RefreshOutboundPickingListDetail(this.txtPickingListNo.Text.Trim(), string.Empty, string.Empty, string.Empty, string.Empty);
                this.txtLocation.Text = string.Empty;
                this.txtLocation.Enabled = true;
                this.txtLPN.Text = string.Empty;
                this.txtLPN.Enabled = true;
                this.txtItemNumber.SetArrayItemsToCombobox(new string[] { "" });
                this.txtItemNumber.Text = string.Empty;
                this.txtItemNumber.Enabled = true;
                this.txtDescription.Text = string.Empty;
                this.txtLotNumber.SetArrayItemsToCombobox(new string[] { "" });
                this.txtLotNumber.Text = string.Empty;
                this.txtLotNumber.Enabled = true;
                this.txtExpiryDate.SetArrayItemsToCombobox(new string[] { "" });
                this.txtExpiryDate.Text = string.Empty;
                this.txtExpiryDate.Enabled = true;
                this.txtQuantity.Text = string.Empty;
                this.txtQuantity.Enabled = true;
                this.cmbUOM.DataSource = null;
                this.cmbUOM.SelectedValue = string.Empty;
                this.txtItemStatus.Text = string.Empty;
                this.lblResultCounter.Text = "0/0";
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
        private void appContextUOMBinding(string itemNumber)
        {
            try
            {
                ComboBoxBinding.BindEntityToCombobox(AppContext.UOMDDLBinding(itemNumber), this.cmbUOM, "Uom", "ItemUomId", "");
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
        private void CreateTableOnGridView()
        {
            dt = new DataTable();
            dt.TableName = "PickItems";
            dt.Columns.Add("ItemNumber", typeof(string));
            dt.Columns.Add("ItemName", typeof(string));
            dt.Columns.Add("QuantityPlan", typeof(string));
            dt.Columns.Add("QuantityPick", typeof(string));
            dt.Columns.Add("QuantityRemain", typeof(string));
            dt.Columns.Add("UOM", typeof(string));
            dt.Columns.Add("LocationPlan", typeof(string));
            dt.Columns.Add("LPN", typeof(string));
            dt.Columns.Add("LotNumber", typeof(string));
            dt.Columns.Add("ExpiryDate", typeof(DateTime));
            dgvPickItem.DataSource = dt;
        }
        private void DisableControlByItem(string action)
        {
            if (action == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
            {
                this.txtLotNumber.Enabled = false;
                this.txtExpiryDate.Enabled = false;
                this.txtQuantity.Enabled = false;
                this.cmbUOM.Enabled = false;
                this.txtToLPN.Enabled = false;
            }
        }
        private bool checkLotNumber(string pickListNo, string locationcCode, string lpn, string itemNumber, string lotNumber)
        {
            bool result = false;
            try
            {
                List<string> _listLotNumber = new List<string>();
                _listLotNumber = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundPickingListItemLotNumbers(string.Empty, pickListNo, locationcCode, string.Empty, lpn, itemNumber).ToList();
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
        private bool checkExpiryDate(string pickListNo, string locationcCode, string lpn, string itemNumber, string expiryDate)
        {
            bool result = false;
            try
            {

                List<string> _listExpiryDate = new List<string>();
                _listExpiryDate = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundPickingListItemExpiryDates(string.Empty, pickListNo, locationcCode, string.Empty, lpn, itemNumber).ToList();
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
        private void RefreshOutboundPickingListDetail(string pickingListNo, string locationCode, string lpn, string itemNumber, string lotNumber)
        {
            try
            {
                this.dgvPickItem.DataSource = null;
                CreateTableOnGridView();
                var outboundPickListResult = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundPickingListDetails(string.Empty, pickingListNo, locationCode, string.Empty, lpn, itemNumber, lotNumber, string.Empty, string.Empty);
                if (outboundPickListResult != null)
                {
                    // เอาข้อมูลมาใส่ Gridview Production
                    DataTable dtTempPickList = ConvertObject.ToTable(outboundPickListResult);
                    if (dtTempPickList != null)
                    {
                        if (dtTempPickList.Rows.Count > 0)
                        {
                            //Add to datagrid.
                            DataRow AddAll;
                            foreach (DataRow item in dtTempPickList.Rows)
                            {
                                AddAll = dt.NewRow();
                                AddAll["ItemNumber"] = Convert.ToString(item["ItemNumber"]).Trim();
                                AddAll["ItemName"] = Convert.ToString(item["ItemName"]).Trim();
                                AddAll["QuantityPlan"] = Convert.ToString(item["QuantityPlan"]).Trim();
                                AddAll["QuantityPick"] = Convert.ToString(item["QuantityPick"]).Trim();
                                //AddAll["QuantityRemain"] = string.Empty;
                                AddAll["UOM"] = Convert.ToString(item["UOM"]).Trim();
                                AddAll["LocationPlan"] = Convert.ToString(item["LocationPlan"]).Trim();
                                AddAll["LPN"] = Convert.ToString(item["LPN"]).Trim();
                                AddAll["LotNumber"] = Convert.ToString(item["LotNumber"]).Trim();
                                AddAll["ExpiryDate"] = string.IsNullOrEmpty(item["ExpiryDate"].ToString()) ? DateTime.Now : Convert.ToDateTime(item["ExpiryDate"]);
                                dt.Rows.Add(AddAll);
                            }

                            dt.TableName = "PickItems";
                            dgvPickItem.DataSource = dt;
                        }
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
        private void lotNumberBinding(string picklistNo, string locationcCode, string lpn, string itemNumber)
        {
            try
            {
                List<string> _listLotNumber = new List<string>();
                _listLotNumber = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundPickingListItemLotNumbers(string.Empty, picklistNo, locationcCode, string.Empty, lpn, itemNumber).ToList();
                if (_listLotNumber != null)
                {
                    if (_listLotNumber.Count() == 1)
                    {
                        txtLotNumber.SetArrayItemsToCombobox(_listLotNumber.ToArray());
                        txtLotNumber.SelectedIndex = 0;
                    }
                    else if (_listLotNumber.Count() > 1)
                    {
                        _listLotNumber.Insert(0, string.Empty);
                        txtLotNumber.SetArrayItemsToCombobox(_listLotNumber.ToArray());
                    }
                    else
                    {
                        this.txtLotNumber.SetArrayItemsToCombobox(new string[] { "" });
                        this.txtLotNumber.Text = string.Empty;
                        this.txtItemNumber.customFocus();
                    }
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
        private void expiryDateBinding(string picklistNo, string locationcCode, string lpn, string itemNumber)
        {
            try
            {
                List<string> _listExpiryDate = new List<string>();
                _listExpiryDate = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundPickingListItemExpiryDates(string.Empty, picklistNo, locationcCode, string.Empty, lpn, itemNumber).ToList();
                if (_listExpiryDate != null)
                {
                    if (_listExpiryDate.Count() >= 1)
                    {
                        txtExpiryDate.SetArrayItemsToCombobox(_listExpiryDate.ToArray());
                        txtExpiryDate.SelectedIndex = 0;
                    }
                    else if (_listExpiryDate.Count() >= 1)
                    {
                        _listExpiryDate.Insert(0, string.Empty);
                        txtExpiryDate.SetArrayItemsToCombobox(_listExpiryDate.ToArray());
                    }
                    else
                    {
                        this.txtExpiryDate.SetArrayItemsToCombobox(new string[] { "" });
                        this.txtExpiryDate.Text = string.Empty;
                        this.txtItemNumber.customFocus();
                    }
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
        private void itemNumberBindingByLocation(string pickingListNo, string locationCode, string lpn, string itemNumber, string lotNumber, ref string erroMsg)
        {
            try
            {
                List<string> _listItemNumber = new List<string>();
                _listItemNumber = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundPickingListItems(string.Empty, pickingListNo, locationCode, string.Empty, lpn, string.Empty).ToList();
                if (_listItemNumber != null)
                {
                    if (_listItemNumber.Count() > 0)
                    {
                        /*
                        _listItemNumber.Insert(0, string.Empty);
                        _listItemNumber.Insert(1, Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL);
                        txtItemNumber.SetArrayItemsToCombobox(_listItemNumber.ToArray());
                        */

                        _listItemNumber.Insert(0, string.Empty);
                        txtItemNumber.SetArrayItemsToCombobox(_listItemNumber.ToArray());
                    }
                    else
                    {
                        erroMsg = "Not found data of Location : " + locationCode + " in system";
                        this.txtItemNumber.SetArrayItemsToCombobox(new string[] { "" });
                        this.txtItemNumber.Text = string.Empty;
                    }
                }
                else
                {
                    erroMsg = "Null data of Location : " + locationCode + " in system";
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
        private void itemNumberBindingByLPN(string pickingListNo, string locationCode, string lpn, string itemNumber, string lotNumber, ref string erroMsg)
        {
            try
            {
                List<string> _listItemNumber = new List<string>();
                _listItemNumber = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundPickingListItems(string.Empty, pickingListNo, locationCode, string.Empty, lpn, string.Empty).ToList();
                if (_listItemNumber != null)
                {
                    if (_listItemNumber.Count() > 0)
                    {
                        /*
                        _listItemNumber.Insert(0, string.Empty);
                        _listItemNumber.Insert(1, Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL);
                        txtItemNumber.SetArrayItemsToCombobox(_listItemNumber.ToArray());
                        */

                        _listItemNumber.Insert(0, string.Empty);
                        txtItemNumber.SetArrayItemsToCombobox(_listItemNumber.ToArray());
                    }
                    else
                    {
                        erroMsg = "Not found data of LPN : " + this.txtLPN.Text.Trim() + " in system";
                        this.txtItemNumber.SetArrayItemsToCombobox(new string[] { "" });
                        this.txtItemNumber.Text = string.Empty;
                    }
                }
                else
                {
                    erroMsg = "Null data of LPN : " + this.txtLPN.Text.Trim() + " in system";
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
        private void ScanItemNumber(ref string errorMsg)
        {
            try
            {
                refErrorMsg = string.Empty;
                List<Calbee.WMS.Services.OutboundService.OutboundPickDetail> itemResult = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundPickingListDetails(string.Empty, this.txtPickingListNo.Text.Trim(), this.txtLocation.Text.Trim(), string.Empty, this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim(), string.Empty, string.Empty, string.Empty).ToList();
                if (itemResult != null)
                {
                    if (itemResult.Count() >= 1)
                    {
                        this.txtLotNumber.Enabled = itemResult.FirstOrDefault().LotControl;
                        if (itemResult.FirstOrDefault().LotControl)
                        {
                            // Lotcontrol = true
                            lotNumberBinding(this.txtPickingListNo.Text.Trim(), this.txtLocation.Text.Trim(), this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim());
                        }
                        this.txtExpiryDate.Enabled = itemResult.FirstOrDefault().ExpiryDateControl;
                        if (itemResult.FirstOrDefault().ExpiryDateControl)
                        {
                            // ExpiryDateControl = true
                            expiryDateBinding(this.txtPickingListNo.Text.Trim(), this.txtLocation.Text.Trim(), this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim());
                        }

                        this.txtDescription.Text = string.IsNullOrEmpty(itemResult.FirstOrDefault().ItemName) ? string.Empty : itemResult.FirstOrDefault().ItemName;
                        ComboBoxBinding.BindEntityToCombobox(AppContext.UOMDDLBinding(this.txtItemNumber.Text.Trim()), this.cmbUOM, "Uom", "Uom", "");
                        this.cmbUOM.SelectedValue = itemResult.FirstOrDefault().Uom;
                        this.txtItemStatus.Text = Calbee.Infra.Common.Constants.WConstants.defaultItemStatus;
                        this.lblResultCounter.Text = itemResult.FirstOrDefault().QuantityPick + "/" + itemResult.FirstOrDefault().QuantityPlan;
                    }
                    else if (itemResult.Count() == 0)
                    {
                        errorMsg = "Not found item number : " + this.txtItemNumber.Text.Trim() + " in system";
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    errorMsg = ex.InnerException.Message.ToString();
                }
                else
                {
                    if (Calbee.Infra.Common.Constants.IConstants.CatchFlag.Equals("Y"))
                    {
                        // Show error description detail
                        errorMsg = ex.GetBaseException().ToString();
                    }
                    else
                    {
                        // Show message error
                        errorMsg = ex.Message.ToString();
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
                this.txtItemStatus.Text = string.Empty;
                this.txtToLPN.Text = string.Empty;

                this.txtLPN.Focus();
                this.txtLPN.SelectAll();
            }
            else if (actionEvent.Equals("ITEMS"))
            {
                this.txtItemNumber.SetArrayItemsToCombobox(new string[] { "" });
                this.txtItemNumber.Text = string.Empty;
                this.txtDescription.Text = string.Empty;
                this.txtLotNumber.Text = string.Empty;
                this.txtExpiryDate.Text = string.Empty;
                this.txtQuantity.Text = string.Empty;
                if (this.cmbUOM.DataSource != null)
                {
                    this.cmbUOM.SelectedIndex = 0;
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
                else if (string.IsNullOrEmpty(this.txtLocation.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan location");
                    result = false;
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
                else if (string.IsNullOrEmpty(this.txtLocation.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan location");
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
                Calbee.WMS.Services.OutboundService.PickItem pickitem = new Calbee.WMS.Services.OutboundService.PickItem();
                pickitem.Device = AppContext.DeviceName;
                pickitem.PickBy = Calbee.Infra.Common.Constants.WConstants.userName;
                pickitem.WarehouseCode = Calbee.Infra.Common.Constants.WConstants.wareHouseDDL;
                pickitem.Location = this.txtLocation.Text.Trim();
                pickitem.ToLocation = Calbee.Infra.Common.Constants.WConstants.forkLiftDDL;
                pickitem.Lpn = this.txtLPN.Text.Trim();
                pickitem.ToLpn = this.txtToLPN.Text.Trim();
                pickitem.PickDate = Convert.ToDateTime(AppContext.GetDateTimeServerString(Calbee.Infra.Common.Constants.WConstants.formatDateString));
                pickitem.PickDateSpecified = true;
                pickitem.PickingListNumber = this.txtPickingListNo.Text.Trim();
                if (this.txtItemNumber.Text.Trim() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
                {
                    // Select item number ALL
                    pickitem.ItemNumber = Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL;
                }
                else
                {
                    // Select item
                    pickitem.ItemNumber = this.txtItemNumber.Text.Trim();
                    pickitem.LotNumber = this.txtLotNumber.Text.Trim();
                    pickitem.ExpiryDate = this.txtExpiryDate.Text.Trim();
                    pickitem.QuantityPick = Convert.ToDouble(this.txtQuantity.Text.Trim());
                    pickitem.QuantityPickSpecified = true;
                    pickitem.Uom = this.cmbUOM.SelectedValue.ToString();
                    pickitem.Status = string.IsNullOrEmpty(this.txtItemStatus.Text.Trim()) ? Calbee.Infra.Common.Constants.WConstants.defaultItemStatus : this.txtItemStatus.Text.Trim();
                }

                Calbee.WMS.Services.OutboundService.Response savePickItem = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.SetPickItem(pickitem);
                if (savePickItem != null)
                {
                    if (savePickItem.StatusCode == 0)
                    {
                        // Success = StatusCode 0
                        MsgBox.DialogInfomation(savePickItem.Message);
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
                            string[] arrayCountInt = Convert.ToString(Convert.ToDecimal(tempArray) + Convert.ToDecimal(tempQuantity)).Split('.');
                            if (arrayCountInt.Length == 2)
                            {
                                if (arrayCountInt[1].ToString() == "0")
                                {
                                    this.lblResultCounter.Text = arrayCountInt[0].ToString() + "/" + tempTotal;
                                }
                                else
                                {
                                    this.lblResultCounter.Text = Convert.ToString(Convert.ToDecimal(tempArray) + Convert.ToDecimal(tempQuantity)) + "/" + tempTotal;
                                }
                            }
                            else
                            {
                                this.lblResultCounter.Text = Convert.ToString(Convert.ToDecimal(tempArray) + Convert.ToDecimal(tempQuantity)) + "/" + tempTotal;
                            }
                        }
                        string SuggestLocationValue = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundPickSuggestLocation(string.Empty, this.txtPickingListNo.Text.Trim(), string.Empty);
                        if (string.IsNullOrEmpty(SuggestLocationValue))
                        {
                            // ไม่มี Location กลับมา
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
                            // มี Location กลับมา
                            if (SuggestLocationValue == this.txtLocation.Text.Trim())
                            {
                                // Location ตัวเดียวกัน
                                this.txtLPN.Text = string.Empty;
                                this.txtLPN.Enabled = true;
                                this.txtItemNumber.SetArrayItemsToCombobox(new string[] { "" });
                                this.txtItemNumber.Text = string.Empty;
                                this.txtItemNumber.Enabled = true;
                                this.txtDescription.Text = string.Empty;
                                this.txtLotNumber.SetArrayItemsToCombobox(new string[] { "" });
                                this.txtLotNumber.Text = string.Empty;
                                this.txtLotNumber.Enabled = true;
                                this.txtExpiryDate.SetArrayItemsToCombobox(new string[] { "" });
                                this.txtExpiryDate.Text = string.Empty;
                                this.txtExpiryDate.Enabled = true;
                                this.txtQuantity.Text = string.Empty;
                                this.txtQuantity.Enabled = true;
                                this.cmbUOM.DataSource = null;
                                this.cmbUOM.SelectedValue = string.Empty;
                                this.txtItemStatus.Text = string.Empty;
                            }
                            else
                            {
                                // Location คนละตัวกัน
                                this.txtSuggestLocation.Text = SuggestLocationValue;
                                this.txtLocation.Text = string.Empty;
                                this.txtLocation.Enabled = true;
                                this.txtLPN.Text = string.Empty;
                                this.txtLPN.Enabled = true;
                                this.txtItemNumber.SetArrayItemsToCombobox(new string[] { "" });
                                this.txtItemNumber.Text = string.Empty;
                                this.txtItemNumber.Enabled = true;
                                this.txtDescription.Text = string.Empty;
                                this.txtLotNumber.SetArrayItemsToCombobox(new string[] { "" });
                                this.txtLotNumber.Text = string.Empty;
                                this.txtLotNumber.Enabled = true;
                                this.txtExpiryDate.SetArrayItemsToCombobox(new string[] { "" });
                                this.txtExpiryDate.Text = string.Empty;
                                this.txtExpiryDate.Enabled = true;
                                this.txtQuantity.Text = string.Empty;
                                this.txtQuantity.Enabled = true;
                                this.cmbUOM.DataSource = null;
                                this.cmbUOM.SelectedValue = string.Empty;
                                this.txtItemStatus.Text = string.Empty;
                            }
                        }
                    }
                    else
                    {
                        MsgBox.DialogError(savePickItem.Message);
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

        private void frmPickItem_Load(object sender, EventArgs e)
        {
            eventcomboItemNumber = true;
            eventcomboLotNumber = true;
            eventcomboExpiryDate = true;
            CreateTableOnGridView();
            this.lblResultCounter.Text = "0/0";
            this.txtPickingListNo.Focus();
            this.txtPickingListNo.SelectAll();
        }
        private void frmPickItem_KeyUp(object sender, KeyEventArgs e)
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.txtPickingListNo.Focus();
                this.txtPickingListNo.SelectAll();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                if (!string.IsNullOrEmpty(this.txtPickingListNo.Text))
                {
                    this.txtPickingListRefresh.Text = this.txtPickingListNo.Text.Trim();
                    this.txtPickingListRefresh.Focus();
                    this.txtPickingListRefresh.SelectAll();
                }
                else
                {
                    this.txtPickingListRefresh.Text = string.Empty;
                    this.txtPickingListRefresh.Focus();
                    this.txtPickingListRefresh.SelectAll();
                }
            }
        }

        private void txtPickingListNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(this.txtPickingListNo.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan picking list no");
                    this.txtPickingListNo.Focus();
                    this.txtPickingListNo.SelectAll();
                    return;
                }
                else
                {
                    try
                    {
                        // Refresh control
                        RefreshControl();
                        string SuggestLocationValue = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundPickSuggestLocation(string.Empty, this.txtPickingListNo.Text.Trim(), string.Empty);
                        this.txtSuggestLocation.Text = string.IsNullOrEmpty(SuggestLocationValue) ? string.Empty : SuggestLocationValue;

                        // Binding Gridview
                        RefreshOutboundPickingListDetail(this.txtPickingListNo.Text.Trim(), string.Empty, string.Empty, string.Empty, string.Empty);
                        this.txtLocation.Focus();
                        this.txtLocation.SelectAll();
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
                    try
                    {
                        var outboundPickListResult = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundPickingListDetail(string.Empty, this.txtPickingListNo.Text.Trim(), this.txtLocation.Text, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                        if (outboundPickListResult != null)
                        {
                            this.txtLPN.Enabled = outboundPickListResult.LpnControl;
                            if (this.txtLPN.Enabled)
                            {
                                // Lpn = True
                                this.txtLPN.Focus();
                                this.txtLPN.SelectAll();
                            }
                            else
                            {
                                // Lpn = False
                                itemNumberBindingByLocation(this.txtPickingListNo.Text.Trim(), this.txtLocation.Text.Trim(), string.Empty, string.Empty, string.Empty, ref refErrorMsg);
                                if (!string.IsNullOrEmpty(refErrorMsg))
                                {
                                    MsgBox.DialogError(refErrorMsg);
                                    this.txtLocation.Focus();
                                    this.txtLocation.SelectAll();
                                }
                                else
                                {
                                    this.txtItemNumber.customFocus();
                                }
                            }
                        }
                        else
                        {
                            MsgBox.DialogWarning("Null location : " + this.txtLocation.Text.Trim() + " in system");
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
        }
        private void txtLPN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                    try
                    {
                        refErrorMsg = string.Empty;
                        itemNumberBindingByLPN(this.txtPickingListNo.Text.Trim(), this.txtLocation.Text.Trim(), this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim(), string.Empty, ref refErrorMsg);
                        if (!string.IsNullOrEmpty(refErrorMsg))
                        {
                            MsgBox.DialogError(refErrorMsg);
                            this.txtLPN.Focus();
                            this.txtLPN.SelectAll();
                        }
                        else
                        {
                            this.txtItemNumber.customFocus();
                            this.txtToLPN.Text = this.txtLPN.Text;
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
                this.cmbUOM.DataSource = null;
                this.txtItemStatus.Text = string.Empty;
                this.txtToLPN.Enabled = true;
                this.txtToLPN.Text = string.Empty;
            }
                /*
            else if (this.txtItemNumber.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
            {
                DisableControlByItem(Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL);
                this.txtLotNumber.Text = string.Empty;
                this.txtExpiryDate.Text = string.Empty;
                this.cmbUOM.DataSource = null;
                this.txtItemStatus.Text = string.Empty;
                this.txtQuantity.Text = string.Empty;
                this.txtToLPN.Text = this.txtLPN.Text.Trim();
            }
                */
            else if (this.txtItemNumber.SelectedIndex > 1)
            {
                ScanItemNumber(ref refErrorMsg);
                if (!string.IsNullOrEmpty(refErrorMsg))
                {
                    MsgBox.DialogError(refErrorMsg);
                    this.txtLotNumber.Enabled = true;
                    this.txtExpiryDate.Enabled = true;
                    this.txtQuantity.Enabled = true;
                    this.cmbUOM.Enabled = true;
                    this.txtToLPN.Text = string.Empty;
                    this.txtItemNumber.customFocus();
                }
                else
                {
                    this.txtToLPN.Text = string.Empty;
                    if (this.txtLotNumber.Enabled)
                    {
                        this.txtLotNumber.customFocus();
                    }
                    else
                    {
                        this.txtQuantity.Focus();
                        this.txtQuantity.SelectAll();
                    }
                }
            }
        }
        private void txtItemNumber_KeyDowns(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(this.txtItemNumber.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan item numner");
                    this.txtItemNumber.customFocus();
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtItemNumber.Text))
                    {
                        this.txtLotNumber.Enabled = true;
                        this.txtExpiryDate.Enabled = true;
                        this.txtQuantity.Enabled = true;
                        this.cmbUOM.Enabled = true;
                        this.cmbUOM.DataSource = null;
                        this.txtItemStatus.Text = string.Empty;
                        this.txtToLPN.Enabled = true;
                        this.txtToLPN.Text = string.Empty;
                    }
                    else
                    {
                        ScanItemNumber(ref refErrorMsg);
                        if (!string.IsNullOrEmpty(refErrorMsg))
                        {
                            MsgBox.DialogError(refErrorMsg);
                            this.txtLotNumber.Enabled = true;
                            this.txtExpiryDate.Enabled = true;
                            this.txtQuantity.Enabled = true;
                            this.cmbUOM.Enabled = true;
                            this.txtToLPN.Text = string.Empty;
                            this.txtItemNumber.customFocus();
                            this.txtItemNumber.customSelectAll();
                        }
                        else
                        {
                            this.txtQuantity.Focus();
                            this.txtQuantity.SelectAll();
                        }
                    }
                }
            }
        }

        private void txtLotNumber_SelectedIndexChangeds(object sender, EventArgs e)
        {
            if (!eventcomboLotNumber) return;
            if (this.txtLotNumber.SelectedIndex == 0)
            {
                this.txtExpiryDate.SelectedIndex = 0;
                this.txtLotNumber.customFocus();
            }
                /*
            else if (this.txtLotNumber.SelectedIndex == 1)
            {
                // ALL
                this.txtExpiryDate.SelectedIndex = 1;
                this.txtExpiryDate.Text = Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL;
                this.txtQuantity.Focus();
            }
                */
            else
            {
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
                    this.txtExpiryDate.SelectedIndex = 0;
                }
                    /*
                else if (this.txtLotNumber.Text.Trim() == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
                {
                    // ALL
                    this.txtExpiryDate.SelectedIndex = 1;
                    this.txtExpiryDate.Text = Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL;
                    this.txtQuantity.Focus();
                }
                    */
                else
                {
                    // Select lot number
                    if (!checkLotNumber(this.txtPickingListNo.Text.Trim(), this.txtLocation.Text.Trim(), this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim(), this.txtLotNumber.Text.Trim()))
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
                this.txtExpiryDate.customFocus();
            }
                /*
            else if (this.txtExpiryDate.SelectedIndex == 1)
            {
                // ALL
                this.txtLotNumber.SelectedIndex = 1;
                this.txtLotNumber.Text = Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL;
                this.txtQuantity.Focus();
            }
                */
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
        private void txtExpiryDate_KeyDowns(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtExpiryDate.SelectedIndex == 0)
                {
                    this.txtExpiryDate.customFocus();
                }
                    /*
                else if (this.txtExpiryDate.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL)
                {
                    // ALL
                    this.txtLotNumber.SelectedIndex = 1;
                    this.txtLotNumber.Text = Calbee.Infra.Common.Constants.WConstants.defaultDropdownALL;
                    this.txtQuantity.Focus();
                }
                    */
                else
                {
                    // Select lot number
                    if (!checkExpiryDate(this.txtPickingListNo.Text.Trim(), this.txtLocation.Text.Trim(), this.txtLPN.Text.Trim(), this.txtItemNumber.Text.Trim(), this.txtExpiryDate.Text.Trim()))
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
        private void brnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPickingListRefresh.Text.Trim()))
            {
                MsgBox.DialogWarning("Please scan picking list no");
                this.txtPickingListRefresh.Focus();
                this.txtPickingListRefresh.SelectAll();
                return;
            }
            else
            {
                // Binding Gridview
                RefreshOutboundPickingListDetail(this.txtPickingListRefresh.Text.Trim(), string.Empty, string.Empty, string.Empty, string.Empty);
            }
        }
        private void btnStaging_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPickingListRefresh.Text.Trim()))
            {
                MsgBox.DialogWarning("Please scan picking list no");
                this.txtPickingListRefresh.Focus();
                this.txtPickingListRefresh.SelectAll();
                return;
            }
            else
            {
                /* ถ้าต้องการให้ Refresh หน้า frmPutawayStaging ให้เปิด Comment ออก
                   Forms.Putaway.frmPutawayStaging fPutawayStaging = new Calbee.WMS.UI.Forms.Putaway.frmPutawayStaging(this.txtPickingListRefresh.Text.Trim());
                   fPutawayStaging.Show();
                   this.Close();
                */

                using (Forms.Putaway.frmPutawayStaging fPutawayStaging = new Calbee.WMS.UI.Forms.Putaway.frmPutawayStaging(this.txtPickingListRefresh.Text.Trim()))
                {
                    fPutawayStaging.ShowDialog();
                }
            }
        }

        #endregion
    }
}