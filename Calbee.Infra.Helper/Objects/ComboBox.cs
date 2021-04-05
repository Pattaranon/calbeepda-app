using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Calbee.Infra.Helper.Objects
{
    public class ComboBoxBinding
    {
        /// <summary>
        /// bind ข้อมูลสำหรับ ComboBox
        /// </summary>
        /// <param name="cmbTarget"></param>
        /// <param name="dt"></param>
        /// <param name="displayMember"></param>
        /// <param name="valueMember"></param>
        public static void BindComboBox(System.Windows.Forms.ComboBox cmbTarget, DataTable dt, string displayMember, string valueMember)
        {
            try
            {
                cmbTarget.DataSource = null;
                cmbTarget.Items.Clear();

                if (dt.Rows.Count > 0)
                {
                    cmbTarget.DataSource = null;
                    cmbTarget.BeginUpdate();
                    cmbTarget.DisplayMember = displayMember;
                    cmbTarget.ValueMember = valueMember;
                    cmbTarget.DataSource = dt;
                    cmbTarget.EndUpdate();
                    cmbTarget.SelectedIndex = -1;
                }
                else
                {
                    cmbTarget.Items.Add("---- ไม่พบข้อมูล -----");
                    cmbTarget.SelectedIndex = 0;
                }
            }
            catch
            {
                throw;
            }
        }

        public static void BindDataTableToCombobox(DataTable dt, System.Windows.Forms.ComboBox cmb, string DisplayMember, string ValueMember, string Text)
        {
            if (dt.Rows.Count > 0)
            {

                dt.Columns[DisplayMember].MaxLength = 100;

                DataRow dr = dt.NewRow();
                //dr[0] = Text;
                dr[DisplayMember] = Text;

                dt.Rows.InsertAt(dr, 0);

                cmb.BeginUpdate();
                cmb.DataSource = dt;
                cmb.DisplayMember = DisplayMember;
                cmb.ValueMember = ValueMember;
                cmb.EndUpdate();
            }
        }
        public static void BindDataTableToCombobox(DataTable dt, System.Windows.Forms.ComboBox cmb, string DisplayMember, string ValueMember)
        {
            cmb.DataSource = null;
            cmb.Items.Clear();

            if (dt.Rows.Count > 0)
            {
                cmb.DataSource = null;
                cmb.BeginUpdate();
                cmb.DisplayMember = DisplayMember;
                cmb.ValueMember = ValueMember;
                cmb.DataSource = dt;
                cmb.EndUpdate();
                // cmb.SelectedIndex = -1;
            }
            else
            {
                //cmbTarget.Items.Add("---- ไม่พบข้อมูล -----");
                cmb.Items.Add("");
                cmb.SelectedIndex = 0;
            }
        }
        public static void BindListToCombobox(object _list, System.Windows.Forms.ComboBox cmb, string DisplayMember, string ValueMember)
        {
            cmb.BeginUpdate();
            cmb.DataSource = _list;
            cmb.DisplayMember = DisplayMember;
            cmb.ValueMember = ValueMember;
            cmb.EndUpdate();
        }
        public static void BindEntityToCombobox(object ent, System.Windows.Forms.ComboBox cmb, string DisplayMember, string ValueMember, string Text)
        {
            if (ent != null)
            {
                cmb.BeginUpdate();
                cmb.DataSource = ent;
                cmb.DisplayMember = DisplayMember;
                cmb.ValueMember = ValueMember;
                cmb.EndUpdate();
            }
        }
        public static void BindLStringToCombobox(object ent, System.Windows.Forms.ComboBox cmb)
        {
            if (ent != null)
            {
                cmb.BeginUpdate();
                cmb.DataSource = ent;
                //cmb.DisplayMember = DisplayMember;
                //cmb.ValueMember = ValueMember;
                cmb.EndUpdate();
            }
        }
    }
}