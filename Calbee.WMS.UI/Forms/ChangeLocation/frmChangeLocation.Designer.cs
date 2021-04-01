namespace Calbee.WMS.UI.Forms.ChangeLocation
{
    partial class frmChangeLocation
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
            this.tabChangeLocation = new System.Windows.Forms.TabControl();
            this.tabChangeLocationControl = new System.Windows.Forms.TabPage();
            this.txtToLocation = new System.Windows.Forms.TextBox();
            this.lblToLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbItemStatus = new System.Windows.Forms.ComboBox();
            this.lblItemStatus = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.txtLotNumber = new System.Windows.Forms.TextBox();
            this.lblLotNumber = new System.Windows.Forms.Label();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblLPN = new System.Windows.Forms.Label();
            this.txtLPN = new System.Windows.Forms.TextBox();
            this.tabChangeLocationDetail = new System.Windows.Forms.TabPage();
            this.btnBackDetail = new System.Windows.Forms.Button();
            this.dgvChangeStatusDetail = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.cQuantity = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cItemStatus = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cUOM = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cReceiveDate = new System.Windows.Forms.DataGridTextBoxColumn();
            this.lblTitleHeaderDetail = new System.Windows.Forms.Label();
            this.tabChangeLocation.SuspendLayout();
            this.tabChangeLocationControl.SuspendLayout();
            this.tabChangeLocationDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChangeLocation
            // 
            this.tabChangeLocation.Controls.Add(this.tabChangeLocationControl);
            this.tabChangeLocation.Controls.Add(this.tabChangeLocationDetail);
            this.tabChangeLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabChangeLocation.Location = new System.Drawing.Point(0, 0);
            this.tabChangeLocation.Name = "tabChangeLocation";
            this.tabChangeLocation.SelectedIndex = 0;
            this.tabChangeLocation.Size = new System.Drawing.Size(242, 307);
            this.tabChangeLocation.TabIndex = 134;
            // 
            // tabChangeLocationControl
            // 
            this.tabChangeLocationControl.Controls.Add(this.txtToLocation);
            this.tabChangeLocationControl.Controls.Add(this.lblToLocation);
            this.tabChangeLocationControl.Controls.Add(this.txtLocation);
            this.tabChangeLocationControl.Controls.Add(this.txtDescription);
            this.tabChangeLocationControl.Controls.Add(this.lblDescription);
            this.tabChangeLocationControl.Controls.Add(this.btnBack);
            this.tabChangeLocationControl.Controls.Add(this.btnSave);
            this.tabChangeLocationControl.Controls.Add(this.cmbItemStatus);
            this.tabChangeLocationControl.Controls.Add(this.lblItemStatus);
            this.tabChangeLocationControl.Controls.Add(this.txtQuantity);
            this.tabChangeLocationControl.Controls.Add(this.lblQuantity);
            this.tabChangeLocationControl.Controls.Add(this.dtpExpiryDate);
            this.tabChangeLocationControl.Controls.Add(this.lblExpiryDate);
            this.tabChangeLocationControl.Controls.Add(this.txtLotNumber);
            this.tabChangeLocationControl.Controls.Add(this.lblLotNumber);
            this.tabChangeLocationControl.Controls.Add(this.txtItemNumber);
            this.tabChangeLocationControl.Controls.Add(this.lblItemNumber);
            this.tabChangeLocationControl.Controls.Add(this.lblLocation);
            this.tabChangeLocationControl.Controls.Add(this.lblLPN);
            this.tabChangeLocationControl.Controls.Add(this.txtLPN);
            this.tabChangeLocationControl.Location = new System.Drawing.Point(4, 25);
            this.tabChangeLocationControl.Name = "tabChangeLocationControl";
            this.tabChangeLocationControl.Size = new System.Drawing.Size(234, 278);
            this.tabChangeLocationControl.Text = "Change Location";
            // 
            // txtToLocation
            // 
            this.txtToLocation.BackColor = System.Drawing.Color.White;
            this.txtToLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtToLocation.ForeColor = System.Drawing.Color.Black;
            this.txtToLocation.Location = new System.Drawing.Point(82, 211);
            this.txtToLocation.Name = "txtToLocation";
            this.txtToLocation.Size = new System.Drawing.Size(147, 18);
            this.txtToLocation.TabIndex = 18;
            this.txtToLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToLocation_KeyDown);
            // 
            // lblToLocation
            // 
            this.lblToLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblToLocation.Location = new System.Drawing.Point(6, 215);
            this.lblToLocation.Name = "lblToLocation";
            this.lblToLocation.Size = new System.Drawing.Size(75, 14);
            this.lblToLocation.Text = "To Location";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtLocation.ForeColor = System.Drawing.Color.Black;
            this.txtLocation.Location = new System.Drawing.Point(83, 26);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(147, 18);
            this.txtLocation.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(83, 66);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(147, 59);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblDescription.Location = new System.Drawing.Point(6, 69);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 13);
            this.lblDescription.Text = "Description";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnBack.Location = new System.Drawing.Point(86, 243);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 20);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "<- Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnSave.Location = new System.Drawing.Point(156, 243);
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
            this.cmbItemStatus.Location = new System.Drawing.Point(83, 168);
            this.cmbItemStatus.Name = "cmbItemStatus";
            this.cmbItemStatus.Size = new System.Drawing.Size(148, 18);
            this.cmbItemStatus.TabIndex = 6;
            // 
            // lblItemStatus
            // 
            this.lblItemStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemStatus.Location = new System.Drawing.Point(6, 171);
            this.lblItemStatus.Name = "lblItemStatus";
            this.lblItemStatus.Size = new System.Drawing.Size(75, 14);
            this.lblItemStatus.Text = "Item Status";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(83, 190);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(146, 18);
            this.txtQuantity.TabIndex = 7;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblQuantity.Location = new System.Drawing.Point(6, 192);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(75, 15);
            this.lblQuantity.Text = "Quantity";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.CustomFormat = "yyyy-MM-dd";
            this.dtpExpiryDate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(83, 147);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(146, 19);
            this.dtpExpiryDate.TabIndex = 5;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblExpiryDate.Location = new System.Drawing.Point(6, 151);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(71, 15);
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.BackColor = System.Drawing.Color.White;
            this.txtLotNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtLotNumber.ForeColor = System.Drawing.Color.Black;
            this.txtLotNumber.Location = new System.Drawing.Point(83, 127);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.Size = new System.Drawing.Size(146, 18);
            this.txtLotNumber.TabIndex = 4;
            // 
            // lblLotNumber
            // 
            this.lblLotNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLotNumber.Location = new System.Drawing.Point(6, 130);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(75, 14);
            this.lblLotNumber.Text = "Lot Number";
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.BackColor = System.Drawing.Color.White;
            this.txtItemNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtItemNumber.ForeColor = System.Drawing.Color.Black;
            this.txtItemNumber.Location = new System.Drawing.Point(83, 46);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(147, 18);
            this.txtItemNumber.TabIndex = 2;
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemNumber.Location = new System.Drawing.Point(6, 49);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(75, 14);
            this.lblItemNumber.Text = "Item Number";
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLocation.Location = new System.Drawing.Point(6, 29);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(75, 13);
            this.lblLocation.Text = "Location";
            // 
            // lblLPN
            // 
            this.lblLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLPN.Location = new System.Drawing.Point(6, 9);
            this.lblLPN.Name = "lblLPN";
            this.lblLPN.Size = new System.Drawing.Size(75, 13);
            this.lblLPN.Text = "LPN";
            // 
            // txtLPN
            // 
            this.txtLPN.BackColor = System.Drawing.Color.White;
            this.txtLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtLPN.ForeColor = System.Drawing.Color.Black;
            this.txtLPN.Location = new System.Drawing.Point(83, 6);
            this.txtLPN.Name = "txtLPN";
            this.txtLPN.Size = new System.Drawing.Size(147, 18);
            this.txtLPN.TabIndex = 0;
            this.txtLPN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLPN_KeyDown);
            // 
            // tabChangeLocationDetail
            // 
            this.tabChangeLocationDetail.Controls.Add(this.btnBackDetail);
            this.tabChangeLocationDetail.Controls.Add(this.dgvChangeStatusDetail);
            this.tabChangeLocationDetail.Controls.Add(this.lblTitleHeaderDetail);
            this.tabChangeLocationDetail.Location = new System.Drawing.Point(4, 25);
            this.tabChangeLocationDetail.Name = "tabChangeLocationDetail";
            this.tabChangeLocationDetail.Size = new System.Drawing.Size(234, 278);
            this.tabChangeLocationDetail.Text = "Change Loc. Detail";
            // 
            // btnBackDetail
            // 
            this.btnBackDetail.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnBackDetail.Location = new System.Drawing.Point(13, 245);
            this.btnBackDetail.Name = "btnBackDetail";
            this.btnBackDetail.Size = new System.Drawing.Size(208, 20);
            this.btnBackDetail.TabIndex = 17;
            this.btnBackDetail.Text = "<- Back";
            this.btnBackDetail.Click += new System.EventHandler(this.btnBackDetail_Click);
            // 
            // dgvChangeStatusDetail
            // 
            this.dgvChangeStatusDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvChangeStatusDetail.Location = new System.Drawing.Point(3, 24);
            this.dgvChangeStatusDetail.Name = "dgvChangeStatusDetail";
            this.dgvChangeStatusDetail.Size = new System.Drawing.Size(228, 215);
            this.dgvChangeStatusDetail.TabIndex = 2;
            this.dgvChangeStatusDetail.TableStyles.Add(this.dataGridTableStyle2);
            // 
            // dataGridTableStyle2
            // 
            this.dataGridTableStyle2.GridColumnStyles.Add(this.cQuantity);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.cItemStatus);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.cUOM);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.cReceiveDate);
            this.dataGridTableStyle2.MappingName = "Detail";
            // 
            // cQuantity
            // 
            this.cQuantity.Format = "";
            this.cQuantity.FormatInfo = null;
            this.cQuantity.HeaderText = "Quantity";
            this.cQuantity.MappingName = "Quantity";
            this.cQuantity.Width = 80;
            // 
            // cItemStatus
            // 
            this.cItemStatus.Format = "";
            this.cItemStatus.FormatInfo = null;
            this.cItemStatus.HeaderText = "Item Status";
            this.cItemStatus.MappingName = "ItemStatus";
            this.cItemStatus.Width = 80;
            // 
            // cUOM
            // 
            this.cUOM.Format = "";
            this.cUOM.FormatInfo = null;
            this.cUOM.HeaderText = "UOM";
            this.cUOM.MappingName = "UOM";
            this.cUOM.Width = 80;
            // 
            // cReceiveDate
            // 
            this.cReceiveDate.Format = "yyyy-MM-dd HH:mm";
            this.cReceiveDate.FormatInfo = null;
            this.cReceiveDate.HeaderText = "Receive Date";
            this.cReceiveDate.MappingName = "ReceiveDate";
            this.cReceiveDate.Width = 120;
            // 
            // lblTitleHeaderDetail
            // 
            this.lblTitleHeaderDetail.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTitleHeaderDetail.ForeColor = System.Drawing.Color.Black;
            this.lblTitleHeaderDetail.Location = new System.Drawing.Point(13, 7);
            this.lblTitleHeaderDetail.Name = "lblTitleHeaderDetail";
            this.lblTitleHeaderDetail.Size = new System.Drawing.Size(197, 14);
            this.lblTitleHeaderDetail.Text = "Change Status Detail";
            // 
            // frmChangeLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.tabChangeLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangeLocation";
            this.Text = "Change Status";
            this.Load += new System.EventHandler(this.frmChangeStatus_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmChangeStatus_KeyUp);
            this.tabChangeLocation.ResumeLayout(false);
            this.tabChangeLocationControl.ResumeLayout(false);
            this.tabChangeLocationDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabChangeLocation;
        private System.Windows.Forms.TabPage tabChangeLocationControl;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbItemStatus;
        private System.Windows.Forms.Label lblItemStatus;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.TextBox txtLotNumber;
        private System.Windows.Forms.Label lblLotNumber;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblLPN;
        private System.Windows.Forms.TextBox txtLPN;
        private System.Windows.Forms.TabPage tabChangeLocationDetail;
        private System.Windows.Forms.DataGrid dgvChangeStatusDetail;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
        private System.Windows.Forms.Label lblTitleHeaderDetail;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblToLocation;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnBackDetail;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantity;
        private System.Windows.Forms.DataGridTextBoxColumn cItemStatus;
        private System.Windows.Forms.DataGridTextBoxColumn cUOM;
        private System.Windows.Forms.DataGridTextBoxColumn cReceiveDate;
        private System.Windows.Forms.TextBox txtToLocation;
    }
}