namespace Calbee.WMS.UI.MainMenu
{
    partial class frmSelectWAF
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
            this.lblHeaderMenu = new System.Windows.Forms.Label();
            this.lblForklift = new System.Windows.Forms.Label();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            this.cmbForklift = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeaderMenu
            // 
            this.lblHeaderMenu.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHeaderMenu.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderMenu.Location = new System.Drawing.Point(3, 9);
            this.lblHeaderMenu.Name = "lblHeaderMenu";
            this.lblHeaderMenu.Size = new System.Drawing.Size(239, 16);
            this.lblHeaderMenu.Text = "Select Warehouse and Forklift";
            this.lblHeaderMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblForklift
            // 
            this.lblForklift.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblForklift.ForeColor = System.Drawing.Color.Black;
            this.lblForklift.Location = new System.Drawing.Point(11, 93);
            this.lblForklift.Name = "lblForklift";
            this.lblForklift.Size = new System.Drawing.Size(81, 14);
            this.lblForklift.Text = "Forklift";
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblWarehouse.ForeColor = System.Drawing.Color.Black;
            this.lblWarehouse.Location = new System.Drawing.Point(11, 56);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(81, 15);
            this.lblWarehouse.Text = "Warehouse";
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.BackColor = System.Drawing.Color.White;
            this.cmbWarehouse.ForeColor = System.Drawing.Color.Black;
            this.cmbWarehouse.Location = new System.Drawing.Point(88, 52);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(143, 23);
            this.cmbWarehouse.TabIndex = 6;
            this.cmbWarehouse.SelectedIndexChanged += new System.EventHandler(this.cmbWarehouse_SelectedIndexChanged);
            // 
            // cmbForklift
            // 
            this.cmbForklift.BackColor = System.Drawing.Color.White;
            this.cmbForklift.ForeColor = System.Drawing.Color.Black;
            this.cmbForklift.Location = new System.Drawing.Point(88, 89);
            this.cmbForklift.Name = "cmbForklift";
            this.cmbForklift.Size = new System.Drawing.Size(143, 23);
            this.cmbForklift.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnBack.Location = new System.Drawing.Point(88, 129);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 20);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "<- Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnNext.Location = new System.Drawing.Point(148, 129);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(83, 20);
            this.btnNext.TabIndex = 32;
            this.btnNext.Text = "Next ->";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmSelectWAF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cmbForklift);
            this.Controls.Add(this.cmbWarehouse);
            this.Controls.Add(this.lblForklift);
            this.Controls.Add(this.lblWarehouse);
            this.Controls.Add(this.lblHeaderMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectWAF";
            this.Text = "Select Warehouse and Forklift";
            this.Load += new System.EventHandler(this.frmSelectWAF_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmSelectWAF_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderMenu;
        private System.Windows.Forms.Label lblForklift;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.ComboBox cmbWarehouse;
        private System.Windows.Forms.ComboBox cmbForklift;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
    }
}