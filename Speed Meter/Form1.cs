using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using Add_And_Remove_Programme_To_Or_From_Startup;
using System.Collections;
using System.Runtime.InteropServices;

namespace Speed_Meter
{
    public partial class Form1 : Form
    {
        private NetworkInterface[] nicArr;
        private NetworkInterface activeConnection;
        string bytesent = "0";
        string byterecieved = "0";
        private bool isMaximized = false;
        private bool close = true;
        int x = 0;
        string startupKey = "speedmeter";

        private long[] byteRecieved;
        private long[] byteSent;
        private bool[] connection;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            this.Location = new Point(1020, 680);
            InitializeComponent();
            init();
            timer1.Start();

            Startup.AddProgrammeToStartUp(startupKey);

        }

        private void init()
        {
            nicArr = NetworkInterface.GetAllNetworkInterfaces();
            byteRecieved = new long[nicArr.Length];
            byteSent = new long[nicArr.Length];
            connection = new bool[nicArr.Length];

            for(int i = 0; i < nicArr.Length; i++)
            {
                connection[i] = false;
                byteSent[i] = 0;
                byteRecieved[i] = 0;
            }
        }
        private void checkAvailableConnection()
        {
            bool flag = false;
            int pos = 0;
            IPv4InterfaceStatistics interfaceStats;

            for(int i = 0; i < nicArr.Length; i++)
            {
                interfaceStats = nicArr[i].GetIPv4Statistics();
                if(interfaceStats.BytesReceived != byteRecieved[i] || interfaceStats.BytesSent != byteSent[i])
                {
                    activeConnection = nicArr[i];
                    flag = true;
                    pos = i;
                   
                   
                }

              

            }
            
            int byteSentPerSec;
            int byteRecievedPerSec;

            if(flag){
                interfaceStats = nicArr[pos].GetIPv4Statistics();

                byteSentPerSec = (int)(interfaceStats.BytesSent - (double)byteSent[pos]) / 1024;
                byteRecievedPerSec = (int)(interfaceStats.BytesReceived - (double)byteRecieved[pos]) / 1024;
            }

            else
            {
                byteRecievedPerSec = 0;
                byteSentPerSec = 0;
            }

            lblUploadSpeed.Text = byteSentPerSec + " kb/s";
            lblAgueUp.Text = byteSentPerSec + " kb/s";

            lbldownload.Text = byteRecievedPerSec + " kb/s";
            lblAgueDown.Text = byteRecievedPerSec + " kb/s";


            aGaugeDown.Value = byteRecievedPerSec;
            aGaugeUp.Value = byteSentPerSec;

            if (close && x > 0)
            {
                this.Size = new Size(339, 36);
                close = false;
            }

            for(int i = 0; i < nicArr.Length; i++)
            {
                interfaceStats = nicArr[i].GetIPv4Statistics();

                byteSent[i] = interfaceStats.BytesSent;
                byteRecieved[i] = interfaceStats.BytesReceived;
            }

            

        }

       


        private void initialize()
        {
           
            nicArr = NetworkInterface.GetAllNetworkInterfaces();
            NetworkInterface n = nicArr[3];
            for(int i = 0; i < nicArr.Length; i++)
            {
                if (nicArr[i].Name == "Wi-Fi")
                {
                    n = nicArr[i];
                    break;
                }
            }
            
            IPv4InterfaceStatistics interfaceStats = n.GetIPv4Statistics();


            int bytesSentSpeed = (int)(interfaceStats.BytesSent - double.Parse(bytesent)) / 1024;
            int bytesReceivedSpeed = (int)(interfaceStats.BytesReceived - double.Parse(byterecieved)) / 1024;

            bytesent = interfaceStats.BytesSent.ToString();
            byterecieved = interfaceStats.BytesReceived.ToString();

            lblUploadSpeed.Text = bytesSentSpeed.ToString() + " kb/s";
            lblAgueUp.Text = bytesSentSpeed.ToString() + " kb/s";

            lbldownload.Text = bytesReceivedSpeed.ToString() + " kb/s";
            lblAgueDown.Text = bytesReceivedSpeed.ToString() + " kb/s";

            aGaugeDown.Value = bytesReceivedSpeed;
            aGaugeUp.Value = bytesSentSpeed;

            if (close && x > 0)
            {
                this.Size = new Size(339, 36);
                close = false;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
           // initialize();

            checkAvailableConnection();
            
        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isMaximized == true)
            {
                this.Size = new Size(339, 36);
                button1.Text = "Maximize";
                isMaximized = false;
                //this.Location = new Point(this.Location.X + 120, this.Location.Y + 300);
            }
            else if (isMaximized == false)
            {
                this.Size = new Size(472, 314);
                button1.Text = "Minimize";
                isMaximized = true;
               // this.Location = new Point(this.Location.X - 120, this.Location.Y - 300);
            }

        }

         private void FromMoveWithouse(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.ShowDialog();
        }
    }
}
