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

namespace Calbee.WMS.UI.Forms.ChangeLocation
{
    public partial class frmChangeLocation : Form
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

        public frmChangeLocation()
        {
            InitializeComponent();
        }

        #endregion

        #region Create Table

        private void CreateTableDetailOnGridView()
        {
            dtDetail = new DataTable();
            dtDetail.TableName = "Detail";
            dtDetail.Columns.Add("Quantity", typeof(string));
            dtDetail.Columns.Add("ItemStatus", typeof(string));
            dtDetail.Columns.Add("UOM", typeof(string));
            dtDetail.Columns.Add("ReceiveDate", typeof(string));

            dgvChangeStatusDetail.DataSource = dtDetail;
        }

        #endregion

        #region Method

        private void ReadOnlyControls()
        {
            this.txtLocation.ReadOnly = true;
            this.txtItemNumber.ReadOnly = true;
            this.txtDescription.ReadOnly = true;
            this.txtLotNumber.ReadOnly = true;
            this.dtpExpiryDate.Enabled = false;
        }
        private void ForceExitApplication()
        {
            if (MessageBox.Show("Do you want to force exit program", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DoAfterSave()
        {
            this.txtItemNumber.Text = string.Empty;
            this.txtLocation.Text = string.Empty;
            this.txtDescription.Text = string.Empty;
            this.txtLotNumber.Text = string.Empty;
            this.txtLotNumber.Text = string.Empty;
            this.dtpExpiryDate.Value = AppContext.GetDateTimeServer();
            this.txtQuantity.Text = string.Empty;
            this.cmbItemStatus.DataSource = null;
            this.txtToLocation.Text = string.Empty;

            this.txtLPN.Focus();
            this.txtLPN.SelectAll();
        }
        private bool DoValidate()
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
                MsgBox.DialogWarning("Please scan LPN");
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtLotNumber.Text))
            {
                MsgBox.DialogWarning("Please select lot number");
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtQuantity.Text.Trim()))
            {
                MsgBox.DialogWarning("Please input quantity");
                return false;
            }
            else if (string.IsNullOrEmpty(this.cmbItemStatus.SelectedValue.ToString()))
            {
                MsgBox.DialogWarning("Please select item status");
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtToLocation.Text.Trim()))
            {
                MsgBox.DialogWarning("Please scan to location");
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
                Calbee.WMS.Services.InventoryService.InventoryItem pickup = new Calbee.WMS.Services.InventoryService.InventoryItem();
                pickup.AllLpn = false;
                pickup.AllLpnSpecified = true;
                pickup.Device = AppContext.DeviceName;
                pickup.PickBy = Calbee.Infra.Common.Constants.WConstants.userName;
                pickup.WarehouseCode = Calbee.Infra.Common.Constants.WConstants.wareHouseDDL;
                pickup.ToLocation = this.txtToLocation.Text.Trim();
                pickup.SubTranType = Calbee.Infra.Common.Constants.WConstants.ChangeLocationTranType;
                pickup.TransactionType = Calbee.Infra.Common.Constants.WConstants.ChangeLocationTranType;
                pickup.Lpn = this.txtLPN.Text.Trim();
                pickup.ToLpn = toLpn;
                pickup.Location = this.txtLocation.Text.Trim();
                // Select item
                pickup.AllItem = false;
                pickup.AllItemSpecified = true;
                pickup.ItemNumber = this.txtItemNumber.Text.Trim();
                pickup.AllExp = false;
                pickup.AllExpSpecified = true;
                pickup.ExpiryDate = this.dtpExpiryDate.Value.ToString("yyy-MM-dd");
                pickup.AllLot = false;
                pickup.AllLotSpecified = true;
                pickup.LotNumber = this.txtLotNumber.Text.Trim();
                pickup.Quantity = Convert.ToDouble(this.txtQuantity.Text.Trim());
                pickup.QuantitySpecified = true;
                pickup.Uom = this.UOM;
                pickup.Status = this.cmbItemStatus.SelectedValue.ToString();
                pickup.ToStatus = this.cmbItemStatus.SelectedValue.ToString();

                Calbee.WMS.Services.InventoryService.Response saveRecevie = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.SetPickupPutawayItem(pickup);
                if (saveRecevie != null)
                {
                    if (saveRecevie.StatusCode == 0)
                    {
                        // Success = StatusCode 0
                        MsgBox.DialogInfomation(saveRecevie.Message);
                        DoAfterSave();
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

        private void frmChangeStatus_Load(object sender, EventArgs e)
        {
            CreateTableDetailOnGridView();
            this.tabChangeLocation.SelectedIndex = 0;
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

        private void txtLPN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(this.txtLPN.Text.Trim()))
                {
                    MsgBox.DialogWarning("Please scan lpn");
                    this.txtLPN.Focus();
                    this.txtLPN.SelectAll();
                    return;
                }
                else
                {
                    try
                    {
                        var LpnDetailResult = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventorys(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, string.Empty, string.Empty, this.txtLPN.Text.Trim(), string.Empty, string.Empty);
                        if (LpnDetailResult != null)
                        {
                            if (LpnDetailResult.Count() > 0)
                            {
                                // เอาข้อมูลมาใส่ Gridview Production
                                CreateTableDetailOnGridView();
                                DataTable dtTempProduction = ConvertObject.ToTable(LpnDetailResult);
                                if (dtTempProduction != null)
                                {
                                    if (dtTempProduction.Rows.Count > 0)
                                    {
                                        //Add to datagrid.
                                        DataRow AddAll;
                                        foreach (DataRow item in dtTempProduction.Rows)
                                        {
                                            AddAll = dtDetail.NewRow();
                                            AddAll["Quantity"] = Convert.ToString(item["Quantity"]).Trim();
                                            AddAll["ItemStatus"] = Convert.ToString(item["StatusName"]).Trim();
                                            AddAll["UOM"] = Convert.ToString(item["UOM"]).Trim();
                                            AddAll["ReceiveDate"] = Convert.ToString(item["ReceiveDate"]).Trim();
                                            dtDetail.Rows.Add(AddAll);
                                        }

                                        dtDetail.TableName = "Detail";
                                        dgvChangeStatusDetail.DataSource = dtDetail;
                                    }
                                }

                                this.txtLocation.Text = string.IsNullOrEmpty(LpnDetailResult.FirstOrDefault().LocationCode) ? string.Empty : LpnDetailResult.FirstOrDefault().LocationCode;
                                this.txtLocation.ReadOnly = true;
                                this.txtItemNumber.Text = string.IsNullOrEmpty(LpnDetailResult.FirstOrDefault().ItemNumber) ? string.Empty : LpnDetailResult.FirstOrDefault().ItemNumber;
                                this.txtItemNumber.ReadOnly = true;
                                this.txtDescription.Text = string.IsNullOrEmpty(LpnDetailResult.FirstOrDefault().ItemName) ? string.Empty : LpnDetailResult.FirstOrDefault().ItemName;
                                this.txtDescription.ReadOnly = true;
                                this.txtLotNumber.Text = string.IsNullOrEmpty(LpnDetailResult.FirstOrDefault().LotNumber) ? string.Empty : LpnDetailResult.FirstOrDefault().LotNumber;
                                this.txtLotNumber.ReadOnly = true;
                                if (LpnDetailResult.FirstOrDefault().ExpiryDate != null)
                                {
                                    this.dtpExpiryDate.Value = LpnDetailResult.FirstOrDefault().ExpiryDate.Value;
                                }
                                else
                                {
                                    this.dtpExpiryDate.Value = AppContext.GetDateTimeServer();
                                }
                                this.toLpn = LpnDetailResult.FirstOrDefault().Lpn;
                                this.UOM = LpnDetailResult.FirstOrDefault().UOM;
                                this.expiryDateControl = LpnDetailResult.FirstOrDefault().ExpiryDateControl;
                                this.dtpExpiryDate.Enabled = false;
                                this.txtQuantity.Text = LpnDetailResult.FirstOrDefault().Quantity.ToString();
                                List<string> _listItemStatus = new List<string>();
                                foreach (var item in LpnDetailResult)
                                {
                                    _listItemStatus.Add(item.StatusName);
                                }

                                ComboBoxBinding.BindLStringToCombobox(_listItemStatus, this.cmbItemStatus);
                                this.txtToLocation.Focus();
                            }
                        }
                        else
                        {
                            MsgBox.DialogWarning("Not found lpn : " + this.txtLPN.Text);
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
        }
        private void txtToLocation_KeyDown(object sender, KeyEventArgs e)
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
        private void btnBackDetail_Click(object sender, EventArgs e)
        {
            this.tabChangeLocation.SelectedIndex = 0;
        }

        #endregion
    }
}