using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DataBarCode
{
    public partial class InventTaskList : Form
    {
        public ListScanOperation ScanOperation;
        public DataTable _tblTask;
        public Intermec.DataCollection.BarcodeReader bcr;
        public bool FormActive = true;
        private string SelectRZDN = "";
        private string SelectRZDNDate = "";
        private string SelectRZDNMore = "";
        private InventTaskMX _InventTaskMX = null;

        public InventTaskList(Intermec.DataCollection.BarcodeReader _bcr, ListScanOperation _ScanOperation)
        {
            InitializeComponent();

            bcr = _bcr;
            ScanOperation = _ScanOperation;
            //Тут правим лейбл
            string StatusBD = "БД: " + SqLiteDB.UpdateDateTime + ". Операции: " + BufferToBD.CountBuffer;

            labelBD.BeginInvoke(new Action(() =>
            {
                labelBD.Text = StatusBD;
            }));
            this.KeyPreview = true;

            LoadRZDN();
        }


        private void LoadRZDN()
        {//Загрузка заданий


            using (SQLiteConnection connection = new SQLiteConnection())
            {

                //Тут делаем таблицу и выводим инфу

                _tblTask = new DataTable("TASK");

                ;//(SQLiteConnection)factory.CreateConnection();
                connection.ConnectionString = "Data Source = " + SqLiteDB.pathDBFull_EU;
                SQLiteCommand command = new SQLiteCommand(connection);
                // SQLiteCommand insert = new SQLiteCommand("select * from TASKLIST WHERE ROWNUM <> -1 ORDER BY TASKLIST.ROWNUM  LIMIT 100;", connection);
                //
                SQLiteCommand insert = new SQLiteCommand("select  TASKLIST.RZDN_DATE, TASKLIST.TS_NUM, TASKLIST.RZDN_PRM from TASKLIST WHERE TASKLIST.OPER_TYPE_ID == 1050 ORDER BY TASKLIST.ROWNUM  LIMIT 100;", connection);
                connection.Open();
                SQLiteDataReader reader = insert.ExecuteReader();
                _tblTask.Load(reader);
                reader.Close();
                connection.Close();

                command.Dispose();
                insert.Dispose();
                reader.Dispose();

            }


            dataGridTask.BeginInvoke(new Action(() =>
            {
                dataGridTask.DataSource = _tblTask;
            }));

            if (_tblTask.Rows.Count > 0)
            {

                buttonNext.BeginInvoke(new Action(() =>
                {
                    buttonNext.Enabled = true;
                }));


                dataGridTask.BeginInvoke(new Action(() =>
                {
                    dataGridTask.Select(0);

                    try
                    {
                        SelectRZDN = dataGridTask[0, 2].ToString();
                        SelectRZDNDate = dataGridTask[0, 0].ToString();
                        SelectRZDNMore = dataGridTask[0, 1].ToString();
                    }

                    catch (Exception ex)
                    {
                        // MessageBox.Show(ex.Message);
                    }

                }));

                //SelectLabel = dataGridEu[dataGridEu.CurrentRowIndex, 3].ToString();
                //SelectYE = dataGridEu[dataGridEu.CurrentRowIndex, 0].ToString();
                //SelectMarka = dataGridEu[dataGridEu.CurrentRowIndex, 1].ToString();
                //SelectRazmer = dataGridEu[dataGridEu.CurrentRowIndex, 2].ToString();
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string StatusBD = StatusBar.getSatus();

                labelBD.BeginInvoke(new Action(() =>
                {
                    labelBD.Text = StatusBD;
                    labelBD.ForeColor = StatusBar.GetColorLabel();
                }));
            }

            catch (Exception) { }
        }

        private void InventTaskList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormActive = false;
                this.Close();
            }

            else if (e.KeyCode == Keys.F1)
            {
                ///Интерфейс для теста


            }

            else if (e.KeyCode == Keys.F9)
            {
                OperationNext();
            }
        }

        private void OperationNext()
        {//Переходим к форма просмотра МХ, и задания

            if (_InventTaskMX == null)
            {
                _InventTaskMX = new InventTaskMX(bcr, ListScanOperation.InventoryTask, SelectRZDN, SelectRZDNDate, SelectRZDNMore);
                _InventTaskMX.Show();
            }

            else
            {
                if (_InventTaskMX.FormActive) { }
                else
                {
                    _InventTaskMX.Close();
                    // UIEU.DisposeInventTaskList
                    _InventTaskMX = new InventTaskMX(bcr, ListScanOperation.InventoryTask, SelectRZDN, SelectRZDNDate, SelectRZDNMore);
                    _InventTaskMX.Show();
                }
            }
        }

        private void dataGridTask_CurrentCellChanged_1(object sender, EventArgs e)
        {
            try
            {
                dataGridTask.Select(dataGridTask.CurrentRowIndex);
                //Установим нужные значения

                 SelectRZDN = dataGridTask[dataGridTask.CurrentRowIndex, 2].ToString();
                 SelectRZDNDate = dataGridTask[dataGridTask.CurrentRowIndex, 0].ToString();
                 SelectRZDNMore = dataGridTask[dataGridTask.CurrentRowIndex, 1].ToString();

            }
            catch (Exception ex)
            {

            }
        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            OperationNext();

        }
    }
}