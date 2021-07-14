namespace Calbee.WMS.UI.Forms.Receive
{
    partial class frmReceiveRawMaterial
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
            this.tabReceive = new System.Windows.Forms.TabControl();
            this.tabReceiveItem = new System.Windows.Forms.TabPage();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbUOM = new System.Windows.Forms.ComboBox();
            this.lblResultCounter = new System.Windows.Forms.Label();
            this.lblReceived = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dtpReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.lblReceiveDate = new System.Windows.Forms.Label();
            this.cmbItemStatus = new System.Windows.Forms.ComboBox();
            this.lblItemStatus = new System.Windows.Forms.Label();
            this.lblUOM = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblLotNumber = new System.Windows.Forms.Label();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.txtReceiveLPN = new System.Windows.Forms.TextBox();
            this.lblReceiveLPN = new System.Windows.Forms.Label();
            this.txtReceiveLocation = new System.Windows.Forms.TextBox();
            this.lblReceiveLocation = new System.Windows.Forms.Label();
            this.lblReceiveNumber = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.tabReceiveDetail = new System.Windows.Forms.TabPage();
            this.dgvReceiveProduction = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.cItemNumberProduction = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cDescriptionProduction = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cQuantityReceiveProduction = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cQuantityProduction = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cUOMProduction = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLocationProduction = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLPNProduction = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLotNumberProduction = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cExpiryDateProduction = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cItemStatusProduction = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cReceiveDateProduction = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cReceiveByProduction = new System.Windows.Forms.DataGridTextBoxColumn();
            this.brnRefresh = new System.Windows.Forms.Button();
            this.dgvReceiveDetail = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.cItemNumberDetail = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cDescriptionDetail = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cQuantityReceiveDetail = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cQuantityDetail = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cUOMDetail = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLocationDetail = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLPNDetail = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLotNumberDetail = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cExpiryDateDetail = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cItemStatusDetail = new System.Windows.Forms.DataGridTextBoxColumn();
            this.lblTitleHeaderDetail = new System.Windows.Forms.Label();
            this.cReceiveBy = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cRecevieDate = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cItemStatus = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cExpiryDate = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLotNumber = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLpn = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLocation = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cUom = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cQuantity = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cItemNumber = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cQuantityReceive = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dtpLotNumber = new System.Windows.Forms.DateTimePicker();
            this.txtReceiveNumber = new Calbee.WMS.UI.UserControls.AutoCompleteTextBox();
            this.tabReceive.SuspendLayout();
            this.tabReceiveItem.SuspendLayout();
            this.tabReceiveDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabReceive
            // 
            this.tabReceive.Controls.Add(this.tabReceiveItem);
            this.tabReceive.Controls.Add(this.tabReceiveDetail);
            this.tabReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReceive.Location = new System.Drawing.Point(0, 0);
            this.tabReceive.Name = "tabReceive";
            this.tabReceive.SelectedIndex = 0;
            this.tabReceive.Size = new System.Drawing.Size(242, 307);
            this.tabReceive.TabIndex = 133;
            this.tabReceive.SelectedIndexChanged += new System.EventHandler(this.tabReceive_SelectedIndexChanged);
            // 
            // tabReceiveItem
            // 
            this.tabReceiveItem.Controls.Add(this.dtpLotNumber);
            this.tabReceiveItem.Controls.Add(this.txtDescription);
            this.tabReceiveItem.Controls.Add(this.lblDescription);
            this.tabReceiveItem.Controls.Add(this.txtReceiveNumber);
            this.tabReceiveItem.Controls.Add(this.cmbUOM);
            this.tabReceiveItem.Controls.Add(this.lblResultCounter);
            this.tabReceiveItem.Controls.Add(this.lblReceived);
            this.tabReceiveItem.Controls.Add(this.btnBack);
            this.tabReceiveItem.Controls.Add(this.btnSave);
            this.tabReceiveItem.Controls.Add(this.btnNew);
            this.tabReceiveItem.Controls.Add(this.dtpReceiveDate);
            this.tabReceiveItem.Controls.Add(this.lblReceiveDate);
            this.tabReceiveItem.Controls.Add(this.cmbItemStatus);
            this.tabReceiveItem.Controls.Add(this.lblItemStatus);
            this.tabReceiveItem.Controls.Add(this.lblUOM);
            this.tabReceiveItem.Controls.Add(this.txtQuantity);
            this.tabReceiveItem.Controls.Add(this.lblQuantity);
            this.tabReceiveItem.Controls.Add(this.dtpExpiryDate);
            this.tabReceiveItem.Controls.Add(this.lblExpiryDate);
            this.tabReceiveItem.Controls.Add(this.lblLotNumber);
            this.tabReceiveItem.Controls.Add(this.txtItemNumber);
            this.tabReceiveItem.Controls.Add(this.lblItemNumber);
            this.tabReceiveItem.Controls.Add(this.txtReceiveLPN);
            this.tabReceiveItem.Controls.Add(this.lblReceiveLPN);
            this.tabReceiveItem.Controls.Add(this.txtReceiveLocation);
            this.tabReceiveItem.Controls.Add(this.lblReceiveLocation);
            this.tabReceiveItem.Controls.Add(this.lblReceiveNumber);
            this.tabReceiveItem.Controls.Add(this.lblOrderNumber);
            this.tabReceiveItem.Controls.Add(this.txtOrderNumber);
            this.tabReceiveItem.Location = new System.Drawing.Point(4, 25);
            this.tabReceiveItem.Name = "tabReceiveItem";
            this.tabReceiveItem.Size = new System.Drawing.Size(234, 278);
            this.tabReceiveItem.Text = "Receive Item";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(70, 122);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(160, 34);
            this.txtDescription.TabIndex = 85;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblDescription.Location = new System.Drawing.Point(3, 125);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(64, 13);
            this.lblDescription.Text = "Description";
            // 
            // cmbUOM
            // 
            this.cmbUOM.BackColor = System.Drawing.Color.White;
            this.cmbUOM.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.cmbUOM.ForeColor = System.Drawing.Color.Black;
            this.cmbUOM.Location = new System.Drawing.Point(159, 178);
            this.cmbUOM.Name = "cmbUOM";
            this.cmbUOM.Size = new System.Drawing.Size(74, 18);
            this.cmbUOM.TabIndex = 8;
            // 
            // lblResultCounter
            // 
            this.lblResultCounter.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblResultCounter.ForeColor = System.Drawing.Color.Red;
            this.lblResultCounter.Location = new System.Drawing.Point(126, 3);
            this.lblResultCounter.Name = "lblResultCounter";
            this.lblResultCounter.Size = new System.Drawing.Size(104, 13);
            this.lblResultCounter.Text = "xx.xxx/xx.xxx";
            this.lblResultCounter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblReceived
            // 
            this.lblReceived.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblReceived.Location = new System.Drawing.Point(63, 3);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(64, 13);
            this.lblReceived.Text = "Received : ";
            this.lblReceived.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnBack.Location = new System.Drawing.Point(80, 243);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 20);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "<- Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnSave.Location = new System.Drawing.Point(156, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 20);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save ->";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnNew.Location = new System.Drawing.Point(197, 41);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(33, 18);
            this.btnNew.TabIndex = 58;
            this.btnNew.Text = "NEW";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dtpReceiveDate
            // 
            this.dtpReceiveDate.CustomFormat = "dd-MM-yyyy";
            this.dtpReceiveDate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.dtpReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceiveDate.Location = new System.Drawing.Point(71, 220);
            this.dtpReceiveDate.Name = "dtpReceiveDate";
            this.dtpReceiveDate.Size = new System.Drawing.Size(161, 19);
            this.dtpReceiveDate.TabIndex = 10;
            // 
            // lblReceiveDate
            // 
            this.lblReceiveDate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblReceiveDate.Location = new System.Drawing.Point(3, 225);
            this.lblReceiveDate.Name = "lblReceiveDate";
            this.lblReceiveDate.Size = new System.Drawing.Size(64, 13);
            this.lblReceiveDate.Text = "Receive Date";
            // 
            // cmbItemStatus
            // 
            this.cmbItemStatus.BackColor = System.Drawing.Color.White;
            this.cmbItemStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.cmbItemStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbItemStatus.Location = new System.Drawing.Point(70, 199);
            this.cmbItemStatus.Name = "cmbItemStatus";
            this.cmbItemStatus.Size = new System.Drawing.Size(163, 18);
            this.cmbItemStatus.TabIndex = 9;
            // 
            // lblItemStatus
            // 
            this.lblItemStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemStatus.Location = new System.Drawing.Point(3, 202);
            this.lblItemStatus.Name = "lblItemStatus";
            this.lblItemStatus.Size = new System.Drawing.Size(64, 14);
            this.lblItemStatus.Text = "Item Status";
            // 
            // lblUOM
            // 
            this.lblUOM.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblUOM.Location = new System.Drawing.Point(133, 181);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(27, 13);
            this.lblUOM.Text = "UOM";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(70, 178);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(62, 18);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblQuantity.Location = new System.Drawing.Point(3, 181);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 15);
            this.lblQuantity.Text = "Quantity";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.CustomFormat = "dd-MM-yyyy";
            this.dtpExpiryDate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(161, 157);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(71, 19);
            this.dtpExpiryDate.TabIndex = 6;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblExpiryDate.Location = new System.Drawing.Point(140, 160);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(22, 15);
            this.lblExpiryDate.Text = "Exp.";
            // 
            // lblLotNumber
            // 
            this.lblLotNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLotNumber.Location = new System.Drawing.Point(3, 161);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(64, 14);
            this.lblLotNumber.Text = "Lot Number";
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.BackColor = System.Drawing.Color.White;
            this.txtItemNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtItemNumber.ForeColor = System.Drawing.Color.Black;
            this.txtItemNumber.Location = new System.Drawing.Point(70, 102);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(160, 18);
            this.txtItemNumber.TabIndex = 4;
            this.txtItemNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemNumber_KeyDown);
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemNumber.Location = new System.Drawing.Point(3, 105);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(64, 14);
            this.lblItemNumber.Text = "Item Number";
            // 
            // txtReceiveLPN
            // 
            this.txtReceiveLPN.BackColor = System.Drawing.Color.White;
            this.txtReceiveLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtReceiveLPN.ForeColor = System.Drawing.Color.Black;
            this.txtReceiveLPN.Location = new System.Drawing.Point(70, 82);
            this.txtReceiveLPN.Name = "txtReceiveLPN";
            this.txtReceiveLPN.Size = new System.Drawing.Size(160, 18);
            this.txtReceiveLPN.TabIndex = 3;
            this.txtReceiveLPN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceiveLPN_KeyDown);
            // 
            // lblReceiveLPN
            // 
            this.lblReceiveLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblReceiveLPN.Location = new System.Drawing.Point(3, 85);
            this.lblReceiveLPN.Name = "lblReceiveLPN";
            this.lblReceiveLPN.Size = new System.Drawing.Size(64, 13);
            this.lblReceiveLPN.Text = "Receive LPN";
            // 
            // txtReceiveLocation
            // 
            this.txtReceiveLocation.BackColor = System.Drawing.Color.White;
            this.txtReceiveLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtReceiveLocation.ForeColor = System.Drawing.Color.Black;
            this.txtReceiveLocation.Location = new System.Drawing.Point(70, 62);
            this.txtReceiveLocation.Name = "txtReceiveLocation";
            this.txtReceiveLocation.Size = new System.Drawing.Size(160, 18);
            this.txtReceiveLocation.TabIndex = 2;
            this.txtReceiveLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceiveLocation_KeyDown);
            // 
            // lblReceiveLocation
            // 
            this.lblReceiveLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblReceiveLocation.Location = new System.Drawing.Point(3, 65);
            this.lblReceiveLocation.Name = "lblReceiveLocation";
            this.lblReceiveLocation.Size = new System.Drawing.Size(64, 14);
            this.lblReceiveLocation.Text = "Rec. Location";
            // 
            // lblReceiveNumber
            // 
            this.lblReceiveNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblReceiveNumber.Location = new System.Drawing.Point(3, 44);
            this.lblReceiveNumber.Name = "lblReceiveNumber";
            this.lblReceiveNumber.Size = new System.Drawing.Size(64, 13);
            this.lblReceiveNumber.Text = "Rec. Number";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblOrderNumber.Location = new System.Drawing.Point(3, 24);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(64, 13);
            this.lblOrderNumber.Text = "Order Number";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.BackColor = System.Drawing.Color.White;
            this.txtOrderNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtOrderNumber.ForeColor = System.Drawing.Color.Black;
            this.txtOrderNumber.Location = new System.Drawing.Point(70, 21);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(160, 18);
            this.txtOrderNumber.TabIndex = 0;
            this.txtOrderNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrderNumber_KeyDown);
            // 
            // tabReceiveDetail
            // 
            this.tabReceiveDetail.Controls.Add(this.dgvReceiveProduction);
            this.tabReceiveDetail.Controls.Add(this.brnRefresh);
            this.tabReceiveDetail.Controls.Add(this.dgvReceiveDetail);
            this.tabReceiveDetail.Controls.Add(this.lblTitleHeaderDetail);
            this.tabReceiveDetail.Location = new System.Drawing.Point(4, 25);
            this.tabReceiveDetail.Name = "tabReceiveDetail";
            this.tabReceiveDetail.Size = new System.Drawing.Size(234, 278);
            this.tabReceiveDetail.Text = "Receive Detail";
            // 
            // dgvReceiveProduction
            // 
            this.dgvReceiveProduction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvReceiveProduction.Location = new System.Drawing.Point(3, 51);
            this.dgvReceiveProduction.Name = "dgvReceiveProduction";
            this.dgvReceiveProduction.RowHeadersVisible = false;
            this.dgvReceiveProduction.Size = new System.Drawing.Size(228, 199);
            this.dgvReceiveProduction.TabIndex = 15;
            this.dgvReceiveProduction.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cItemNumberProduction);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cDescriptionProduction);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cQuantityReceiveProduction);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cQuantityProduction);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cUOMProduction);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cLocationProduction);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cLPNProduction);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cLotNumberProduction);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cExpiryDateProduction);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cItemStatusProduction);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cReceiveDateProduction);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cReceiveByProduction);
            this.dataGridTableStyle1.MappingName = "Production";
            // 
            // cItemNumberProduction
            // 
            this.cItemNumberProduction.Format = "";
            this.cItemNumberProduction.HeaderText = "Item Number";
            this.cItemNumberProduction.MappingName = "ItemNumber";
            this.cItemNumberProduction.Width = 80;
            // 
            // cDescriptionProduction
            // 
            this.cDescriptionProduction.Format = "";
            this.cDescriptionProduction.HeaderText = "Description";
            this.cDescriptionProduction.MappingName = "ItemName";
            this.cDescriptionProduction.Width = 200;
            // 
            // cQuantityReceiveProduction
            // 
            this.cQuantityReceiveProduction.Format = "";
            this.cQuantityReceiveProduction.HeaderText = "QuantityReceive";
            this.cQuantityReceiveProduction.MappingName = "QuantityReceive";
            this.cQuantityReceiveProduction.Width = 70;
            // 
            // cQuantityProduction
            // 
            this.cQuantityProduction.Format = "";
            this.cQuantityProduction.HeaderText = "Quantity";
            this.cQuantityProduction.MappingName = "Quantity";
            // 
            // cUOMProduction
            // 
            this.cUOMProduction.Format = "";
            this.cUOMProduction.HeaderText = "UOM";
            this.cUOMProduction.MappingName = "Uom";
            // 
            // cLocationProduction
            // 
            this.cLocationProduction.Format = "";
            this.cLocationProduction.HeaderText = "Location";
            this.cLocationProduction.MappingName = "Location";
            this.cLocationProduction.Width = 80;
            // 
            // cLPNProduction
            // 
            this.cLPNProduction.Format = "";
            this.cLPNProduction.HeaderText = "LPN";
            this.cLPNProduction.MappingName = "Lpn";
            this.cLPNProduction.Width = 70;
            // 
            // cLotNumberProduction
            // 
            this.cLotNumberProduction.Format = "";
            this.cLotNumberProduction.HeaderText = "Lot Number";
            this.cLotNumberProduction.MappingName = "LotNumber";
            this.cLotNumberProduction.Width = 80;
            // 
            // cExpiryDateProduction
            // 
            this.cExpiryDateProduction.Format = "yyyy-MM-dd HH:mm";
            this.cExpiryDateProduction.HeaderText = "Expiry Date";
            this.cExpiryDateProduction.MappingName = "ExpiryDate";
            this.cExpiryDateProduction.Width = 120;
            // 
            // cItemStatusProduction
            // 
            this.cItemStatusProduction.Format = "";
            this.cItemStatusProduction.HeaderText = "Item Status";
            this.cItemStatusProduction.MappingName = "LpnStatus";
            this.cItemStatusProduction.Width = 60;
            // 
            // cReceiveDateProduction
            // 
            this.cReceiveDateProduction.Format = "yyyy-MM-dd HH:mm";
            this.cReceiveDateProduction.HeaderText = "Receive Date";
            this.cReceiveDateProduction.MappingName = "ReceiveDate";
            this.cReceiveDateProduction.Width = 120;
            // 
            // cReceiveByProduction
            // 
            this.cReceiveByProduction.Format = "";
            this.cReceiveByProduction.HeaderText = "Receive By";
            this.cReceiveByProduction.MappingName = "ReceiveBy";
            this.cReceiveByProduction.Width = 80;
            // 
            // brnRefresh
            // 
            this.brnRefresh.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.brnRefresh.Location = new System.Drawing.Point(154, 25);
            this.brnRefresh.Name = "brnRefresh";
            this.brnRefresh.Size = new System.Drawing.Size(70, 20);
            this.brnRefresh.TabIndex = 13;
            this.brnRefresh.Text = "Refresh";
            this.brnRefresh.Click += new System.EventHandler(this.brnRefresh_Click);
            // 
            // dgvReceiveDetail
            // 
            this.dgvReceiveDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvReceiveDetail.Location = new System.Drawing.Point(3, 51);
            this.dgvReceiveDetail.Name = "dgvReceiveDetail";
            this.dgvReceiveDetail.Size = new System.Drawing.Size(228, 199);
            this.dgvReceiveDetail.TabIndex = 2;
            this.dgvReceiveDetail.TableStyles.Add(this.dataGridTableStyle2);
            // 
            // dataGridTableStyle2
            // 
            this.dataGridTableStyle2.GridColumnStyles.Add(this.cItemNumberDetail);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.cDescriptionDetail);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.cQuantityReceiveDetail);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.cQuantityDetail);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.cUOMDetail);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.cLocationDetail);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.cLPNDetail);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.cLotNumberDetail);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.cExpiryDateDetail);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.cItemStatusDetail);
            this.dataGridTableStyle2.MappingName = "Detail";
            // 
            // cItemNumberDetail
            // 
            this.cItemNumberDetail.Format = "";
            this.cItemNumberDetail.HeaderText = "Item Number";
            this.cItemNumberDetail.MappingName = "ItemNumber";
            this.cItemNumberDetail.Width = 80;
            // 
            // cDescriptionDetail
            // 
            this.cDescriptionDetail.Format = "";
            this.cDescriptionDetail.HeaderText = "Description";
            this.cDescriptionDetail.MappingName = "ItemName";
            this.cDescriptionDetail.Width = 200;
            // 
            // cQuantityReceiveDetail
            // 
            this.cQuantityReceiveDetail.Format = "";
            this.cQuantityReceiveDetail.HeaderText = "QuantityReceive";
            this.cQuantityReceiveDetail.MappingName = "QuantityReceive";
            this.cQuantityReceiveDetail.Width = 70;
            // 
            // cQuantityDetail
            // 
            this.cQuantityDetail.Format = "";
            this.cQuantityDetail.HeaderText = "Quantity";
            this.cQuantityDetail.MappingName = "QuantityOrder";
            // 
            // cUOMDetail
            // 
            this.cUOMDetail.Format = "";
            this.cUOMDetail.HeaderText = "UOM";
            this.cUOMDetail.MappingName = "Uom";
            // 
            // cLocationDetail
            // 
            this.cLocationDetail.Format = "";
            this.cLocationDetail.HeaderText = "Location";
            this.cLocationDetail.MappingName = "DefaultLocation";
            this.cLocationDetail.Width = 80;
            // 
            // cLPNDetail
            // 
            this.cLPNDetail.Format = "";
            this.cLPNDetail.HeaderText = "LPN";
            this.cLPNDetail.MappingName = "DefaultLPN";
            this.cLPNDetail.Width = 70;
            // 
            // cLotNumberDetail
            // 
            this.cLotNumberDetail.Format = "";
            this.cLotNumberDetail.HeaderText = "Lot Number";
            this.cLotNumberDetail.MappingName = "DefaultLotNumber";
            this.cLotNumberDetail.Width = 60;
            // 
            // cExpiryDateDetail
            // 
            this.cExpiryDateDetail.Format = "yyyy-MM-dd HH:mm";
            this.cExpiryDateDetail.HeaderText = "Expiry Date";
            this.cExpiryDateDetail.MappingName = "ExpiryDate";
            this.cExpiryDateDetail.Width = 120;
            // 
            // cItemStatusDetail
            // 
            this.cItemStatusDetail.Format = "";
            this.cItemStatusDetail.HeaderText = "Item Status";
            this.cItemStatusDetail.MappingName = "ItemStatus";
            this.cItemStatusDetail.Width = 80;
            // 
            // lblTitleHeaderDetail
            // 
            this.lblTitleHeaderDetail.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTitleHeaderDetail.ForeColor = System.Drawing.Color.Black;
            this.lblTitleHeaderDetail.Location = new System.Drawing.Point(13, 7);
            this.lblTitleHeaderDetail.Name = "lblTitleHeaderDetail";
            this.lblTitleHeaderDetail.Size = new System.Drawing.Size(197, 14);
            this.lblTitleHeaderDetail.Text = "Receive Detail";
            // 
            // cReceiveBy
            // 
            this.cReceiveBy.Format = "";
            this.cReceiveBy.HeaderText = "Receive By";
            this.cReceiveBy.MappingName = "ReceiveBy";
            // 
            // cRecevieDate
            // 
            this.cRecevieDate.Format = "";
            this.cRecevieDate.HeaderText = "Recevie Date";
            this.cRecevieDate.MappingName = "RecevieDate";
            this.cRecevieDate.Width = 120;
            // 
            // cItemStatus
            // 
            this.cItemStatus.Format = "";
            this.cItemStatus.HeaderText = "Item Status";
            this.cItemStatus.MappingName = "ItemStatus";
            // 
            // cExpiryDate
            // 
            this.cExpiryDate.Format = "";
            this.cExpiryDate.HeaderText = "Expiry Date";
            this.cExpiryDate.MappingName = "ExpiryDate";
            this.cExpiryDate.Width = 120;
            // 
            // cLotNumber
            // 
            this.cLotNumber.Format = "";
            this.cLotNumber.HeaderText = "Lot Number";
            this.cLotNumber.MappingName = "LotNumber";
            this.cLotNumber.Width = 70;
            // 
            // cLpn
            // 
            this.cLpn.Format = "";
            this.cLpn.HeaderText = "LPN";
            this.cLpn.MappingName = "Lpn";
            // 
            // cLocation
            // 
            this.cLocation.Format = "";
            this.cLocation.HeaderText = "Location";
            this.cLocation.MappingName = "Location";
            // 
            // cUom
            // 
            this.cUom.Format = "";
            this.cUom.HeaderText = "UOM";
            this.cUom.MappingName = "Uom";
            // 
            // cQuantity
            // 
            this.cQuantity.Format = "";
            this.cQuantity.HeaderText = "Quantity";
            this.cQuantity.MappingName = "Quantity";
            // 
            // cDescription
            // 
            this.cDescription.Format = "";
            this.cDescription.HeaderText = "Description";
            this.cDescription.MappingName = "ItemName";
            this.cDescription.Width = 300;
            // 
            // cItemNumber
            // 
            this.cItemNumber.Format = "";
            this.cItemNumber.HeaderText = "Item Number";
            this.cItemNumber.MappingName = "ItemNumber";
            this.cItemNumber.Width = 60;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            // 
            // cQuantityReceive
            // 
            this.cQuantityReceive.Format = "";
            // 
            // dtpLotNumber
            // 
            this.dtpLotNumber.CustomFormat = "dd-MM-yyyy";
            this.dtpLotNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.dtpLotNumber.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLotNumber.Location = new System.Drawing.Point(70, 157);
            this.dtpLotNumber.Name = "dtpLotNumber";
            this.dtpLotNumber.Size = new System.Drawing.Size(70, 19);
            this.dtpLotNumber.TabIndex = 100;
            // 
            // txtReceiveNumber
            // 
            this.txtReceiveNumber.BackColor = System.Drawing.Color.White;
            this.txtReceiveNumber.ForeColor = System.Drawing.Color.Black;
            this.txtReceiveNumber.Location = new System.Drawing.Point(70, 41);
            this.txtReceiveNumber.Name = "txtReceiveNumber";
            this.txtReceiveNumber.Size = new System.Drawing.Size(125, 18);
            this.txtReceiveNumber.TabIndex = 70;
            this.txtReceiveNumber.SelectedIndexChangeds += new System.EventHandler(this.txtReceiveNumber_SelectedIndexChangeds);
            this.txtReceiveNumber.KeyDowns += new System.Windows.Forms.KeyEventHandler(this.txtReceiveNumber_KeyDowns);
            // 
            // frmReceiveRawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.tabReceive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReceiveRawMaterial";
            this.Text = "Receive RawMaterial";
            this.Load += new System.EventHandler(this.frmReceive_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmReceive_KeyUp);
            this.tabReceive.ResumeLayout(false);
            this.tabReceiveItem.ResumeLayout(false);
            this.tabReceiveDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReceive;
        private System.Windows.Forms.TabPage tabReceiveDetail;
        private System.Windows.Forms.Label lblTitleHeaderDetail;
        private System.Windows.Forms.DataGrid dgvReceiveDetail;
        private System.Windows.Forms.TabPage tabReceiveItem;
        private System.Windows.Forms.Label lblResultCounter;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DateTimePicker dtpReceiveDate;
        private System.Windows.Forms.Label lblReceiveDate;
        private System.Windows.Forms.ComboBox cmbItemStatus;
        private System.Windows.Forms.Label lblItemStatus;
        private System.Windows.Forms.Label lblUOM;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblLotNumber;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.TextBox txtReceiveLPN;
        private System.Windows.Forms.Label lblReceiveLPN;
        private System.Windows.Forms.TextBox txtReceiveLocation;
        private System.Windows.Forms.Label lblReceiveLocation;
        private System.Windows.Forms.Label lblReceiveNumber;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.ComboBox cmbUOM;
        private System.Windows.Forms.Button brnRefresh;
        private System.Windows.Forms.DataGridTextBoxColumn cReceiveBy;
        private System.Windows.Forms.DataGridTextBoxColumn cRecevieDate;
        private System.Windows.Forms.DataGridTextBoxColumn cItemStatus;
        private System.Windows.Forms.DataGridTextBoxColumn cExpiryDate;
        private System.Windows.Forms.DataGridTextBoxColumn cLotNumber;
        private System.Windows.Forms.DataGridTextBoxColumn cLpn;
        private System.Windows.Forms.DataGridTextBoxColumn cLocation;
        private System.Windows.Forms.DataGridTextBoxColumn cUom;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantity;
        private System.Windows.Forms.DataGridTextBoxColumn cDescription;
        private System.Windows.Forms.DataGridTextBoxColumn cItemNumber;
        private System.Windows.Forms.DataGrid dgvReceiveProduction;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn cItemNumberProduction;
        private System.Windows.Forms.DataGridTextBoxColumn cDescriptionProduction;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantityProduction;
        private System.Windows.Forms.DataGridTextBoxColumn cUOMProduction;
        private System.Windows.Forms.DataGridTextBoxColumn cLocationProduction;
        private System.Windows.Forms.DataGridTextBoxColumn cLPNProduction;
        private System.Windows.Forms.DataGridTextBoxColumn cLotNumberProduction;
        private System.Windows.Forms.DataGridTextBoxColumn cExpiryDateProduction;
        private System.Windows.Forms.DataGridTextBoxColumn cItemStatusProduction;
        private System.Windows.Forms.DataGridTextBoxColumn cReceiveDateProduction;
        private System.Windows.Forms.DataGridTextBoxColumn cReceiveByProduction;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
        private System.Windows.Forms.DataGridTextBoxColumn cItemNumberDetail;
        private System.Windows.Forms.DataGridTextBoxColumn cDescriptionDetail;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantityDetail;
        private System.Windows.Forms.DataGridTextBoxColumn cUOMDetail;
        private System.Windows.Forms.DataGridTextBoxColumn cLocationDetail;
        private System.Windows.Forms.DataGridTextBoxColumn cLPNDetail;
        private System.Windows.Forms.DataGridTextBoxColumn cLotNumberDetail;
        private System.Windows.Forms.DataGridTextBoxColumn cExpiryDateDetail;
        private System.Windows.Forms.DataGridTextBoxColumn cItemStatusDetail;
        private Calbee.WMS.UI.UserControls.AutoCompleteTextBox txtReceiveNumber;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantityReceiveProduction;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantityReceiveDetail;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantityReceive;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dtpLotNumber;
    }
}