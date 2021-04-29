namespace Calbee.WMS.UI.UserControls
{
    partial class AutoCompleteTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.innerComboBox = new System.Windows.Forms.ComboBox();
            this.innerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // innerComboBox
            // 
            this.innerComboBox.BackColor = System.Drawing.Color.White;
            this.innerComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.innerComboBox.ForeColor = System.Drawing.Color.Black;
            this.innerComboBox.Location = new System.Drawing.Point(0, 0);
            this.innerComboBox.Name = "innerComboBox";
            this.innerComboBox.Size = new System.Drawing.Size(190, 23);
            this.innerComboBox.TabIndex = 0;
            this.innerComboBox.SelectedIndexChanged += new System.EventHandler(this.innerComboBox_SelectedIndexChanged);
            // 
            // innerTextBox
            // 
            this.innerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.innerTextBox.BackColor = System.Drawing.Color.White;
            this.innerTextBox.ForeColor = System.Drawing.Color.Black;
            this.innerTextBox.Location = new System.Drawing.Point(0, 0);
            this.innerTextBox.Name = "innerTextBox";
            this.innerTextBox.Size = new System.Drawing.Size(175, 23);
            this.innerTextBox.TabIndex = 0;
            this.innerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.innerTextBox_KeyDown);
            // 
            // AutoCompleteTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.innerTextBox);
            this.Controls.Add(this.innerComboBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AutoCompleteTextBox";
            this.Size = new System.Drawing.Size(190, 22);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox innerComboBox;
        private System.Windows.Forms.TextBox innerTextBox;
    }
}
