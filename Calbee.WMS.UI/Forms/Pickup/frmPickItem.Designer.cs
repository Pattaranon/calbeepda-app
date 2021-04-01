namespace Calbee.WMS.UI.Forms.Pickup
{
    partial class frmPickItem
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPickItem = new System.Windows.Forms.TabPage();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtItemStatus = new System.Windows.Forms.TextBox();
            this.lblResultCounter = new System.Windows.Forms.Label();
            this.lblReceived = new System.Windows.Forms.Label();
            this.txtExpiryDate = new Calbee.WMS.UI.UserControls.AutoCompleteTextBox();
            this.txtLotNumber = new Calbee.WMS.UI.UserControls.AutoCompleteTextBox();
            this.txtItemNumber = new Calbee.WMS.UI.UserControls.AutoCompleteTextBox();
            this.cmbUOM = new System.Windows.Forms.ComboBox();
            this.lblUOM = new System.Windows.Forms.Label();
            this.lblPickingListNo = new System.Windows.Forms.Label();
            this.txtPickingListNo = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblToLPN = new System.Windows.Forms.Label();
            this.txtToLPN = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblItemStatus = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblLotNumber = new System.Windows.Forms.Label();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblLPN = new System.Windows.Forms.Label();
            this.txtLPN = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblSuggestLocation = new System.Windows.Forms.Label();
            this.txtSuggestLocation = new System.Windows.Forms.TextBox();
            this.tabPickDetail = new System.Windows.Forms.TabPage();
            this.lblPickingListRefresh = new System.Windows.Forms.Label();
            this.txtPickingListRefresh = new System.Windows.Forms.TextBox();
            this.brnRefresh = new System.Windows.Forms.Button();
            this.btnStaging = new System.Windows.Forms.Button();
            this.dgvPickItem = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.cItemNumber = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cItemName = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLotNumber = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cExpiryDate = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cQuantityPlan = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cQuantityPick = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cQuantityRemain = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cUOM = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLocationPlan = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLPN = new System.Windows.Forms.DataGridTextBoxColumn();
            this.lblTitleHeaderDetail = new System.Windows.Forms.Label();
            this.cQuantity = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cQuantityBalance = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLocation = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPickItem.SuspendLayout();
            this.tabPickDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPickItem);
            this.tabControl1.Controls.Add(this.tabPickDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(242, 307);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPickItem
            // 
            this.tabPickItem.Controls.Add(this.lblDescription);
            this.tabPickItem.Controls.Add(this.txtDescription);
            this.tabPickItem.Controls.Add(this.txtItemStatus);
            this.tabPickItem.Controls.Add(this.lblResultCounter);
            this.tabPickItem.Controls.Add(this.lblReceived);
            this.tabPickItem.Controls.Add(this.txtExpiryDate);
            this.tabPickItem.Controls.Add(this.txtLotNumber);
            this.tabPickItem.Controls.Add(this.txtItemNumber);
            this.tabPickItem.Controls.Add(this.cmbUOM);
            this.tabPickItem.Controls.Add(this.lblUOM);
            this.tabPickItem.Controls.Add(this.lblPickingListNo);
            this.tabPickItem.Controls.Add(this.txtPickingListNo);
            this.tabPickItem.Controls.Add(this.btnBack);
            this.tabPickItem.Controls.Add(this.btnSave);
            this.tabPickItem.Controls.Add(this.lblToLPN);
            this.tabPickItem.Controls.Add(this.txtToLPN);
            this.tabPickItem.Controls.Add(this.lblQuantity);
            this.tabPickItem.Controls.Add(this.txtQuantity);
            this.tabPickItem.Controls.Add(this.lblItemStatus);
            this.tabPickItem.Controls.Add(this.lblExpiryDate);
            this.tabPickItem.Controls.Add(this.lblLotNumber);
            this.tabPickItem.Controls.Add(this.lblItemNumber);
            this.tabPickItem.Controls.Add(this.lblLPN);
            this.tabPickItem.Controls.Add(this.txtLPN);
            this.tabPickItem.Controls.Add(this.lblLocation);
            this.tabPickItem.Controls.Add(this.txtLocation);
            this.tabPickItem.Controls.Add(this.lblSuggestLocation);
            this.tabPickItem.Controls.Add(this.txtSuggestLocation);
            this.tabPickItem.Location = new System.Drawing.Point(4, 25);
            this.tabPickItem.Name = "tabPickItem";
            this.tabPickItem.Size = new System.Drawing.Size(234, 278);
            this.tabPickItem.Text = "Pick Item";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblDescription.Location = new System.Drawing.Point(5, 118);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 13);
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(81, 115);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(150, 38);
            this.txtDescription.TabIndex = 24;
            // 
            // txtItemStatus
            // 
            this.txtItemStatus.BackColor = System.Drawing.Color.White;
            this.txtItemStatus.Enabled = false;
            this.txtItemStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtItemStatus.ForeColor = System.Drawing.Color.Black;
            this.txtItemStatus.Location = new System.Drawing.Point(81, 212);
            this.txtItemStatus.Name = "txtItemStatus";
            this.txtItemStatus.Size = new System.Drawing.Size(55, 18);
            this.txtItemStatus.TabIndex = 9;
            // 
            // lblResultCounter
            // 
            this.lblResultCounter.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblResultCounter.ForeColor = System.Drawing.Color.Red;
            this.lblResultCounter.Location = new System.Drawing.Point(127, 3);
            this.lblResultCounter.Name = "lblResultCounter";
            this.lblResultCounter.Size = new System.Drawing.Size(104, 13);
            this.lblResultCounter.Text = "xx.xxx/xx.xxx";
            this.lblResultCounter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblReceived
            // 
            this.lblReceived.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblReceived.Location = new System.Drawing.Point(74, 3);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(52, 13);
            this.lblReceived.Text = "Picked : ";
            this.lblReceived.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.BackColor = System.Drawing.Color.White;
            this.txtExpiryDate.ForeColor = System.Drawing.Color.Black;
            this.txtExpiryDate.Location = new System.Drawing.Point(81, 173);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.SelectedIndex = -1;
            this.txtExpiryDate.Size = new System.Drawing.Size(150, 18);
            this.txtExpiryDate.TabIndex = 6;
            this.txtExpiryDate.SelectedIndexChangeds += new System.EventHandler(this.txtExpiryDate_SelectedIndexChangeds);
            this.txtExpiryDate.KeyDowns += new System.Windows.Forms.KeyEventHandler(this.txtExpiryDate_KeyDowns);
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.BackColor = System.Drawing.Color.White;
            this.txtLotNumber.ForeColor = System.Drawing.Color.Black;
            this.txtLotNumber.Location = new System.Drawing.Point(81, 154);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.SelectedIndex = -1;
            this.txtLotNumber.Size = new System.Drawing.Size(150, 18);
            this.txtLotNumber.TabIndex = 5;
            this.txtLotNumber.SelectedIndexChangeds += new System.EventHandler(this.txtLotNumber_SelectedIndexChangeds);
            this.txtLotNumber.KeyDowns += new System.Windows.Forms.KeyEventHandler(this.txtLotNumber_KeyDowns);
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.BackColor = System.Drawing.Color.White;
            this.txtItemNumber.ForeColor = System.Drawing.Color.Black;
            this.txtItemNumber.Location = new System.Drawing.Point(81, 96);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.SelectedIndex = -1;
            this.txtItemNumber.Size = new System.Drawing.Size(150, 18);
            this.txtItemNumber.TabIndex = 4;
            this.txtItemNumber.SelectedIndexChangeds += new System.EventHandler(this.txtItemNumber_SelectedIndexChangeds);
            this.txtItemNumber.KeyDowns += new System.Windows.Forms.KeyEventHandler(this.txtItemNumber_KeyDowns);
            // 
            // cmbUOM
            // 
            this.cmbUOM.BackColor = System.Drawing.Color.White;
            this.cmbUOM.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.cmbUOM.ForeColor = System.Drawing.Color.Black;
            this.cmbUOM.Location = new System.Drawing.Point(167, 192);
            this.cmbUOM.Name = "cmbUOM";
            this.cmbUOM.Size = new System.Drawing.Size(65, 18);
            this.cmbUOM.TabIndex = 8;
            // 
            // lblUOM
            // 
            this.lblUOM.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblUOM.Location = new System.Drawing.Point(140, 195);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(24, 11);
            this.lblUOM.Text = "UOM";
            // 
            // lblPickingListNo
            // 
            this.lblPickingListNo.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblPickingListNo.Location = new System.Drawing.Point(5, 23);
            this.lblPickingListNo.Name = "lblPickingListNo";
            this.lblPickingListNo.Size = new System.Drawing.Size(76, 13);
            this.lblPickingListNo.Text = "Picking List No";
            // 
            // txtPickingListNo
            // 
            this.txtPickingListNo.BackColor = System.Drawing.Color.White;
            this.txtPickingListNo.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtPickingListNo.ForeColor = System.Drawing.Color.Black;
            this.txtPickingListNo.Location = new System.Drawing.Point(81, 20);
            this.txtPickingListNo.Name = "txtPickingListNo";
            this.txtPickingListNo.Size = new System.Drawing.Size(150, 18);
            this.txtPickingListNo.TabIndex = 0;
            this.txtPickingListNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPickingListNo_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnBack.Location = new System.Drawing.Point(82, 234);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 20);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "<- Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnSave.Location = new System.Drawing.Point(157, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 20);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save ->";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblToLPN
            // 
            this.lblToLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblToLPN.Location = new System.Drawing.Point(135, 217);
            this.lblToLPN.Name = "lblToLPN";
            this.lblToLPN.Size = new System.Drawing.Size(34, 13);
            this.lblToLPN.Text = "To LPN";
            // 
            // txtToLPN
            // 
            this.txtToLPN.BackColor = System.Drawing.Color.White;
            this.txtToLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtToLPN.ForeColor = System.Drawing.Color.Black;
            this.txtToLPN.Location = new System.Drawing.Point(169, 213);
            this.txtToLPN.Name = "txtToLPN";
            this.txtToLPN.Size = new System.Drawing.Size(63, 18);
            this.txtToLPN.TabIndex = 10;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblQuantity.Location = new System.Drawing.Point(5, 195);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(75, 13);
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(81, 192);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(55, 18);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // lblItemStatus
            // 
            this.lblItemStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemStatus.Location = new System.Drawing.Point(5, 215);
            this.lblItemStatus.Name = "lblItemStatus";
            this.lblItemStatus.Size = new System.Drawing.Size(75, 13);
            this.lblItemStatus.Text = "Item Status";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblExpiryDate.Location = new System.Drawing.Point(5, 176);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(75, 13);
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // lblLotNumber
            // 
            this.lblLotNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLotNumber.Location = new System.Drawing.Point(5, 157);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(75, 13);
            this.lblLotNumber.Text = "Lot Number";
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemNumber.Location = new System.Drawing.Point(5, 98);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(75, 13);
            this.lblItemNumber.Text = "Item Number";
            // 
            // lblLPN
            // 
            this.lblLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLPN.Location = new System.Drawing.Point(5, 80);
            this.lblLPN.Name = "lblLPN";
            this.lblLPN.Size = new System.Drawing.Size(75, 13);
            this.lblLPN.Text = "LPN";
            // 
            // txtLPN
            // 
            this.txtLPN.BackColor = System.Drawing.Color.White;
            this.txtLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtLPN.ForeColor = System.Drawing.Color.Black;
            this.txtLPN.Location = new System.Drawing.Point(81, 77);
            this.txtLPN.Name = "txtLPN";
            this.txtLPN.Size = new System.Drawing.Size(150, 18);
            this.txtLPN.TabIndex = 3;
            this.txtLPN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLPN_KeyDown);
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLocation.Location = new System.Drawing.Point(5, 62);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(75, 13);
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtLocation.ForeColor = System.Drawing.Color.Black;
            this.txtLocation.Location = new System.Drawing.Point(81, 58);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(150, 18);
            this.txtLocation.TabIndex = 2;
            this.txtLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocation_KeyDown);
            // 
            // lblSuggestLocation
            // 
            this.lblSuggestLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblSuggestLocation.Location = new System.Drawing.Point(5, 42);
            this.lblSuggestLocation.Name = "lblSuggestLocation";
            this.lblSuggestLocation.Size = new System.Drawing.Size(76, 13);
            this.lblSuggestLocation.Text = "Suggest Location";
            // 
            // txtSuggestLocation
            // 
            this.txtSuggestLocation.BackColor = System.Drawing.Color.LimeGreen;
            this.txtSuggestLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtSuggestLocation.ForeColor = System.Drawing.Color.White;
            this.txtSuggestLocation.Location = new System.Drawing.Point(81, 39);
            this.txtSuggestLocation.Name = "txtSuggestLocation";
            this.txtSuggestLocation.ReadOnly = true;
            this.txtSuggestLocation.Size = new System.Drawing.Size(150, 18);
            this.txtSuggestLocation.TabIndex = 1;
            // 
            // tabPickDetail
            // 
            this.tabPickDetail.Controls.Add(this.lblPickingListRefresh);
            this.tabPickDetail.Controls.Add(this.txtPickingListRefresh);
            this.tabPickDetail.Controls.Add(this.brnRefresh);
            this.tabPickDetail.Controls.Add(this.btnStaging);
            this.tabPickDetail.Controls.Add(this.dgvPickItem);
            this.tabPickDetail.Controls.Add(this.lblTitleHeaderDetail);
            this.tabPickDetail.Location = new System.Drawing.Point(4, 25);
            this.tabPickDetail.Name = "tabPickDetail";
            this.tabPickDetail.Size = new System.Drawing.Size(234, 278);
            this.tabPickDetail.Text = "Pick Detail";
            // 
            // lblPickingListRefresh
            // 
            this.lblPickingListRefresh.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblPickingListRefresh.Location = new System.Drawing.Point(12, 27);
            this.lblPickingListRefresh.Name = "lblPickingListRefresh";
            this.lblPickingListRefresh.Size = new System.Drawing.Size(68, 12);
            this.lblPickingListRefresh.Text = "Picking List No";
            // 
            // txtPickingListRefresh
            // 
            this.txtPickingListRefresh.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtPickingListRefresh.Location = new System.Drawing.Point(84, 24);
            this.txtPickingListRefresh.Name = "txtPickingListRefresh";
            this.txtPickingListRefresh.Size = new System.Drawing.Size(147, 18);
            this.txtPickingListRefresh.TabIndex = 102;
            // 
            // brnRefresh
            // 
            this.brnRefresh.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.brnRefresh.Location = new System.Drawing.Point(161, 43);
            this.brnRefresh.Name = "brnRefresh";
            this.brnRefresh.Size = new System.Drawing.Size(70, 20);
            this.brnRefresh.TabIndex = 99;
            this.brnRefresh.Text = "Refresh";
            this.brnRefresh.Click += new System.EventHandler(this.brnRefresh_Click);
            // 
            // btnStaging
            // 
            this.btnStaging.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnStaging.Location = new System.Drawing.Point(151, 240);
            this.btnStaging.Name = "btnStaging";
            this.btnStaging.Size = new System.Drawing.Size(81, 20);
            this.btnStaging.TabIndex = 97;
            this.btnStaging.Text = "Staging ->";
            this.btnStaging.Click += new System.EventHandler(this.btnStaging_Click);
            // 
            // dgvPickItem
            // 
            this.dgvPickItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvPickItem.Location = new System.Drawing.Point(2, 65);
            this.dgvPickItem.Name = "dgvPickItem";
            this.dgvPickItem.Size = new System.Drawing.Size(230, 171);
            this.dgvPickItem.TabIndex = 4;
            this.dgvPickItem.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cItemNumber);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cItemName);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cLotNumber);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cExpiryDate);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cQuantityPlan);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cQuantityPick);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cQuantityRemain);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cUOM);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cLocationPlan);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.cLPN);
            this.dataGridTableStyle1.MappingName = "PickItems";
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
            // cQuantityRemain
            // 
            this.cQuantityRemain.Format = "";
            this.cQuantityRemain.HeaderText = "Qty Remain";
            this.cQuantityRemain.MappingName = "QuantityRemain";
            this.cQuantityRemain.Width = 60;
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
            // cLPN
            // 
            this.cLPN.Format = "";
            this.cLPN.HeaderText = "LPN";
            this.cLPN.MappingName = "Lpn";
            this.cLPN.Width = 90;
            // 
            // lblTitleHeaderDetail
            // 
            this.lblTitleHeaderDetail.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTitleHeaderDetail.ForeColor = System.Drawing.Color.Black;
            this.lblTitleHeaderDetail.Location = new System.Drawing.Point(12, 5);
            this.lblTitleHeaderDetail.Name = "lblTitleHeaderDetail";
            this.lblTitleHeaderDetail.Size = new System.Drawing.Size(128, 14);
            this.lblTitleHeaderDetail.Text = "Pick Detail";
            // 
            // cQuantity
            // 
            this.cQuantity.Format = "";
            this.cQuantity.HeaderText = "QuantityPlan";
            this.cQuantity.MappingName = "QuantityPlan";
            this.cQuantity.Width = 60;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            // 
            // cQuantityBalance
            // 
            this.cQuantityBalance.Format = "";
            this.cQuantityBalance.HeaderText = "Qty Balance";
            this.cQuantityBalance.MappingName = "QuantityRemain";
            this.cQuantityBalance.Width = 60;
            // 
            // cLocation
            // 
            this.cLocation.Format = "";
            this.cLocation.HeaderText = "Location Plan";
            this.cLocation.MappingName = "LocationPlan";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            // 
            // frmPickItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPickItem";
            this.Text = "Pick Item";
            this.Load += new System.EventHandler(this.frmPickItem_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPickItem_KeyUp);
            this.tabControl1.ResumeLayout(false);
            this.tabPickItem.ResumeLayout(false);
            this.tabPickDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPickItem;
        private System.Windows.Forms.TabPage tabPickDetail;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblToLPN;
        private System.Windows.Forms.TextBox txtToLPN;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblItemStatus;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblLotNumber;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblLPN;
        private System.Windows.Forms.TextBox txtLPN;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblSuggestLocation;
        private System.Windows.Forms.TextBox txtSuggestLocation;
        private System.Windows.Forms.Label lblPickingListNo;
        private System.Windows.Forms.TextBox txtPickingListNo;
        private System.Windows.Forms.ComboBox cmbUOM;
        private System.Windows.Forms.Label lblUOM;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGrid dgvPickItem;
        private System.Windows.Forms.Label lblTitleHeaderDetail;
        private System.Windows.Forms.Button btnStaging;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn cItemNumber;
        private System.Windows.Forms.DataGridTextBoxColumn cItemName;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantityPlan;
        private System.Windows.Forms.DataGridTextBoxColumn cUOM;
        private System.Windows.Forms.DataGridTextBoxColumn cLocationPlan;
        private System.Windows.Forms.DataGridTextBoxColumn cLPN;
        private System.Windows.Forms.DataGridTextBoxColumn cLotNumber;
        private System.Windows.Forms.DataGridTextBoxColumn cExpiryDate;
        private System.Windows.Forms.Button brnRefresh;
        private Calbee.WMS.UI.UserControls.AutoCompleteTextBox txtExpiryDate;
        private Calbee.WMS.UI.UserControls.AutoCompleteTextBox txtLotNumber;
        private Calbee.WMS.UI.UserControls.AutoCompleteTextBox txtItemNumber;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantityPick;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantity;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantityBalance;
        private System.Windows.Forms.DataGridTextBoxColumn cLocation;
        private System.Windows.Forms.Label lblResultCounter;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantityRemain;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.TextBox txtItemStatus;
        private System.Windows.Forms.Label lblPickingListRefresh;
        private System.Windows.Forms.TextBox txtPickingListRefresh;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
    }
}