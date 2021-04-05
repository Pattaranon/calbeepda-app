using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Calbee.Infra.Helper.Controls
{
    public class EditingControls
    {
        System.Windows.Forms.DataGrid dgv = new System.Windows.Forms.DataGrid();
        /// <summary>
        /// Method EditingRows for DataGridView
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        public bool EditingRows(string msg, params System.Windows.Forms.Control[] control)
        {
            bool chk = false;
            foreach (System.Windows.Forms.Control item in control)
            {
                dgv = (System.Windows.Forms.DataGrid)item;
                int iRows = dgv.CurrentRowIndex;
                if (iRows == -1) { Message.MsgBox.DialogWarning(msg); chk = false; }
                else if (iRows != -1) { chk = true; }
            }
            return chk;
        }
    }
}
