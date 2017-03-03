using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Configuration;


namespace DataBrCode_View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable _result;
        DataTable _resultOnline;
        Thread _updateTr;
        Thread _updateUpdater;
        Thread _updateTSDOnline;
        List<SolidColorBrush> ColorList;
        List<String> MacList = null;
        private string Login;
        private string pass;



        public string GetWebServiceURL
        {
            get
            {
                if (Dns.GetHostName().ToUpper() == "IVPAKHOLKOV-PC")
                    return "http://192.168.80.15:4607/WebSDataBrCode.asmx";
                else return "http://10.96.9.3:8081/WebSDataBrCode.asmx";

            }

        }

        public string GetWebServiceUpdaterURL
        {
            get
            {
                if (Dns.GetHostName().ToUpper() == "IVPAKHOLKOV-PC")
                    return "http://192.168.80.15:27078/websdatabrupdater.asmx";
                else return "http://10.96.9.3:8082/WebSDataBrUpdater.asmx";

            }

        }

        public MainWindow()
        {
            InitializeComponent();
            //Загружаем справичники

            Login = ConfigurationManager.AppSettings["Login"];
            pass = ConfigurationManager.AppSettings["Pass"];

            MacList = new List<string>();
            MacList.Add("-");


            ColorList = new List<SolidColorBrush>();
            ColorList.Add(new SolidColorBrush(Colors.Tomato));
            ColorList.Add(new SolidColorBrush(Colors.LightSkyBlue));
            ColorList.Add(new SolidColorBrush(Colors.LightSeaGreen));
            ColorList.Add(new SolidColorBrush(Colors.MediumAquamarine));
            ColorList.Add(new SolidColorBrush(Colors.LightSalmon));
            ColorList.Add(new SolidColorBrush(Colors.LightPink));
            ColorList.Add(new SolidColorBrush(Colors.Salmon));
            ColorList.Add(new SolidColorBrush(Colors.PaleTurquoise));
            ColorList.Add(new SolidColorBrush(Colors.Teal));
            ColorList.Add(new SolidColorBrush(Colors.LightSteelBlue));
            ColorList.Add(new SolidColorBrush(Colors.MistyRose));

            for (int i = 0; i < 20; i++)
            {
                ColorList.Add(new SolidColorBrush(Colors.LightGray));
            }

            _updateTr = new Thread(UpdateUi);
            _updateTr.Start();

            _updateUpdater = new Thread(UpdateUiUpdate);
            _updateUpdater.Start();

            _updateTSDOnline = new Thread(UpdateUiTSDOnline);
            _updateTSDOnline.Start();

        }

        private void UpdateUiUpdate(object obj)
        {
            while (true)
            {
                try
                {
                    ServiceReference2.WebSDataBrUpdaterSoapClient BrServer = new ServiceReference2.WebSDataBrUpdaterSoapClient();
                    //BrServer.S = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
                    BrServer.Endpoint.Address = new System.ServiceModel.EndpointAddress(GetWebServiceUpdaterURL);
                    _result = BrServer.GetLogTSD();


                    //GridViewLog.(new Action(() =>
                    //{
                    //    GridViewLog.DataContext = _result;
                    //}));
                    Dispatcher.Invoke(new Action(() =>
                    {
                        if (_result != null)
                        {
                            DataColumn colBack = new DataColumn("Background", typeof(SolidColorBrush));
                            _result.Columns.Add(colBack);

                            try
                            {
                                //Запилим проход
                                for (int i = 0; i < _result.Rows.Count; i++)
                                {
                                    string mac = _result.Rows[i]["Mac"].ToString();
                                    string service = _result.Rows[i]["SERVICE"].ToString();
                                    int indexF = MacList.IndexOf(mac);
                                    SolidColorBrush Color = GetColor(indexF, mac, service);
                                    //
                                    _result.Rows[i]["Background"] = Color;


                                }

                            }

                            catch (Exception) { }
                        }

                        // SetOracleImage(false);
                        GridViewLogUpdater.DataContext = _result;
                        // GridViewLog.

                    }));


                    Dispatcher.Invoke(new Action(() =>
                    {
                        // SetOracleImage(false);
                        TextStatusUpdater.Text = DateTime.Now.ToString() + ": Запрос к серверу - Ок";
                        // GridViewLog.
                    }));


                    Thread.Sleep(2000);

                }

                catch (Exception ex)
                {

                    try
                    {
                        Dispatcher.Invoke(new Action(() =>
                        {
                            // SetOracleImage(false);
                            TextStatusUpdater.Text = DateTime.Now.ToString() + ": Запрос к серверу - Exc: " + ex.Message;
                            // GridViewLog.
                        }));
                    }
                    catch (Exception) { }

                    Thread.Sleep(5000);
                }
            }
        }


        public void UpdateUi()
        {

            while (true)
            {
                try
                {
                    ServiceReference1.WebSDataBrCodeSoapClient BrServer = new ServiceReference1.WebSDataBrCodeSoapClient();
                    //BrServer.S = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
                    BrServer.Endpoint.Address = new System.ServiceModel.EndpointAddress(GetWebServiceURL);
                    ///Вот тут пилим авторизацию...
                    //if (BrServer.ClientCredentials != null)
                    //{
                    //    BrServer.ClientCredentials.UserName.UserName = Login;
                    //    BrServer.ClientCredentials.UserName.Password = pass;
                    //    BrServer.ClientCredentials.Windows.ClientCredential = new NetworkCredential(Login, pass);
                    //}

                    //  BrServer.ClientCredentials.Windows.ClientCredential = new NetworkCredential(Login, pass);
                    BrServer.ClientCredentials.UserName.UserName = Login;
                    BrServer.ClientCredentials.UserName.Password = pass;

                    _result = BrServer.GetLogTSD();


                    //GridViewLog.(new Action(() =>
                    //{
                    //    GridViewLog.DataContext = _result;
                    //}));
                    Dispatcher.Invoke(new Action(() =>
                    {
                        if (_result != null)
                        {
                            try
                            {
                                DataColumn colBack = new DataColumn("Background", typeof(SolidColorBrush));
                                _result.Columns.Add(colBack);
                            }

                            catch (Exception) { }

                            try
                            {
                                //Запилим проход
                                for (int i = 0; i < _result.Rows.Count; i++)
                                {
                                    string mac = _result.Rows[i]["Mac"].ToString();
                                    string service = _result.Rows[i]["SERVICE"].ToString();
                                    int indexF = MacList.IndexOf(mac);
                                    SolidColorBrush Color = GetColor(indexF, mac, service);
                                    //

                                    _result.Rows[i]["Background"] = Color;
                                }

                            }

                            catch (Exception) { }
                        }

                        // SetOracleImage(false);
                        GridViewLog.DataContext = _result;
                        // GridViewLog.

                    }));


                    Dispatcher.Invoke(new Action(() =>
                    {
                        // SetOracleImage(false);
                        TextStatus.Text = DateTime.Now.ToString() + ": Запрос к серверу - Ок";
                        // GridViewLog.
                    }));


                    Thread.Sleep(2000);

                }

                catch (Exception ex)
                {

                    try
                    {
                        Dispatcher.Invoke(new Action(() =>
                        {
                            // SetOracleImage(false);
                            TextStatus.Text = DateTime.Now.ToString() + ": Запрос к серверу - Exc: " + ex.Message + "USER: " + Login;
                            // GridViewLog.
                        }));
                    }
                    catch (Exception) { }

                    Thread.Sleep(5000);


                }
            }

        }

        public SolidColorBrush GetColor(int indexF, string mac, string service)
        {
            SolidColorBrush Color = null;

            if (indexF == -1)
            {
                MacList.Add(mac);
                Color = new SolidColorBrush(Colors.LightGreen);
            }
            else if (mac == "-")
            {
                Color = new SolidColorBrush(Colors.LightGray);
            }

            else if (service == "Login")
            {
                Color = new SolidColorBrush(Colors.MediumTurquoise);
            }
            else
            {
                Color = ColorList[indexF];
            }

            return Color;
        }

        public void UpdateUiTSDOnline()
        {

            while (true)
            {
                try
                {
                    ServiceReference1.WebSDataBrCodeSoapClient BrServer = new ServiceReference1.WebSDataBrCodeSoapClient();
                    //BrServer.S = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
                    BrServer.Endpoint.Address = new System.ServiceModel.EndpointAddress(GetWebServiceURL);
                    ///Вот тут пилим авторизацию...
                    //if (BrServer.ClientCredentials != null)
                    //{
                    //    BrServer.ClientCredentials.UserName.UserName = Login;
                    //    BrServer.ClientCredentials.UserName.Password = pass;
                    //    BrServer.ClientCredentials.Windows.ClientCredential = new NetworkCredential(Login, pass);
                    //}

                    //  BrServer.ClientCredentials.Windows.ClientCredential = new NetworkCredential(Login, pass);
                    BrServer.ClientCredentials.UserName.UserName = Login;
                    BrServer.ClientCredentials.UserName.Password = pass;

                    _resultOnline = BrServer.GetLogTSDOnline();


                    //GridViewLog.(new Action(() =>
                    //{
                    //    GridViewLog.DataContext = _result;
                    //}));
                    Dispatcher.Invoke(new Action(() =>
                    {
                        if (_resultOnline != null)
                        {
                            try
                            {
                                DataColumn colBack = new DataColumn("Background", typeof(SolidColorBrush));
                                _resultOnline.Columns.Add(colBack);
                            }

                            catch (Exception) { }
                            try
                            {
                                //Запилим проход
                                for (int i = 0; i < _resultOnline.Rows.Count; i++)
                                {
                                    string mac = _resultOnline.Rows[i]["Mac"].ToString();
                                    string service = "";
                                    int indexF = MacList.IndexOf(mac);
                                    SolidColorBrush Color = GetColor(indexF, mac, service);

                                    _resultOnline.Rows[i]["Background"] = Color;
                                }

                            }

                            catch (Exception) { }
                        }

                        // SetOracleImage(false);
                        GridViewLogOnline.DataContext = _resultOnline;
                        // GridViewLog.

                    }));


                    Dispatcher.Invoke(new Action(() =>
                    {
                        // SetOracleImage(false);
                        TextStatusOnline.Text = DateTime.Now.ToString() + ": Запрос к серверу - Ок";
                        // GridViewLog.
                    }));


                    Thread.Sleep(2000);

                }

                catch (Exception ex)
                {

                    try
                    {
                        Dispatcher.Invoke(new Action(() =>
                        {
                            // SetOracleImage(false);
                            TextStatusOnline.Text = DateTime.Now.ToString() + ": Запрос к серверу - Exc: " + ex.Message + "USER: " + Login;
                            // GridViewLog.
                        }));
                    }
                    catch (Exception) { }

                    Thread.Sleep(5000);


                }
            }

        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            try
            {
                _updateTr.Abort();
            }

            catch (Exception) { }

            try
            {
                _updateUpdater.Abort();
            }

            catch (Exception) { }


            try
            {
                _updateTSDOnline.Abort();
            }

            catch (Exception) { }
        }








    }
}
