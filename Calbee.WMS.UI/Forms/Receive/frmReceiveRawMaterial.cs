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

namespace Calbee.WMS.UI.Forms.Receive
{
    public partial class frmReceiveRawMaterial : Form
    {
        #region Member

        bool eventcomboReceiveNumber = false;
        DataTable dtProduction = new DataTable();
        DataTable dtDetail = new DataTable();
        System.Globalization.CultureInfo _cultureEnInfo = new System.Globalization.CultureInfo("en-US");
        public string orderType { get; set; }
        private static AppContext appContext = AppContext.Instance;
        public AppContext AppContext
        {
            get { return appContext; }
        }

        #endregion

        #region Constructor

        public frmReceiveRawMaterial()
        {
            InitializeComponent();
            this.txtQuantity.KeyPress += new KeyPressEventHandler(EventControls.txtNumber_TextChanged);
            //this.txtLotNumber.KeyPress += new KeyPressEventHandler(EventControls.txtNumberDat_TextChanged);
        }

        #endregion

        #region Method

        private void receiveNumberBinding(string orderNumber, ref string errorMsg)
        {
            try
            {
                List<Calbee.WMS.Services.InboundService.ReceiptHeader> _listReceiveNumber = new List<Calbee.WMS.Services.InboundService.ReceiptHeader>();
                Calbee.WMS.Services.InboundService.ReceiptHeader _master;
                _listReceiveNumber = Calbee.WMS.Services.Inbound.InboundServiceProxy.WS.GetInboundReceiptHeader(orderNumber).ToList();
                if (_listReceiveNumber != null)
                {
                    if (_listReceiveNumber.Count() == 0)
                    {
                        #region Scan order number = 0

                        // ไม่มีข้อมูล -> scan order number 
                        // แล้วถ้าไม่มี ข้อมูล receive number ให้เรียก GenerateReceiveNumber เลยแล้ว binding drowdown และให้ไป focus ที่ receive location
                        var receiveNumberResult = Calbee.WMS.Services.Inbound.InboundServiceProxy.WS.GenerateReceiveNumber(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtOrderNumber.Text.Trim(), AppContext.CurrentUser.UserName);
                        if (receiveNumberResult != null)
                        {
                            // Binding ReceiveNumber
                            List<Calbee.WMS.Services.InboundService.ReceiptHeader> _listBinding = Calbee.WMS.Services.Inbound.InboundServiceProxy.WS.GetInboundReceiptHeader(orderNumber).ToList();
                            if (_listBinding != null)
                            {
                                if (_listBinding.Count() == 1)
                                {
                                    // Default value ReceiveNumber
                                    orderType = _listBinding.FirstOrDefault().OrderType;
                                    this.txtReceiveNumber.SetEntityItemsToCombobox(_listBinding, "ReceiptNumber", "ReceiptNumber");
                                }
                                else
                                {
                                    orderType = _listBinding.FirstOrDefault().OrderType;
                                    _master = new Calbee.WMS.Services.InboundService.ReceiptHeader();
                                    _master.ReceiptNumber = Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect;
                                    _listReceiveNumber.Insert(0, _master);
                                    this.txtReceiveNumber.SetEntityItemsToCombobox(_listBinding, "ReceiptNumber", "ReceiptNumber");
                                }
                            }
                        }
                        else
                        {
                            this.txtReceiveNumber.SetArrayItemsToCombobox(new string[] { "" });
                            this.txtReceiveNumber.Text = string.Empty;
                            this.txtReceiveNumber.customFocus();
                        }

                        #endregion
                    }
                    else if (_listReceiveNumber.Count() == 1)
                    {
                        #region Scan order number = 1

                        // Default value ReceiveNumber
                        orderType = _listReceiveNumber.FirstOrDefault().OrderType;
                        this.txtReceiveNumber.SetEntityItemsToCombobox(_listReceiveNumber, "ReceiptNumber", "ReceiptNumber");

                        #endregion
                    }
                    else if (_listReceiveNumber.Count() > 1)
                    {
                        #region Scan order number > 1

                        // Binding dropdowm
                        orderType = _listReceiveNumber.FirstOrDefault().OrderType;
                        _master = new Calbee.WMS.Services.InboundService.ReceiptHeader();
                        _master.ReceiptNumber = Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect;
                        _listReceiveNumber.Insert(0, _master);
                        this.txtReceiveNumber.SetEntityItemsToCombobox(_listReceiveNumber, "ReceiptNumber", "ReceiptNumber");

                        #endregion
                    }
                    else
                    {
                        #region Exception = null

                        orderType = string.Empty;
                        this.txtReceiveNumber.SetArrayItemsToCombobox(new string[] { "" });
                        this.txtReceiveNumber.Text = string.Empty;

                        #endregion
                    }

                    this.txtReceiveNumber.customFocus();
                }
                else
                {
                    this.txtReceiveNumber.SetArrayItemsToCombobox(new string[] { "" });
                    this.txtReceiveNumber.Text = string.Empty;
                    this.txtReceiveNumber.customFocus();
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

                errorMsg = "ERR";
                return;
            }
        }
        private bool checkReceiveNumber(string orderNumber, string receiveNumber)
        {
            bool result = false;
            try
            {
                List<Calbee.WMS.Services.InboundService.ReceiptHeader> _listReceiveNumber = new List<Calbee.WMS.Services.InboundService.ReceiptHeader>();
                _listReceiveNumber = Calbee.WMS.Services.Inbound.InboundServiceProxy.WS.GetInboundReceiptHeader(orderNumber).ToList();
                if (_listReceiveNumber != null)
                {
                    foreach (var item in _listReceiveNumber)
                    {
                        if (item.ReceiptNumber.Trim() == receiveNumber.Trim())
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
        private void ItemStatusBinding()
        {
            try
            {
                List<Calbee.WMS.Services.MasterService.tbc_Status> _listItemStatus = new List<Calbee.WMS.Services.MasterService.tbc_Status>();
                Calbee.WMS.Services.MasterService.tbc_Status _master;
                _listItemStatus = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetStatus(Calbee.Infra.Common.Constants.WConstants.reciveItemStatusType).ToList();
                if (_listItemStatus != null)
                {
                    if (_listItemStatus.Count() == 1)
                    {
                        // Default value ReceiveNumber
                        ComboBoxBinding.BindEntityToCombobox(_listItemStatus, this.cmbItemStatus, "StatusName", "StatusName", "");
                    }
                    else if (_listItemStatus.Count() > 1)
                    {
                        // Binding dropdowm
                        _master = new Calbee.WMS.Services.MasterService.tbc_Status();
                        _master.StatusName = Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect;
                        _listItemStatus.Insert(0, _master);
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
        private void RefreshControl()
        {
            this.txtReceiveNumber.SetEntityItemsToCombobox(new List<Calbee.WMS.Services.InboundService.ReceiptHeader>(), string.Empty, string.Empty);
            this.txtReceiveNumber.Text = string.Empty;
            this.txtReceiveNumber.Enabled = true;
            this.txtReceiveLocation.Text = string.Empty;
            this.txtReceiveLocation.Enabled = true;
            this.txtReceiveLPN.Text = string.Empty;
            this.txtReceiveLPN.Enabled = true;
            this.txtItemNumber.Text = string.Empty;
            this.txtItemNumber.Enabled = true;
            this.txtDescription.Text = string.Empty;
            this.txtDescription.Enabled = false;
            this.dtpLotNumber.Value = DateTime.Now;
            this.dtpLotNumber.Enabled = true;
            this.dtpExpiryDate.Value = DateTime.Now;
            this.dtpExpiryDate.Enabled = true;
            this.txtQuantity.Text = string.Empty;
            this.txtQuantity.Enabled = true;
            this.cmbUOM.DataSource = null;
            this.cmbUOM.SelectedValue = string.Empty;
            this.cmbItemStatus.SelectedIndex = 0;
            this.dtpReceiveDate.Value = DateTime.Now;
            this.dtpReceiveDate.Enabled = true;
            this.lblResultCounter.Text = "0/0";
        }
        private void gotoItemNumber()
        {
            this.txtItemNumber.Text = string.Empty;
            this.txtItemNumber.Enabled = true;
            this.txtDescription.Text = string.Empty;
            this.txtDescription.Enabled = false;
            this.dtpLotNumber.Value = DateTime.Now;
            this.dtpLotNumber.Enabled = true;
            this.dtpExpiryDate.Value = DateTime.Now;
            this.dtpExpiryDate.Enabled = true;
            this.txtQuantity.Text = string.Empty;
            this.txtQuantity.Enabled = true;
            this.cmbUOM.DataSource = null;
            this.cmbUOM.SelectedValue = string.Empty;
        }
        private void CreateTableProductionOnGridView()
        {
            dtProduction = new DataTable();
            dtProduction.TableName = "Production";
            dtProduction.Columns.Add("ItemNumber", typeof(string));
            dtProduction.Columns.Add("ItemName", typeof(string));
            dtProduction.Columns.Add("QuantityReceive", typeof(string));
            dtProduction.Columns.Add("Quantity", typeof(string));
            dtProduction.Columns.Add("UOM", typeof(string));
            dtProduction.Columns.Add("Location", typeof(string));
            dtProduction.Columns.Add("LPN", typeof(string));
            dtProduction.Columns.Add("LotNumber", typeof(string));
            dtProduction.Columns.Add("ExpiryDate", typeof(string));
            dtProduction.Columns.Add("StatusName", typeof(string));
            dtProduction.Columns.Add("ReceiveDate", typeof(string));
            dtProduction.Columns.Add("ReceiveBy", typeof(string));

            dgvReceiveProduction.DataSource = dtProduction;
        }
        private void CreateTableDetailOnGridView()
        {
            dtDetail = new DataTable();
            dtDetail.TableName = "Detail";
            dtDetail.Columns.Add("ItemNumber", typeof(string));
            dtDetail.Columns.Add("ItemName", typeof(string));
            dtDetail.Columns.Add("QuantityReceive", typeof(string));
            dtDetail.Columns.Add("QuantityOrder", typeof(string));
            dtDetail.Columns.Add("UOM", typeof(string));
            dtDetail.Columns.Add("DefaultLocation", typeof(string));
            dtDetail.Columns.Add("DefaultLPN", typeof(string));
            dtDetail.Columns.Add("LotNumber", typeof(string));
            dtDetail.Columns.Add("ExpiryDate", typeof(string));
            dtDetail.Columns.Add("ItemStatus", typeof(string));

            dgvReceiveDetail.DataSource = dtDetail;
        }
        private void RefreshInboundLpnDetail(string orderNumber, string lpn, string itemNumber)
        {
            try
            {
                this.dgvReceiveProduction.DataSource = null;
                CreateTableProductionOnGridView();
                var inboundLpnResult = Calbee.WMS.Services.Inbound.InboundServiceProxy.WS.GetInboundLpnDetails(orderNumber.Trim(), Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, lpn, itemNumber);
                if (inboundLpnResult != null)
                {
                    // เอาข้อมูลมาใส่ Gridview Production
                    DataTable dtTempProduction = ConvertObject.ToTable(inboundLpnResult);
                    if (dtTempProduction != null)
                    {
                        if (dtTempProduction.Rows.Count > 0)
                        {
                            //Add to datagrid.
                            DataRow AddAll;
                            foreach (DataRow item in dtTempProduction.Rows)
                            {
                                AddAll = dtProduction.NewRow();
                                AddAll["ItemNumber"] = Convert.ToString(item["ItemNumber"]).Trim();
                                AddAll["ItemName"] = Convert.ToString(item["ItemName"]).Trim();
                                AddAll["QuantityReceive"] = Convert.ToString(item["QuantityReceive"]).Trim();
                                AddAll["Quantity"] = Convert.ToString(item["Quantity"]).Trim();
                                AddAll["UOM"] = Convert.ToString(item["UOM"]).Trim();
                                AddAll["Location"] = string.Empty; //Convert.ToString(item["Location"]).Trim();
                                AddAll["LPN"] = Convert.ToString(item["LPN"]).Trim();
                                AddAll["LotNumber"] = Convert.ToString(item["LotNumber"]).Trim();
                                AddAll["ExpiryDate"] = Convert.ToString(item["ExpiryDate"]).Trim();
                                AddAll["StatusName"] = Convert.ToString(item["LpnStatus"]).Trim();
                                AddAll["ReceiveDate"] = Convert.ToString(item["ReceiveDate"]).Trim();
                                AddAll["ReceiveBy"] = Convert.ToString(item["ReceiveBy"]).Trim();
                                dtProduction.Rows.Add(AddAll);
                            }

                            dtProduction.TableName = "Production";
                            dgvReceiveProduction.DataSource = dtProduction;
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
        private void RefreshInboundDetail(string orderNumber, string lpn, string itemNumber)
        {
            try
            {
                this.dgvReceiveDetail.DataSource = null;
                CreateTableDetailOnGridView();
                var inboundDetailResult = Calbee.WMS.Services.Inbound.InboundServiceProxy.WS.GetInboundDetails(orderNumber.Trim(), Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, lpn, itemNumber);
                if (inboundDetailResult != null)
                {
                    // เอาข้อมูลมาใส่ Gridview Production
                    DataTable dtTempDetail = ConvertObject.ToTable(inboundDetailResult);
                    if (dtTempDetail != null)
                    {
                        if (dtTempDetail.Rows.Count > 0)
                        {
                            //Add to datagrid.
                            DataRow AddAll;
                            foreach (DataRow item in dtTempDetail.Rows)
                            {
                                AddAll = dtDetail.NewRow();
                                AddAll["ItemNumber"] = Convert.ToString(item["ItemNumber"]).Trim();
                                AddAll["ItemName"] = Convert.ToString(item["ItemName"]).Trim();
                                AddAll["QuantityReceive"] = Convert.ToString(item["QuantityReceive"]).Trim();
                                AddAll["QuantityOrder"] = Convert.ToString(item["QuantityOrder"]).Trim();
                                AddAll["UOM"] = Convert.ToString(item["UOM"]).Trim();
                                AddAll["DefaultLocation"] = Convert.ToString(item["DefaultLocation"]).Trim();
                                AddAll["DefaultLPN"] = Convert.ToString(item["DefaultLPN"]).Trim();
                                AddAll["LotNumber"] = Convert.ToString(item["LotNumber"]).Trim();
                                if (string.IsNullOrEmpty(item["DaysToExpire"].ToString()))
                                {
                                    AddAll["ExpiryDate"] = AppContext.GetDateTimeServer().ToString(Calbee.Infra.Common.Constants.WConstants.formatDateString, _cultureEnInfo);
                                }
                                else
                                {
                                    AddAll["ExpiryDate"] = AppContext.GetDateTimeServer().AddDays(Convert.ToInt32(item["DaysToExpire"])).ToString(Calbee.Infra.Common.Constants.WConstants.formatDateString, _cultureEnInfo);
                                }
                                AddAll["ItemStatus"] = Convert.ToString(item["ItemStatus"]).Trim();
                                dtDetail.Rows.Add(AddAll);
                            }

                            dtDetail.TableName = "Detail";
                            dgvReceiveDetail.DataSource = dtDetail;
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
                else if (string.IsNullOrEmpty(this.txtReceiveLocation.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan receive location");
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
                else if (string.IsNullOrEmpty(this.txtReceiveLocation.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan receive location");
                    result = false;
                }
                else if (string.IsNullOrEmpty(this.txtQuantity.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please input quantity");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.cmbUOM.SelectedValue.ToString()))
                {
                    if (this.cmbUOM.Enabled)
                    {
                        MsgBox.DialogWarning("Please select uom");
                        return false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                else if (string.IsNullOrEmpty(this.cmbItemStatus.SelectedValue.ToString()))
                {
                    if (this.cmbItemStatus.Enabled)
                    {
                        MsgBox.DialogWarning("Please select item status");
                        return false;
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
                Calbee.WMS.Services.InboundService.ReceiveItem receive = new Calbee.WMS.Services.InboundService.ReceiveItem();
                receive.Device = AppContext.DeviceName;
                if (this.dtpExpiryDate.Enabled)
                {
                    receive.ExpiryDate = Convert.ToDateTime(this.dtpExpiryDate.Value, _cultureEnInfo).ToString(Calbee.Infra.Common.Constants.WConstants.formatDateString, _cultureEnInfo);
                }
                receive.ItemName = string.Empty;
                receive.ItemNumber = this.txtItemNumber.Text;
                receive.LPN = this.txtReceiveLPN.Text;
                receive.Location = this.txtReceiveLocation.Text.Trim();
                if (this.dtpLotNumber.Enabled)
                {
                    receive.LotNumber = Convert.ToDateTime(this.dtpLotNumber.Value, _cultureEnInfo).ToString(Calbee.Infra.Common.Constants.WConstants.formatDateString, _cultureEnInfo);
                }
                receive.OrderNumber = this.txtOrderNumber.Text.Trim();
                receive.ParentLPN = string.Empty;
                receive.PlantCode = string.Empty;
                receive.QuantityReceive = Convert.ToDouble(this.txtQuantity.Text.Trim());
                receive.QuantityReceiveSpecified = true;
                receive.ReceiveBy = Calbee.Infra.Common.Constants.WConstants.userName;

                receive.ReceiveDate = Convert.ToDateTime(this.dtpReceiveDate.Value, _cultureEnInfo).ToString(Calbee.Infra.Common.Constants.WConstants.formatDateString, _cultureEnInfo);
                receive.ReceiveNumber = this.txtReceiveNumber.Text.Trim();
                receive.SerialNumber = string.Empty;
                receive.Status = this.cmbItemStatus.SelectedValue.ToString();
                receive.Uom = this.cmbUOM.SelectedValue.ToString();
                receive.WarehouseCode = Calbee.Infra.Common.Constants.WConstants.wareHouseDDL;
                Calbee.WMS.Services.InboundService.Response saveRecevie = Calbee.WMS.Services.Inbound.InboundServiceProxy.WS.SetReceiveItem(receive);
                if (saveRecevie != null)
                {
                    if (saveRecevie.StatusCode == 0)
                    {
                        // Success = StatusCode 0
                        MsgBox.DialogInfomation(saveRecevie.Message);

                        var counterResult = Calbee.WMS.Services.Inbound.InboundServiceProxy.WS.GetInboundReceiptDetailSummary(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtOrderNumber.Text.Trim(), this.txtItemNumber.Text);
                        this.lblResultCounter.Text = counterResult.QuantityReceived + "/" + counterResult.QuantityOrder;

                        // after save
                        gotoItemNumber();
                        // Startup
                        if (orderType.Contains(Calbee.Infra.Common.Constants.WConstants.orderProductionType))
                        {
                            this.txtReceiveLPN.Focus();
                            this.txtReceiveLPN.SelectAll();
                        }
                        else
                        {
                            this.txtItemNumber.Focus();
                            this.txtItemNumber.SelectAll();
                        }
                    }
                    else
                    {
                        // Error
                        MsgBox.DialogError(saveRecevie.Message);
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

        private void frmReceive_Load(object sender, EventArgs e)
        {
            CreateTableProductionOnGridView();
            CreateTableDetailOnGridView();
            this.tabReceive.SelectedIndex = 0;
            ItemStatusBinding();
            this.lblResultCounter.Text = "0/0";
            this.txtOrderNumber.Focus();
            this.txtOrderNumber.SelectAll();

            dgvReceiveProduction.Visible = false;
            dgvReceiveDetail.Visible = true;
        }
        private void frmReceive_KeyUp(object sender, KeyEventArgs e)
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
            else if (Calbee.Infra.Common.Constants.WConstants.eventEnter == 122)
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.F11:
                        btnSave_Click(null, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
        }

        private void tabReceive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabReceive.SelectedIndex == 1)
            {
                this.lblTitleHeaderDetail.Text = "Receive Detail";
                dgvReceiveDetail.Visible = true;
                dgvReceiveProduction.Visible = false;
                dgvReceiveProduction.DataSource = null;

                /*
                if (!string.IsNullOrEmpty(orderType))
                {
                    if (orderType.Contains(Calbee.Infra.Common.Constants.WConstants.orderProductionType))
                    {
                        this.lblTitleHeaderDetail.Text = "Receive Production Detail";
                        dgvReceiveProduction.Visible = true;
                        dgvReceiveDetail.Visible = false;
                        dgvReceiveDetail.DataSource = null;
                    }
                    else
                    {
                        this.lblTitleHeaderDetail.Text = "Receive Detail";
                        dgvReceiveDetail.Visible = true;
                        dgvReceiveProduction.Visible = false;
                        dgvReceiveProduction.DataSource = null;
                    }
                }
                else
                {
                    this.lblTitleHeaderDetail.Text = "Receive viewer";
                    dgvReceiveDetail.Visible = false;
                    dgvReceiveProduction.Visible = false;
                }
                */
            }
            else if (tabReceive.SelectedIndex == 0)
            {
                this.txtOrderNumber.Focus();
            }
        }

        private void txtOrderNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(this.txtOrderNumber.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan order number");
                    this.txtOrderNumber.Focus();
                    this.txtOrderNumber.SelectAll();
                    return;
                }
                else
                {
                    string msgResult = string.Empty;
                    // Refresh control
                    RefreshControl();
                    // Binding ReceiveNumber
                    receiveNumberBinding(this.txtOrderNumber.Text.Trim(), ref msgResult);
                    try
                    {
                        if (msgResult == "ERR")
                        {
                            return;
                        }

                        // เอาข้อมูลมาใส่ Gridview Detail
                        RefreshInboundDetail(this.txtOrderNumber.Text.Trim(), string.Empty, string.Empty);
                        dgvReceiveProduction.Visible = false;
                        dgvReceiveDetail.Visible = true;

                        this.txtReceiveLocation.Focus();
                        this.txtReceiveLocation.SelectAll();

                        /*
                        // Call service GetLocation.
                        var locationResult = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetLocations(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, string.Empty, string.Empty, Calbee.Infra.Common.Constants.WConstants.receiveLocationType);
                        if (locationResult != null)
                        {
                            if (locationResult.Count() == 1)
                            {
                                // เอาข้อมูลมาใส่ Gridview Detail
                                RefreshInboundDetail(this.txtOrderNumber.Text.Trim(), string.Empty, string.Empty);
                                dgvReceiveProduction.Visible = false;
                                dgvReceiveDetail.Visible = true;
                                
                                if (locationResult.FirstOrDefault().LpnControlled)
                                {
                                    this.txtReceiveLPN.Focus();
                                }
                                else
                                {
                                    this.txtItemNumber.Focus();
                                }
                            }
                            else if (locationResult.Count() > 1)
                            {
                                this.txtReceiveLocation.Focus();
                                this.txtReceiveLocation.SelectAll();
                            }
                        }
                        */
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
        private void txtReceiveNumber_SelectedIndexChangeds(object sender, EventArgs e)
        {
            if (!eventcomboReceiveNumber) return;
            if (this.txtReceiveNumber.SelectedIndex >= 0)
            {
                try
                {
                    if (!checkReceiveNumber(this.txtOrderNumber.Text.Trim(), this.txtReceiveNumber.Text.Trim()))
                    {
                        MsgBox.DialogWarning("Not found receive number : " + this.txtReceiveNumber.Text.Trim() + " in system");
                        return;
                    }
                    else
                    {
                        if (this.txtReceiveNumber.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect)
                        {
                            this.txtReceiveNumber.customFocus();
                        }
                        else
                        {
                            this.txtReceiveLocation.Focus();
                            this.txtReceiveLocation.SelectAll();
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
        private void txtReceiveNumber_KeyDowns(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(this.txtReceiveNumber.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan receive number");
                    this.txtReceiveNumber.customFocus();
                    return;
                }
                else
                {
                    try
                    {
                        if (!checkReceiveNumber(this.txtOrderNumber.Text.Trim(), this.txtReceiveNumber.Text.Trim()))
                        {
                            MsgBox.DialogWarning("Not found receive number : " + this.txtReceiveNumber.Text.Trim() + " in system");
                            this.txtReceiveLocation.Focus();
                            this.txtReceiveLocation.SelectAll();
                            return;
                        }
                        else
                        {
                            if (this.txtReceiveNumber.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect)
                            {
                                this.txtReceiveNumber.customFocus();
                            }
                            else
                            {
                                this.txtReceiveLocation.Focus();
                                this.txtReceiveLocation.SelectAll();
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
        }
        private void txtReceiveLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (string.IsNullOrEmpty(this.txtReceiveLocation.Text.Trim()))
                    {
                        MsgBox.DialogWarning("Please scan receive location");
                        this.txtReceiveLocation.Focus();
                        this.txtReceiveLocation.SelectAll();
                        return;
                    }
                    else
                    {
                        var locationResult = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetLocation(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtReceiveLocation.Text.Trim(), string.Empty, string.Empty);
                        if (locationResult != null)
                        {
                            this.txtReceiveLPN.Enabled = locationResult.LpnControlled;
                            if (this.txtReceiveLPN.Enabled)
                            {
                                // True call service
                                this.txtReceiveLPN.Focus();
                                this.txtReceiveLPN.SelectAll();
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
                            MsgBox.DialogWarning("Null location : " + this.txtReceiveLocation.Text.Trim() + " in system");
                            this.txtReceiveLocation.Focus();
                            this.txtReceiveLocation.SelectAll();
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
        private void txtReceiveLPN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (orderType.Contains(Calbee.Infra.Common.Constants.WConstants.orderProductionType))
                {
                    try
                    {
                        // Call service getInboundLpnDetail
                        var inboundLpnDetailResult = Calbee.WMS.Services.Inbound.InboundServiceProxy.WS.GetInboundLpnDetails(this.txtOrderNumber.Text.Trim(), Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtReceiveLPN.Text.Trim(), string.Empty);
                        if (inboundLpnDetailResult != null)
                        {
                            if (inboundLpnDetailResult.Count() > 0)
                            {
                                string lpnStatus = string.IsNullOrEmpty(inboundLpnDetailResult.FirstOrDefault().LpnStatus) ? "NEW" : inboundLpnDetailResult.FirstOrDefault().LpnStatus;
                                if (lpnStatus.ToUpper().Trim() == "NEW" || lpnStatus.ToUpper().Trim() == "RECEIVING'")
                                {
                                    // New
                                    this.txtItemNumber.Text = string.IsNullOrEmpty(inboundLpnDetailResult.FirstOrDefault().ItemNumber) ? string.Empty : inboundLpnDetailResult.FirstOrDefault().ItemNumber;
                                    this.txtDescription.Text = string.IsNullOrEmpty(inboundLpnDetailResult.FirstOrDefault().ItemName) ? string.Empty : inboundLpnDetailResult.FirstOrDefault().ItemName;
                                    if (!string.IsNullOrEmpty(inboundLpnDetailResult.FirstOrDefault().LotNumber))
                                    {
                                        this.dtpLotNumber.Value = DateTime.Parse(inboundLpnDetailResult.FirstOrDefault().LotNumber);
                                    }
                                    else
                                    {
                                        this.dtpLotNumber.Value = AppContext.GetDateTimeServer();
                                    }
                                    if (inboundLpnDetailResult.FirstOrDefault().ExpiryDate != null)
                                    {
                                        this.dtpExpiryDate.Value = inboundLpnDetailResult.FirstOrDefault().ExpiryDate.Value;
                                    }
                                    else
                                    {
                                        this.dtpExpiryDate.Value = AppContext.GetDateTimeServer().AddYears(1);
                                    }
                                    this.txtQuantity.Text = inboundLpnDetailResult.FirstOrDefault().Quantity.ToString();
                                    ComboBoxBinding.BindEntityToCombobox(AppContext.UOMDDLBinding(inboundLpnDetailResult.FirstOrDefault().ItemNumber), this.cmbUOM, "Uom", "Uom", "");
                                    this.cmbUOM.SelectedValue = inboundLpnDetailResult.FirstOrDefault().Uom;
                                    var counterResult = Calbee.WMS.Services.Inbound.InboundServiceProxy.WS.GetReceiptSummary(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtOrderNumber.Text.Trim(), this.txtItemNumber.Text);
                                    this.lblResultCounter.Text = counterResult.PalletReceived + "/" + counterResult.TotalBoxReceived + " Total " + counterResult.PalletPlan;
                                    // Disable control
                                    this.txtItemNumber.Enabled = false;
                                    this.dtpLotNumber.Enabled = false;
                                    this.dtpExpiryDate.Enabled = false;
                                    this.txtQuantity.Focus();
                                    this.txtQuantity.SelectAll();
                                }
                                else
                                {
                                    // Other
                                    MsgBox.DialogWarning("This LPN : " + this.txtReceiveLPN.Text.Trim() + " Already received");
                                    this.txtReceiveLPN.Focus();
                                    this.txtReceiveLPN.SelectAll();
                                    return;
                                }
                            }
                            else
                            {
                                MsgBox.DialogWarning("This LPN : " + this.txtReceiveLPN.Text.Trim() + " not found");
                                this.txtReceiveLPN.Focus();
                                this.txtReceiveLPN.SelectAll();
                                return;
                            }
                        }
                        else
                        {
                            MsgBox.DialogWarning("Null LPN : " + this.txtReceiveLPN.Text.Trim() + " not found");
                            this.txtReceiveLPN.Focus();
                            this.txtReceiveLPN.SelectAll();
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
                else
                {
                    this.txtItemNumber.Focus();
                    this.txtItemNumber.SelectAll();
                }
            }
        }
        private void txtItemNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(this.txtItemNumber.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan item number");
                    this.txtItemNumber.Focus();
                    this.txtItemNumber.SelectAll();
                    return;
                }
                else
                {
                    try
                    {
                        // Call service getInboundDetail
                        this.dtpLotNumber.Enabled = true;
                        if (orderType.Contains(Calbee.Infra.Common.Constants.WConstants.orderProductionType))
                        {
                            // Production
                            var inboundLpnDetailResult = Calbee.WMS.Services.Inbound.InboundServiceProxy.WS.GetInboundDetails(this.txtOrderNumber.Text.Trim(), Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtReceiveLPN.Text.Trim(), string.Empty);
                            if (inboundLpnDetailResult != null)
                            {
                                if (inboundLpnDetailResult.Count() > 0)
                                {
                                    this.txtDescription.Text = string.IsNullOrEmpty(inboundLpnDetailResult.FirstOrDefault().ItemName) ? string.Empty : inboundLpnDetailResult.FirstOrDefault().ItemName;

                                    this.dtpLotNumber.Enabled = inboundLpnDetailResult.FirstOrDefault().LotControl;
                                    this.dtpExpiryDate.Enabled = inboundLpnDetailResult.FirstOrDefault().ExpiryDateControl;

                                    if (!string.IsNullOrEmpty(inboundLpnDetailResult.FirstOrDefault().LotNumber))
                                    {
                                        this.dtpLotNumber.Value = DateTime.Parse(inboundLpnDetailResult.FirstOrDefault().LotNumber);
                                    }
                                    else
                                    {
                                        this.dtpLotNumber.Value = AppContext.GetDateTimeServer();
                                    }

                                    this.dtpExpiryDate.Value = AppContext.GetDateTimeServer().AddDays(inboundLpnDetailResult.FirstOrDefault().DaysToExpire.Value);
                                    this.txtQuantity.Text = inboundLpnDetailResult.FirstOrDefault().QuantityOrder.ToString();
                                    ComboBoxBinding.BindEntityToCombobox(AppContext.UOMDDLBinding(inboundLpnDetailResult.FirstOrDefault().ItemNumber), this.cmbUOM, "Uom", "Uom", "");
                                    this.cmbUOM.SelectedValue = inboundLpnDetailResult.FirstOrDefault().Uom;
                                    // Binding counter
                                    var counterResult = Calbee.WMS.Services.Inbound.InboundServiceProxy.WS.GetInboundReceiptDetailSummary(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtOrderNumber.Text.Trim(), this.txtItemNumber.Text);
                                    this.lblResultCounter.Text = counterResult.QuantityReceived + "/" + counterResult.QuantityOrder;
                                }
                                else if (inboundLpnDetailResult.Count() == 0)
                                {
                                    MsgBox.DialogWarning("Not found item number : " + this.txtItemNumber.Text);
                                    this.txtItemNumber.Focus();
                                    this.txtItemNumber.SelectAll();
                                    return;
                                }
                            }
                        }
                        else
                        {
                            // Not production
                            var inboundDetailResult = Calbee.WMS.Services.Inbound.InboundServiceProxy.WS.GetInboundDetails(this.txtOrderNumber.Text.Trim(), Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtReceiveLPN.Text.Trim(), this.txtItemNumber.Text.Trim());
                            if (inboundDetailResult != null)
                            {
                                if (inboundDetailResult.Count() > 0)
                                {
                                    if (inboundDetailResult.FirstOrDefault().ExpiryDateControl)
                                    {
                                        this.dtpExpiryDate.Value = AppContext.GetDateTimeServer().AddDays(inboundDetailResult.FirstOrDefault().DaysToExpire.Value);
                                        this.dtpExpiryDate.Enabled = true;
                                    }
                                    else
                                    {
                                        this.dtpExpiryDate.Enabled = false;
                                    }
                                    if (inboundDetailResult.FirstOrDefault().LotControl)
                                    {
                                        this.dtpLotNumber.Value = AppContext.GetDateTimeServer();
                                        this.dtpLotNumber.Enabled = true;
                                    }
                                    else
                                    {
                                        this.dtpLotNumber.Enabled = false;
                                    }

                                    this.txtDescription.Text = string.IsNullOrEmpty(inboundDetailResult.FirstOrDefault().ItemName) ? string.Empty : inboundDetailResult.FirstOrDefault().ItemName;
                                    ComboBoxBinding.BindEntityToCombobox(AppContext.UOMDDLBinding(inboundDetailResult.FirstOrDefault().ItemNumber), this.cmbUOM, "Uom", "Uom", "");
                                    this.cmbUOM.SelectedValue = inboundDetailResult.FirstOrDefault().Uom;
                                    this.cmbItemStatus.SelectedValue = inboundDetailResult.FirstOrDefault().DefaultItemStatus;
                                    if (string.IsNullOrEmpty(this.cmbItemStatus.SelectedValue.ToString()))
                                    {
                                        this.cmbItemStatus.SelectedIndex = 1;
                                    }
                                    this.txtQuantity.Focus();
                                    this.lblResultCounter.Text = inboundDetailResult.FirstOrDefault().QuantityReceive + "/" + inboundDetailResult.FirstOrDefault().QuantityOrder;
                                }
                                else if (inboundDetailResult.Count() == 0)
                                {
                                    MsgBox.DialogWarning("Not found item number : " + this.txtItemNumber.Text);
                                    this.txtItemNumber.Focus();
                                    this.txtItemNumber.SelectAll();
                                    return;
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
            }
        }
        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, new EventArgs());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Create receive number
            if (string.IsNullOrEmpty(this.txtOrderNumber.Text.Trim()))
            {
                MsgBox.DialogWarning("Plases scan order number");
                this.txtOrderNumber.Focus();
                this.txtOrderNumber.SelectAll();
                return;
            }
            else
            {
                try
                {
                    string msgResult = string.Empty;
                    // Call service GenerateReceiveNumber.
                    var receiveNumberResult = Calbee.WMS.Services.Inbound.InboundServiceProxy.WS.GenerateReceiveNumber(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtOrderNumber.Text.Trim(), AppContext.CurrentUser.UserName);
                    if (receiveNumberResult != null)
                    {
                        // Binding ReceiveNumber
                        receiveNumberBinding(this.txtOrderNumber.Text.Trim(), ref msgResult);
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
            // Not production
            // เอาข้อมูลมาใส่ Gridview Detail
            RefreshInboundDetail(this.txtOrderNumber.Text.Trim(), string.Empty, string.Empty);
            dgvReceiveProduction.Visible = false;
            dgvReceiveDetail.Visible = true;
        }

        #endregion
    }
}