using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ProfForTest;

namespace NonameThing_1
{
    public partial class LoginForm : Form
    {
        public static TcpListener tlsListn;
        internal bool online = false;
        NetworkStream tcpStream;
        TcpClient tcpClient;

        public Request sh = new Request();
        string adr; 
        int serverPort; 
        int localport = 2113;
        public LoginForm()
        {
            InitializeComponent();
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Visible = true;
            mf.Enabled = true;
            if (online == true)
            {
                adr = IP1.Text;
                serverPort = int.Parse(textBoxServerPort.Text);
                LogIn();
            }
            else
                offlineLogIn();
        }

        private void LogIn()
        {
            try
            {
                using (tcpClient = new TcpClient())
                {
                    try
                    {
                        sh.login = Login.Text;
                        sh.password = Password.Text;
                        sh.port = localport;
                        sh.ipadress = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
                        BinaryFormatter binaryFmt = new BinaryFormatter();
                        tcpClient.Connect(adr, serverPort);
                        tcpStream = tcpClient.GetStream();
                        binaryFmt.Serialize(tcpStream, sh);
                        tcpStream = tcpClient.GetStream();
                        sh = (Request)new BinaryFormatter().Deserialize(tcpStream);
                        tcpStream.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        tcpStream.Close();
                    }
                }
            }
            catch (Exception ex) { sh.exception = ex.ToString(); }

            if (sh.permission)  
            {
                Form1.isOk = 1;
                Program.Info = new SysInfo(sh.login, sh.password, sh.access_value, adr, serverPort, sh.ipadress, sh.port);
                this.Close();
            }
            else{ MessageBox.Show(sh.exception);}  

        }
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                LogIn();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
               Password.Focus();
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                LogIn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel1.Visible = true;
        }

        void offlineLogIn()
        {
            Form1.isOk = 2;
            Program.Info = new SysInfo();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.loginMode == 1)
                onlineRB.Checked = true;
            else
                oflineRB.Checked = true;
            IP1.Text = Properties.Settings.Default.serverIP;
            textBoxServerPort.Text = Properties.Settings.Default.serverPort;
        }

        private void onlineRB_CheckedChanged(object sender, EventArgs e)
        {
            if (onlineRB.Checked)
            {
                online = true;
                IP1.Enabled = true;
                textBoxServerPort.Enabled = true;
                Login.Enabled = true;
                Password.Enabled = true;
            }
        }

        private void oflineRB_CheckedChanged(object sender, EventArgs e)
        {
            if (oflineRB.Checked)
            {
                online = false;
                IP1.Enabled = false;
                textBoxServerPort.Enabled = false;
                Login.Enabled = false;
                Password.Enabled = false;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (online)
            {
                Properties.Settings.Default.loginMode = 1;
                Properties.Settings.Default.serverIP = adr;
                Properties.Settings.Default.serverPort = serverPort.ToString();
            }
            else
                Properties.Settings.Default.loginMode = 0;
            Properties.Settings.Default.Save();
        }
    }
}
