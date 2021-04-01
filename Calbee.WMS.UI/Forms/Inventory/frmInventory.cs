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

namespace Calbee.WMS.UI.Forms.Inventory
{
    public partial class frmInventory : Form
    {
        #region Member

        DataTable dt = new DataTable();
        private static AppContext appContext = AppContext.Instance;
        public AppContext AppContext
        {
            get { return appContext; }
        }

        #endregion

        #region Constructor

        public frmInventory()
        {
            InitializeComponent();
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
            if (string.IsNullOrEmpty(this.txtLocation.Text.Trim()) && string.IsNullOrEmpty(this.txtItemNumber.Text.Trim()))
            {
                MsgBox.DialogWarning("Please scan Location OR Item Number");
                dgvInventory.DataSource = null;
                cmbLotNumber.DataSource = null;
                CreateTableOnGridView();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void CreateTableOnGridView()
        {
            dt = new DataTable();
            dt.TableName = "Inventory";
            dt.Columns.Add("LPN", typeof(string));
            dt.Columns.Add("ItemNumber", typeof(string));
            dt.Columns.Add("ItemName", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));
            dt.Columns.Add("UOM", typeof(string));
            dt.Columns.Add("LocationCode", typeof(string));
            dt.Columns.Add("LotNumber", typeof(string));
            dt.Columns.Add("ExpiryDate", typeof(string));
            dt.Columns.Add("StatusName", typeof(string));
            dt.Columns.Add("ReceiveDate", typeof(string));
            dgvInventory.DataSource = dt;
        }
        private void LotNumberBinding()
        {
            try
            {
                List<string> _listLotNumber = new List<string>();
                _listLotNumber = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventoryLotNumbers(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtLocation.Text.Trim(), string.Empty, string.Empty, this.txtItemNumber.Text.Trim()).OrderBy(s => s).ToList();
                if (_listLotNumber != null)
                {
                    if (_listLotNumber.Count() >= 1)
                    {
                        ComboBoxBinding.BindLStringToCombobox(_listLotNumber, this.cmbLotNumber);
                    }
                    else
                    {
                        this.cmbLotNumber.DataSource = null;
                    }
                }
                else
                {
                    this.cmbLotNumber.DataSource = null;
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

        private void frmInventory_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInventory.DataSource = null;
                CreateTableOnGridView();
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
        private void frmInventory_KeyUp(object sender, KeyEventArgs e)
        {
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
                btnRefresh_Click(null, new EventArgs());
            }
        }
        private void txtItemNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGetLotNumber_Click(null, new EventArgs());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DoValidate())
                {
                    return;
                }
                else
                {
                    dgvInventory.DataSource = null;
                    CreateTableOnGridView();
                    string lotNumber = string.Empty;
                    if (cmbLotNumber.DataSource != null)
                    {
                        lotNumber = string.IsNullOrEmpty(this.cmbLotNumber.SelectedValue.ToString()) ? string.Empty : this.cmbLotNumber.SelectedValue.ToString();
                    }
                    else
                    {
                        lotNumber = string.Empty;
                    }

                    var inventoryResult = Calbee.WMS.Services.Inventory.InventoryServiceProxy.WS.GetInventorys(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, this.txtLocation.Text.Trim(), string.Empty, string.Empty, this.txtItemNumber.Text.Trim(), lotNumber).OrderBy(s => s.Lpn);
                    if (inventoryResult != null)
                    {
                        // Count
                        this.lblResultCountLPN.Text = inventoryResult.Select(q => q.Lpn).Count().ToString();
                        // Sum
                        if (!string.IsNullOrEmpty(lotNumber))
                        {
                            this.lblResultCountBox.Text = inventoryResult.Where(i => i.LotNumber == lotNumber).Select(q => q.Quantity).Sum().ToString();
                        }
                        else
                        {
                            this.lblResultCountBox.Text = inventoryResult.Select(q => q.Quantity).Sum().ToString();
                        }

                        DataTable dtIventory = ConvertObject.ToTable(inventoryResult);
                        if (dtIventory != null)
                        {
                            if (dtIventory.Rows.Count > 0)
                            {
                                //Add to datagrid.
                                DataRow AddAll;
                                foreach (DataRow item in dtIventory.Rows)
                                {
                                    AddAll = dt.NewRow();
                                    AddAll["LPN"] = Convert.ToString(item["LPN"]).Trim();
                                    AddAll["ItemNumber"] = Convert.ToString(item["ItemNumber"]).Trim();
                                    AddAll["ItemName"] = Convert.ToString(item["ItemName"]).Trim();
                                    AddAll["Quantity"] = Convert.ToString(item["Quantity"]).Trim();
                                    AddAll["UOM"] = Convert.ToString(item["UOM"]).Trim();
                                    AddAll["LocationCode"] = Convert.ToString(item["LocationCode"]).Trim();
                                    AddAll["LotNumber"] = Convert.ToString(item["LotNumber"]).Trim();
                                    AddAll["ExpiryDate"] = Convert.ToString(item["ExpiryDate"]).Trim();
                                    AddAll["StatusName"] = Convert.ToString(item["StatusName"]).Trim();
                                    AddAll["ReceiveDate"] = Convert.ToString(item["ReceiveDate"]).Trim();
                                    dt.Rows.Add(AddAll);
                                }

                                dt.TableName = "Inventory";
                                dgvInventory.DataSource = dt;
                            }
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
        private void btnGetLotNumber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtItemNumber.Text.Trim()) && string.IsNullOrEmpty(this.txtLocation.Text.Trim()))
            {
                MsgBox.DialogWarning("Please scan Location OR Item Number");
            }
            else
            {
                LotNumberBinding();
            }
        }

        #endregion
    }
}