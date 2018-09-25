namespace NonameThing_1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginModeGB = new System.Windows.Forms.GroupBox();
            this.oflineRB = new System.Windows.Forms.RadioButton();
            this.onlineRB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IP1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxServerPort = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.loginModeGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.SystemColors.Window;
            this.Login.Location = new System.Drawing.Point(11, 72);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(211, 24);
            this.Login.TabIndex = 0;
            this.Login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.SystemColors.Window;
            this.Password.Location = new System.Drawing.Point(11, 143);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(211, 24);
            this.Password.TabIndex = 1;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Location = new System.Drawing.Point(11, 209);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(211, 73);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Вход";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.loginModeGB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.IP1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBoxServerPort);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(4, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 240);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // loginModeGB
            // 
            this.loginModeGB.BackColor = System.Drawing.Color.MidnightBlue;
            this.loginModeGB.Controls.Add(this.oflineRB);
            this.loginModeGB.Controls.Add(this.onlineRB);
            this.loginModeGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginModeGB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginModeGB.Location = new System.Drawing.Point(11, 11);
            this.loginModeGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginModeGB.Name = "loginModeGB";
            this.loginModeGB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginModeGB.Size = new System.Drawing.Size(211, 63);
            this.loginModeGB.TabIndex = 0;
            this.loginModeGB.TabStop = false;
            this.loginModeGB.Text = "Войти";
            // 
            // oflineRB
            // 
            this.oflineRB.AutoSize = true;
            this.oflineRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oflineRB.Location = new System.Drawing.Point(99, 23);
            this.oflineRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oflineRB.Name = "oflineRB";
            this.oflineRB.Size = new System.Drawing.Size(91, 24);
            this.oflineRB.TabIndex = 1;
            this.oflineRB.TabStop = true;
            this.oflineRB.Text = "Офлайн";
            this.oflineRB.UseVisualStyleBackColor = true;
            this.oflineRB.CheckedChanged += new System.EventHandler(this.oflineRB_CheckedChanged);
            // 
            // onlineRB
            // 
            this.onlineRB.AutoSize = true;
            this.onlineRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.onlineRB.Location = new System.Drawing.Point(10, 23);
            this.onlineRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.onlineRB.Name = "onlineRB";
            this.onlineRB.Size = new System.Drawing.Size(85, 24);
            this.onlineRB.TabIndex = 0;
            this.onlineRB.TabStop = true;
            this.onlineRB.Text = "Онлайн";
            this.onlineRB.UseVisualStyleBackColor = true;
            this.onlineRB.CheckedChanged += new System.EventHandler(this.onlineRB_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(7, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "IP сервера";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(7, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Порт";
            // 
            // IP1
            // 
            this.IP1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.IP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IP1.ForeColor = System.Drawing.SystemColors.Window;
            this.IP1.Location = new System.Drawing.Point(11, 119);
            this.IP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IP1.MaxLength = 15;
            this.IP1.Name = "IP1";
            this.IP1.Size = new System.Drawing.Size(211, 24);
            this.IP1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(7, 201);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 73);
            this.button2.TabIndex = 10;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxServerPort
            // 
            this.textBoxServerPort.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxServerPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxServerPort.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxServerPort.Location = new System.Drawing.Point(130, 156);
            this.textBoxServerPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxServerPort.MaxLength = 4;
            this.textBoxServerPort.Name = "textBoxServerPort";
            this.textBoxServerPort.Size = new System.Drawing.Size(92, 24);
            this.textBoxServerPort.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(191, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(11, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(11, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(235, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Login);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вход в систему";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.loginModeGB.ResumeLayout(false);
            this.loginModeGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxServerPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox IP1;
        private System.Windows.Forms.GroupBox loginModeGB;
        private System.Windows.Forms.RadioButton oflineRB;
        private System.Windows.Forms.RadioButton onlineRB;
        private System.Windows.Forms.Label label1;
    }
}