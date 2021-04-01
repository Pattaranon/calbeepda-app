namespace Calbee.WMS.UI.Authentication
{
    partial class frmConfigWebService
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
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtURLWebService = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitleHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.ForeColor = System.Drawing.Color.Black;
            this.btnTestConnection.Location = new System.Drawing.Point(8, 148);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(105, 20);
            this.btnTestConnection.TabIndex = 78;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(176, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 20);
            this.btnSave.TabIndex = 79;
            this.btnSave.Text = "Save ->";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(115, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 20);
            this.btnExit.TabIndex = 77;
            this.btnExit.Text = "<- Back";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtURLWebService
            // 
            this.txtURLWebService.BackColor = System.Drawing.Color.White;
            this.txtURLWebService.ForeColor = System.Drawing.Color.Black;
            this.txtURLWebService.Location = new System.Drawing.Point(8, 106);
            this.txtURLWebService.Name = "txtURLWebService";
            this.txtURLWebService.Size = new System.Drawing.Size(226, 23);
            this.txtURLWebService.TabIndex = 76;
            this.txtURLWebService.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURLWebService_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.Text = "Server Name / IP :";
            // 
            // lblTitleHeader
            // 
            this.lblTitleHeader.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTitleHeader.ForeColor = System.Drawing.Color.Black;
            this.lblTitleHeader.Location = new System.Drawing.Point(3, 9);
            this.lblTitleHeader.Name = "lblTitleHeader";
            this.lblTitleHeader.Size = new System.Drawing.Size(232, 19);
            this.lblTitleHeader.Text = "Setting Server Name/IP of Service";
            this.lblTitleHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmConfigWebService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitleHeader);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtURLWebService);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfigWebService";
            this.Text = "Web Service";
            this.Load += new System.EventHandler(this.frmConfigWebService_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmConfigWebService_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtURLWebService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitleHeader;
    }
}