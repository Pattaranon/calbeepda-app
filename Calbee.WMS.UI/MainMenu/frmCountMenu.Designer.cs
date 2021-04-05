namespace Calbee.WMS.UI.MainMenu
{
    partial class frmCountMenu
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
            this.btnCountMenu = new System.Windows.Forms.Button();
            this.btnCountLPN = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeaderMainMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCountMenu
            // 
            this.btnCountMenu.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnCountMenu.Location = new System.Drawing.Point(24, 32);
            this.btnCountMenu.Name = "btnCountMenu";
            this.btnCountMenu.Size = new System.Drawing.Size(194, 27);
            this.btnCountMenu.TabIndex = 0;
            this.btnCountMenu.Text = "Count";
            this.btnCountMenu.Click += new System.EventHandler(this.btnCountMenu_Click);
            // 
            // btnCountLPN
            // 
            this.btnCountLPN.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnCountLPN.Location = new System.Drawing.Point(24, 68);
            this.btnCountLPN.Name = "btnCountLPN";
            this.btnCountLPN.Size = new System.Drawing.Size(194, 27);
            this.btnCountLPN.TabIndex = 1;
            this.btnCountLPN.Text = "Count LPN";
            this.btnCountLPN.Click += new System.EventHandler(this.btnCountLPN_Click);
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
            this.lblHeaderMainMenu.Text = "Count Menu";
            this.lblHeaderMainMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCountMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.lblHeaderMainMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCountLPN);
            this.Controls.Add(this.btnCountMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCountMenu";
            this.Text = "Count Menu";
            this.Load += new System.EventHandler(this.frmInventoryMenu_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmInventoryMenu_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCountMenu;
        private System.Windows.Forms.Button btnCountLPN;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHeaderMainMenu;
    }
}