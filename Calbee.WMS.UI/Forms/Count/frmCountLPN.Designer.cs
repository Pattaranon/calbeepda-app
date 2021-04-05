namespace Calbee.WMS.UI.Forms.Count
{
    partial class frmCountLPN
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
            this.cmbCountNumner = new System.Windows.Forms.ComboBox();
            this.lblCountNo = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbItemStatus = new System.Windows.Forms.ComboBox();
            this.lblItemStatus = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblHeaderCountMenu = new System.Windows.Forms.Label();
            this.cmbUOM = new System.Windows.Forms.ComboBox();
            this.lblUOM = new System.Windows.Forms.Label();
            this.cmbItemNumber = new System.Windows.Forms.ComboBox();
            this.txtCtcCode = new System.Windows.Forms.TextBox();
            this.lblCTCCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCountNumner
            // 
            this.cmbCountNumner.BackColor = System.Drawing.Color.White;
            this.cmbCountNumner.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.cmbCountNumner.ForeColor = System.Drawing.Color.Black;
            this.cmbCountNumner.Location = new System.Drawing.Point(86, 33);
            this.cmbCountNumner.Name = "cmbCountNumner";
            this.cmbCountNumner.Size = new System.Drawing.Size(148, 18);
            this.cmbCountNumner.TabIndex = 0;
            this.cmbCountNumner.SelectedIndexChanged += new System.EventHandler(this.cmbCountNumner_SelectedIndexChanged);
            // 
            // lblCountNo
            // 
            this.lblCountNo.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblCountNo.Location = new System.Drawing.Point(10, 36);
            this.lblCountNo.Name = "lblCountNo";
            this.lblCountNo.Size = new System.Drawing.Size(75, 13);
            this.lblCountNo.Text = "Count No";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtLocation.ForeColor = System.Drawing.Color.Black;
            this.txtLocation.Location = new System.Drawing.Point(86, 55);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(147, 18);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocation_KeyDown);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(86, 120);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(147, 59);
            this.txtDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblDescription.Location = new System.Drawing.Point(9, 123);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 13);
            this.lblDescription.Text = "Description";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnBack.Location = new System.Drawing.Point(89, 271);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 20);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "<- Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnSave.Location = new System.Drawing.Point(159, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 20);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save ->";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbItemStatus
            // 
            this.cmbItemStatus.BackColor = System.Drawing.Color.White;
            this.cmbItemStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.cmbItemStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbItemStatus.Location = new System.Drawing.Point(86, 202);
            this.cmbItemStatus.Name = "cmbItemStatus";
            this.cmbItemStatus.Size = new System.Drawing.Size(148, 18);
            this.cmbItemStatus.TabIndex = 6;
            // 
            // lblItemStatus
            // 
            this.lblItemStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemStatus.Location = new System.Drawing.Point(9, 205);
            this.lblItemStatus.Name = "lblItemStatus";
            this.lblItemStatus.Size = new System.Drawing.Size(75, 14);
            this.lblItemStatus.Text = "Item Status";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(86, 224);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(146, 18);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblQuantity.Location = new System.Drawing.Point(9, 226);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(75, 15);
            this.lblQuantity.Text = "Quantity";
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemNumber.Location = new System.Drawing.Point(9, 78);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(75, 14);
            this.lblItemNumber.Text = "Item Number";
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLocation.Location = new System.Drawing.Point(9, 58);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(75, 13);
            this.lblLocation.Text = "Location";
            // 
            // lblHeaderCountMenu
            // 
            this.lblHeaderCountMenu.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHeaderCountMenu.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderCountMenu.Location = new System.Drawing.Point(3, 9);
            this.lblHeaderCountMenu.Name = "lblHeaderCountMenu";
            this.lblHeaderCountMenu.Size = new System.Drawing.Size(234, 15);
            this.lblHeaderCountMenu.Text = "Count LPN";
            // 
            // cmbUOM
            // 
            this.cmbUOM.BackColor = System.Drawing.Color.White;
            this.cmbUOM.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.cmbUOM.ForeColor = System.Drawing.Color.Black;
            this.cmbUOM.Location = new System.Drawing.Point(86, 181);
            this.cmbUOM.Name = "cmbUOM";
            this.cmbUOM.Size = new System.Drawing.Size(147, 18);
            this.cmbUOM.TabIndex = 5;
            // 
            // lblUOM
            // 
            this.lblUOM.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblUOM.Location = new System.Drawing.Point(9, 185);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(75, 13);
            this.lblUOM.Text = "UOM";
            // 
            // cmbItemNumber
            // 
            this.cmbItemNumber.Location = new System.Drawing.Point(86, 74);
            this.cmbItemNumber.Name = "cmbItemNumber";
            this.cmbItemNumber.Size = new System.Drawing.Size(147, 23);
            this.cmbItemNumber.TabIndex = 2;
            this.cmbItemNumber.SelectedValueChanged += new System.EventHandler(this.cmbItemNumber_SelectedValueChanged);
            // 
            // txtCtcCode
            // 
            this.txtCtcCode.BackColor = System.Drawing.Color.White;
            this.txtCtcCode.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtCtcCode.ForeColor = System.Drawing.Color.Black;
            this.txtCtcCode.Location = new System.Drawing.Point(86, 100);
            this.txtCtcCode.Name = "txtCtcCode";
            this.txtCtcCode.ReadOnly = true;
            this.txtCtcCode.Size = new System.Drawing.Size(146, 18);
            this.txtCtcCode.TabIndex = 3;
            // 
            // lblCTCCode
            // 
            this.lblCTCCode.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblCTCCode.Location = new System.Drawing.Point(9, 102);
            this.lblCTCCode.Name = "lblCTCCode";
            this.lblCTCCode.Size = new System.Drawing.Size(75, 15);
            this.lblCTCCode.Text = "CTC Code";
            // 
            // frmCountLPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.txtCtcCode);
            this.Controls.Add(this.lblCTCCode);
            this.Controls.Add(this.cmbItemNumber);
            this.Controls.Add(this.cmbUOM);
            this.Controls.Add(this.lblUOM);
            this.Controls.Add(this.lblHeaderCountMenu);
            this.Controls.Add(this.cmbCountNumner);
            this.Controls.Add(this.lblCountNo);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbItemStatus);
            this.Controls.Add(this.lblItemStatus);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblItemNumber);
            this.Controls.Add(this.lblLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCountLPN";
            this.Text = "Count LPN";
            this.Load += new System.EventHandler(this.frmChangeStatus_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmChangeStatus_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCountNumner;
        private System.Windows.Forms.Label lblCountNo;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbItemStatus;
        private System.Windows.Forms.Label lblItemStatus;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblLocation;
        public System.Windows.Forms.Label lblHeaderCountMenu;
        private System.Windows.Forms.ComboBox cmbUOM;
        private System.Windows.Forms.Label lblUOM;
        private System.Windows.Forms.ComboBox cmbItemNumber;
        private System.Windows.Forms.TextBox txtCtcCode;
        private System.Windows.Forms.Label lblCTCCode;

    }
}