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
    public partial class QueueTask : Form
    {
        public bool FormActive = true;
        public Intermec.DataCollection.BarcodeReader bcr;
        public ListScanOperation ScanOperation;
        public DataTable _tblTask;
        public string SelectRZDN = "-";
        QueueTaskEU _taskEU = null;

        public QueueTask(Intermec.DataCollection.BarcodeReader _bcr, ListScanOperation _ScanOperation)
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
        {

        
            using (SQLiteConnection connection = new SQLiteConnection())
            {

                //Тут делаем таблицу и выводим инфу

                _tblTask = new DataTable("TASK");

                ;//(SQLiteConnection)factory.CreateConnection();
                connection.ConnectionString = "Data Source = " + SqLiteDB.pathDBFull_EU;
                SQLiteCommand command = new SQLiteCommand(connection);
               // SQLiteCommand insert = new SQLiteCommand("select * from TASKLIST WHERE ROWNUM <> -1 ORDER BY TASKLIST.ROWNUM  LIMIT 100;", connection);
                //
                SQLiteCommand insert = new SQLiteCommand("select TASKLIST.RZDN_PRM, TASKLIST.ZDN_NUM, TASKLIST.TASK_MARKA, TASKLIST.TASK_STANDART_MARKA, printf('%sx%s', TASKLIST.TASK_THICKNESS, TASKLIST.TASK_WIDTH) 'RAZMER', TASKLIST.RZDN_STATUS from TASKLIST WHERE ROWNUM <> -1 ORDER BY TASKLIST.ROWNUM  LIMIT 100;", connection);
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
                        SelectRZDN = dataGridTask[0, 5].ToString();
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

  

        private void QueueTask_KeyDown(object sender, KeyEventArgs e)
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
        {
            ///*/*/*///
            ///

            ///ОТкрываем форму для сканирования
            ///
            if (_taskEU == null)
            {
                _taskEU = new QueueTaskEU(bcr, SelectRZDN);
                _taskEU.Show();
            }

            else
            {
                if (_taskEU.FormActive) { }
                else
                {
                    _taskEU.Close();
                    // UIEU.Dispose();
                    _taskEU = new QueueTaskEU(bcr, SelectRZDN);
                    _taskEU.Show();
                }
            }


        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            OperationNext();
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

        private void dataGridTask_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridTask.Select(dataGridTask.CurrentRowIndex);
                //Установим нужные значения

                SelectRZDN = dataGridTask[dataGridTask.CurrentRowIndex, 5].ToString();
 

            }
            catch (Exception ex)
            {

            }
        }
    }
}