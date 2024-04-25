namespace BerkayTCPApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnConnect = new Button();
            btnListen = new Button();
            tbxServerPort = new TextBox();
            label2 = new Label();
            tbxServerIp = new TextBox();
            label1 = new Label();
            rdbClient = new RadioButton();
            rdbServer = new RadioButton();
            label3 = new Label();
            lstMessages = new ListBox();
            groupBox2 = new GroupBox();
            pnlM1 = new Panel();
            txtMessageRank = new TextBox();
            label17 = new Label();
            txtMessageReferanceNoM1 = new TextBox();
            label18 = new Label();
            txtMessageSurname = new TextBox();
            txtMessageName = new TextBox();
            label15 = new Label();
            label16 = new Label();
            pnlM2 = new Panel();
            txtMessageLoc = new TextBox();
            label23 = new Label();
            label20 = new Label();
            txtMessageReferanceNoM2 = new TextBox();
            label21 = new Label();
            label19 = new Label();
            label22 = new Label();
            txtMessageLatitude = new TextBox();
            txtMessageAltitude = new TextBox();
            txtMessageLongitude = new TextBox();
            pnlUnknown = new Panel();
            label24 = new Label();
            txtMessageUnknown = new TextBox();
            tbcMessages = new TabControl();
            Message1 = new TabPage();
            cbRank = new ComboBox();
            txtSurname = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtName = new TextBox();
            label7 = new Label();
            txtReferanceNoM1 = new TextBox();
            label6 = new Label();
            Message2 = new TabPage();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            txtAltitude = new TextBox();
            txtLongitude = new TextBox();
            txtLatitude = new TextBox();
            txtLocationValid = new TextBox();
            label11 = new Label();
            txtReferanceNoM2 = new TextBox();
            label10 = new Label();
            label4 = new Label();
            button2 = new Button();
            txtTimer = new TextBox();
            label5 = new Label();
            tmrStart = new Button();
            tmrStop = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            pnlM1.SuspendLayout();
            pnlM2.SuspendLayout();
            pnlUnknown.SuspendLayout();
            tbcMessages.SuspendLayout();
            Message1.SuspendLayout();
            Message2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnConnect);
            groupBox1.Controls.Add(btnListen);
            groupBox1.Controls.Add(tbxServerPort);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbxServerIp);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rdbClient);
            groupBox1.Controls.Add(rdbServer);
            groupBox1.Location = new Point(32, 18);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1238, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "App Type";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(996, 104);
            btnConnect.Margin = new Padding(5);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(216, 43);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnListen
            // 
            btnListen.Location = new Point(996, 104);
            btnListen.Margin = new Padding(5);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(216, 43);
            btnListen.TabIndex = 6;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // tbxServerPort
            // 
            tbxServerPort.Location = new Point(619, 104);
            tbxServerPort.Margin = new Padding(5);
            tbxServerPort.Name = "tbxServerPort";
            tbxServerPort.Size = new Size(215, 39);
            tbxServerPort.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(552, 109);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 4;
            label2.Text = "Port";
            // 
            // tbxServerIp
            // 
            tbxServerIp.Location = new Point(101, 104);
            tbxServerIp.Margin = new Padding(5);
            tbxServerIp.Name = "tbxServerIp";
            tbxServerIp.Size = new Size(388, 39);
            tbxServerIp.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 109);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 2;
            label1.Text = "Server";
            // 
            // rdbClient
            // 
            rdbClient.AutoSize = true;
            rdbClient.Location = new Point(135, 42);
            rdbClient.Margin = new Padding(5);
            rdbClient.Name = "rdbClient";
            rdbClient.Size = new Size(107, 36);
            rdbClient.TabIndex = 1;
            rdbClient.Text = "Client";
            rdbClient.UseVisualStyleBackColor = true;
            rdbClient.CheckedChanged += rdbClient_CheckedChanged;
            // 
            // rdbServer
            // 
            rdbServer.AutoSize = true;
            rdbServer.Checked = true;
            rdbServer.Location = new Point(10, 42);
            rdbServer.Margin = new Padding(5);
            rdbServer.Name = "rdbServer";
            rdbServer.Size = new Size(112, 36);
            rdbServer.TabIndex = 0;
            rdbServer.TabStop = true;
            rdbServer.Text = "Server";
            rdbServer.UseVisualStyleBackColor = true;
            rdbServer.CheckedChanged += rdbServer_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 194);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(190, 32);
            label3.TabIndex = 6;
            label3.Text = "Message History";
            // 
            // lstMessages
            // 
            lstMessages.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstMessages.FormattingEnabled = true;
            lstMessages.ItemHeight = 32;
            lstMessages.Location = new Point(32, 230);
            lstMessages.Margin = new Padding(5);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(665, 260);
            lstMessages.TabIndex = 7;
            lstMessages.Click += lstMessages_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pnlM1);
            groupBox2.Controls.Add(pnlM2);
            groupBox2.Controls.Add(pnlUnknown);
            groupBox2.Location = new Point(736, 198);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(535, 296);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Preview";
            // 
            // pnlM1
            // 
            pnlM1.Controls.Add(txtMessageRank);
            pnlM1.Controls.Add(label17);
            pnlM1.Controls.Add(txtMessageReferanceNoM1);
            pnlM1.Controls.Add(label18);
            pnlM1.Controls.Add(txtMessageSurname);
            pnlM1.Controls.Add(txtMessageName);
            pnlM1.Controls.Add(label15);
            pnlM1.Controls.Add(label16);
            pnlM1.Location = new Point(17, 32);
            pnlM1.Name = "pnlM1";
            pnlM1.Size = new Size(510, 256);
            pnlM1.TabIndex = 0;
            pnlM1.Visible = false;
            // 
            // txtMessageRank
            // 
            txtMessageRank.Location = new Point(291, 198);
            txtMessageRank.Name = "txtMessageRank";
            txtMessageRank.Size = new Size(200, 39);
            txtMessageRank.TabIndex = 15;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(203, 201);
            label17.Name = "label17";
            label17.Size = new Size(82, 32);
            label17.TabIndex = 14;
            label17.Text = "Rütbe:";
            // 
            // txtMessageReferanceNoM1
            // 
            txtMessageReferanceNoM1.Location = new Point(291, 135);
            txtMessageReferanceNoM1.Name = "txtMessageReferanceNoM1";
            txtMessageReferanceNoM1.Size = new Size(200, 39);
            txtMessageReferanceNoM1.TabIndex = 13;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(8, 135);
            label18.Name = "label18";
            label18.Size = new Size(277, 32);
            label18.TabIndex = 12;
            label18.Text = "Birlik Referans Numarası:";
            // 
            // txtMessageSurname
            // 
            txtMessageSurname.Location = new Point(291, 79);
            txtMessageSurname.Name = "txtMessageSurname";
            txtMessageSurname.Size = new Size(200, 39);
            txtMessageSurname.TabIndex = 11;
            // 
            // txtMessageName
            // 
            txtMessageName.Location = new Point(291, 14);
            txtMessageName.Name = "txtMessageName";
            txtMessageName.Size = new Size(200, 39);
            txtMessageName.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(195, 79);
            label15.Name = "label15";
            label15.Size = new Size(90, 32);
            label15.TabIndex = 10;
            label15.Text = "Soyadı:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(231, 14);
            label16.Name = "label16";
            label16.Size = new Size(54, 32);
            label16.TabIndex = 8;
            label16.Text = "Adı:";
            // 
            // pnlM2
            // 
            pnlM2.Controls.Add(txtMessageLoc);
            pnlM2.Controls.Add(label23);
            pnlM2.Controls.Add(label20);
            pnlM2.Controls.Add(txtMessageReferanceNoM2);
            pnlM2.Controls.Add(label21);
            pnlM2.Controls.Add(label19);
            pnlM2.Controls.Add(label22);
            pnlM2.Controls.Add(txtMessageLatitude);
            pnlM2.Controls.Add(txtMessageAltitude);
            pnlM2.Controls.Add(txtMessageLongitude);
            pnlM2.Location = new Point(20, 37);
            pnlM2.Name = "pnlM2";
            pnlM2.Size = new Size(507, 241);
            pnlM2.TabIndex = 0;
            pnlM2.Visible = false;
            // 
            // txtMessageLoc
            // 
            txtMessageLoc.Location = new Point(293, 199);
            txtMessageLoc.Name = "txtMessageLoc";
            txtMessageLoc.Size = new Size(200, 39);
            txtMessageLoc.TabIndex = 11;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(5, 199);
            label23.Name = "label23";
            label23.Size = new Size(276, 32);
            label23.TabIndex = 10;
            label23.Text = "Konum Bilgisi Geçerliliği:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(164, 149);
            label20.Name = "label20";
            label20.Size = new Size(117, 32);
            label20.TabIndex = 15;
            label20.Text = "Yükseklik:";
            // 
            // txtMessageReferanceNoM2
            // 
            txtMessageReferanceNoM2.Location = new Point(292, 3);
            txtMessageReferanceNoM2.Name = "txtMessageReferanceNoM2";
            txtMessageReferanceNoM2.Size = new Size(200, 39);
            txtMessageReferanceNoM2.TabIndex = 11;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(183, 102);
            label21.Name = "label21";
            label21.Size = new Size(98, 32);
            label21.TabIndex = 14;
            label21.Text = "Boylam:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(9, 6);
            label19.Name = "label19";
            label19.Size = new Size(277, 32);
            label19.TabIndex = 10;
            label19.Text = "Birlik Referans Numarası:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(196, 52);
            label22.Name = "label22";
            label22.Size = new Size(85, 32);
            label22.TabIndex = 13;
            label22.Text = "Enlem:";
            // 
            // txtMessageLatitude
            // 
            txtMessageLatitude.Location = new Point(292, 49);
            txtMessageLatitude.Name = "txtMessageLatitude";
            txtMessageLatitude.Size = new Size(200, 39);
            txtMessageLatitude.TabIndex = 10;
            // 
            // txtMessageAltitude
            // 
            txtMessageAltitude.Location = new Point(292, 149);
            txtMessageAltitude.Name = "txtMessageAltitude";
            txtMessageAltitude.Size = new Size(200, 39);
            txtMessageAltitude.TabIndex = 12;
            // 
            // txtMessageLongitude
            // 
            txtMessageLongitude.Location = new Point(292, 96);
            txtMessageLongitude.Name = "txtMessageLongitude";
            txtMessageLongitude.Size = new Size(200, 39);
            txtMessageLongitude.TabIndex = 11;
            // 
            // pnlUnknown
            // 
            pnlUnknown.Controls.Add(label24);
            pnlUnknown.Controls.Add(txtMessageUnknown);
            pnlUnknown.Location = new Point(23, 37);
            pnlUnknown.Name = "pnlUnknown";
            pnlUnknown.Size = new Size(493, 237);
            pnlUnknown.TabIndex = 0;
            pnlUnknown.Visible = false;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(34, 9);
            label24.Name = "label24";
            label24.Size = new Size(108, 32);
            label24.TabIndex = 1;
            label24.Text = "Message";
            // 
            // txtMessageUnknown
            // 
            txtMessageUnknown.Location = new Point(34, 44);
            txtMessageUnknown.Multiline = true;
            txtMessageUnknown.Name = "txtMessageUnknown";
            txtMessageUnknown.Size = new Size(421, 172);
            txtMessageUnknown.TabIndex = 0;
            // 
            // tbcMessages
            // 
            tbcMessages.Controls.Add(Message1);
            tbcMessages.Controls.Add(Message2);
            tbcMessages.Location = new Point(32, 550);
            tbcMessages.Margin = new Padding(5);
            tbcMessages.Name = "tbcMessages";
            tbcMessages.SelectedIndex = 0;
            tbcMessages.Size = new Size(986, 232);
            tbcMessages.TabIndex = 10;
            // 
            // Message1
            // 
            Message1.Controls.Add(cbRank);
            Message1.Controls.Add(txtSurname);
            Message1.Controls.Add(label9);
            Message1.Controls.Add(label8);
            Message1.Controls.Add(txtName);
            Message1.Controls.Add(label7);
            Message1.Controls.Add(txtReferanceNoM1);
            Message1.Controls.Add(label6);
            Message1.Location = new Point(8, 46);
            Message1.Margin = new Padding(5);
            Message1.Name = "Message1";
            Message1.Padding = new Padding(5);
            Message1.Size = new Size(970, 178);
            Message1.TabIndex = 0;
            Message1.Text = "Message 1";
            Message1.UseVisualStyleBackColor = true;
            // 
            // cbRank
            // 
            cbRank.FormattingEnabled = true;
            cbRank.Items.AddRange(new object[] { "Üsteğmen", "Teğmen", "Asteğmen" });
            cbRank.Location = new Point(671, 104);
            cbRank.Name = "cbRank";
            cbRank.Size = new Size(242, 40);
            cbRank.TabIndex = 8;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(144, 97);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(200, 39);
            txtSurname.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 97);
            label9.Name = "label9";
            label9.Size = new Size(90, 32);
            label9.TabIndex = 6;
            label9.Text = "Soyadı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(583, 107);
            label8.Name = "label8";
            label8.Size = new Size(82, 32);
            label8.TabIndex = 4;
            label8.Text = "Rütbe:";
            // 
            // txtName
            // 
            txtName.Location = new Point(144, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 39);
            txtName.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 32);
            label7.Name = "label7";
            label7.Size = new Size(54, 32);
            label7.TabIndex = 2;
            label7.Text = "Adı:";
            // 
            // txtReferanceNoM1
            // 
            txtReferanceNoM1.Location = new Point(671, 32);
            txtReferanceNoM1.Name = "txtReferanceNoM1";
            txtReferanceNoM1.Size = new Size(200, 39);
            txtReferanceNoM1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 32);
            label6.Name = "label6";
            label6.Size = new Size(277, 32);
            label6.TabIndex = 0;
            label6.Text = "Birlik Referans Numarası:";
            // 
            // Message2
            // 
            Message2.Controls.Add(label14);
            Message2.Controls.Add(label13);
            Message2.Controls.Add(label12);
            Message2.Controls.Add(txtAltitude);
            Message2.Controls.Add(txtLongitude);
            Message2.Controls.Add(txtLatitude);
            Message2.Controls.Add(txtLocationValid);
            Message2.Controls.Add(label11);
            Message2.Controls.Add(txtReferanceNoM2);
            Message2.Controls.Add(label10);
            Message2.Location = new Point(8, 46);
            Message2.Margin = new Padding(5);
            Message2.Name = "Message2";
            Message2.Padding = new Padding(5);
            Message2.Size = new Size(970, 178);
            Message2.TabIndex = 1;
            Message2.Text = "Message 2";
            Message2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(611, 119);
            label14.Name = "label14";
            label14.Size = new Size(117, 32);
            label14.TabIndex = 9;
            label14.Text = "Yükseklik:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(630, 72);
            label13.Name = "label13";
            label13.Size = new Size(98, 32);
            label13.TabIndex = 8;
            label13.Text = "Boylam:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(643, 22);
            label12.Name = "label12";
            label12.Size = new Size(85, 32);
            label12.TabIndex = 7;
            label12.Text = "Enlem:";
            // 
            // txtAltitude
            // 
            txtAltitude.Location = new Point(739, 119);
            txtAltitude.Name = "txtAltitude";
            txtAltitude.Size = new Size(200, 39);
            txtAltitude.TabIndex = 6;
            // 
            // txtLongitude
            // 
            txtLongitude.Location = new Point(739, 66);
            txtLongitude.Name = "txtLongitude";
            txtLongitude.Size = new Size(200, 39);
            txtLongitude.TabIndex = 5;
            // 
            // txtLatitude
            // 
            txtLatitude.Location = new Point(739, 19);
            txtLatitude.Name = "txtLatitude";
            txtLatitude.Size = new Size(200, 39);
            txtLatitude.TabIndex = 4;
            // 
            // txtLocationValid
            // 
            txtLocationValid.Location = new Point(385, 112);
            txtLocationValid.Name = "txtLocationValid";
            txtLocationValid.Size = new Size(200, 39);
            txtLocationValid.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 115);
            label11.Name = "label11";
            label11.Size = new Size(335, 32);
            label11.TabIndex = 2;
            label11.Text = "Birlik Konum Bilgisi Geçerliliği:";
            // 
            // txtReferanceNoM2
            // 
            txtReferanceNoM2.Location = new Point(385, 26);
            txtReferanceNoM2.Name = "txtReferanceNoM2";
            txtReferanceNoM2.Size = new Size(200, 39);
            txtReferanceNoM2.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(102, 29);
            label10.Name = "label10";
            label10.Size = new Size(277, 32);
            label10.TabIndex = 0;
            label10.Text = "Birlik Referans Numarası:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 514);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 32);
            label4.TabIndex = 11;
            label4.Text = "Send";
            // 
            // button2
            // 
            button2.Location = new Point(1029, 733);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(216, 43);
            button2.TabIndex = 12;
            button2.Text = "Send";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Send_Button_Clicked;
            // 
            // txtTimer
            // 
            txtTimer.Location = new Point(1029, 597);
            txtTimer.Margin = new Padding(5);
            txtTimer.Name = "txtTimer";
            txtTimer.Size = new Size(201, 39);
            txtTimer.TabIndex = 13;
            txtTimer.Text = "1000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1029, 560);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 32);
            label5.TabIndex = 14;
            label5.Text = "Interval";
            // 
            // tmrStart
            // 
            tmrStart.Location = new Point(1029, 650);
            tmrStart.Margin = new Padding(5);
            tmrStart.Name = "tmrStart";
            tmrStart.Size = new Size(88, 43);
            tmrStart.TabIndex = 15;
            tmrStart.Text = "Start";
            tmrStart.UseVisualStyleBackColor = true;
            tmrStart.Click += tmrStart_Click;
            // 
            // tmrStop
            // 
            tmrStop.Location = new Point(1144, 650);
            tmrStop.Margin = new Padding(5);
            tmrStop.Name = "tmrStop";
            tmrStop.Size = new Size(88, 43);
            tmrStop.TabIndex = 16;
            tmrStop.Text = "Stop";
            tmrStop.UseVisualStyleBackColor = true;
            tmrStop.Click += tmrStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 808);
            Controls.Add(tmrStop);
            Controls.Add(tmrStart);
            Controls.Add(label5);
            Controls.Add(txtTimer);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(tbcMessages);
            Controls.Add(groupBox2);
            Controls.Add(lstMessages);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "TCP/IP Communication Application";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            pnlM1.ResumeLayout(false);
            pnlM1.PerformLayout();
            pnlM2.ResumeLayout(false);
            pnlM2.PerformLayout();
            pnlUnknown.ResumeLayout(false);
            pnlUnknown.PerformLayout();
            tbcMessages.ResumeLayout(false);
            Message1.ResumeLayout(false);
            Message1.PerformLayout();
            Message2.ResumeLayout(false);
            Message2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbxServerIp;
        private Label label1;
        private RadioButton rdbClient;
        private RadioButton rdbServer;
        private TextBox tbxServerPort;
        private Label label2;
        private Label label3;
        private ListBox lstMessages;
        private GroupBox groupBox2;
        private TabControl tbcMessages;
        private TabPage Message1;
        private TabPage Message2;
        private Label label4;
        private Button btnListen;
        private Button button2;
        private TextBox txtTimer;
        private Label label5;
        private Button tmrStart;
        private Button tmrStop;
        private Button btnConnect;
        private TextBox txtReferanceNoM1;
        private Label label6;
        private TextBox txtSurname;
        private Label label9;
        private Label label8;
        private TextBox txtName;
        private Label label7;
        private TextBox txtReferanceNoM2;
        private Label label10;
        private TextBox txtAltitude;
        private TextBox txtLongitude;
        private TextBox txtLatitude;
        private TextBox txtLocationValid;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label13;
        private Panel pnlM1;
        private Panel pnlM2;
        private TextBox txtMessageRank;
        private Label label17;
        private TextBox txtMessageReferanceNoM1;
        private Label label18;
        private TextBox txtMessageSurname;
        private TextBox txtMessageName;
        private Label label15;
        private Label label16;
        private Panel pnlUnknown;
        private Label label24;
        private TextBox txtMessageUnknown;
        private TextBox txtMessageLoc;
        private Label label23;
        private Label label20;
        private TextBox txtMessageReferanceNoM2;
        private Label label21;
        private Label label19;
        private Label label22;
        private TextBox txtMessageLatitude;
        private TextBox txtMessageAltitude;
        private TextBox txtMessageLongitude;
        private ComboBox cbRank;
    }
}
