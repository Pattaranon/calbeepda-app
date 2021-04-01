using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Calbee.Infra.Helper.Controls
{
    public delegate void CheckCellEventHandler(object sender, DataGridEnableEventArgs e);

    public class DataGridEnableEventArgs : EventArgs
    {
        private int _row;
        private bool _meetsCriteria;

        public DataGridEnableEventArgs(int row, bool val)
        {
            _row = row;
            _meetsCriteria = val;
        }

        public int Row
        {
            get { return _row; }
            set { _row = value; }
        }

        public bool MeetsCriteria
        {
            get { return _meetsCriteria; }
            set { _meetsCriteria = value; }
        }
    }

    public class ColumnStyle : DataGridTextBoxColumn
    {
        public event CheckCellEventHandler CheckCellEven;

        private int _col;

        public ColumnStyle(int column)
        {
            _col = column;
        }

        protected override void Paint(Graphics g, Rectangle Bounds, CurrencyManager Source, int RowNum, Brush BackBrush, Brush ForeBrush, bool AlignToRight)
        {
            if (CheckCellEven != null)
            {
                DataGridEnableEventArgs e = new DataGridEnableEventArgs(RowNum, true);
                CheckCellEven(this, e);
                if (e.MeetsCriteria)
                {
                    BackBrush = new SolidBrush(Calbee.Infra.Common.Constants.IConstants.Color);
                }

                base.Paint(g, Bounds, Source, RowNum, BackBrush, ForeBrush, AlignToRight);
            }
        }
    }
}
