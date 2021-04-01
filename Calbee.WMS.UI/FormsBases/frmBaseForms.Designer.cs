namespace Calbee.WMS.UI.FormsBases
{
    partial class frmBaseForms
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
            this.SuspendLayout();
            // 
            // lblHeaderMainMenu
            // 
            this.lblHeaderMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderMainMenu.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblHeaderMainMenu.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderMainMenu.Location = new System.Drawing.Point(9, 9);
            this.lblHeaderMainMenu.Name = "lblHeaderMainMenu";
            this.lblHeaderMainMenu.Size = new System.Drawing.Size(214, 15);
            this.lblHeaderMainMenu.Text = "Menu name";
            // 
            // frmBaseForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.lblHeaderMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaseForms";
            this.Text = "frmBaseForms";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblHeaderMainMenu;

    }
}