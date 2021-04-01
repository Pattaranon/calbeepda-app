namespace Calbee.WMS.UI.MainMenu
{
    partial class frmInventoryMenu
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
            this.btnPickupMenu = new System.Windows.Forms.Button();
            this.btnPutaway = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeaderMainMenu = new System.Windows.Forms.Label();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.btnChangeLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPickupMenu
            // 
            this.btnPickupMenu.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnPickupMenu.Location = new System.Drawing.Point(24, 32);
            this.btnPickupMenu.Name = "btnPickupMenu";
            this.btnPickupMenu.Size = new System.Drawing.Size(194, 27);
            this.btnPickupMenu.TabIndex = 0;
            this.btnPickupMenu.Text = "Pickup";
            this.btnPickupMenu.Click += new System.EventHandler(this.btnPickupMenu_Click);
            // 
            // btnPutaway
            // 
            this.btnPutaway.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnPutaway.Location = new System.Drawing.Point(24, 68);
            this.btnPutaway.Name = "btnPutaway";
            this.btnPutaway.Size = new System.Drawing.Size(194, 27);
            this.btnPutaway.TabIndex = 1;
            this.btnPutaway.Text = "Put away";
            this.btnPutaway.Click += new System.EventHandler(this.btnPutaway_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnInventory.Location = new System.Drawing.Point(24, 104);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(194, 27);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnBack.Location = new System.Drawing.Point(24, 259);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(194, 27);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeaderMainMenu
            // 
            this.lblHeaderMainMenu.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHeaderMainMenu.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderMainMenu.Location = new System.Drawing.Point(5, 9);
            this.lblHeaderMainMenu.Name = "lblHeaderMainMenu";
            this.lblHeaderMainMenu.Size = new System.Drawing.Size(231, 15);
            this.lblHeaderMainMenu.Text = "Inventory Menu";
            this.lblHeaderMainMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnChangeStatus.Location = new System.Drawing.Point(24, 140);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(194, 27);
            this.btnChangeStatus.TabIndex = 3;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // btnChangeLocation
            // 
            this.btnChangeLocation.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnChangeLocation.Location = new System.Drawing.Point(24, 175);
            this.btnChangeLocation.Name = "btnChangeLocation";
            this.btnChangeLocation.Size = new System.Drawing.Size(194, 27);
            this.btnChangeLocation.TabIndex = 5;
            this.btnChangeLocation.Text = "Change Location";
            this.btnChangeLocation.Click += new System.EventHandler(this.btnChangeLocation_Click);
            // 
            // frmInventoryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.btnChangeLocation);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.lblHeaderMainMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnPutaway);
            this.Controls.Add(this.btnPickupMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventoryMenu";
            this.Text = "Inventory Menu";
            this.Load += new System.EventHandler(this.frmInventoryMenu_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmInventoryMenu_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPickupMenu;
        private System.Windows.Forms.Button btnPutaway;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHeaderMainMenu;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Button btnChangeLocation;
    }
}