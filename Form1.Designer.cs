namespace Seri_Port_Terminal
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
            this.rtbEkran = new System.Windows.Forms.RichTextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SeriPort = new System.IO.Ports.SerialPort(this.components);
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnKes = new System.Windows.Forms.Button();
            this.btnEkraniTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.chbCR = new System.Windows.Forms.CheckBox();
            this.chbLF = new System.Windows.Forms.CheckBox();
            this.btnAc = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rtbGonder = new System.Windows.Forms.RichTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label31 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbEkran
            // 
            this.rtbEkran.AcceptsTab = true;
            this.rtbEkran.Location = new System.Drawing.Point(12, 12);
            this.rtbEkran.Name = "rtbEkran";
            this.rtbEkran.Size = new System.Drawing.Size(372, 61);
            this.rtbEkran.TabIndex = 0;
            this.rtbEkran.Text = "";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(1020, 44);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(129, 29);
            this.btnGonder.TabIndex = 2;
            this.btnGonder.Text = "Send";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(449, 12);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(75, 21);
            this.cbComPort.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Com Port";
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Location = new System.Drawing.Point(449, 39);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(75, 21);
            this.cbBaud.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BaudRate";
            // 
            // SeriPort
            // 
            this.SeriPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SeriPort_DataReceived);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(550, 12);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(75, 23);
            this.btnBaglan.TabIndex = 7;
            this.btnBaglan.Text = "Connect";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnKes
            // 
            this.btnKes.Location = new System.Drawing.Point(550, 41);
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(75, 23);
            this.btnKes.TabIndex = 9;
            this.btnKes.Text = "Off";
            this.btnKes.UseVisualStyleBackColor = true;
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // btnEkraniTemizle
            // 
            this.btnEkraniTemizle.Location = new System.Drawing.Point(631, 10);
            this.btnEkraniTemizle.Name = "btnEkraniTemizle";
            this.btnEkraniTemizle.Size = new System.Drawing.Size(85, 25);
            this.btnEkraniTemizle.TabIndex = 10;
            this.btnEkraniTemizle.Text = "Clear Screen";
            this.btnEkraniTemizle.UseVisualStyleBackColor = true;
            this.btnEkraniTemizle.Click += new System.EventHandler(this.btnEkraniTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(632, 39);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 24);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Save to Text";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // chbCR
            // 
            this.chbCR.AutoSize = true;
            this.chbCR.Location = new System.Drawing.Point(976, 8);
            this.chbCR.Name = "chbCR";
            this.chbCR.Size = new System.Drawing.Size(41, 17);
            this.chbCR.TabIndex = 12;
            this.chbCR.Text = "CR";
            this.chbCR.UseVisualStyleBackColor = true;
            // 
            // chbLF
            // 
            this.chbLF.AutoSize = true;
            this.chbLF.Location = new System.Drawing.Point(976, 37);
            this.chbLF.Name = "chbLF";
            this.chbLF.Size = new System.Drawing.Size(38, 17);
            this.chbLF.TabIndex = 13;
            this.chbLF.Text = "LF";
            this.chbLF.UseVisualStyleBackColor = true;
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(1090, 5);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(59, 35);
            this.btnAc.TabIndex = 14;
            this.btnAc.Text = "Choose File";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtbGonder
            // 
            this.rtbGonder.Location = new System.Drawing.Point(722, 9);
            this.rtbGonder.Name = "rtbGonder";
            this.rtbGonder.Size = new System.Drawing.Size(248, 51);
            this.rtbGonder.TabIndex = 15;
            this.rtbGonder.Text = "";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1020, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(64, 34);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Clear Screeen";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ItemSize = new System.Drawing.Size(600, 40);
            this.tabControl1.Location = new System.Drawing.Point(12, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1288, 480);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.zedGraphControl1);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1280, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Summary";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zedGraphControl1.Location = new System.Drawing.Point(377, 10);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(7);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(878, 418);
            this.zedGraphControl1.TabIndex = 32;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(90, 69);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 24);
            this.label31.TabIndex = 29;
            this.label31.Text = "$,0,0,0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(245, 186);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 31);
            this.label25.TabIndex = 23;
            this.label25.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(245, 252);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 31);
            this.label24.TabIndex = 22;
            this.label24.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(245, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 31);
            this.label17.TabIndex = 15;
            this.label17.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(88, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "data3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(88, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "data2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(88, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "data1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 45);
            this.button1.TabIndex = 27;
            this.button1.Text = "Start Graphing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 638);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 45);
            this.button2.TabIndex = 28;
            this.button2.Text = "Pause Graphing";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(289, 615);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 31);
            this.label9.TabIndex = 29;
            this.label9.Text = "Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(415, 615);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 31);
            this.label10.TabIndex = 30;
            this.label10.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 697);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.rtbGonder);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.chbLF);
            this.Controls.Add(this.chbCR);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnEkraniTemizle);
            this.Controls.Add(this.btnKes);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBaud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbComPort);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.rtbEkran);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real Time Graph";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEkran;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort SeriPort;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnKes;
        private System.Windows.Forms.Button btnEkraniTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox chbCR;
        private System.Windows.Forms.CheckBox chbLF;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox rtbGonder;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label31;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}

