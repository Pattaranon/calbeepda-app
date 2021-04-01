namespace Calbee.WMS.UI.Forms.Count
{
    partial class frmCount
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
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbUOM = new System.Windows.Forms.ComboBox();
            this.lblUOM = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbItemStatus = new System.Windows.Forms.ComboBox();
            this.lblItemStatus = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblLotNumber = new System.Windows.Forms.Label();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblLPN = new System.Windows.Forms.Label();
            this.txtLPN = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCountNumner = new System.Windows.Forms.ComboBox();
            this.lblCountNo = new System.Windows.Forms.Label();
            this.lblHeaderMainMenu = new System.Windows.Forms.Label();
            this.lblResultCounter = new System.Windows.Forms.Label();
            this.lblReceived = new System.Windows.Forms.Label();
            this.txtExpiryDate = new Calbee.WMS.UI.UserControls.AutoCompleteTextBox();
            this.txtLotNumber = new Calbee.WMS.UI.UserControls.AutoCompleteTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.BackColor = System.Drawing.Color.White;
            this.txtItemNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtItemNumber.ForeColor = System.Drawing.Color.Black;
            this.txtItemNumber.Location = new System.Drawing.Point(89, 86);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(147, 18);
            this.txtItemNumber.TabIndex = 3;
            this.txtItemNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemNumber_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnBack.Location = new System.Drawing.Point(89, 259);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 20);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "<- Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnSave.Location = new System.Drawing.Point(166, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 20);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save ->";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbUOM
            // 
            this.cmbUOM.BackColor = System.Drawing.Color.White;
            this.cmbUOM.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.cmbUOM.ForeColor = System.Drawing.Color.Black;
            this.cmbUOM.Location = new System.Drawing.Point(89, 213);
            this.cmbUOM.Name = "cmbUOM";
            this.cmbUOM.Size = new System.Drawing.Size(147, 18);
            this.cmbUOM.TabIndex = 8;
            // 
            // lblUOM
            // 
            this.lblUOM.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblUOM.Location = new System.Drawing.Point(12, 217);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(75, 13);
            this.lblUOM.Text = "UOM";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblQuantity.Location = new System.Drawing.Point(12, 196);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(75, 13);
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(89, 194);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(147, 18);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // cmbItemStatus
            // 
            this.cmbItemStatus.BackColor = System.Drawing.Color.White;
            this.cmbItemStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.cmbItemStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbItemStatus.Location = new System.Drawing.Point(89, 234);
            this.cmbItemStatus.Name = "cmbItemStatus";
            this.cmbItemStatus.Size = new System.Drawing.Size(147, 18);
            this.cmbItemStatus.TabIndex = 9;
            // 
            // lblItemStatus
            // 
            this.lblItemStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemStatus.Location = new System.Drawing.Point(12, 237);
            this.lblItemStatus.Name = "lblItemStatus";
            this.lblItemStatus.Size = new System.Drawing.Size(75, 13);
            this.lblItemStatus.Text = "Item Status";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblExpiryDate.Location = new System.Drawing.Point(12, 177);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(75, 13);
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // lblLotNumber
            // 
            this.lblLotNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLotNumber.Location = new System.Drawing.Point(12, 157);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(75, 13);
            this.lblLotNumber.Text = "Lot Number";
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemNumber.Location = new System.Drawing.Point(12, 89);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(75, 13);
            this.lblItemNumber.Text = "Item Number";
            // 
            // lblLPN
            // 
            this.lblLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLPN.Location = new System.Drawing.Point(12, 70);
            this.lblLPN.Name = "lblLPN";
            this.lblLPN.Size = new System.Drawing.Size(75, 13);
            this.lblLPN.Text = "LPN";
            // 
            // txtLPN
            // 
            this.txtLPN.BackColor = System.Drawing.Color.White;
            this.txtLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtLPN.ForeColor = System.Drawing.Color.Black;
            this.txtLPN.Location = new System.Drawing.Point(89, 67);
            this.txtLPN.Name = "txtLPN";
            this.txtLPN.Size = new System.Drawing.Size(147, 18);
            this.txtLPN.TabIndex = 2;
            this.txtLPN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLPN_KeyDown);
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLocation.Location = new System.Drawing.Point(12, 51);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(75, 13);
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtLocation.ForeColor = System.Drawing.Color.Black;
            this.txtLocation.Location = new System.Drawing.Point(89, 48);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(147, 18);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocation_KeyDown);
            // 
            // cmbCountNumner
            // 
            this.cmbCountNumner.BackColor = System.Drawing.Color.White;
            this.cmbCountNumner.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.cmbCountNumner.ForeColor = System.Drawing.Color.Black;
            this.cmbCountNumner.Location = new System.Drawing.Point(89, 28);
            this.cmbCountNumner.Name = "cmbCountNumner";
            this.cmbCountNumner.Size = new System.Drawing.Size(147, 18);
            this.cmbCountNumner.TabIndex = 0;
            this.cmbCountNumner.SelectedIndexChanged += new System.EventHandler(this.cmbCountNumner_SelectedIndexChanged);
            // 
            // lblCountNo
            // 
            this.lblCountNo.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblCountNo.Location = new System.Drawing.Point(12, 31);
            this.lblCountNo.Name = "lblCountNo";
            this.lblCountNo.Size = new System.Drawing.Size(75, 13);
            this.lblCountNo.Text = "Count No";
            // 
            // lblHeaderMainMenu
            // 
            this.lblHeaderMainMenu.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHeaderMainMenu.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderMainMenu.Location = new System.Drawing.Point(3, 9);
            this.lblHeaderMainMenu.Name = "lblHeaderMainMenu";
            this.lblHeaderMainMenu.Size = new System.Drawing.Size(234, 15);
            this.lblHeaderMainMenu.Text = "Count";
            // 
            // lblResultCounter
            // 
            this.lblResultCounter.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblResultCounter.ForeColor = System.Drawing.Color.Red;
            this.lblResultCounter.Location = new System.Drawing.Point(132, 9);
            this.lblResultCounter.Name = "lblResultCounter";
            this.lblResultCounter.Size = new System.Drawing.Size(104, 13);
            this.lblResultCounter.Text = "xx.xxx/xx.xxx";
            this.lblResultCounter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblResultCounter.Visible = false;
            // 
            // lblReceived
            // 
            this.lblReceived.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblReceived.Location = new System.Drawing.Point(72, 9);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(57, 13);
            this.lblReceived.Text = "Counted : ";
            this.lblReceived.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblReceived.Visible = false;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.BackColor = System.Drawing.Color.White;
            this.txtExpiryDate.ForeColor = System.Drawing.Color.Black;
            this.txtExpiryDate.Location = new System.Drawing.Point(89, 174);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.SelectedIndex = -1;
            this.txtExpiryDate.Size = new System.Drawing.Size(147, 18);
            this.txtExpiryDate.TabIndex = 6;
            this.txtExpiryDate.SelectedIndexChangeds += new System.EventHandler(this.txtExpiryDate_SelectedIndexChangeds);
            this.txtExpiryDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpiryDate_KeyDowns);
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.BackColor = System.Drawing.Color.White;
            this.txtLotNumber.ForeColor = System.Drawing.Color.Black;
            this.txtLotNumber.Location = new System.Drawing.Point(89, 154);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.SelectedIndex = -1;
            this.txtLotNumber.Size = new System.Drawing.Size(147, 18);
            this.txtLotNumber.TabIndex = 5;
            this.txtLotNumber.SelectedIndexChangeds += new System.EventHandler(this.txtLotNumber_SelectedIndexChangeds);
            this.txtLotNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLotNumber_KeyDowns);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblDescription.Location = new System.Drawing.Point(12, 108);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 13);
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(89, 105);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(147, 48);
            this.txtDescription.TabIndex = 4;
            // 
            // frmCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblResultCounter);
            this.Controls.Add(this.lblReceived);
            this.Controls.Add(this.lblHeaderMainMenu);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.txtLotNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbUOM);
            this.Controls.Add(this.lblUOM);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbItemStatus);
            this.Controls.Add(this.lblItemStatus);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblLotNumber);
            this.Controls.Add(this.lblItemNumber);
            this.Controls.Add(this.lblLPN);
            this.Controls.Add(this.txtLPN);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.cmbCountNumner);
            this.Controls.Add(this.lblCountNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCount";
            this.Text = "Count";
            this.Load += new System.EventHandler(this.frmCount_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmCount_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemNumber;
        private Calbee.WMS.UI.UserControls.AutoCompleteTextBox txtExpiryDate;
        private Calbee.WMS.UI.UserControls.AutoCompleteTextBox txtLotNumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbUOM;
        private System.Windows.Forms.Label lblUOM;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbItemStatus;
        private System.Windows.Forms.Label lblItemStatus;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblLotNumber;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblLPN;
        private System.Windows.Forms.TextBox txtLPN;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbCountNumner;
        private System.Windows.Forms.Label lblCountNo;
        public System.Windows.Forms.Label lblHeaderMainMenu;
        private System.Windows.Forms.Label lblResultCounter;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;

    }
}