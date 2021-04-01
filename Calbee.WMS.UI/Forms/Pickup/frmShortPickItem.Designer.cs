namespace Calbee.WMS.UI.Forms.Pickup
{
    partial class frmShortPickItem
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLPN = new System.Windows.Forms.Label();
            this.txtLPN = new System.Windows.Forms.TextBox();
            this.lblSTGLocation = new System.Windows.Forms.Label();
            this.txtSTGLocation = new System.Windows.Forms.TextBox();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblLotNumber = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblUOM = new System.Windows.Forms.Label();
            this.lblToLPN = new System.Windows.Forms.Label();
            this.txtToLPN = new System.Windows.Forms.TextBox();
            this.lblItemStatus = new System.Windows.Forms.Label();
            this.txtItemStatus = new System.Windows.Forms.TextBox();
            this.cmbUOM = new System.Windows.Forms.ComboBox();
            this.lblResultCounter = new System.Windows.Forms.Label();
            this.lblReceived = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabShortPick = new System.Windows.Forms.TabPage();
            this.txtCarLicense = new System.Windows.Forms.TextBox();
            this.lblTruckNo = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtExpiryDate = new Calbee.WMS.UI.UserControls.AutoCompleteTextBox();
            this.txtLotNumber = new Calbee.WMS.UI.UserControls.AutoCompleteTextBox();
            this.txtItemNumber = new Calbee.WMS.UI.UserControls.AutoCompleteTextBox();
            this.tabShortPickDetail = new System.Windows.Forms.TabPage();
            this.lblResultPickQty = new System.Windows.Forms.Label();
            this.lblPickQty = new System.Windows.Forms.Label();
            this.btnBackDetail = new System.Windows.Forms.Button();
            this.lblPickingListRefresh = new System.Windows.Forms.Label();
            this.txtPickingListRefresh = new System.Windows.Forms.TextBox();
            this.brnRefresh = new System.Windows.Forms.Button();
            this.dgvPickItem = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.cPickStatus = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLPN = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cItemNumber = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cItemName = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLotNumber = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cExpiryDate = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cQuantityPlan = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cQuantityPick = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cUOM = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLocationPlan = new System.Windows.Forms.DataGridTextBoxColumn();
            this.lblTitleHeaderDetail = new System.Windows.Forms.Label();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabShortPick.SuspendLayout();
            this.tabShortPickDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPickingListNo
            // 
            this.lblPickingListNo.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblPickingListNo.Location = new System.Drawing.Point(2, 22);
            this.lblPickingListNo.Name = "lblPickingListNo";
            this.lblPickingListNo.Size = new System.Drawing.Size(67, 13);
            this.lblPickingListNo.Text = "Picking List No";
            // 
            // txtPickingListNo
            // 
            this.txtPickingListNo.BackColor = System.Drawing.Color.White;
            this.txtPickingListNo.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtPickingListNo.ForeColor = System.Drawing.Color.Black;
            this.txtPickingListNo.Location = new System.Drawing.Point(70, 19);
            this.txtPickingListNo.Name = "txtPickingListNo";
            this.txtPickingListNo.Size = new System.Drawing.Size(161, 18);
            this.txtPickingListNo.TabIndex = 0;
            this.txtPickingListNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPickingListNo_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnBack.Location = new System.Drawing.Point(70, 230);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 20);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "<- Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnSave.Location = new System.Drawing.Point(148, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 20);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save ->";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLPN
            // 
            this.lblLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLPN.Location = new System.Drawing.Point(2, 60);
            this.lblLPN.Name = "lblLPN";
            this.lblLPN.Size = new System.Drawing.Size(66, 13);
            this.lblLPN.Text = "LPN";
            // 
            // txtLPN
            // 
            this.txtLPN.BackColor = System.Drawing.Color.White;
            this.txtLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtLPN.ForeColor = System.Drawing.Color.Black;
            this.txtLPN.Location = new System.Drawing.Point(70, 57);
            this.txtLPN.Name = "txtLPN";
            this.txtLPN.Size = new System.Drawing.Size(161, 18);
            this.txtLPN.TabIndex = 2;
            this.txtLPN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLPN_KeyDown);
            // 
            // lblSTGLocation
            // 
            this.lblSTGLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblSTGLocation.Location = new System.Drawing.Point(2, 40);
            this.lblSTGLocation.Name = "lblSTGLocation";
            this.lblSTGLocation.Size = new System.Drawing.Size(67, 13);
            this.lblSTGLocation.Text = "STG Location";
            // 
            // txtSTGLocation
            // 
            this.txtSTGLocation.BackColor = System.Drawing.Color.White;
            this.txtSTGLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtSTGLocation.ForeColor = System.Drawing.Color.Black;
            this.txtSTGLocation.Location = new System.Drawing.Point(70, 38);
            this.txtSTGLocation.Name = "txtSTGLocation";
            this.txtSTGLocation.Size = new System.Drawing.Size(161, 18);
            this.txtSTGLocation.TabIndex = 1;
            this.txtSTGLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSTGLocation_KeyDown);
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemNumber.Location = new System.Drawing.Point(2, 78);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(67, 13);
            this.lblItemNumber.Text = "Item Number";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblExpiryDate.Location = new System.Drawing.Point(2, 152);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(66, 13);
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // lblLotNumber
            // 
            this.lblLotNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLotNumber.Location = new System.Drawing.Point(2, 134);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(67, 13);
            this.lblLotNumber.Text = "Lot Number";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblQuantity.Location = new System.Drawing.Point(2, 172);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(66, 13);
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(70, 169);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(61, 18);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // lblUOM
            // 
            this.lblUOM.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblUOM.Location = new System.Drawing.Point(132, 173);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(25, 11);
            this.lblUOM.Text = "UOM";
            // 
            // lblToLPN
            // 
            this.lblToLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblToLPN.Location = new System.Drawing.Point(3, 211);
            this.lblToLPN.Name = "lblToLPN";
            this.lblToLPN.Size = new System.Drawing.Size(34, 13);
            this.lblToLPN.Text = "To LPN";
            // 
            // txtToLPN
            // 
            this.txtToLPN.BackColor = System.Drawing.Color.White;
            this.txtToLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtToLPN.ForeColor = System.Drawing.Color.Black;
            this.txtToLPN.Location = new System.Drawing.Point(70, 210);
            this.txtToLPN.Name = "txtToLPN";
            this.txtToLPN.Size = new System.Drawing.Size(161, 18);
            this.txtToLPN.TabIndex = 11;
            // 
            // lblItemStatus
            // 
            this.lblItemStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemStatus.Location = new System.Drawing.Point(2, 194);
            this.lblItemStatus.Name = "lblItemStatus";
            this.lblItemStatus.Size = new System.Drawing.Size(67, 13);
            this.lblItemStatus.Text = "Item Status";
            // 
            // txtItemStatus
            // 
            this.txtItemStatus.BackColor = System.Drawing.Color.White;
            this.txtItemStatus.Enabled = false;
            this.txtItemStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtItemStatus.ForeColor = System.Drawing.Color.Black;
            this.txtItemStatus.Location = new System.Drawing.Point(70, 191);
            this.txtItemStatus.Name = "txtItemStatus";
            this.txtItemStatus.Size = new System.Drawing.Size(61, 18);
            this.txtItemStatus.TabIndex = 9;
            // 
            // cmbUOM
            // 
            this.cmbUOM.BackColor = System.Drawing.Color.White;
            this.cmbUOM.Enabled = false;
            this.cmbUOM.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.cmbUOM.ForeColor = System.Drawing.Color.Black;
            this.cmbUOM.Location = new System.Drawing.Point(158, 169);
            this.cmbUOM.Name = "cmbUOM";
            this.cmbUOM.Size = new System.Drawing.Size(73, 18);
            this.cmbUOM.TabIndex = 8;
            // 
            // lblResultCounter
            // 
            this.lblResultCounter.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblResultCounter.ForeColor = System.Drawing.Color.Red;
            this.lblResultCounter.Location = new System.Drawing.Point(123, 3);
            this.lblResultCounter.Name = "lblResultCounter";
            this.lblResultCounter.Size = new System.Drawing.Size(107, 13);
            this.lblResultCounter.Text = "xx.xxx/xx.xxx";
            this.lblResultCounter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblReceived
            // 
            this.lblReceived.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblReceived.Location = new System.Drawing.Point(64, 3);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(59, 13);
            this.lblReceived.Text = "Picked : ";
            this.lblReceived.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabShortPick);
            this.tabControl1.Controls.Add(this.tabShortPickDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(242, 307);
            this.tabControl1.TabIndex = 19;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabShortPick
            // 
            this.tabShortPick.Controls.Add(this.txtCarLicense);
            this.tabShortPick.Controls.Add(this.lblTruckNo);
            this.tabShortPick.Controls.Add(this.txtDescription);
            this.tabShortPick.Controls.Add(this.lblDescription);
            this.tabShortPick.Controls.Add(this.lblPickingListNo);
            this.tabShortPick.Controls.Add(this.lblResultCounter);
            this.tabShortPick.Controls.Add(this.txtSTGLocation);
            this.tabShortPick.Controls.Add(this.lblReceived);
            this.tabShortPick.Controls.Add(this.lblSTGLocation);
            this.tabShortPick.Controls.Add(this.txtExpiryDate);
            this.tabShortPick.Controls.Add(this.txtLPN);
            this.tabShortPick.Controls.Add(this.txtLotNumber);
            this.tabShortPick.Controls.Add(this.lblLPN);
            this.tabShortPick.Controls.Add(this.txtItemNumber);
            this.tabShortPick.Controls.Add(this.btnSave);
            this.tabShortPick.Controls.Add(this.cmbUOM);
            this.tabShortPick.Controls.Add(this.btnBack);
            this.tabShortPick.Controls.Add(this.lblUOM);
            this.tabShortPick.Controls.Add(this.txtPickingListNo);
            this.tabShortPick.Controls.Add(this.lblToLPN);
            this.tabShortPick.Controls.Add(this.lblLotNumber);
            this.tabShortPick.Controls.Add(this.txtToLPN);
            this.tabShortPick.Controls.Add(this.lblExpiryDate);
            this.tabShortPick.Controls.Add(this.lblItemStatus);
            this.tabShortPick.Controls.Add(this.lblItemNumber);
            this.tabShortPick.Controls.Add(this.txtItemStatus);
            this.tabShortPick.Controls.Add(this.txtQuantity);
            this.tabShortPick.Controls.Add(this.lblQuantity);
            this.tabShortPick.Location = new System.Drawing.Point(4, 25);
            this.tabShortPick.Name = "tabShortPick";
            this.tabShortPick.Size = new System.Drawing.Size(234, 278);
            this.tabShortPick.Text = "Short Pick";
            // 
            // txtCarLicense
            // 
            this.txtCarLicense.BackColor = System.Drawing.Color.White;
            this.txtCarLicense.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtCarLicense.ForeColor = System.Drawing.Color.Black;
            this.txtCarLicense.Location = new System.Drawing.Point(159, 191);
            this.txtCarLicense.Name = "txtCarLicense";
            this.txtCarLicense.Size = new System.Drawing.Size(72, 18);
            this.txtCarLicense.TabIndex = 10;
            // 
            // lblTruckNo
            // 
            this.lblTruckNo.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblTruckNo.Location = new System.Drawing.Point(134, 195);
            this.lblTruckNo.Name = "lblTruckNo";
            this.lblTruckNo.Size = new System.Drawing.Size(22, 12);
            this.lblTruckNo.Text = "Car.";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(70, 96);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(161, 34);
            this.txtDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblDescription.Location = new System.Drawing.Point(2, 99);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.Text = "Description";
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.BackColor = System.Drawing.Color.White;
            this.txtExpiryDate.ForeColor = System.Drawing.Color.Black;
            this.txtExpiryDate.Location = new System.Drawing.Point(70, 150);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.SelectedIndex = -1;
            this.txtExpiryDate.Size = new System.Drawing.Size(161, 18);
            this.txtExpiryDate.TabIndex = 6;
            this.txtExpiryDate.SelectedIndexChangeds += new System.EventHandler(this.txtExpiryDate_SelectedIndexChangeds);
            this.txtExpiryDate.KeyDowns += new System.Windows.Forms.KeyEventHandler(this.txtExpiryDate_KeyDowns);
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.BackColor = System.Drawing.Color.White;
            this.txtLotNumber.ForeColor = System.Drawing.Color.Black;
            this.txtLotNumber.Location = new System.Drawing.Point(70, 131);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.SelectedIndex = -1;
            this.txtLotNumber.Size = new System.Drawing.Size(161, 18);
            this.txtLotNumber.TabIndex = 5;
            this.txtLotNumber.SelectedIndexChangeds += new System.EventHandler(this.txtLotNumber_SelectedIndexChangeds);
            this.txtLotNumber.KeyDowns += new System.Windows.Forms.KeyEventHandler(this.txtLotNumber_KeyDowns);
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.BackColor = System.Drawing.Color.White;
            this.txtItemNumber.ForeColor = System.Drawing.Color.Black;
            this.txtItemNumber.Location = new System.Drawing.Point(70, 76);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.SelectedIndex = -1;
            this.txtItemNumber.Size = new System.Drawing.Size(161, 18);
            this.txtItemNumber.TabIndex = 3;
            this.txtItemNumber.SelectedIndexChangeds += new System.EventHandler(this.txtItemNumber_SelectedIndexChangeds);
            this.txtItemNumber.KeyDowns += new System.Windows.Forms.KeyEventHandler(this.txtItemNumber_KeyDowns);
            // 
            // tabShortPickDetail
            // 
            this.tabShortPickDetail.Controls.Add(this.lblResultPickQty);
            this.tabShortPickDetail.Controls.Add(this.lblPickQty);
            this.tabShortPickDetail.Controls.Add(this.btnBackDetail);
            this.tabShortPickDetail.Controls.Add(this.lblPickingListRefresh);
            this.tabShortPickDetail.Controls.Add(this.txtPickingListRefresh);
            this.tabShortPickDetail.Controls.Add(this.brnRefresh);
            this.tabShortPickDetail.Controls.Add(this.dgvPickItem);
            this.tabShortPickDetail.Controls.Add(this.lblTitleHeaderDetail);
            this.tabShortPickDetail.Location = new System.Drawing.Point(4, 25);
            this.tabShortPickDetail.Name = "tabShortPickDetail";
            this.tabShortPickDetail.Size = new System.Drawing.Size(234, 278);
            this.tabShortPickDetail.Text = "Short Pick Detail";
            // 
            // lblResultPickQty
            // 
            this.lblResultPickQty.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.lblResultPickQty.ForeColor = System.Drawing.Color.Red;
            this.lblResultPickQty.Location = new System.Drawing.Point(64, 49);
            this.lblResultPickQty.Name = "lblResultPickQty";
            this.lblResultPickQty.Size = new System.Drawing.Size(91, 12);
            // 
            // lblPickQty
            // 
            this.lblPickQty.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblPickQty.Location = new System.Drawing.Point(8, 49);
            this.lblPickQty.Name = "lblPickQty";
            this.lblPickQty.Size = new System.Drawing.Size(50, 12);
            this.lblPickQty.Text = "Pick Qty :";
            // 
            // btnBackDetail
            // 
            this.btnBackDetail.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnBackDetail.Location = new System.Drawing.Point(19, 243);
            this.btnBackDetail.Name = "btnBackDetail";
            this.btnBackDetail.Size = new System.Drawing.Size(196, 20);
            this.btnBackDetail.TabIndex = 137;
            this.btnBackDetail.Text = "<- Back";
            this.btnBackDetail.Click += new System.EventHandler(this.btnBackDetail_Click);
            // 
            // lblPickingListRefresh
            // 
            this.lblPickingListRefresh.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblPickingListRefresh.Location = new System.Drawing.Point(8, 27);
            this.lblPickingListRefresh.Name = "lblPickingListRefresh";
            this.lblPickingListRefresh.Size = new System.Drawing.Size(68, 12);
            this.lblPickingListRefresh.Text = "Picking List No";
            // 
            // txtPickingListRefresh
            // 
            this.txtPickingListRefresh.BackColor = System.Drawing.Color.White;
            this.txtPickingListRefresh.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtPickingListRefresh.ForeColor = System.Drawing.Color.Black;
            this.txtPickingListRefresh.Location = new System.Drawing.Point(84, 24);
            this.txtPickingListRefresh.Name = "txtPickingListRefresh";
            this.txtPickingListRefresh.Size = new System.Drawing.Size(147, 18);
            this.txtPickingListRefresh.TabIndex = 107;
            // 
            // brnRefresh
            // 
            this.brnRefresh.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.brnRefresh.Location = new System.Drawing.Point(161, 45);
            this.brnRefresh.Name = "brnRefresh";
            this.brnRefresh.Size = new System.Drawing.Size(70, 21);
            this.brnRefresh.TabIndex = 106;
            this.brnRefresh.Text = "Refresh";
            this.brnRefresh.Click += new System.EventHandler(this.brnRefresh_Click);
            // 
            // dgvPickItem
            // 
            this.dgvPickItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvPickItem.Location = new System.Drawing.Point(2, 70);
            this.dgvPickItem.Name = "dgvPickItem";
            this.dgvPickItem.Size = new System.Drawing.Size(230, 168);
            this.dgvPickItem.TabIndex = 105;
            this.dgvPickItem.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cPickStatus);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cLPN);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cItemNumber);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cItemName);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cLotNumber);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cExpiryDate);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cQuantityPlan);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cQuantityPick);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cUOM);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cLocationPlan);
            this.dataGridTableStyle1.MappingName = "PickItems";
            // 
            // cPickStatus
            // 
            this.cPickStatus.Format = "";
            this.cPickStatus.HeaderText = "PickStatus";
            this.cPickStatus.MappingName = "PickStatus";
            this.cPickStatus.Width = 80;
            // 
            // cLPN
            // 
            this.cLPN.Format = "";
            this.cLPN.HeaderText = "LPN";
            this.cLPN.MappingName = "Lpn";
            this.cLPN.Width = 90;
            // 
            // cItemNumber
            // 
            this.cItemNumber.Format = "";
            this.cItemNumber.HeaderText = "Item Number";
            this.cItemNumber.MappingName = "ItemNumber";
            this.cItemNumber.Width = 90;
            // 
            // cItemName
            // 
            this.cItemName.Format = "";
            this.cItemName.HeaderText = "Description";
            this.cItemName.MappingName = "ItemName";
            this.cItemName.Width = 200;
            // 
            // cLotNumber
            // 
            this.cLotNumber.Format = "";
            this.cLotNumber.HeaderText = "Lot Number";
            this.cLotNumber.MappingName = "LotNumber";
            this.cLotNumber.Width = 80;
            // 
            // cExpiryDate
            // 
            this.cExpiryDate.Format = "yyyy-MM-dd HH:mm:ss";
            this.cExpiryDate.HeaderText = "ExpiryDate";
            this.cExpiryDate.MappingName = "ExpiryDate";
            this.cExpiryDate.Width = 120;
            // 
            // cQuantityPlan
            // 
            this.cQuantityPlan.Format = "";
            this.cQuantityPlan.HeaderText = "Qty Plan";
            this.cQuantityPlan.MappingName = "QuantityPlan";
            this.cQuantityPlan.Width = 60;
            // 
            // cQuantityPick
            // 
            this.cQuantityPick.Format = "";
            this.cQuantityPick.HeaderText = "Qty Pick";
            this.cQuantityPick.MappingName = "QuantityPick";
            this.cQuantityPick.Width = 60;
            // 
            // cUOM
            // 
            this.cUOM.Format = "";
            this.cUOM.HeaderText = "UOM";
            this.cUOM.MappingName = "Uom";
            this.cUOM.Width = 60;
            // 
            // cLocationPlan
            // 
            this.cLocationPlan.Format = "";
            this.cLocationPlan.HeaderText = "Location Plan";
            this.cLocationPlan.MappingName = "LocationPlan";
            this.cLocationPlan.Width = 90;
            // 
            // lblTitleHeaderDetail
            // 
            this.lblTitleHeaderDetail.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTitleHeaderDetail.ForeColor = System.Drawing.Color.Black;
            this.lblTitleHeaderDetail.Location = new System.Drawing.Point(8, 4);
            this.lblTitleHeaderDetail.Name = "lblTitleHeaderDetail";
            this.lblTitleHeaderDetail.Size = new System.Drawing.Size(128, 14);
            this.lblTitleHeaderDetail.Text = "Short Pick Detail";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.textBox1.Location = new System.Drawing.Point(76, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 18);
            this.textBox1.TabIndex = 20;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            // 
            // frmShortPickItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShortPickItem";
            this.Text = "Short Pick Item";
            this.Load += new System.EventHandler(this.frmShortPickItem_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmShortPickItem_KeyUp);
            this.tabControl1.ResumeLayout(false);
            this.tabShortPick.ResumeLayout(false);
            this.tabShortPickDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPickingListNo;
        private System.Windows.Forms.TextBox txtPickingListNo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLPN;
        private System.Windows.Forms.TextBox txtLPN;
        private System.Windows.Forms.Label lblSTGLocation;
        private System.Windows.Forms.TextBox txtSTGLocation;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblLotNumber;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblUOM;
        private System.Windows.Forms.Label lblToLPN;
        private System.Windows.Forms.TextBox txtToLPN;
        private System.Windows.Forms.Label lblItemStatus;
        private System.Windows.Forms.TextBox txtItemStatus;
        private System.Windows.Forms.ComboBox cmbUOM;
        private Calbee.WMS.UI.UserControls.AutoCompleteTextBox txtExpiryDate;
        private Calbee.WMS.UI.UserControls.AutoCompleteTextBox txtLotNumber;
        private Calbee.WMS.UI.UserControls.AutoCompleteTextBox txtItemNumber;
        private System.Windows.Forms.Label lblResultCounter;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabShortPick;
        private System.Windows.Forms.TabPage tabShortPickDetail;
        private System.Windows.Forms.Label lblPickingListRefresh;
        private System.Windows.Forms.TextBox txtPickingListRefresh;
        private System.Windows.Forms.Button brnRefresh;
        private System.Windows.Forms.DataGrid dgvPickItem;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.Label lblTitleHeaderDetail;
        private System.Windows.Forms.DataGridTextBoxColumn cItemNumber;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn cItemName;
        private System.Windows.Forms.DataGridTextBoxColumn cLotNumber;
        private System.Windows.Forms.DataGridTextBoxColumn cExpiryDate;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantityPlan;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantityPick;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn cUOM;
        private System.Windows.Forms.DataGridTextBoxColumn cLocationPlan;
        private System.Windows.Forms.DataGridTextBoxColumn cLPN;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBackDetail;
        private System.Windows.Forms.TextBox txtCarLicense;
        private System.Windows.Forms.Label lblTruckNo;
        private System.Windows.Forms.Label lblResultPickQty;
        private System.Windows.Forms.Label lblPickQty;
        private System.Windows.Forms.DataGridTextBoxColumn cPickStatus;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
    }
}