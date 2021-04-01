namespace Calbee.WMS.UI.FormsBases
{
    partial class frmBaseTitleHeader
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
            this.lblTitleMessageHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleMessageHeader
            // 
            this.lblTitleMessageHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleMessageHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblTitleMessageHeader.ForeColor = System.Drawing.Color.Black;
            this.lblTitleMessageHeader.Location = new System.Drawing.Point(3, 8);
            this.lblTitleMessageHeader.Name = "lblTitleMessageHeader";
            this.lblTitleMessageHeader.Size = new System.Drawing.Size(232, 18);
            this.lblTitleMessageHeader.Text = "Title Message Header";
            this.lblTitleMessageHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmBaseTitleHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitleMessageHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaseTitleHeader";
            this.Text = "Base Title Header";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTitleMessageHeader;

    }
}