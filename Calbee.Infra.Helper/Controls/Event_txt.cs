using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calbee.Infra.Helper.Objects;

namespace Calbee.Infra.Helper.Controls
{
    public class Event_txt
    {
        public static void txtNumberDot_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9')
                || e.KeyChar == '.'
                || e.KeyChar == ControlKeysChars.Back
                || e.KeyChar == (char)22//Paste
                || e.KeyChar == (char)3)/*Copy*/)
            {
                e.Handled = true;
            }

            if (((System.Windows.Forms.TextBox)(sender)).Text.Split('.').Length > 1)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }

        }
        public static void txtNumberDecimal_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '1' && e.KeyChar <= '9')
                || e.KeyChar == '.'
                || e.KeyChar == ControlKeysChars.Back
                || e.KeyChar == (char)22//Paste
                || e.KeyChar == (char)3)/*Copy*/)
            {
                e.Handled = true;
            }

            if (((System.Windows.Forms.TextBox)(sender)).Text.Split('.').Length > 1)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }

        }
        public static void txtNumberMinusDecimal_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') ||
                e.KeyChar == '-' || e.KeyChar == '.' ||
                e.KeyChar == ControlKeysChars.Back
                || e.KeyChar == (char)22//Paste
                || e.KeyChar == (char)3)/*Copy*/)
            {
                e.Handled = true;
            }

            if (((System.Windows.Forms.TextBox)(sender)).Text.Split('.').Length > 1)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
        }
        public static void txtNumberDatStrings_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9')
                || (e.KeyChar == '(' || e.KeyChar == ')')
                || e.KeyChar == '-'
                || e.KeyChar == ControlKeysChars.Back
                || e.KeyChar == (char)22//Paste
                || e.KeyChar == (char)3)/*Copy*/)
            {
                e.Handled = true;
            }
        }
        public static void txtNumberDat_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') 
                || e.KeyChar == '-'
                || e.KeyChar == ControlKeysChars.Back
                || e.KeyChar == (char)22//Paste
                || e.KeyChar == (char)3)/*Copy*/)
            {
                e.Handled = true;
            }
        }
        public static void txtNumInt_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9')
                || e.KeyChar == ControlKeysChars.Back 
                || e.KeyChar == (char)22//Paste
                || e.KeyChar == (char)3)/*Copy*/)
            {
                e.Handled = true;
            }
        }
    }
}
