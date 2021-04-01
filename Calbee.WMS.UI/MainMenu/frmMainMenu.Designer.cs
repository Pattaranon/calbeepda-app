namespace Calbee.WMS.UI.MainMenu
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeaderMainMenu = new System.Windows.Forms.Label();
            this.btnReceiveMenu = new System.Windows.Forms.Button();
            this.btnIssueMenu = new System.Windows.Forms.Button();
            this.btnInventoryMenu = new System.Windows.Forms.Button();
            this.btnCountMenu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShortPickItem = new System.Windows.Forms.Button();
            this.btnLoadMenu = new System.Windows.Forms.Button();
            this.btnReceiveRMMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeaderMainMenu
            // 
            this.lblHeaderMainMenu.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHeaderMainMenu.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderMainMenu.Location = new System.Drawing.Point(6, 9);
            this.lblHeaderMainMenu.Name = "lblHeaderMainMenu";
            this.lblHeaderMainMenu.Size = new System.Drawing.Size(231, 15);
            this.lblHeaderMainMenu.Text = "Main Menu";
            this.lblHeaderMainMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReceiveMenu
            // 
            this.btnReceiveMenu.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnReceiveMenu.Location = new System.Drawing.Point(24, 28);
            this.btnReceiveMenu.Name = "btnReceiveMenu";
            this.btnReceiveMenu.Size = new System.Drawing.Size(194, 27);
            this.btnReceiveMenu.TabIndex = 0;
            this.btnReceiveMenu.Text = "Receive";
            this.btnReceiveMenu.Click += new System.EventHandler(this.btnReceiveMenu_Click);
            // 
            // btnIssueMenu
            // 
            this.btnIssueMenu.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnIssueMenu.Location = new System.Drawing.Point(24, 92);
            this.btnIssueMenu.Name = "btnIssueMenu";
            this.btnIssueMenu.Size = new System.Drawing.Size(194, 27);
            this.btnIssueMenu.TabIndex = 2;
            this.btnIssueMenu.Text = "Pick Item";
            this.btnIssueMenu.Click += new System.EventHandler(this.btnIssueMenu_Click);
            // 
            // btnInventoryMenu
            // 
            this.btnInventoryMenu.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnInventoryMenu.Location = new System.Drawing.Point(24, 156);
            this.btnInventoryMenu.Name = "btnInventoryMenu";
            this.btnInventoryMenu.Size = new System.Drawing.Size(194, 27);
            this.btnInventoryMenu.TabIndex = 4;
            this.btnInventoryMenu.Text = "Inventory";
            this.btnInventoryMenu.Click += new System.EventHandler(this.btnInventoryMenu_Click);
            // 
            // btnCountMenu
            // 
            this.btnCountMenu.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnCountMenu.Location = new System.Drawing.Point(24, 188);
            this.btnCountMenu.Name = "btnCountMenu";
            this.btnCountMenu.Size = new System.Drawing.Size(194, 27);
            this.btnCountMenu.TabIndex = 5;
            this.btnCountMenu.Text = "Count";
            this.btnCountMenu.Click += new System.EventHandler(this.btnCountMenu_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnBack.Location = new System.Drawing.Point(24, 259);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(194, 27);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShortPickItem
            // 
            this.btnShortPickItem.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnShortPickItem.Location = new System.Drawing.Point(24, 124);
            this.btnShortPickItem.Name = "btnShortPickItem";
            this.btnShortPickItem.Size = new System.Drawing.Size(194, 27);
            this.btnShortPickItem.TabIndex = 3;
            this.btnShortPickItem.Text = "Short Pick Item";
            this.btnShortPickItem.Click += new System.EventHandler(this.btnShortPickItem_Click);
            // 
            // btnLoadMenu
            // 
            this.btnLoadMenu.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnLoadMenu.Location = new System.Drawing.Point(24, 220);
            this.btnLoadMenu.Name = "btnLoadMenu";
            this.btnLoadMenu.Size = new System.Drawing.Size(194, 27);
            this.btnLoadMenu.TabIndex = 6;
            this.btnLoadMenu.Text = "Load";
            this.btnLoadMenu.Visible = false;
            this.btnLoadMenu.Click += new System.EventHandler(this.btnLoadMenu_Click);
            // 
            // btnReceiveRMMenu
            // 
            this.btnReceiveRMMenu.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnReceiveRMMenu.Location = new System.Drawing.Point(24, 60);
            this.btnReceiveRMMenu.Name = "btnReceiveRMMenu";
            this.btnReceiveRMMenu.Size = new System.Drawing.Size(194, 27);
            this.btnReceiveRMMenu.TabIndex = 1;
            this.btnReceiveRMMenu.Text = "Receive Raw Material";
            this.btnReceiveRMMenu.Click += new System.EventHandler(this.btnReceiveRMMenu_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.btnLoadMenu);
            this.Controls.Add(this.btnShortPickItem);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCountMenu);
            this.Controls.Add(this.btnInventoryMenu);
            this.Controls.Add(this.btnIssueMenu);
            this.Controls.Add(this.btnReceiveRMMenu);
            this.Controls.Add(this.btnReceiveMenu);
            this.Controls.Add(this.lblHeaderMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMainMenu_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderMainMenu;
        private System.Windows.Forms.Button btnReceiveMenu;
        private System.Windows.Forms.Button btnIssueMenu;
        private System.Windows.Forms.Button btnInventoryMenu;
        private System.Windows.Forms.Button btnCountMenu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShortPickItem;
        private System.Windows.Forms.Button btnLoadMenu;
        private System.Windows.Forms.Button btnReceiveRMMenu;
    }
}