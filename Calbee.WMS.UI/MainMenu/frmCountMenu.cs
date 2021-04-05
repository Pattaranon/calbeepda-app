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
    public partial class frmCountMenu : Form
    {
        #region Member


        #endregion

        #region Consturctor

        public frmCountMenu()
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
            this.btnCountMenu.Focus();
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

        private void btnCountMenu_Click(object sender, EventArgs e)
        {
            // เมนูงานนับ
            using (Forms.Count.frmCount fCount = new Calbee.WMS.UI.Forms.Count.frmCount())
            {
                fCount.ShowDialog();
            }
        }
        private void btnCountLPN_Click(object sender, EventArgs e)
        {
            // เมนูนับ LPN
            using (Forms.Count.frmCountLPN fcountLPN = new Calbee.WMS.UI.Forms.Count.frmCountLPN())
            {
                fcountLPN.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}