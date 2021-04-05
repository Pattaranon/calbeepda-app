using System;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Calbee.WMS.UI.UserControls
{
    public partial class AutoCompleteTextBox : UserControl
    {
        public event KeyEventHandler KeyDowns;
        public event EventHandler SelectedIndexChangeds;
        // stores the items that are used for auto-complete
        private string[] comboBoxItems = new string[0];

        public AutoCompleteTextBox()
        {
            InitializeComponent();

            // if the user uses the ComboBox to choose an item, 
            //  handle this by mirroring it in the TextBox
            innerComboBox.SelectedValueChanged += new EventHandler(innerComboBox_SelectedValueChanged);

            // if the user uses the TextBox to enter text, 
            //  handle this with our home-made autocomplete code below
            innerTextBox.KeyPress += new KeyPressEventHandler(innerTextBox_KeyPress);
        }

        // Create property control
        public override string Text
        {
            get
            {
                return innerTextBox.Text;
            }
            set
            {
                innerTextBox.Text = value;
            }
        }
        public int SelectedIndex
        {
            get
            {
                return innerComboBox.SelectedIndex;
            }
            set
            {
                innerComboBox.SelectedIndex = value;
            }
        }
        public bool customFocus()
        {
            return innerTextBox.Focus();
        }
        public void customSelectAll()
        {
            innerTextBox.SelectAll();
        }

        // provide the array of strings to use for auto-complete matches
        public void SetArrayItemsToCombobox(string[] items)
        {
            comboBoxItems = items;

            innerComboBox.Items.Clear();

            for (int i = 0; i < comboBoxItems.Length; i++)
            {
                innerComboBox.Items.Add(comboBoxItems[i]);
            }
        }
        public void SetEntityItemsToCombobox(object items, string DisplayMember, string ValueMember)
        {
            if (items != null)
            {
                innerComboBox.BeginUpdate();
                innerComboBox.DataSource = items;
                innerComboBox.DisplayMember = DisplayMember;
                innerComboBox.ValueMember = ValueMember;
                innerComboBox.EndUpdate();
            }
        }
        public void SetEntityStringItemsToCombobox(object items)
        {
            if (items != null)
            {
                innerComboBox.BeginUpdate();
                innerComboBox.DataSource = items;
                innerComboBox.EndUpdate();
            }
        }
        public void SetDataTableItemsToCombobox(DataTable dt, string DisplayMember, string ValueMember)
        {
            innerComboBox.DataSource = null;
            innerComboBox.Items.Clear();

            if (dt.Rows.Count > 0)
            {
                innerComboBox.DataSource = null;
                innerComboBox.BeginUpdate();
                innerComboBox.DisplayMember = DisplayMember;
                innerComboBox.ValueMember = ValueMember;
                innerComboBox.DataSource = dt;
                innerComboBox.EndUpdate();
                // cmb.SelectedIndex = -1;
            }
            else
            {
                //cmbTarget.Items.Add("---- ไม่พบข้อมูล -----");
                innerComboBox.Items.Add("");
                innerComboBox.SelectedIndex = 0;
            }
        }

        // add an item to the array of strings used for auto-complete matches
        public void AddItem(string newitem)
        {
            string[] newitems = new string[comboBoxItems.Length + 1];

            Array.Copy(comboBoxItems, newitems, comboBoxItems.Length);

            newitems[comboBoxItems.Length] = newitem;

            SetArrayItemsToCombobox(newitems);
        }

        // clear the list of strings used for auto-complete matches
        public void ClearItems()
        {
            //comboBoxItems = new string[0];
            //innerComboBox.Items.Clear();

            SetArrayItemsToCombobox(new string[] { "" });
            innerTextBox.Text = string.Empty;
        }

        // the user has used the ComboBox to select one of the possible 
        void innerComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            innerTextBox.Text = innerComboBox.Text;
        }
        private void innerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SelectedIndexChangeds != null)
            {
                this.SelectedIndexChangeds(this, e);
            }
        }

        // the user has used the TextBox to select one of the possible 
        void innerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            // this is where we store any match found in the auto-complete list
            string match = null;

            // what has been typed so far?
            int cursorLocation = innerTextBox.SelectionStart;
            string typedSoFar = innerTextBox.Text.Substring(0, cursorLocation);
            
            // what is the user adding now?
            switch (e.KeyChar)
            {
                // BACKSPACE - the user is deleting a character - so we shink
                //   our 'typedSoFar' string by one character
                case (char)Keys.Back:
                    if (cursorLocation > 0)
                    {
                        cursorLocation -= 1;
                        typedSoFar = innerTextBox.Text.Substring(0, cursorLocation);
                    }
                    break;

                // DELETE - do nothing, allowing the 'delete' keystroke to delete
                //    the selected text provided from a previous auto-complete
                case (char)Keys.Delete:
                    break;

                // RETURN - do nothing - swallow this keystroke
                case (char)Keys.Return:
                    // don't do anything else
                    goto key_handle_complete;

                // OTHERWISE - assume we have a alphanumeric keystroke which 
                //   we add to the string typed-so-far
                default:
                    typedSoFar += e.KeyChar;
                    cursorLocation += 1;
                    break;
            }

            // look for a match in the auto-complete list
            for (int i = 0; i < comboBoxItems.Length; i++)
            {
                if (comboBoxItems[i].StartsWith(typedSoFar, StringComparison.CurrentCultureIgnoreCase))
                {
                    match = comboBoxItems[i];

                    // we want first match - once found, break out
                    break;
                }
            }


            // was a match found?

            if (match == null)
            {
                // user has typed something not already in the list
                innerTextBox.Text = typedSoFar;
                innerTextBox.SelectionStart = typedSoFar.Length;
                innerTextBox.SelectionLength = 0;
            }
            else
            {
                // user has typed text which matches the start of something
                //  in the provided auto-complete list

                // display this match, and highlight the portion of it which
                //  was not actually typed by the user
                innerTextBox.Text = match;
                innerTextBox.SelectionStart = cursorLocation;
                innerTextBox.SelectionLength = innerTextBox.Text.Length - innerTextBox.SelectionStart;

                innerComboBox.SelectedItem = match;
            }

            // COMPLETE - finally, prevent key-press being handled by text box
            key_handle_complete: e.Handled = true;
            */
        }
        private void innerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.KeyDowns != null)
            {
                this.KeyDowns(this, e);
            }
        }
    }
}