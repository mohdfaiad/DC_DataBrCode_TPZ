using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace GridSample
{
    public delegate void CheckCellEventHandler(object sender, DataGridEnableEventArgs e);

    public class DataGridEnableEventArgs : EventArgs
    {
        private int _column;
        private int _row;
        private bool _meetsCriteria;
        private bool _paintColor;
        private SolidBrush _colorRows;

        public DataGridEnableEventArgs(int row, int col, bool val)
        {
            _row = row;
            _column = col;
            _meetsCriteria = val;
        }

        public int Column
        {
            get { return _column; }
            set { _column = value; }
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

        public bool PaintColor
        {
            get { return _paintColor; }
            set { _paintColor = value; }
        }

        public SolidBrush ColorRows
        {
            get { return _colorRows; }
            set { _colorRows = value; }
        }
    }

    public class ColumnStyle : DataGridTextBoxColumn
    {
        public event CheckCellEventHandler CheckCellEven;

        private int _col;

        public ColumnStyle(int column)
        {
            _col = column;
          //  this.Width = 100;
        }

        protected override void Paint(Graphics g, Rectangle Bounds, CurrencyManager Source, int RowNum, Brush BackBrush, Brush ForeBrush, bool AlignToRight)
        {
            //can remove this if you don't want to vary the formatting on disabled cells
            bool enabled = true;


            if (CheckCellEven != null)
            {
                DataGridEnableEventArgs e = new DataGridEnableEventArgs(RowNum, _col, enabled);
                CheckCellEven(this, e);
                if (e.MeetsCriteria)
                    BackBrush = new SolidBrush(Color.Aquamarine);

                if (e.PaintColor)
                {//Закрашиваем по другому 
                    BackBrush = e.ColorRows;

                }
            }


            base.Paint(g, Bounds, Source, RowNum, BackBrush, ForeBrush, AlignToRight);


        }

    }
}
