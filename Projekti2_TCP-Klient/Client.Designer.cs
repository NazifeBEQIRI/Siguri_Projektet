namespace TCP_Klienti
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.BWchatLog = new System.ComponentModel.BackgroundWorker();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPorti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceiveAnswer = new System.Windows.Forms.TextBox();
            this.grbRegjistrimi = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtllojiFatures = new System.Windows.Forms.TextBox();
            this.txtviti = new System.Windows.Forms.TextBox();
            this.txtEmriMbiemri = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblvleraEuro = new System.Windows.Forms.Label();
            this.lblllojiFatures = new System.Windows.Forms.Label();
            this.lblviti = new System.Windows.Forms.Label();
            this.lblmuaji = new System.Windows.Forms.Label();
            this.lblEmriMbiemri = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtUserName1 = new System.Windows.Forms.TextBox();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.lblUserName1 = new System.Windows.Forms.Label();
            this.txtvleraEuro = new System.Windows.Forms.TextBox();
            this.txtmuaji = new System.Windows.Forms.TextBox();
            this.grbRegjistrimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BWchatLog
            // 
            this.BWchatLog.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWchatLog_DoWork);
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnect.Location = new System.Drawing.Point(403, 9);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 27);
            this.btnConnect.TabIndex = 21;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.SystemColors.Control;
            this.txtIP.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtIP.Location = new System.Drawing.Point(101, 12);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(129, 22);
            this.txtIP.TabIndex = 20;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // txtPorti
            // 
            this.txtPorti.BackColor = System.Drawing.SystemColors.Control;
            this.txtPorti.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPorti.Location = new System.Drawing.Point(290, 12);
            this.txtPorti.Margin = new System.Windows.Forms.Padding(4);
            this.txtPorti.Name = "txtPorti";
            this.txtPorti.Size = new System.Drawing.Size(89, 22);
            this.txtPorti.TabIndex = 17;
            this.txtPorti.Text = "7000";
            this.txtPorti.TextChanged += new System.EventHandler(this.txtPorti_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(240, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Porti:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(19, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "IP Adresa:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(20, 466);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Përgjegja nga SERVERI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtReceiveAnswer
            // 
            this.txtReceiveAnswer.BackColor = System.Drawing.SystemColors.Control;
            this.txtReceiveAnswer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtReceiveAnswer.Location = new System.Drawing.Point(22, 496);
            this.txtReceiveAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceiveAnswer.Multiline = true;
            this.txtReceiveAnswer.Name = "txtReceiveAnswer";
            this.txtReceiveAnswer.Size = new System.Drawing.Size(792, 82);
            this.txtReceiveAnswer.TabIndex = 15;
            this.txtReceiveAnswer.TextChanged += new System.EventHandler(this.txtReceiveAnswer_TextChanged);
            // 
            // grbRegjistrimi
            // 
            this.grbRegjistrimi.BackColor = System.Drawing.Color.Transparent;
            this.grbRegjistrimi.Controls.Add(this.btnSave);
            this.grbRegjistrimi.Controls.Add(this.txtPassword);
            this.grbRegjistrimi.Controls.Add(this.txtUserName);
            this.grbRegjistrimi.Controls.Add(this.txtEmail);
            this.grbRegjistrimi.Controls.Add(this.txtvleraEuro);
            this.grbRegjistrimi.Controls.Add(this.txtmuaji);
            this.grbRegjistrimi.Controls.Add(this.txtviti);
            this.grbRegjistrimi.Controls.Add(this.txtllojiFatures);
            this.grbRegjistrimi.Controls.Add(this.txtEmriMbiemri);
            this.grbRegjistrimi.Controls.Add(this.lblPassword);
            this.grbRegjistrimi.Controls.Add(this.lblEmail);
            this.grbRegjistrimi.Controls.Add(this.lblvleraEuro);
            this.grbRegjistrimi.Controls.Add(this.lblllojiFatures);
            this.grbRegjistrimi.Controls.Add(this.lblviti);
            this.grbRegjistrimi.Controls.Add(this.lblmuaji);
            this.grbRegjistrimi.Controls.Add(this.lblEmriMbiemri);
            this.grbRegjistrimi.Controls.Add(this.lblUserName);
            this.grbRegjistrimi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grbRegjistrimi.Location = new System.Drawing.Point(23, 84);
            this.grbRegjistrimi.Margin = new System.Windows.Forms.Padding(4);
            this.grbRegjistrimi.Name = "grbRegjistrimi";
            this.grbRegjistrimi.Padding = new System.Windows.Forms.Padding(4);
            this.grbRegjistrimi.Size = new System.Drawing.Size(400, 378);
            this.grbRegjistrimi.TabIndex = 22;
            this.grbRegjistrimi.TabStop = false;
            this.grbRegjistrimi.Text = "Regjistrimi i shfrytezuesit";
            this.grbRegjistrimi.Enter += new System.EventHandler(this.grbRegjistrimi_Enter);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(292, 333);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Ruaje";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPassword.Location = new System.Drawing.Point(119, 281);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(260, 22);
            this.txtPassword.TabIndex = 43;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtUserName.Location = new System.Drawing.Point(119, 246);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(260, 22);
            this.txtUserName.TabIndex = 42;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtEmail.Location = new System.Drawing.Point(119, 212);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 22);
            this.txtEmail.TabIndex = 41;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtllojiFatures
            // 
            this.txtllojiFatures.BackColor = System.Drawing.SystemColors.Control;
            this.txtllojiFatures.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtllojiFatures.Location = new System.Drawing.Point(119, 78);
            this.txtllojiFatures.Margin = new System.Windows.Forms.Padding(4);
            this.txtllojiFatures.Name = "txtllojiFatures";
            this.txtllojiFatures.Size = new System.Drawing.Size(260, 22);
            this.txtllojiFatures.TabIndex = 39;
            this.txtllojiFatures.TextChanged += new System.EventHandler(this.txtllojiFatures_TextChanged);
            // 
            // txtviti
            // 
            this.txtviti.BackColor = System.Drawing.SystemColors.Control;
            this.txtviti.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtviti.Location = new System.Drawing.Point(119, 143);
            this.txtviti.Margin = new System.Windows.Forms.Padding(4);
            this.txtviti.Name = "txtviti";
            this.txtviti.Size = new System.Drawing.Size(260, 22);
            this.txtviti.TabIndex = 38;
            this.txtviti.TextChanged += new System.EventHandler(this.txtviti_TextChanged);
            // 
            // txtEmriMbiemri
            // 
            this.txtEmriMbiemri.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmriMbiemri.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtEmriMbiemri.Location = new System.Drawing.Point(119, 42);
            this.txtEmriMbiemri.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmriMbiemri.Name = "txtEmriMbiemri";
            this.txtEmriMbiemri.Size = new System.Drawing.Size(260, 22);
            this.txtEmriMbiemri.TabIndex = 36;
            this.txtEmriMbiemri.TextChanged += new System.EventHandler(this.txtEmriMbiemri_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPassword.Location = new System.Drawing.Point(18, 281);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 35;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmail.Location = new System.Drawing.Point(19, 212);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 17);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email adresa:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblvleraEuro
            // 
            this.lblvleraEuro.AutoSize = true;
            this.lblvleraEuro.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblvleraEuro.Location = new System.Drawing.Point(17, 175);
            this.lblvleraEuro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvleraEuro.Name = "lblvleraEuro";
            this.lblvleraEuro.Size = new System.Drawing.Size(73, 17);
            this.lblvleraEuro.TabIndex = 33;
            this.lblvleraEuro.Text = "vleraEuro:";
            this.lblvleraEuro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblvleraEuro.Click += new System.EventHandler(this.lblvleraEuro_Click);
            // 
            // lblllojiFatures
            // 
            this.lblllojiFatures.AutoSize = true;
            this.lblllojiFatures.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblllojiFatures.Location = new System.Drawing.Point(19, 78);
            this.lblllojiFatures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblllojiFatures.Name = "lblllojiFatures";
            this.lblllojiFatures.Size = new System.Drawing.Size(80, 17);
            this.lblllojiFatures.TabIndex = 33;
            this.lblllojiFatures.Text = "llojiFatures:";
            this.lblllojiFatures.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblllojiFatures.Click += new System.EventHandler(this.lblllojiFatures_Click);
            // 
            // lblviti
            // 
            this.lblviti.AutoSize = true;
            this.lblviti.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblviti.Location = new System.Drawing.Point(19, 143);
            this.lblviti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblviti.Name = "lblviti";
            this.lblviti.Size = new System.Drawing.Size(29, 17);
            this.lblviti.TabIndex = 31;
            this.lblviti.Text = "viti:";
            this.lblviti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblviti.Click += new System.EventHandler(this.lblviti_Click);
            // 
            // lblmuaji
            // 
            this.lblmuaji.AutoSize = true;
            this.lblmuaji.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblmuaji.Location = new System.Drawing.Point(19, 113);
            this.lblmuaji.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmuaji.Name = "lblmuaji";
            this.lblmuaji.Size = new System.Drawing.Size(45, 17);
            this.lblmuaji.TabIndex = 30;
            this.lblmuaji.Text = "muaji:";
            this.lblmuaji.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblmuaji.Click += new System.EventHandler(this.lblmuaji_Click);
            // 
            // lblEmriMbiemri
            // 
            this.lblEmriMbiemri.AutoSize = true;
            this.lblEmriMbiemri.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmriMbiemri.Location = new System.Drawing.Point(19, 42);
            this.lblEmriMbiemri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmriMbiemri.Name = "lblEmriMbiemri";
            this.lblEmriMbiemri.Size = new System.Drawing.Size(93, 17);
            this.lblEmriMbiemri.TabIndex = 29;
            this.lblEmriMbiemri.Text = "Emri Mbiemri:";
            this.lblEmriMbiemri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmriMbiemri.Click += new System.EventHandler(this.lblEmriMbiemri_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUserName.Location = new System.Drawing.Point(18, 249);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 17);
            this.lblUserName.TabIndex = 28;
            this.lblUserName.Text = "User Name:";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Controls.Add(this.txtPassword1);
            this.groupBox2.Controls.Add(this.txtUserName1);
            this.groupBox2.Controls.Add(this.lblPassword1);
            this.groupBox2.Controls.Add(this.lblUserName1);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(430, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(386, 378);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authentifikimi";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(261, 265);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 45;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword1
            // 
            this.txtPassword1.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPassword1.Location = new System.Drawing.Point(100, 166);
            this.txtPassword1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PasswordChar = '*';
            this.txtPassword1.Size = new System.Drawing.Size(260, 22);
            this.txtPassword1.TabIndex = 44;
            this.txtPassword1.TextChanged += new System.EventHandler(this.txtPassword1_TextChanged);
            // 
            // txtUserName1
            // 
            this.txtUserName1.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtUserName1.Location = new System.Drawing.Point(100, 130);
            this.txtUserName1.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName1.Name = "txtUserName1";
            this.txtUserName1.Size = new System.Drawing.Size(260, 22);
            this.txtUserName1.TabIndex = 43;
            this.txtUserName1.TextChanged += new System.EventHandler(this.txtUserName1_TextChanged);
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPassword1.Location = new System.Drawing.Point(18, 170);
            this.lblPassword1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(73, 17);
            this.lblPassword1.TabIndex = 42;
            this.lblPassword1.Text = "Password:";
            this.lblPassword1.Click += new System.EventHandler(this.lblPassword1_Click);
            // 
            // lblUserName1
            // 
            this.lblUserName1.AutoSize = true;
            this.lblUserName1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUserName1.Location = new System.Drawing.Point(8, 133);
            this.lblUserName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName1.Name = "lblUserName1";
            this.lblUserName1.Size = new System.Drawing.Size(83, 17);
            this.lblUserName1.TabIndex = 41;
            this.lblUserName1.Text = "User Name:";
            this.lblUserName1.Click += new System.EventHandler(this.lblUserName1_Click);
            // 
            // txtvleraEuro
            // 
            this.txtvleraEuro.BackColor = System.Drawing.SystemColors.Control;
            this.txtvleraEuro.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtvleraEuro.Location = new System.Drawing.Point(119, 175);
            this.txtvleraEuro.Margin = new System.Windows.Forms.Padding(4);
            this.txtvleraEuro.Name = "txtvleraEuro";
            this.txtvleraEuro.Size = new System.Drawing.Size(260, 22);
            this.txtvleraEuro.TabIndex = 40;
            this.txtvleraEuro.TextChanged += new System.EventHandler(this.txtvleraEuro_TextChanged);
            this.txtvleraEuro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvleraEuro_KeyPress);
            // 
            // txtmuaji
            // 
            this.txtmuaji.BackColor = System.Drawing.SystemColors.Control;
            this.txtmuaji.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtmuaji.Location = new System.Drawing.Point(119, 113);
            this.txtmuaji.Margin = new System.Windows.Forms.Padding(4);
            this.txtmuaji.Name = "txtmuaji";
            this.txtmuaji.Size = new System.Drawing.Size(260, 22);
            this.txtmuaji.TabIndex = 37;
            this.txtmuaji.TextChanged += new System.EventHandler(this.txtmuaji_TextChanged);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 626);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbRegjistrimi);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtPorti);
            this.Controls.Add(this.txtReceiveAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIEK-TCP Klienti";
            this.Load += new System.EventHandler(this.Client_Load);
            this.grbRegjistrimi.ResumeLayout(false);
            this.grbRegjistrimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BWchatLog;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPorti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReceiveAnswer;
        private System.Windows.Forms.GroupBox grbRegjistrimi;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtllojiFatures;
        private System.Windows.Forms.TextBox txtviti;
        private System.Windows.Forms.TextBox txtEmriMbiemri;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblvleraEuro;
        private System.Windows.Forms.Label lblllojiFatures;
        private System.Windows.Forms.Label lblviti;
        private System.Windows.Forms.Label lblmuaji;
        private System.Windows.Forms.Label lblEmriMbiemri;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtUserName1;
        private System.Windows.Forms.Label lblPassword1;
        private System.Windows.Forms.Label lblUserName1;
        private System.Windows.Forms.TextBox txtvleraEuro;
        private System.Windows.Forms.TextBox txtmuaji;
    }
}

