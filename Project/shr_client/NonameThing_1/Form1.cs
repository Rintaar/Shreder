using System;
using System.Collections.Generic;
using ProfForTest;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.NetworkInformation;
using System.Drawing;
using System.Text.RegularExpressions;

namespace NonameThing_1
{

    public partial class Form1 : Form
    {

        static DateTime LastSeen;
        static bool fnKey = false;
        public static int isOk = 0;
        IPEndPoint endPoint;
        List<DateTime> cal_date = new List<DateTime>();
        List<DayOfWeek> cal_dow = new List<DayOfWeek>();
        private System.Threading.Thread TH;
        static List<BUdate> cal = new List<BUdate>() { };
        Timer timer;
        static string file;
        private delegate void UpdateProgressCallback(Int64 BytesRead, Int64 TotalBytes);
        private delegate void UpdateProgressLabel(string Message);
        private static IPAddress serverIP;
        internal bool alreadySend = false;
        KeyboardHook kh = new KeyboardHook(true);

        public Form1()
        {
            InitializeComponent();
            notifyIcon1.BalloonTipText = "Шредер";
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            notifyIcon1.Visible = false;
            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.Form1_Resize);



            Choosedirectory.FlatAppearance.BorderSize = 0;
            Choosedirectory.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kh.KeyDown += Kh_KeyDown;
            kh.KeyDown += Kh_KeyUP;
            kh.KeyUp += KshUP;

            panel2.Visible = false;
            panel2.Enabled = false;

            if (isOk == 0)
                this.Close();
            else
            {
                LogIn();

                timer = new Timer();
                timer.Tick += new EventHandler(Tick);
                timer.Interval = 1000;
                timer.Start();

                Program.Info.BuDir = Properties.Settings.Default.BUDirectory;
                Program.Info.LocalBuDir = Properties.Settings.Default.localBUAddress;
            }
        }

        private void Kh_KeyDown(Keys key, bool Shift, bool Ctrl, bool Alt)
        {
            if (key == Keys.LMenu || key == Keys.RMenu)
                fnKey = true;
        }

        private void Kh_KeyUP(Keys key, bool Shift, bool Ctrl, bool Alt)
        {
            if (fnKey)
                if (key == Keys.A)
                    Send();
        }

        private void KshUP(Keys key, bool Shift, bool Ctrl, bool Alt)
        {
            if (key == Keys.LMenu || key == Keys.RMenu)
                fnKey = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void LogIn()
        {
            if (isOk == 1)
            {
                label2.Text = Program.Info.GetUserName();
                LogOut.Text = "Выйти";
            }
            else
            {
                label2.Text = "Вход не выпонен";
                LogOut.Text = "Войти";
            }
            cal.Clear();

            if (Properties.Settings.Default.LastSeen != null)
            {
                LastSeen = Properties.Settings.Default.LastSeen;
                //if (LastSeen )
            }

            //if (Properties.Settings.Default.Datelist != null)
            //{
            //    if (Properties.Settings.Default.Datelist.Count > 0)
            //    {
            //        cal_date = Properties.Settings.Default.Datelist;
            //        makeClass(cal_date);
            //        OverrideDate();
            //    }
            //}

            Program.Info.BuDir = Properties.Settings.Default.BUDirectory;
            Program.Info.LocalBuDir = Properties.Settings.Default.localBUAddress;

            buprocText.Text = "";
            buprocText.Visible = false;
            BUProgressBar.Visible = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;

        }
        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }
        
        static int selMin = 1;

        private void IsTime()
        {
            foreach (BUdate date in cal)
                if (date.GetDow() == DateTime.Now.DayOfWeek)
                    if (date.GetTime().Hour == DateTime.Now.Hour && date.GetTime().Minute == DateTime.Now.Minute)
                    {
                        if (selMin == 1)
                        {
                            selMin = DateTime.Now.Minute;
                            Send();
                        }
                    }
                    else
                    {
                        selMin = 1;
                    }
        }

        private void makeClass(List<DateTime> l1)
        {
            for (int i = 0; i < l1.Count(); i++)
            {
                BUdate date = new BUdate(l1[i]);
                cal.Add(date);
            }
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
        }

        private void Choosedirectory_Click(object sender, EventArgs e)
        {
            SelectBUDir();
        }

        private void SelectBUDir()
        {
            ChooseDir.ShowNewFolderButton = false;
            string sp = string.Empty;
            if (ChooseDir.ShowDialog() == DialogResult.OK)
                Program.Info.BuDir = ChooseDir.SelectedPath;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDate();
        }

        private void AddNewDate()
        {
            SetDate SD = new SetDate();
            SD.ShowDialog();
            if (SD.isOK)
            {
                cal.Add(new BUdate(SD.bdate));
                Sort();
                OverrideDate();
            }
        }

        private void DeliteDate()
        {
            cal.RemoveAt(BackupList.SelectedIndex);
            OverrideDate();
        }

        private void OverrideDate()
        {
            BackupList.DataSource = null;
            BackupList.Items.Clear();
            BackupList.DataSource = cal;
            BackupList.SelectedIndex = -1;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            var str = Program.Info.GetLocalIP() + "_" + Program.Info.GetUserName() + DateTime.Now.Second.ToString() + "file";
            Compression.CompressionFolder(Program.Info.BuDir, str);
            file = Program.Info.BuDir + "\\" + str + ".zip";
            Send();
        }

        private void BackupList_MouseDown(object sender, MouseEventArgs e)
        {
            BackupList.SelectedIndex = BackupList.IndexFromPoint(e.X, e.Y);
            if (BackupList.SelectedIndex == -1)
                удалитьToolStripMenuItem.Enabled = false;
            else
                удалитьToolStripMenuItem.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cal_date.Clear();
            foreach (BUdate bud in cal)
                cal_date.Add(bud.GetTime());
            // Properties.Settings.Default.Datelist = cal_date;
            //Properties.Settings.Default.BUDirectory = Program.Info.BuDir;
            //Properties.Settings.Default.localBUAddress = Program.Info.LocalBuDir;
            //Properties.Settings.Default.LastSeen = DateTime.Now;
            //Properties.Settings.Default.Save();
        }

        private void Sort()
        {
            List<BUdate> tmp1 = new List<BUdate>();
            List<DateTime> tmp2 = new List<DateTime>();
            for (int i = 1; i <= 7; i++)
            {
                foreach (BUdate bud in cal)
                    if (bud.GetDowInt() == i)
                        tmp2.Add(bud.GetTime());
                tmp2.Sort();
                foreach (DateTime date in tmp2)
                    foreach (BUdate bud in cal)
                        if (bud.GetDowInt() == i && bud.GetTime() == date)
                            tmp1.Add(bud);
                tmp2.Clear();
            }
            cal = tmp1;
        }

        private void Send()
        {
            if (string.IsNullOrEmpty(Program.Info.BuDir))
                MessageBox.Show("Папка не выбрана");
            else
            {
                buprocText.Text = "Архивация";
                buprocText.Visible = true;
                BUProgressBar.Visible = true;
                if (isOk == 1)
                    TH = new System.Threading.Thread(() => SendBU());
                else
                    TH = new System.Threading.Thread(() => SendLocalBU());
                TH.Start();
            }
        }

        private void CheckInternet()
        {
            PingReply reply = new Ping().Send(Program.Info.GetServerIP(), 500, new byte[32], new PingOptions());
            if (reply.Status == IPStatus.Success)
            {
                isOk = 1;
                label2.Font = new Font("Arial", 11.25f, FontStyle.Regular);
            }
            else
            {
                isOk = 2;
                label2.Font = new Font("Arial", 11.25f, FontStyle.Strikeout);
            }
        }

        private void Tick(object sender, EventArgs e)
        {
            if (isOk == 1)
                CheckInternet();
            IsTime();
        }

        private void UpdateProgress(Int64 BytesSend, Int64 TotalBytes)
        {
            if (TotalBytes > 0)
                BUProgressBar.Value = Convert.ToInt32((BytesSend * 100) / TotalBytes);
            else
            {
                BUProgressBar.Value = 0;
                BUProgressBar.Visible = false;
            }
        }

        private void UpdateLabel(string message)
        {
            buprocText.Text = message;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Удалить?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                DeliteDate();
        }

        private void BackupList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
                if (BackupList.SelectedIndex != -1)
                {
                    DialogResult res = MessageBox.Show("Удалить?", "", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                        DeliteDate();
                }
        }

        private void SendLocalBU()
        {
            System.Threading.Thread.CurrentThread.IsBackground = true;
            
            var str = Program.Info.GetLocalIP() + "_" + Program.Info.GetUserName();
            Compression.CompressionFolder(Program.Info.BuDir, str);
            file = Program.Info.BuDir + "\\" + str + ".zip";
            
            using (FileStream source = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                long fileSize = source.Length;
                this.Invoke(new UpdateProgressLabel(UpdateLabel), "Копирование");

                using (FileStream bustream = new FileStream(Program.Info.LocalBuDir, FileMode.CreateNew, FileAccess.Write))
                {
                    try
                    {
                        long totalBytes = 0;
                        int currentBlockSize = 0;
                        byte[] downBuffer = new byte[2048];
                        
                        while ((currentBlockSize = source.Read(downBuffer, 0, downBuffer.Length)) > 0)
                        {
                            totalBytes += currentBlockSize;
                            bustream.Write(downBuffer, 0, currentBlockSize);
                            this.Invoke(new UpdateProgressCallback(this.UpdateProgress), new object[] { totalBytes, fileSize });
                        }
                        this.Invoke(new UpdateProgressLabel(UpdateLabel), "Готово");
                    }
                    catch
                    {
                        this.Invoke(new UpdateProgressLabel(UpdateLabel), "Ошибка");
                    }
                    finally
                    {
                        System.Threading.Thread.Sleep(1000);
                        File.Delete(file);
                        this.Invoke(new UpdateProgressLabel(UpdateLabel), "");
                        this.Invoke(new UpdateProgressCallback(this.UpdateProgress), new object[] { 0, 0 });
                    }
                }
            }
        }

        TcpClient BUsender;

        private void SendBU()
        {
            System.Threading.Thread.CurrentThread.IsBackground = true;

            var str = Program.Info.GetLocalIP() + "_" + Program.Info.GetUserName();

            Compression.CompressionFolder(Program.Info.BuDir, str);
            file = Program.Info.BuDir + "\\" + str + ".zip";

            using (BUsender = new TcpClient())
                try
                {
                    this.Invoke(new UpdateProgressLabel(UpdateLabel), "Отправка");
                    Request sh = new Request(Program.Info.GetUserName(), 1, true);
                    BinaryFormatter binaryFmt = new BinaryFormatter();
                    BUsender.Connect(IPAddress.Parse(Program.Info.GetServerIP()), Program.Info.GetServerPort());
                    NetworkStream bustream = BUsender.GetStream();
                    binaryFmt.Serialize(bustream, sh);
                    bustream.Flush();

                    System.Threading.Thread.Sleep(500);

                    byte[] byteSend = new byte[BUsender.ReceiveBufferSize];
                    var fstFile = new FileStream(file, FileMode.Open, FileAccess.Read);
                    BinaryReader binFile = new BinaryReader(fstFile);
                    FileInfo fInfo = new FileInfo(file);
                    string fileName = fInfo.Name;
                    byte[] ByteFileName = new byte[2048];

                    ByteFileName = Encoding.ASCII.GetBytes(fileName.ToCharArray());
                    bustream.Write(ByteFileName, 0, ByteFileName.Length);

                    long FileSize = fInfo.Length;
                    byte[] ByteFileSize = new byte[2048];
                    ByteFileSize = Encoding.ASCII.GetBytes(FileSize.ToString().ToCharArray());
                    bustream.Write(ByteFileSize, 0, ByteFileSize.Length);
                    System.Threading.Thread.Sleep(100);

                    int bytesSize = 0;
                    long sent = 0;
                    byte[] downBuffer = new byte[2048];
                    while ((bytesSize = fstFile.Read(downBuffer, 0, downBuffer.Length)) > 0)
                    {
                        bustream.Write(downBuffer, 0, bytesSize);
                        sent += downBuffer.LongLength;
                        this.Invoke(new UpdateProgressCallback(this.UpdateProgress), new object[] { sent, FileSize });
                    }
                    bustream.Close();
                    fstFile.Close();
                    this.Invoke(new UpdateProgressLabel(UpdateLabel), "Готово");
                }
                catch
                {
                    this.Invoke(new UpdateProgressLabel(UpdateLabel), "Ошибка");
                }
                finally
                {
                    File.Delete(file);
                    System.Threading.Thread.Sleep(1000);
                    this.Invoke(new UpdateProgressLabel(UpdateLabel), "");
                    this.Invoke(new UpdateProgressCallback(this.UpdateProgress), new object[] { 0, 0 });
                }
        }

        private void Recieve()
        {
            if (string.IsNullOrEmpty(Program.Info.BuDir))
                MessageBox.Show("Папка бэкапа не выбрана");
            else if (string.IsNullOrEmpty(Program.Info.LocalBuDir))
                MessageBox.Show("Не выбрана папка локального хранения бэкапа");
            else
            {
                if (isOk == 1)
                    TH = new System.Threading.Thread(() => RecieveBU());
                else
                    TH = new System.Threading.Thread(() => RecieveLocalBU());
                buprocText.Visible = true;
                BUProgressBar.Visible = true;
                TH.Start();
            }
        }

        private void Logout()
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            lf.Dispose();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Logout();
            LogIn();
        }

        private void SelectLocalBUDir()
        {
            string sp = string.Empty;
            if (ChooseDir.ShowDialog() == DialogResult.OK)
                Program.Info.LocalBuDir = ChooseDir.SelectedPath;
        }

        private void RecieveLocalBU()
        {
            System.Threading.Thread.CurrentThread.IsBackground = true;
            
            var str = Program.Info.GetLocalIP() + "_" + Program.Info.GetUserName();
            Compression.CompressionFolder(Program.Info.LocalBuDir, str);
            file = Program.Info.BuDir + "\\" + str + ".zip";
            
            using (FileStream source = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                long fileSize = source.Length;
                this.Invoke(new UpdateProgressLabel(UpdateLabel), "Получение");
                using (FileStream bustream = new FileStream(Program.Info.BuDir, FileMode.CreateNew, FileAccess.Write))
                {
                    try
                    {
                        long totalBytes = 0;
                        int currentBlockSize = 0;
                        byte[] downBuffer = new byte[2048];

                        while ((currentBlockSize = source.Read(downBuffer, 0, downBuffer.Length)) > 0)
                        {
                            totalBytes += currentBlockSize;
                            bustream.Write(downBuffer, 0, currentBlockSize);
                            this.Invoke(new UpdateProgressCallback(this.UpdateProgress), new object[] { totalBytes, fileSize });
                        }
                        this.Invoke(new UpdateProgressLabel(UpdateLabel), "Готово");
                    }
                    catch
                    {
                        this.Invoke(new UpdateProgressLabel(UpdateLabel), "Ошибка");
                    }
                    finally
                    {
                        System.Threading.Thread.Sleep(1000);
                        File.Delete(file);
                        this.Invoke(new UpdateProgressLabel(UpdateLabel), "");
                        this.Invoke(new UpdateProgressCallback(this.UpdateProgress), new object[] { 0, 0 });
                    }
                }
            }
        }

        private void RecieveBU()
        {
            using (TcpClient TC = new TcpClient())
            {

                this.Invoke(new UpdateProgressLabel(UpdateLabel), "Приём");
                Request sh = new Request(Program.Info.GetUserName(), Program.Info.GetLocalIP(), 2, true);
                BinaryFormatter binaryFmt = new BinaryFormatter();

                serverIP = IPAddress.Parse(Program.Info.GetServerIP());
                endPoint = new IPEndPoint(serverIP, Program.Info.GetServerPort());
                TC.Connect(endPoint);
                NetworkStream strRemote = TC.GetStream();
                binaryFmt.Serialize(strRemote, sh);
                strRemote.Flush();

                if (Program.Info.BuDir != null)
                {
                    try
                    {
                        int bytesSize = 0;
                        byte[] downBuffer = new byte[2048];
                        bytesSize = strRemote.Read(downBuffer, 0, 2048);
                        string FileName = Encoding.ASCII.GetString(downBuffer, 0, bytesSize);
                        var strLocal = new FileStream(Program.Info.BuDir +@"/"+ FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                        downBuffer = new byte[2048];
                        bytesSize = strRemote.Read(downBuffer, 0, 2048);
                        var str1 = Encoding.ASCII.GetString(downBuffer, 0, bytesSize);
                        long FileSize = Int64.Parse(str1);
                        downBuffer = new byte[2048];
                        while ((bytesSize = strRemote.Read(downBuffer, 0, downBuffer.Length)) > 0)
                        {
                            strLocal.Write(downBuffer, 0, bytesSize);
                            this.Invoke(new UpdateProgressCallback(this.UpdateProgress), new object[] { strLocal.Length, FileSize });
                        }
                        strLocal.Close();
                        System.Threading.Thread.Sleep(500);
                        try
                        {
                            this.Invoke(new UpdateProgressCallback(this.UpdateProgress), new object[] { 0, 0 });
                            this.Invoke(new UpdateProgressLabel(UpdateLabel), "Разархивация");
                            Compression.DeCompressionFolder(Program.Info.BuDir + @"/" + FileName, Program.Info.BuDir);
                            System.Threading.Thread.Sleep(1000);
                            File.Delete(Program.Info.BuDir + @"/" + FileName);
                            this.Invoke(new UpdateProgressLabel(UpdateLabel), "Готово");
                        }
                        catch
                        {
                            this.Invoke(new UpdateProgressLabel(UpdateLabel), "Ошибка при разархивации");
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                    catch
                    {
                        this.Invoke(new UpdateProgressLabel(UpdateLabel), "Ошибка при получении");
                        System.Threading.Thread.Sleep(1000);
                    }
                    finally
                    {
                        strRemote.Close();
                        this.Invoke(new UpdateProgressCallback(this.UpdateProgress), new object[] { 0, 0 });
                        this.Invoke(new UpdateProgressLabel(UpdateLabel), "");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Recieve();   
        }

        private void settingsTabPage_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = Program.Info.GetUserName();
            buDirTextBox.Text = Program.Info.BuDir;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.Enabled = false;
            settingsTabPage_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Enabled = true;
            settingsControl.Visible = true;
            settingsControl.Enabled = true;
            //MessageBox.Show(settingsControl.Visible.ToString());
        }

        private void ChangeUserPassword(string password)
        {
            Request req = new Request(Program.Info.GetUserName(), password , 4, true);
            NetworkStream tcpStream;
            try
            {
                using (var tcpClient = new TcpClient())
                {
                    try
                    {                        
                        BinaryFormatter binaryFmt = new BinaryFormatter();
                        tcpClient.Connect(Program.Info.GetServerIP(), Program.Info.GetServerPort());
                        tcpStream = tcpClient.GetStream();
                        binaryFmt.Serialize(tcpStream, req);
                        tcpStream = tcpClient.GetStream();
                        req = (Request)new BinaryFormatter().Deserialize(tcpStream);
                        tcpStream.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception ex) { req.exception = ex.ToString(); }
        }

        private void ChangeFIO()
        {
            Request req = new Request();//(Program.Info.GetUserName(), Program.Info.GetUserPas(), Program.Info.GetLocalIP(), 4, true);
            NetworkStream tcpStream;
            try
            {
                using (var tcpClient = new TcpClient())
                {
                    try
                    {
                        BinaryFormatter binaryFmt = new BinaryFormatter();
                        tcpClient.Connect(Program.Info.GetServerIP(), Program.Info.GetServerPort());
                        tcpStream = tcpClient.GetStream();
                        binaryFmt.Serialize(tcpStream, req);
                        tcpStream = tcpClient.GetStream();
                        req = (Request)new BinaryFormatter().Deserialize(tcpStream);
                        tcpStream.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception ex) { req.exception = ex.ToString(); }
        }

        private bool RegCheck(string input, string regex)
        {
            Regex rgx = new Regex(regex);
            return rgx.IsMatch(input);
        }


        private void changePasButton_Click(object sender, EventArgs e)
        {
            string regPassword = "^[a-zA-Z0-9]{7,19}$";
            if (oldPasswordTextBox.Text == Program.Info.GetUserPas())
                if (newPasswordTextBox.Text == repeatPasswordTextBox.Text)
                    if (RegCheck(newPasswordTextBox.Text, regPassword))
                    {
                        ChangeUserPassword(newPasswordTextBox.Text);
                        oldPasswordTextBox.Text = string.Empty;
                        repeatPasswordTextBox.Text = string.Empty;
                        newPasswordTextBox.Text = string.Empty;
                    }
                    else
                        MessageBox.Show("Неверный формат пароля");
                else
                    MessageBox.Show("Пароли не совпадают");
            else
                MessageBox.Show("Введён неверный пароль");
        }

        private void changeFIOButton_Click(object sender, EventArgs e)
        {
            if (fioTextBox.Text.Length >= 5)
                ChangeFIO();
            //fioTextBox.Text = Program.Info.
        }

        private void changeBUFolderButton_Click(object sender, EventArgs e)
        {
            SelectBUDir();
            buDirTextBox.Text = Program.Info.BuDir;
        }

        private void changeLocalBUDirectory_Click(object sender, EventArgs e)
        {
            SelectLocalBUDir();
            localBUDirTextBox.Text = Program.Info.LocalBuDir;
        }
    }
}