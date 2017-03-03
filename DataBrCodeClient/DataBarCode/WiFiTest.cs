using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenNETCF.Net;

namespace DataBarCode
{
    public partial class WiFiTest : Form
    {
        OpenNETCF.Net.NetworkInformation.WirelessNetworkInterface IWiFiCurrent = null;
        public WiFiTest()
        {
            InitializeComponent();




        }

        private void WiFiTest_KeyDown(object sender, KeyEventArgs e)
        {
            ///
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F5)
            {
                GetWiFI();
            }
        }

        private void GetWiFI()
        {
            try
            {
                labelNetWiFi.Text = "";
                
               // OpenNETCF.Net.NetworkInformation.WirelessZeroConfigNetworkInterface INw;

                foreach (OpenNETCF.Net.NetworkInformation.INetworkInterface ni in OpenNETCF.Net.NetworkInformation.WirelessNetworkInterface.GetAllNetworkInterfaces())
                {
                    /*
                     *         if (ni is OpenNETCF.Net.NetworkInformation.WirelessNetworkInterface) listBox1.Items.Add("Is Wireless");
                                if (ni is OpenNETCF.Net.NetworkInformation.WirelessZeroConfigNetworkInterface) listBox1.Items.Add("Is WZC");

                                if (ni is OpenNETCF.Net.NetworkInformation.WirelessZeroConfigNetworkInterface )
                                {  // wireless zero config.
                                  INw = (OpenNETCF.Net.NetworkInformation.WirelessZeroConfigNetworkInterface)ni;
                                  listBox1.Items.Add(" AP: " + INw.AssociatedAccessPoint);
                                  listBox1.Items.Add(" AP MAC: " + INw.AssociatedAccessPointMAC.ToString());
                                }
                                else if (ni is OpenNETCF.Net.NetworkInformation.WirelessNetworkInterface )
                                {  // wireless network
                                  IN = (OpenNETCF.Net.NetworkInformation.WirelessNetworkInterface)ni;
                                  listBox1.Items.Add(" AP: " + IN.AssociatedAccessPoint);
                                  listBox1.Items.Add(" AP MAC: " + IN.AssociatedAccessPointMAC.ToString());
                                }
                              }
                     * */
                    if (ni is OpenNETCF.Net.NetworkInformation.WirelessNetworkInterface)
                    {  // wireless network
                        IWiFiCurrent = (OpenNETCF.Net.NetworkInformation.WirelessNetworkInterface)ni;
                        labelNetWiFi.Text += "AP: " + IWiFiCurrent.AssociatedAccessPoint;
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

        }

        private void buttonWifiOff_Click(object sender, EventArgs e)
        {
            if (IWiFiCurrent != null)
            {
                //Пробуем что то сделать
                //IWiFiCurrent.
                if (IWiFiCurrent.AssociatedAccessPoint == textBoxWiFi.Text)
                {
                    MessageBox.Show("Уже подключены к: " + IWiFiCurrent.AssociatedAccessPoint);
                }
                else
                {
                    try
                    {
                      //  IWiFiCurrent.Connect(textBoxWiFi.Text);
                       
                        //  IWiFiCurrent.AuthenticationMode = OpenNETCF.Net.NetworkInformation.AuthenticationMode.WPA2PSK
                        OpenNETCF.Net.ConnectionManager mng = new ConnectionManager();
                        
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
    }
}