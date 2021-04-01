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
    public partial class frmMainMenu : Form
    {
        #region Member

        string wareHouse = string.Empty;
        string forkLift = string.Empty;

        #endregion

        #region Constuctor

        public frmMainMenu(string paramWarehouse, string paramForkLift)
        {
            InitializeComponent();
            this.wareHouse = paramWarehouse;
            this.forkLift = paramForkLift;
            // Binding
            Calbee.Infra.Common.Constants.WConstants.wareHouseDDL = this.wareHouse;
            Calbee.Infra.Common.Constants.WConstants.forkLiftDDL = this.forkLift;
        }
        public frmMainMenu()
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

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            this.btnReceiveMenu.Focus();
        }
        private void frmMainMenu_KeyUp(object sender, KeyEventArgs e)
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

        private void btnReceiveMenu_Click(object sender, EventArgs e)
        {
            // เมนูงานรับ
            using (Forms.Receive.frmReceive fRe = new Calbee.WMS.UI.Forms.Receive.frmReceive())
            {
                fRe.ShowDialog();
            }

            /*
            Forms.Receive.frmReceive fRe = new Calbee.WMS.UI.Forms.Receive.frmReceive();
            fRe.Show();
            this.Close();
            */
        }
        private void btnReceiveRMMenu_Click(object sender, EventArgs e)
        {
            // เมนูงานรับ  Receive Raw Material
            using (Forms.Receive.frmReceiveRawMaterial fReRM = new Calbee.WMS.UI.Forms.Receive.frmReceiveRawMaterial())
            {
                fReRM.ShowDialog();
            }
        }
        private void btnIssueMenu_Click(object sender, EventArgs e)
        {
            /*
            // ยังไม่อนุญาติเปิดใช้งาน
            Calbee.Infra.Helper.Message.MsgBox.DialogError("Not yet allowed to activate of menu Pick Item");
            return;
            */

            // เมนูงานจ่าย
            using (Forms.Pickup.frmPickItem fPickItem = new Calbee.WMS.UI.Forms.Pickup.frmPickItem())
            {
                fPickItem.ShowDialog();
            }
            
            /*
            Forms.Pickup.frmPickItem fPickItem = new Calbee.WMS.UI.Forms.Pickup.frmPickItem();
            fPickItem.Show();
            this.Close();
            */
        }
        private void btnShortPickItem_Click(object sender, EventArgs e)
        {
            // เมนูจ่ายแบบเร็ว
            using (Forms.Pickup.frmShortPickItem fShortPickItem = new Calbee.WMS.UI.Forms.Pickup.frmShortPickItem())
            {
                fShortPickItem.ShowDialog();
            }

            /*
            Forms.Pickup.frmShortPickItem fShortPickItem = new Calbee.WMS.UI.Forms.Pickup.frmShortPickItem();
            fShortPickItem.Show();
            this.Close();
            */
        }
        private void btnInventoryMenu_Click(object sender, EventArgs e)
        {
            // เมนู Inventory
            using (frmInventoryMenu fInvenMenu = new frmInventoryMenu())
            {
                fInvenMenu.ShowDialog();
            }

            /*
            frmInventoryMenu fInvenMenu = new frmInventoryMenu();
            fInvenMenu.Show();
            this.Close();
            */
        }
        private void btnCountMenu_Click(object sender, EventArgs e)
        {
            // เมนูงานนับ
            using (Forms.Count.frmCount fCount = new Calbee.WMS.UI.Forms.Count.frmCount())
            {
                fCount.ShowDialog();
            }

            /*
            Forms.Count.frmCount fCount = new Calbee.WMS.UI.Forms.Count.frmCount();
            fCount.Show();
            this.Close();
            */
        }
        private void btnLoadMenu_Click(object sender, EventArgs e)
        {
            // เมนูโหลด
            using (Forms.Load.frmLoad fLoad = new Calbee.WMS.UI.Forms.Load.frmLoad())
            {
                fLoad.ShowDialog();
            }

            /*
            Forms.Load.frmLoad fLoad = new Calbee.WMS.UI.Forms.Load.frmLoad();
            fLoad.Show();
            this.Close();
            */
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Calbee.Infra.Common.Constants.WConstants.wareHouseDDL = string.Empty;
            //Calbee.Infra.Common.Constants.WConstants.forkLiftDDL = string.Empty;
            // Back form
            //MainMenu.frmSelectWAF fWAF = new frmSelectWAF(Calbee.Infra.Common.Constants.WConstants.wareHouseDDL, Calbee.Infra.Common.Constants.WConstants.forkLiftDDL);
            //fWAF.Show();

            this.Close();
        }

        #endregion
    }
}