using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calbee.WMS.UI.MainMenu
{
    public partial class frmInventoryMenu : Form
    {
        #region Member


        #endregion

        #region Consturctor

        public frmInventoryMenu()
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

        #endregion

        #region Event

        private void frmInventoryMenu_Load(object sender, EventArgs e)
        {
            this.btnPickupMenu.Focus();
        }
        private void frmInventoryMenu_KeyUp(object sender, KeyEventArgs e)
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

        private void btnPickupMenu_Click(object sender, EventArgs e)
        {
            // เมนูหยิบ
            using (Forms.Pickup.frmPickup fPickup = new Calbee.WMS.UI.Forms.Pickup.frmPickup())
            {
                fPickup.ShowDialog();
            }

            /*
            Forms.Pickup.frmPickup fPickup = new Calbee.WMS.UI.Forms.Pickup.frmPickup();
            fPickup.Show();
            this.Close();
            */
        }
        private void btnPutaway_Click(object sender, EventArgs e)
        {
            // เมนูวาง
            using (Forms.Putaway.frmPutaway fPutaway = new Calbee.WMS.UI.Forms.Putaway.frmPutaway())
            {
                fPutaway.ShowDialog();
            }

            /*
            Forms.Putaway.frmPutaway fPutaway = new Calbee.WMS.UI.Forms.Putaway.frmPutaway();
            fPutaway.Show();
            this.Close();
            */
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            using (Forms.Inventory.frmInventory fInventory = new Calbee.WMS.UI.Forms.Inventory.frmInventory())
            {
                fInventory.ShowDialog();
            }

            /*
            Forms.Inventory.frmInventory fInventory = new Calbee.WMS.UI.Forms.Inventory.frmInventory();
            fInventory.Show();
            this.Close();
            */
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            using (Forms.ChangeStatus.frmChangeStatus fChangeStatus = new Calbee.WMS.UI.Forms.ChangeStatus.frmChangeStatus())
            {
                fChangeStatus.ShowDialog();
            }
        }

        private void btnChangeLocation_Click(object sender, EventArgs e)
        {
            using (Forms.ChangeLocation.frmChangeLocation fChangeLocation = new Calbee.WMS.UI.Forms.ChangeLocation.frmChangeLocation())
            {
                fChangeLocation.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            /*
            MainMenu.frmMainMenu fMain = new frmMainMenu();
            fMain.Show();
            this.Close();
            */
        }

        #endregion
    }
}