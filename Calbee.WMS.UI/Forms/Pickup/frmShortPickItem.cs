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

namespace Calbee.WMS.UI.Forms.Pickup
{
    public partial class frmShortPickItem : Form
    {
        #region Member

        Calbee.WMS.Entities.Picks.PickItem entPickItem = new Calbee.WMS.Entities.Picks.PickItem();
        private static AppContext appContext = AppContext.Instance;
        public AppContext AppContext
        {
            get { return appContext; }
        }
        DataTable dt = new DataTable();

        #endregion

        #region Constructor

        public frmShortPickItem()
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
        private void CreateTableOnGridView()
        {
            dt = new DataTable();
            dt.TableName = "PickItems";
            dt.Columns.Add("PickStatus", typeof(string));
            dt.Columns.Add("Lpn", typeof(string));
            dt.Columns.Add("ItemNumber", typeof(string));
            dt.Columns.Add("ItemName", typeof(string));
            dt.Columns.Add("QuantityPlan", typeof(string));
            dt.Columns.Add("QuantityPick", typeof(string));
            dt.Columns.Add("UOM", typeof(string));
            dt.Columns.Add("LocationPlan", typeof(string));
            dt.Columns.Add("LotNumber", typeof(string));
            dt.Columns.Add("ExpiryDate", typeof(DateTime));
            dgvPickItem.DataSource = dt;
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
                        // Sum pick qty
                        this.lblResultPickQty.Text = outboundPickListResult.Select(q => q.QuantityPick).Sum().ToString();
                        if (dtTempPickList.Rows.Count > 0)
                        {
                            //Add to datagrid.
                            DataRow AddAll;
                            foreach (DataRow item in dtTempPickList.Rows)
                            {
                                AddAll = dt.NewRow();
                                AddAll["PickStatus"] = Convert.ToString(item["PickStatus"]).Trim();
                                AddAll["Lpn"] = Convert.ToString(item["Lpn"]).Trim();
                                AddAll["ItemNumber"] = Convert.ToString(item["ItemNumber"]).Trim();
                                AddAll["ItemName"] = Convert.ToString(item["ItemName"]).Trim();
                                AddAll["QuantityPlan"] = Convert.ToString(item["QuantityPlan"]).Trim();
                                AddAll["QuantityPick"] = Convert.ToString(item["QuantityPick"]).Trim();
                                AddAll["UOM"] = Convert.ToString(item["UOM"]).Trim();
                                AddAll["LocationPlan"] = Convert.ToString(item["LocationPlan"]).Trim();
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
            this.txtToLPN.Text = string.Empty;

            this.txtLPN.Focus();
            this.txtLPN.SelectAll();
        }
        private bool DoValidate()
        {
            if (string.IsNullOrEmpty(this.txtPickingListNo.Text.Trim()))
            {
                MsgBox.DialogWarning("Please scan picklist no");
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtSTGLocation.Text.Trim()))
            {
                MsgBox.DialogWarning("Please scan STG location");
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtLPN.Text.Trim()))
            {
                MsgBox.DialogWarning("Please scan lpn");
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtItemNumber.Text.Trim()))
            {
                MsgBox.DialogWarning("Please scan item number");
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtCarLicense.Text.Trim()))
            {
                MsgBox.DialogWarning("Please scan car license");
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
                Calbee.WMS.Services.OutboundService.PickItem pickitem = new Calbee.WMS.Services.OutboundService.PickItem();
                pickitem.Device = AppContext.DeviceName;
                pickitem.PickBy = Calbee.Infra.Common.Constants.WConstants.userName;
                pickitem.WarehouseCode = Calbee.Infra.Common.Constants.WConstants.wareHouseDDL;
                pickitem.Location = entPickItem.location;
                pickitem.ToLocation = this.txtSTGLocation.Text.Trim();
                pickitem.Lpn = this.txtLPN.Text.Trim();
                pickitem.ToLpn = this.txtToLPN.Text.Trim();
                pickitem.PickDate = Convert.ToDateTime(AppContext.GetDateTimeServerString(Calbee.Infra.Common.Constants.WConstants.formatDateString));
                pickitem.PickDateSpecified = true;
                pickitem.PickingListNumber = this.txtPickingListNo.Text.Trim();
                pickitem.CarLicense = this.txtCarLicense.Text.Trim();
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
                Calbee.WMS.Services.OutboundService.Response saveShortPickItem = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.SetPickItem(pickitem);
                if (saveShortPickItem != null)
                {
                    if (saveShortPickItem.StatusCode == 0)
                    {
                        // Success = StatusCode 0
                        MsgBox.DialogInfomation(saveShortPickItem.Message);
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
                        MsgBox.DialogError(saveShortPickItem.Message);
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

        private void frmShortPickItem_Load(object sender, EventArgs e)
        {
            this.lblResultCounter.Text = "0/0";

            this.txtPickingListNo.Focus();
            this.txtPickingListNo.SelectAll();
        }
        private void frmShortPickItem_KeyUp(object sender, KeyEventArgs e)
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
                    MsgBox.DialogWarning("Please scan pickinglist number");
                    this.txtPickingListNo.Focus();
                    this.txtPickingListNo.SelectAll();
                    return;
                }
                else
                {
                    try
                    {
                        List<Calbee.WMS.Services.OutboundService.OutboundPickMaster> pickingListNoResult = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetPickingList(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtPickingListNo.Text.Trim()).ToList();
                        if (pickingListNoResult != null)
                        {
                            if (pickingListNoResult.Count() == 0)
                            {
                                MsgBox.DialogWarning("Not found pickinglist no : " + this.txtPickingListNo.Text.Trim() + " in system");
                                this.txtPickingListNo.Focus();
                                this.txtPickingListNo.SelectAll();
                                return;
                            }
                            else
                            {
                                List<Calbee.WMS.Services.MasterService.Location> stgLocationResult = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetLocations(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, string.Empty, string.Empty, Calbee.Infra.Common.Constants.WConstants.putawayStagingLocationType).ToList();
                                if (stgLocationResult != null)
                                {
                                    if (stgLocationResult.Count() == 1)
                                    {
                                        this.txtSTGLocation.Text = string.IsNullOrEmpty(stgLocationResult.FirstOrDefault().LocationCode) ? string.Empty : stgLocationResult.FirstOrDefault().LocationCode;
                                        this.txtLPN.Focus();
                                        this.txtLPN.SelectAll();
                                    }
                                    else if (stgLocationResult.Count() > 1)
                                    {
                                        this.txtSTGLocation.Focus();
                                        this.txtSTGLocation.SelectAll();
                                    }
                                }
                                else
                                {
                                    this.txtLPN.Focus();
                                    this.txtLPN.SelectAll();
                                }
                            }
                        }
                        else
                        {
                            MsgBox.DialogWarning("Null pickinglist no : " + this.txtPickingListNo.Text.Trim() + " in system");
                            this.txtPickingListNo.Focus();
                            this.txtPickingListNo.SelectAll();
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
        private void txtSTGLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (string.IsNullOrEmpty(this.txtSTGLocation.Text.Trim()))
                    {
                        MsgBox.DialogWarning("Please scan STG Location");
                        this.txtSTGLocation.Focus();
                        this.txtSTGLocation.SelectAll();
                        return;
                    }
                    else
                    {
                        List<Calbee.WMS.Services.MasterService.Location> stgLocationResult = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetLocations(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtSTGLocation.Text.Trim(), string.Empty, Calbee.Infra.Common.Constants.WConstants.putawayStagingLocationType).ToList();
                        if (stgLocationResult != null)
                        {
                            this.txtLPN.Focus();
                            this.txtLPN.SelectAll();
                        }
                        else
                        {
                            MsgBox.DialogWarning("Null stg location : " + this.txtSTGLocation.Text.Trim() + " in system");
                            this.txtSTGLocation.Focus();
                            this.txtSTGLocation.SelectAll();
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
                        Calbee.WMS.Services.OutboundService.PickItem lpnResult = Calbee.WMS.Services.Outbound.OutboundServiceProxy.WS.GetOutboundPickingListLpn(string.Empty, this.txtPickingListNo.Text.Trim(), string.Empty, this.txtLPN.Text.Trim());
                        if (lpnResult != null)
                        {
                            this.txtItemNumber.Text = string.IsNullOrEmpty(lpnResult.ItemNumber) ? string.Empty : lpnResult.ItemNumber;
                            entPickItem.itemNumber = string.IsNullOrEmpty(lpnResult.ItemNumber) ? string.Empty : lpnResult.ItemNumber;
                            this.txtDescription.Text = string.IsNullOrEmpty(lpnResult.ItemName) ? string.Empty : lpnResult.ItemName;
                            this.txtLotNumber.Text = string.IsNullOrEmpty(lpnResult.LotNumber) ? string.Empty : lpnResult.LotNumber;
                            entPickItem.lotNumber = string.IsNullOrEmpty(lpnResult.LotNumber) ? string.Empty : lpnResult.LotNumber;
                            this.txtExpiryDate.Text = string.IsNullOrEmpty(lpnResult.ExpiryDate) ? string.Empty : lpnResult.ExpiryDate;
                            entPickItem.expiryDate = string.IsNullOrEmpty(lpnResult.ExpiryDate) ? string.Empty : lpnResult.ExpiryDate;
                            this.txtQuantity.Text = string.IsNullOrEmpty(lpnResult.QuantityPlan.ToString()) ? string.Empty : lpnResult.QuantityPlan.ToString();
                            entPickItem.quantityPlan = lpnResult.QuantityPlan;
                            ComboBoxBinding.BindEntityToCombobox(AppContext.UOMDDLBinding(this.txtItemNumber.Text.Trim()), this.cmbUOM, "Uom", "Uom", "");
                            this.cmbUOM.SelectedValue = string.IsNullOrEmpty(lpnResult.Uom) ? string.Empty : lpnResult.Uom;
                            entPickItem.uom = string.IsNullOrEmpty(lpnResult.Uom) ? string.Empty : lpnResult.Uom;
                            this.txtItemStatus.Text = string.IsNullOrEmpty(lpnResult.Status) ? string.Empty : lpnResult.Status;
                            entPickItem.status = string.IsNullOrEmpty(lpnResult.Status) ? string.Empty : lpnResult.Status;
                            entPickItem.location = string.IsNullOrEmpty(lpnResult.Location) ? string.Empty : lpnResult.Location;
                            this.txtToLPN.Text = this.txtLPN.Text.Trim();

                            this.lblResultCounter.Text = lpnResult.CompletedPalletQty + "/" + lpnResult.PlanPalletQty;

                            this.txtQuantity.Focus();
                            this.txtQuantity.SelectAll();
                        }
                        else
                        {
                            MsgBox.DialogWarning("Null LPN : " + this.txtLPN.Text.Trim() + " in system");
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
        }

        private void txtItemNumber_SelectedIndexChangeds(object sender, EventArgs e)
        {

        }
        private void txtItemNumber_KeyDowns(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtLotNumber.customFocus();
            }
        }

        private void txtLotNumber_SelectedIndexChangeds(object sender, EventArgs e)
        {

        }
        private void txtLotNumber_KeyDowns(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtExpiryDate.customFocus();
            }
        }

        private void txtExpiryDate_SelectedIndexChangeds(object sender, EventArgs e)
        {

        }
        private void txtExpiryDate_KeyDowns(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtQuantity.Focus();
                this.txtQuantity.SelectAll();
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
        private void btnBackDetail_Click(object sender, EventArgs e)
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
                // Clear
                this.dgvPickItem.DataSource = null;
                this.lblResultPickQty.Text = string.Empty;
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

        #endregion
    }
}