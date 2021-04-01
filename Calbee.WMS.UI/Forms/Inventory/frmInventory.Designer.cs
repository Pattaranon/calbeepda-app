namespace Calbee.WMS.UI.Forms.Inventory
{
    partial class frmInventory
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
            System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
            this.cLPN = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cItemNumebr = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cItemName = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cQuantity = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cUOM = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLocationCode = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLotNumber = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cExpiryDate = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cStatusName = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cReceiveDate = new System.Windows.Forms.DataGridTextBoxColumn();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGrid();
            this.lblHeaderMainMenu = new System.Windows.Forms.Label();
            this.cmbLotNumber = new System.Windows.Forms.ComboBox();
            this.lblItemStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultCountLPN = new System.Windows.Forms.Label();
            this.lblResultCountBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetLotNumber = new System.Windows.Forms.Button();
            dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.SuspendLayout();
            // 
            // dataGridTableStyle1
            // 
            dataGridTableStyle1.GridColumnStyles.Add(this.cLPN);
            dataGridTableStyle1.GridColumnStyles.Add(this.cItemNumebr);
            dataGridTableStyle1.GridColumnStyles.Add(this.cItemName);
            dataGridTableStyle1.GridColumnStyles.Add(this.cQuantity);
            dataGridTableStyle1.GridColumnStyles.Add(this.cUOM);
            dataGridTableStyle1.GridColumnStyles.Add(this.cLocationCode);
            dataGridTableStyle1.GridColumnStyles.Add(this.cLotNumber);
            dataGridTableStyle1.GridColumnStyles.Add(this.cExpiryDate);
            dataGridTableStyle1.GridColumnStyles.Add(this.cStatusName);
            dataGridTableStyle1.GridColumnStyles.Add(this.cReceiveDate);
            dataGridTableStyle1.MappingName = "Inventory";
            // 
            // cLPN
            // 
            this.cLPN.Format = "";
            this.cLPN.FormatInfo = null;
            this.cLPN.HeaderText = "LPN";
            this.cLPN.MappingName = "LPN";
            this.cLPN.Width = 80;
            // 
            // cItemNumebr
            // 
            this.cItemNumebr.Format = "";
            this.cItemNumebr.FormatInfo = null;
            this.cItemNumebr.HeaderText = "Item Number";
            this.cItemNumebr.MappingName = "ItemNumber";
            this.cItemNumebr.Width = 100;
            // 
            // cItemName
            // 
            this.cItemName.Format = "";
            this.cItemName.FormatInfo = null;
            this.cItemName.HeaderText = "Description";
            this.cItemName.MappingName = "ItemName";
            this.cItemName.Width = 300;
            // 
            // cQuantity
            // 
            this.cQuantity.Format = "";
            this.cQuantity.FormatInfo = null;
            this.cQuantity.HeaderText = "Quantity";
            this.cQuantity.MappingName = "Quantity";
            this.cQuantity.Width = 60;
            // 
            // cUOM
            // 
            this.cUOM.Format = "";
            this.cUOM.FormatInfo = null;
            this.cUOM.HeaderText = "UOM";
            this.cUOM.MappingName = "UOM";
            // 
            // cLocationCode
            // 
            this.cLocationCode.Format = "";
            this.cLocationCode.FormatInfo = null;
            this.cLocationCode.HeaderText = "Location";
            this.cLocationCode.MappingName = "LocationCode";
            this.cLocationCode.Width = 80;
            // 
            // cLotNumber
            // 
            this.cLotNumber.Format = "";
            this.cLotNumber.FormatInfo = null;
            this.cLotNumber.HeaderText = "Lot Number";
            this.cLotNumber.MappingName = "LotNumber";
            this.cLotNumber.Width = 90;
            // 
            // cExpiryDate
            // 
            this.cExpiryDate.Format = "dd-MM-yyyy HH:mm";
            this.cExpiryDate.FormatInfo = null;
            this.cExpiryDate.HeaderText = "Expiry Date";
            this.cExpiryDate.MappingName = "ExpiryDate";
            this.cExpiryDate.Width = 120;
            // 
            // cStatusName
            // 
            this.cStatusName.Format = "";
            this.cStatusName.FormatInfo = null;
            this.cStatusName.HeaderText = "Item Status";
            this.cStatusName.MappingName = "StatusName";
            this.cStatusName.Width = 70;
            // 
            // cReceiveDate
            // 
            this.cReceiveDate.Format = "dd-MM-yyyy HH:mm";
            this.cReceiveDate.FormatInfo = null;
            this.cReceiveDate.HeaderText = "Receive Date";
            this.cReceiveDate.MappingName = "ReceiveDate";
            this.cReceiveDate.Width = 120;
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblLocation.Location = new System.Drawing.Point(10, 29);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(76, 13);
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtLocation.ForeColor = System.Drawing.Color.Black;
            this.txtLocation.Location = new System.Drawing.Point(87, 26);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(149, 18);
            this.txtLocation.TabIndex = 120;
            this.txtLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocation_KeyDown);
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemNumber.Location = new System.Drawing.Point(10, 48);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(76, 13);
            this.lblItemNumber.Text = "Item Number";
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.BackColor = System.Drawing.Color.White;
            this.txtItemNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtItemNumber.ForeColor = System.Drawing.Color.Black;
            this.txtItemNumber.Location = new System.Drawing.Point(87, 45);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(122, 18);
            this.txtItemNumber.TabIndex = 122;
            this.txtItemNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemNumber_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnBack.Location = new System.Drawing.Point(24, 266);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(196, 20);
            this.btnBack.TabIndex = 136;
            this.btnBack.Text = "<- Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnRefresh.Location = new System.Drawing.Point(158, 84);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(78, 20);
            this.btnRefresh.TabIndex = 135;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvInventory.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dgvInventory.Location = new System.Drawing.Point(3, 108);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.Size = new System.Drawing.Size(235, 138);
            this.dgvInventory.TabIndex = 137;
            this.dgvInventory.TableStyles.Add(dataGridTableStyle1);
            // 
            // lblHeaderMainMenu
            // 
            this.lblHeaderMainMenu.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHeaderMainMenu.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderMainMenu.Location = new System.Drawing.Point(3, 9);
            this.lblHeaderMainMenu.Name = "lblHeaderMainMenu";
            this.lblHeaderMainMenu.Size = new System.Drawing.Size(236, 15);
            this.lblHeaderMainMenu.Text = "Inventory";
            // 
            // cmbLotNumber
            // 
            this.cmbLotNumber.BackColor = System.Drawing.Color.White;
            this.cmbLotNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.cmbLotNumber.ForeColor = System.Drawing.Color.Black;
            this.cmbLotNumber.Location = new System.Drawing.Point(87, 64);
            this.cmbLotNumber.Name = "cmbLotNumber";
            this.cmbLotNumber.Size = new System.Drawing.Size(148, 18);
            this.cmbLotNumber.TabIndex = 141;
            // 
            // lblItemStatus
            // 
            this.lblItemStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblItemStatus.Location = new System.Drawing.Point(10, 67);
            this.lblItemStatus.Name = "lblItemStatus";
            this.lblItemStatus.Size = new System.Drawing.Size(75, 14);
            this.lblItemStatus.Text = "Lot Number";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(3, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.Text = "Total LPN :";
            // 
            // lblResultCountLPN
            // 
            this.lblResultCountLPN.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblResultCountLPN.ForeColor = System.Drawing.Color.Red;
            this.lblResultCountLPN.Location = new System.Drawing.Point(60, 250);
            this.lblResultCountLPN.Name = "lblResultCountLPN";
            this.lblResultCountLPN.Size = new System.Drawing.Size(35, 13);
            this.lblResultCountLPN.Text = "0";
            // 
            // lblResultCountBox
            // 
            this.lblResultCountBox.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblResultCountBox.ForeColor = System.Drawing.Color.Red;
            this.lblResultCountBox.Location = new System.Drawing.Point(165, 250);
            this.lblResultCountBox.Name = "lblResultCountBox";
            this.lblResultCountBox.Size = new System.Drawing.Size(35, 13);
            this.lblResultCountBox.Text = "0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(108, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.Text = "Total Box :";
            // 
            // btnGetLotNumber
            // 
            this.btnGetLotNumber.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnGetLotNumber.Location = new System.Drawing.Point(211, 45);
            this.btnGetLotNumber.Name = "btnGetLotNumber";
            this.btnGetLotNumber.Size = new System.Drawing.Size(24, 17);
            this.btnGetLotNumber.TabIndex = 151;
            this.btnGetLotNumber.Text = "...";
            this.btnGetLotNumber.Click += new System.EventHandler(this.btnGetLotNumber_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(242, 307);
            this.ControlBox = false;
            this.Controls.Add(this.btnGetLotNumber);
            this.Controls.Add(this.lblResultCountBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultCountLPN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLotNumber);
            this.Controls.Add(this.lblItemStatus);
            this.Controls.Add(this.lblHeaderMainMenu);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblItemNumber);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmInventory_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Label lblHeaderMainMenu;
        private System.Windows.Forms.DataGridTextBoxColumn cItemNumebr;
        private System.Windows.Forms.DataGridTextBoxColumn cItemName;
        private System.Windows.Forms.DataGridTextBoxColumn cQuantity;
        private System.Windows.Forms.DataGridTextBoxColumn cUOM;
        private System.Windows.Forms.DataGridTextBoxColumn cLocationCode;
        private System.Windows.Forms.DataGridTextBoxColumn cLPN;
        private System.Windows.Forms.DataGridTextBoxColumn cLotNumber;
        private System.Windows.Forms.DataGridTextBoxColumn cExpiryDate;
        private System.Windows.Forms.DataGridTextBoxColumn cStatusName;
        private System.Windows.Forms.DataGridTextBoxColumn cReceiveDate;
        private System.Windows.Forms.DataGrid dgvInventory;
        private System.Windows.Forms.ComboBox cmbLotNumber;
        private System.Windows.Forms.Label lblItemStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultCountLPN;
        private System.Windows.Forms.Label lblResultCountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetLotNumber;
    }
}