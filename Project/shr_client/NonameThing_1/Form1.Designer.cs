namespace NonameThing_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ChooseDir = new System.Windows.Forms.FolderBrowserDialog();
            this.BackupList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.buprocText = new System.Windows.Forms.ToolStripStatusLabel();
            this.BUProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Choosedirectory = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.settingsControl = new System.Windows.Forms.TabControl();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.changeLocalBUDirectory = new System.Windows.Forms.Button();
            this.changeBUFolderButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.localBUDirTextBox = new System.Windows.Forms.TextBox();
            this.localBULabel = new System.Windows.Forms.Label();
            this.buDirTextBox = new System.Windows.Forms.TextBox();
            this.buDirLabel = new System.Windows.Forms.Label();
            this.changeFIOButton = new System.Windows.Forms.Button();
            this.changePasButton = new System.Windows.Forms.Button();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.fioLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.adminTabPage = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.settingsControl.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.adminTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackupList
            // 
            this.BackupList.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackupList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackupList.ContextMenuStrip = this.contextMenuStrip1;
            this.BackupList.ForeColor = System.Drawing.SystemColors.Window;
            this.BackupList.FormattingEnabled = true;
            this.BackupList.ItemHeight = 16;
            this.BackupList.Location = new System.Drawing.Point(477, 66);
            this.BackupList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackupList.Name = "BackupList";
            this.BackupList.Size = new System.Drawing.Size(219, 274);
            this.BackupList.TabIndex = 0;
            this.BackupList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackupList_KeyDown);
            this.BackupList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackupList_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 56);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buprocText,
            this.BUProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 352);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(712, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // buprocText
            // 
            this.buprocText.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buprocText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buprocText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buprocText.Name = "buprocText";
            this.buprocText.Size = new System.Drawing.Size(151, 21);
            this.buprocText.Text = "toolStripStatusLabel1";
            // 
            // BUProgressBar
            // 
            this.BUProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BUProgressBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.BUProgressBar.Name = "BUProgressBar";
            this.BUProgressBar.Size = new System.Drawing.Size(520, 20);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LogOut);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(477, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 48);
            this.panel1.TabIndex = 6;
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.Window;
            this.LogOut.Location = new System.Drawing.Point(160, 22);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(55, 17);
            this.LogOut.TabIndex = 1;
            this.LogOut.Text = "Выйти";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "@username";
            // 
            // Choosedirectory
            // 
            this.Choosedirectory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Choosedirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Choosedirectory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Choosedirectory.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Choosedirectory.FlatAppearance.BorderSize = 0;
            this.Choosedirectory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Choosedirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Choosedirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Choosedirectory.ForeColor = System.Drawing.SystemColors.Window;
            this.Choosedirectory.Image = ((System.Drawing.Image)(resources.GetObject("Choosedirectory.Image")));
            this.Choosedirectory.Location = new System.Drawing.Point(12, 13);
            this.Choosedirectory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Choosedirectory.Name = "Choosedirectory";
            this.Choosedirectory.Size = new System.Drawing.Size(223, 160);
            this.Choosedirectory.TabIndex = 7;
            this.Choosedirectory.Text = " ";
            this.Choosedirectory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Choosedirectory.UseVisualStyleBackColor = false;
            this.Choosedirectory.Click += new System.EventHandler(this.Choosedirectory_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(241, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 161);
            this.button2.TabIndex = 8;
            this.button2.Text = " ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(241, 178);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 162);
            this.button3.TabIndex = 10;
            this.button3.Text = " ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(12, 178);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 162);
            this.button4.TabIndex = 9;
            this.button4.Text = " ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.settingsControl);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 377);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // settingsControl
            // 
            this.settingsControl.Controls.Add(this.settingsTabPage);
            this.settingsControl.Controls.Add(this.adminTabPage);
            this.settingsControl.Enabled = false;
            this.settingsControl.Location = new System.Drawing.Point(0, 0);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.SelectedIndex = 0;
            this.settingsControl.Size = new System.Drawing.Size(712, 377);
            this.settingsControl.TabIndex = 0;
            this.settingsControl.Visible = false;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.BackColor = System.Drawing.Color.MidnightBlue;
            this.settingsTabPage.Controls.Add(this.changeLocalBUDirectory);
            this.settingsTabPage.Controls.Add(this.changeBUFolderButton);
            this.settingsTabPage.Controls.Add(this.button7);
            this.settingsTabPage.Controls.Add(this.localBUDirTextBox);
            this.settingsTabPage.Controls.Add(this.localBULabel);
            this.settingsTabPage.Controls.Add(this.buDirTextBox);
            this.settingsTabPage.Controls.Add(this.buDirLabel);
            this.settingsTabPage.Controls.Add(this.changeFIOButton);
            this.settingsTabPage.Controls.Add(this.changePasButton);
            this.settingsTabPage.Controls.Add(this.fioTextBox);
            this.settingsTabPage.Controls.Add(this.fioLabel);
            this.settingsTabPage.Controls.Add(this.repeatPasswordTextBox);
            this.settingsTabPage.Controls.Add(this.newPasswordTextBox);
            this.settingsTabPage.Controls.Add(this.oldPasswordTextBox);
            this.settingsTabPage.Controls.Add(this.repeatPasswordLabel);
            this.settingsTabPage.Controls.Add(this.newPasswordLabel);
            this.settingsTabPage.Controls.Add(this.oldPasswordLabel);
            this.settingsTabPage.ForeColor = System.Drawing.SystemColors.Window;
            this.settingsTabPage.Location = new System.Drawing.Point(4, 25);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(704, 348);
            this.settingsTabPage.TabIndex = 0;
            this.settingsTabPage.Text = "Настройки";
            this.settingsTabPage.Click += new System.EventHandler(this.settingsTabPage_Click);
            // 
            // changeLocalBUDirectory
            // 
            this.changeLocalBUDirectory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.changeLocalBUDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeLocalBUDirectory.Location = new System.Drawing.Point(583, 261);
            this.changeLocalBUDirectory.Name = "changeLocalBUDirectory";
            this.changeLocalBUDirectory.Size = new System.Drawing.Size(106, 31);
            this.changeLocalBUDirectory.TabIndex = 29;
            this.changeLocalBUDirectory.Text = "Сменить";
            this.changeLocalBUDirectory.UseVisualStyleBackColor = false;
            this.changeLocalBUDirectory.Click += new System.EventHandler(this.changeLocalBUDirectory_Click);
            // 
            // changeBUFolderButton
            // 
            this.changeBUFolderButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.changeBUFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeBUFolderButton.Location = new System.Drawing.Point(583, 189);
            this.changeBUFolderButton.Name = "changeBUFolderButton";
            this.changeBUFolderButton.Size = new System.Drawing.Size(106, 31);
            this.changeBUFolderButton.TabIndex = 28;
            this.changeBUFolderButton.Text = "Сменить";
            this.changeBUFolderButton.UseVisualStyleBackColor = false;
            this.changeBUFolderButton.Click += new System.EventHandler(this.changeBUFolderButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(601, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // localBUDirTextBox
            // 
            this.localBUDirTextBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.localBUDirTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.localBUDirTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.localBUDirTextBox.Location = new System.Drawing.Point(14, 297);
            this.localBUDirTextBox.Name = "localBUDirTextBox";
            this.localBUDirTextBox.ReadOnly = true;
            this.localBUDirTextBox.Size = new System.Drawing.Size(675, 30);
            this.localBUDirTextBox.TabIndex = 26;
            this.localBUDirTextBox.Text = "longlonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglonglongl" +
    "onglonglonglonglongstring";
            // 
            // localBULabel
            // 
            this.localBULabel.AutoSize = true;
            this.localBULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.localBULabel.ForeColor = System.Drawing.SystemColors.Window;
            this.localBULabel.Location = new System.Drawing.Point(9, 267);
            this.localBULabel.Name = "localBULabel";
            this.localBULabel.Size = new System.Drawing.Size(339, 25);
            this.localBULabel.TabIndex = 25;
            this.localBULabel.Text = "Адрес локального хранения бекапа";
            // 
            // buDirTextBox
            // 
            this.buDirTextBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buDirTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buDirTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.buDirTextBox.Location = new System.Drawing.Point(14, 224);
            this.buDirTextBox.Name = "buDirTextBox";
            this.buDirTextBox.Size = new System.Drawing.Size(675, 30);
            this.buDirTextBox.TabIndex = 24;
            // 
            // buDirLabel
            // 
            this.buDirLabel.AutoSize = true;
            this.buDirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buDirLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.buDirLabel.Location = new System.Drawing.Point(9, 195);
            this.buDirLabel.Name = "buDirLabel";
            this.buDirLabel.Size = new System.Drawing.Size(195, 25);
            this.buDirLabel.TabIndex = 23;
            this.buDirLabel.Text = "Адрес папки бекапа";
            // 
            // changeFIOButton
            // 
            this.changeFIOButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.changeFIOButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeFIOButton.Location = new System.Drawing.Point(436, 153);
            this.changeFIOButton.Name = "changeFIOButton";
            this.changeFIOButton.Size = new System.Drawing.Size(106, 31);
            this.changeFIOButton.TabIndex = 22;
            this.changeFIOButton.Text = "Сменить";
            this.changeFIOButton.UseVisualStyleBackColor = false;
            this.changeFIOButton.Click += new System.EventHandler(this.changeFIOButton_Click);
            // 
            // changePasButton
            // 
            this.changePasButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.changePasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePasButton.Location = new System.Drawing.Point(436, 79);
            this.changePasButton.Name = "changePasButton";
            this.changePasButton.Size = new System.Drawing.Size(106, 31);
            this.changePasButton.TabIndex = 21;
            this.changePasButton.Text = "Сменить";
            this.changePasButton.UseVisualStyleBackColor = false;
            this.changePasButton.Click += new System.EventHandler(this.changePasButton_Click);
            // 
            // fioTextBox
            // 
            this.fioTextBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.fioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.fioTextBox.Location = new System.Drawing.Point(14, 153);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(378, 30);
            this.fioTextBox.TabIndex = 19;
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.fioLabel.Location = new System.Drawing.Point(332, 119);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(60, 25);
            this.fioLabel.TabIndex = 18;
            this.fioLabel.Text = "ФИО";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.repeatPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatPasswordTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(206, 79);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.PasswordChar = '*';
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(186, 30);
            this.repeatPasswordTextBox.TabIndex = 17;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.newPasswordTextBox.Location = new System.Drawing.Point(206, 43);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.Size = new System.Drawing.Size(186, 30);
            this.newPasswordTextBox.TabIndex = 16;
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.oldPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPasswordTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.oldPasswordTextBox.Location = new System.Drawing.Point(206, 7);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.PasswordChar = '*';
            this.oldPasswordTextBox.Size = new System.Drawing.Size(186, 30);
            this.oldPasswordTextBox.TabIndex = 15;
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatPasswordLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(9, 82);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(115, 25);
            this.repeatPasswordLabel.TabIndex = 13;
            this.repeatPasswordLabel.Text = "Повторите";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.newPasswordLabel.Location = new System.Drawing.Point(9, 46);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(141, 25);
            this.newPasswordLabel.TabIndex = 12;
            this.newPasswordLabel.Text = "Новый пароль";
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPasswordLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.oldPasswordLabel.Location = new System.Drawing.Point(9, 10);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(153, 25);
            this.oldPasswordLabel.TabIndex = 11;
            this.oldPasswordLabel.Text = "Старый пароль";
            // 
            // adminTabPage
            // 
            this.adminTabPage.BackColor = System.Drawing.Color.MidnightBlue;
            this.adminTabPage.Controls.Add(this.button12);
            this.adminTabPage.Controls.Add(this.label3);
            this.adminTabPage.Controls.Add(this.comboBox1);
            this.adminTabPage.Controls.Add(this.button11);
            this.adminTabPage.Controls.Add(this.textBox1);
            this.adminTabPage.Controls.Add(this.label1);
            this.adminTabPage.Controls.Add(this.button8);
            this.adminTabPage.Controls.Add(this.button1);
            this.adminTabPage.Controls.Add(this.usernameTextBox);
            this.adminTabPage.Controls.Add(this.userNameLabel);
            this.adminTabPage.Controls.Add(this.listBox1);
            this.adminTabPage.ForeColor = System.Drawing.SystemColors.Window;
            this.adminTabPage.Location = new System.Drawing.Point(4, 25);
            this.adminTabPage.Name = "adminTabPage";
            this.adminTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.adminTabPage.Size = new System.Drawing.Size(704, 348);
            this.adminTabPage.TabIndex = 1;
            this.adminTabPage.Text = "Админ-панель";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(580, 138);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(106, 31);
            this.button12.TabIndex = 30;
            this.button12.Text = "Сменить";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(153, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Права доступа";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 25;
            this.comboBox1.Location = new System.Drawing.Point(350, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 33);
            this.comboBox1.TabIndex = 28;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(580, 86);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(106, 31);
            this.button11.TabIndex = 27;
            this.button11.Text = "Сменить";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(158, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 30);
            this.textBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(153, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "ФИО";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(459, 188);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(227, 31);
            this.button8.TabIndex = 24;
            this.button8.Text = "Сбросить пароль";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(580, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Сменить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.usernameTextBox.Location = new System.Drawing.Point(350, 14);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(186, 30);
            this.usernameTextBox.TabIndex = 22;
            this.usernameTextBox.WordWrap = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.userNameLabel.Location = new System.Drawing.Point(153, 17);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(191, 25);
            this.userNameLabel.TabIndex = 21;
            this.userNameLabel.Text = "Имя пользователя";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 212);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(712, 378);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Choosedirectory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BackupList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.settingsControl.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
            this.adminTabPage.ResumeLayout(false);
            this.adminTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog ChooseDir;
        private System.Windows.Forms.ListBox BackupList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar BUProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel buprocText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.Button Choosedirectory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl settingsControl;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.TabPage adminTabPage;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.Label fioLabel;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.Button changeFIOButton;
        private System.Windows.Forms.Button changePasButton;
        private System.Windows.Forms.TextBox localBUDirTextBox;
        private System.Windows.Forms.Label localBULabel;
        private System.Windows.Forms.TextBox buDirTextBox;
        private System.Windows.Forms.Label buDirLabel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button changeLocalBUDirectory;
        private System.Windows.Forms.Button changeBUFolderButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label3;
    }
}

