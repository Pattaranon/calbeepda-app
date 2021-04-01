namespace Calbee.WMS.UI.Forms.Putaway
{
    partial class frmPutaway
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
            this.lblSuggestLocation = new System.Windows.Forms.Label();
            this.txtSuggestLocation = new System.Windows.Forms.TextBox();
            this.lblToLocation = new System.Windows.Forms.Label();
            this.txtToLocation = new System.Windows.Forms.TextBox();
            this.lblLPN = new System.Windows.Forms.Label();
            this.txtLPN = new System.Windows.Forms.TextBox();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblLotNumber = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.cmbItemStatus = new System.Windows.Forms.ComboBox();
            this.lblItemStatus = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblToLPN = new System.Windows.Forms.Label();
            this.txtToLPN = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHeaderMainMenu = new System.Windows.Forms.Label();
            this.cmbUOM = new System.Windows.Forms.ComboBox();
            this.lblUOM = new System.Windows.Forms.Label();
            this.txtLotNumber = new Calbee.WMS.UI.UserControls.AutoCompleteTextBox();
            this.txtExpiryDate = new Calbee.WMS.UI.UserControls.AutoCompleteTextBox();
            this.txtItemNumber = new Calbee.WMS.UI.UserControls.AutoCompleteTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSuggestLocation
            // 
            this.lblSuggestLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblSuggestLocation.Location = new System.Drawing.Point(8, 30);
            this.lblSuggestLocation.Name = "lblSuggestLocation";
            this.lblSuggestLocation.Size = new System.Drawing.Size(76, 13);
            this.lblSuggestLocation.Text = "Suggest Location";
            // 
            // txtSuggestLocation
            // 
            this.txtSuggestLocation.BackColor = System.Drawing.Color.LimeGreen;
            this.txtSuggestLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.txtSuggestLocation.ForeColor = System.Drawing.Color.White;
            this.txtSuggestLocation.Location = new System.Drawing.Point(85, 27);
            this.txtSuggestLocation.Name = "txtSuggestLocation";
            this.txtSuggestLocation.ReadOnly = true;
            this.txtSuggestLocation.Size = new System.Drawing.Size(151, 18);
            this.txtSuggestLocation.TabIndex = 999;
            // 
            // lblToLocation
            // 
            this.lblToLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblToLocation.Location = new System.Drawing.Point(8, 49);
            this.lblToLocation.Name = "lblToLocation";
            this.lblToLocation.Size = new System.Drawing.Size(75, 13);
            this.lblToLocation.Text = "To Location";
            // 
            // txtToLocation
            // 
            this.txtToLocation.BackColor = System.Drawing.Color.White;
            this.txtToLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtToLocation.ForeColor = System.Drawing.Color.Black;
            this.txtToLocation.Location = new System.Drawing.Point(85, 46);
            this.txtToLocation.Name = "txtToLocation";
            this.txtToLocation.Size = new System.Drawing.Size(151, 18);
            this.txtToLocation.TabIndex = 0;
            this.txtToLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToLocation_KeyDown);
            // 
            // lblLPN
            // 
            this.lblLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLPN.Location = new System.Drawing.Point(8, 68);
            this.lblLPN.Name = "lblLPN";
            this.lblLPN.Size = new System.Drawing.Size(75, 13);
            this.lblLPN.Text = "LPN";
            // 
            // txtLPN
            // 
            this.txtLPN.BackColor = System.Drawing.Color.White;
            this.txtLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtLPN.ForeColor = System.Drawing.Color.Black;
            this.txtLPN.Location = new System.Drawing.Point(85, 65);
            this.txtLPN.Name = "txtLPN";
            this.txtLPN.Size = new System.Drawing.Size(151, 18);
            this.txtLPN.TabIndex = 1;
            this.txtLPN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLPN_KeyDown);
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemNumber.Location = new System.Drawing.Point(8, 88);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(75, 13);
            this.lblItemNumber.Text = "Item Number";
            // 
            // lblLotNumber
            // 
            this.lblLotNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLotNumber.Location = new System.Drawing.Point(8, 154);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(75, 13);
            this.lblLotNumber.Text = "Lot Number";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblExpiryDate.Location = new System.Drawing.Point(8, 174);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(75, 13);
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // cmbItemStatus
            // 
            this.cmbItemStatus.BackColor = System.Drawing.Color.White;
            this.cmbItemStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.cmbItemStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbItemStatus.Location = new System.Drawing.Point(85, 212);
            this.cmbItemStatus.Name = "cmbItemStatus";
            this.cmbItemStatus.Size = new System.Drawing.Size(151, 18);
            this.cmbItemStatus.TabIndex = 8;
            // 
            // lblItemStatus
            // 
            this.lblItemStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemStatus.Location = new System.Drawing.Point(8, 216);
            this.lblItemStatus.Name = "lblItemStatus";
            this.lblItemStatus.Size = new System.Drawing.Size(75, 13);
            this.lblItemStatus.Text = "Item Status";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblQuantity.Location = new System.Drawing.Point(8, 194);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(75, 13);
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(85, 190);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(57, 18);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // lblToLPN
            // 
            this.lblToLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblToLPN.Location = new System.Drawing.Point(8, 239);
            this.lblToLPN.Name = "lblToLPN";
            this.lblToLPN.Size = new System.Drawing.Size(75, 13);
            this.lblToLPN.Text = "To LPN";
            // 
            // txtToLPN
            // 
            this.txtToLPN.BackColor = System.Drawing.Color.White;
            this.txtToLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtToLPN.ForeColor = System.Drawing.Color.Black;
            this.txtToLPN.Location = new System.Drawing.Point(85, 235);
            this.txtToLPN.Name = "txtToLPN";
            this.txtToLPN.Size = new System.Drawing.Size(151, 18);
            this.txtToLPN.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnBack.Location = new System.Drawing.Point(85, 256);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 20);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "<- Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnSave.Location = new System.Drawing.Point(160, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 20);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save ->";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHeaderMainMenu
            // 
            this.lblHeaderMainMenu.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHeaderMainMenu.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderMainMenu.Location = new System.Drawing.Point(3, 9);
            this.lblHeaderMainMenu.Name = "lblHeaderMainMenu";
            this.lblHeaderMainMenu.Size = new System.Drawing.Size(234, 15);
            this.lblHeaderMainMenu.Text = "Putaway";
            // 
            // cmbUOM
            // 
            this.cmbUOM.BackColor = System.Drawing.Color.White;
            this.cmbUOM.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.cmbUOM.ForeColor = System.Drawing.Color.Black;
            this.cmbUOM.Location = new System.Drawing.Point(176, 189);
            this.cmbUOM.Name = "cmbUOM";
            this.cmbUOM.Size = new System.Drawing.Size(60, 18);
            this.cmbUOM.TabIndex = 7;
            // 
            // lblUOM
            // 
            this.lblUOM.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblUOM.Location = new System.Drawing.Point(146, 193);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(24, 11);
            this.lblUOM.Text = "UOM";
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.BackColor = System.Drawing.Color.White;
            this.txtLotNumber.ForeColor = System.Drawing.Color.Black;
            this.txtLotNumber.Location = new System.Drawing.Point(85, 150);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.SelectedIndex = -1;
            this.txtLotNumber.Size = new System.Drawing.Size(151, 18);
            this.txtLotNumber.TabIndex = 4;
            this.txtLotNumber.SelectedIndexChangeds += new System.EventHandler(this.txtLotNumber_SelectedIndexChangeds);
            this.txtLotNumber.KeyDowns += new System.Windows.Forms.KeyEventHandler(this.txtLotNumber_KeyDowns);
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.BackColor = System.Drawing.Color.White;
            this.txtExpiryDate.ForeColor = System.Drawing.Color.Black;
            this.txtExpiryDate.Location = new System.Drawing.Point(85, 170);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.SelectedIndex = -1;
            this.txtExpiryDate.Size = new System.Drawing.Size(151, 18);
            this.txtExpiryDate.TabIndex = 5;
            this.txtExpiryDate.SelectedIndexChangeds += new System.EventHandler(this.txtExpiryDate_SelectedIndexChangeds);
            this.txtExpiryDate.KeyDowns += new System.Windows.Forms.KeyEventHandler(this.txtExpiryDate_KeyDowns);
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.BackColor = System.Drawing.Color.White;
            this.txtItemNumber.ForeColor = System.Drawing.Color.Black;
            this.txtItemNumber.Location = new System.Drawing.Point(85, 84);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.SelectedIndex = -1;
            this.txtItemNumber.Size = new System.Drawing.Size(151, 18);
            this.txtItemNumber.TabIndex = 2;
            this.txtItemNumber.SelectedIndexChangeds += new System.EventHandler(this.txtItemNumber_SelectedIndexChangeds);
            this.txtItemNumber.KeyDowns += new System.Windows.Forms.KeyEventHandler(this.txtItemNumber_KeyDowns);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblDescription.Location = new System.Drawing.Point(8, 108);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 13);
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(85, 104);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(151, 45);
            this.txtDescription.TabIndex = 3;
            // 
            // frmPutaway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtLotNumber);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.cmbUOM);
            this.Controls.Add(this.lblUOM);
            this.Controls.Add(this.lblHeaderMainMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblToLPN);
            this.Controls.Add(this.txtToLPN);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbItemStatus);
            this.Controls.Add(this.lblItemStatus);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblLotNumber);
            this.Controls.Add(this.lblItemNumber);
            this.Controls.Add(this.lblLPN);
            this.Controls.Add(this.txtLPN);
            this.Controls.Add(this.lblToLocation);
            this.Controls.Add(this.txtToLocation);
            this.Controls.Add(this.lblSuggestLocation);
            this.Controls.Add(this.txtSuggestLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPutaway";
            this.Text = "Putaway";
            this.Load += new System.EventHandler(this.frmPutaway_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPutaway_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSuggestLocation;
        private System.Windows.Forms.TextBox txtSuggestLocation;
        private System.Windows.Forms.Label lblToLocation;
        private System.Windows.Forms.TextBox txtToLocation;
        private System.Windows.Forms.Label lblLPN;
        private System.Windows.Forms.TextBox txtLPN;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblLotNumber;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.ComboBox cmbItemStatus;
        private System.Windows.Forms.Label lblItemStatus;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblToLPN;
        private System.Windows.Forms.TextBox txtToLPN;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label lblHeaderMainMenu;
        private System.Windows.Forms.ComboBox cmbUOM;
        private System.Windows.Forms.Label lblUOM;
        private Calbee.WMS.UI.UserControls.AutoCompleteTextBox txtItemNumber;
        private Calbee.WMS.UI.UserControls.AutoCompleteTextBox txtExpiryDate;
        private Calbee.WMS.UI.UserControls.AutoCompleteTextBox txtLotNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
    }
}