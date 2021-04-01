namespace Calbee.WMS.UI.Forms.Putaway
{
    partial class frmPutawayStaging
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
            this.lblPickingListNo = new System.Windows.Forms.Label();
            this.txtPickingListNo = new System.Windows.Forms.TextBox();
            this.lblToLocation = new System.Windows.Forms.Label();
            this.txtToLocation = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHeaderMainMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPickingListNo
            // 
            this.lblPickingListNo.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblPickingListNo.Location = new System.Drawing.Point(5, 39);
            this.lblPickingListNo.Name = "lblPickingListNo";
            this.lblPickingListNo.Size = new System.Drawing.Size(76, 13);
            this.lblPickingListNo.Text = "Picking List No";
            // 
            // txtPickingListNo
            // 
            this.txtPickingListNo.BackColor = System.Drawing.Color.LimeGreen;
            this.txtPickingListNo.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtPickingListNo.ForeColor = System.Drawing.Color.White;
            this.txtPickingListNo.Location = new System.Drawing.Point(82, 36);
            this.txtPickingListNo.Name = "txtPickingListNo";
            this.txtPickingListNo.ReadOnly = true;
            this.txtPickingListNo.Size = new System.Drawing.Size(155, 18);
            this.txtPickingListNo.TabIndex = 118;
            // 
            // lblToLocation
            // 
            this.lblToLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblToLocation.Location = new System.Drawing.Point(5, 63);
            this.lblToLocation.Name = "lblToLocation";
            this.lblToLocation.Size = new System.Drawing.Size(76, 13);
            this.lblToLocation.Text = "To Location";
            // 
            // txtToLocation
            // 
            this.txtToLocation.BackColor = System.Drawing.Color.White;
            this.txtToLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtToLocation.ForeColor = System.Drawing.Color.Black;
            this.txtToLocation.Location = new System.Drawing.Point(82, 63);
            this.txtToLocation.Name = "txtToLocation";
            this.txtToLocation.Size = new System.Drawing.Size(155, 18);
            this.txtToLocation.TabIndex = 0;
            this.txtToLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToLocation_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnBack.Location = new System.Drawing.Point(82, 88);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 20);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "<- Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnSave.Location = new System.Drawing.Point(153, 88);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 20);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save ->";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHeaderMainMenu
            // 
            this.lblHeaderMainMenu.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHeaderMainMenu.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderMainMenu.Location = new System.Drawing.Point(3, 9);
            this.lblHeaderMainMenu.Name = "lblHeaderMainMenu";
            this.lblHeaderMainMenu.Size = new System.Drawing.Size(236, 15);
            this.lblHeaderMainMenu.Text = "Putaway to Staging";
            // 
            // frmPutawayStaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.lblHeaderMainMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblToLocation);
            this.Controls.Add(this.txtToLocation);
            this.Controls.Add(this.lblPickingListNo);
            this.Controls.Add(this.txtPickingListNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPutawayStaging";
            this.Text = "Putaway Staging";
            this.Load += new System.EventHandler(this.frmPutawayStaging_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPutawayStaging_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPickingListNo;
        private System.Windows.Forms.TextBox txtPickingListNo;
        private System.Windows.Forms.Label lblToLocation;
        private System.Windows.Forms.TextBox txtToLocation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label lblHeaderMainMenu;
    }
}