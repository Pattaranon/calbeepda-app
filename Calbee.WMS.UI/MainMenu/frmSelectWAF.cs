using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calbee.Infra.Helper.Message;
using Calbee.Infra.Helper.Objects;
using Calbee.Infra.Shared;

namespace Calbee.WMS.UI.MainMenu
{
    public partial class frmSelectWAF : Form
    {
        #region Member

        string wareHouse = string.Empty;
        string forkLift = string.Empty;
        bool eventcomboBOxRoot = false;
        private static AppContext appContext = AppContext.Instance;
        public AppContext AppContext
        {
            get { return appContext; }
        }

        #endregion

        #region Constructor

        public frmSelectWAF(string paramWarehouse, string paramForkLift)
        {
            InitializeComponent();
            this.cmbWarehouse.SelectedValue = paramWarehouse;
            this.cmbForklift.SelectedValue = paramForkLift;
        }
        public frmSelectWAF()
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
        private bool DoValidateByPassForms()
        {
            if (this.cmbWarehouse.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect)
            {
                MsgBox.ShowExclamation("Plases select warehouse");
                return false;
            }
            if (string.IsNullOrEmpty(this.cmbWarehouse.Text))
            {
                MsgBox.ShowExclamation("Plases select warehouse");
                return false;
            }
            if (this.cmbForklift.DataSource == null)
            {
                MsgBox.ShowExclamation("Plases select forklift");
                return false;
            }
            if (this.cmbForklift.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect)
            {
                MsgBox.ShowExclamation("Plases select forklift");
                return false;
            }
            if (string.IsNullOrEmpty(this.cmbForklift.Text))
            {
                MsgBox.ShowExclamation("Plases select forklift");
                return false;
            }

            return true;
        }
        private void warehouseBinding()
        {
            try
            {
                List<Calbee.WMS.Services.MasterService.Warehouse> _listWarehouse = new List<Calbee.WMS.Services.MasterService.Warehouse>();
                Calbee.WMS.Services.MasterService.Warehouse _master;
                _listWarehouse = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetWarehousesUser(AppContext.CurrentUser.UserId, true).ToList();
                if (_listWarehouse != null)
                {
                    _master = new Calbee.WMS.Services.MasterService.Warehouse();
                    _master.WarehouseCode = Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect;
                    _listWarehouse.Insert(0, _master);
                    ComboBoxBinding.BindEntityToCombobox(_listWarehouse, this.cmbWarehouse, "WarehouseCode", "WarehouseCode", "");
                }
                else
                {
                    this.cmbWarehouse.DataSource = null;
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
        private void forkLiftBinding(string warehouseCode)
        {
            try
            {
                /*
                List<Calbee.WMS.Services.MasterService.Location> _listForkLift = new List<Calbee.WMS.Services.MasterService.Location>();
                Calbee.WMS.Services.MasterService.Location _master;
                _listForkLift = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetLocations(warehouseCode, string.Empty, string.Empty, Calbee.Infra.Common.Constants.WConstants.locationType).ToList();
                if (_listForkLift != null)
                {
                    if (_listForkLift.Count() == 1)
                    {
                        ComboBoxBinding.BindEntityToCombobox(_listForkLift, this.cmbForklift, "LocationCode", "LocationCode", "");
                    }
                    else
                    {
                        _master = new Calbee.WMS.Services.MasterService.Location();
                        _master.LocationCode = Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect;
                        _listForkLift.Insert(0, _master);
                        ComboBoxBinding.BindEntityToCombobox(_listForkLift, this.cmbForklift, "LocationCode", "LocationCode", "");
                    }
                }
                else
                {
                    this.cmbWarehouse.DataSource = null;
                }
                */

                List<Calbee.WMS.Services.MasterService.Location> _listForkLift = new List<Calbee.WMS.Services.MasterService.Location>();
                Calbee.WMS.Services.MasterService.Location _master;
                string forkliftLocation = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetWarehousesUserLocation(Calbee.Infra.Common.Constants.WConstants.userId, true, warehouseCode);
                if (!string.IsNullOrEmpty(forkliftLocation))
                {
                    _master = new Calbee.WMS.Services.MasterService.Location();
                    _master.LocationCode = forkliftLocation;
                    _listForkLift.Insert(0, _master);
                    ComboBoxBinding.BindEntityToCombobox(_listForkLift, this.cmbForklift, "LocationCode", "LocationCode", "");
                }
                else
                {
                    // MsgBox.ShowExclamation("Not found forklift by This Warehouse : " + this.cmbWarehouse.Text);
                    this.cmbForklift.DataSource = null;
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

        private void frmSelectWAF_Load(object sender, EventArgs e)
        {
            //Binding dropdown
            this.warehouseBinding();
            eventcomboBOxRoot = true;
        }
        private void frmSelectWAF_KeyUp(object sender, KeyEventArgs e)
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

        private void cmbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!eventcomboBOxRoot) return;
                if (this.cmbWarehouse.SelectedIndex >= 0)
                {
                    if (this.cmbWarehouse.Text == Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect)
                    {
                        this.cmbForklift.DataSource = null;
                        return;
                    }
                    if (string.IsNullOrEmpty(this.cmbWarehouse.Text))
                    {
                        this.cmbForklift.DataSource = null;
                        return;
                    }

                    if (!string.IsNullOrEmpty(this.cmbWarehouse.SelectedValue.ToString().Trim()))
                    {
                        // Binding
                        forkLiftBinding(this.cmbWarehouse.SelectedValue.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MsgBox.DialogErrorTryCatch("System InnerException :", ex.InnerException);
                }
                else
                {
                    MsgBox.DialogErrorTryCatch("System Error:", ex);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Calbee.Infra.Common.Constants.WConstants.userName = string.Empty;
            Calbee.Infra.Common.Constants.WConstants.wareHouseDDL = string.Empty;
            Calbee.Infra.Common.Constants.WConstants.forkLiftDDL = string.Empty;
            this.Close();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (!DoValidateByPassForms())
                {
                    return;
                }
                else
                {
                    // Next forms
                    using (MainMenu.frmMainMenu fMainMenu = new frmMainMenu(this.cmbWarehouse.SelectedValue.ToString(), this.cmbForklift.SelectedValue.ToString()))
                    {
                        fMainMenu.ShowDialog();
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
    }
}