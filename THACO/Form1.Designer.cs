namespace THACO
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
            this.COM = new System.IO.Ports.SerialPort(this.components);
            this.TIMER1 = new System.Windows.Forms.Timer(this.components);
            this.TIMER2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.BT_CONNECT = new System.Windows.Forms.Button();
            this.LISTCOM = new System.Windows.Forms.ComboBox();
            this.button_GetData = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NSX = new System.Windows.Forms.TextBox();
            this.TB_LKT = new System.Windows.Forms.TextBox();
            this.TB_NSX2 = new System.Windows.Forms.TextBox();
            this.TB_TKHT = new System.Windows.Forms.TextBox();
            this.TB_TTHT = new System.Windows.Forms.TextBox();
            this.TB_TKHN = new System.Windows.Forms.TextBox();
            this.TB_TTHN = new System.Windows.Forms.TextBox();
            this.TB_KHT7 = new System.Windows.Forms.TextBox();
            this.TB_KHT6 = new System.Windows.Forms.TextBox();
            this.TB_KHT5 = new System.Windows.Forms.TextBox();
            this.TB_KHT4 = new System.Windows.Forms.TextBox();
            this.TB_KHT3 = new System.Windows.Forms.TextBox();
            this.TB_KHT2 = new System.Windows.Forms.TextBox();
            this.TB_KHT1 = new System.Windows.Forms.TextBox();
            this.TB_THT7 = new System.Windows.Forms.TextBox();
            this.TB_THT6 = new System.Windows.Forms.TextBox();
            this.TB_THT5 = new System.Windows.Forms.TextBox();
            this.TB_THT4 = new System.Windows.Forms.TextBox();
            this.TB_THT3 = new System.Windows.Forms.TextBox();
            this.TB_THT2 = new System.Windows.Forms.TextBox();
            this.TB_THT1 = new System.Windows.Forms.TextBox();
            this.TB_KHN7 = new System.Windows.Forms.TextBox();
            this.TB_KHN6 = new System.Windows.Forms.TextBox();
            this.TB_KHN5 = new System.Windows.Forms.TextBox();
            this.TB_KHN4 = new System.Windows.Forms.TextBox();
            this.TB_KHN3 = new System.Windows.Forms.TextBox();
            this.TB_KHN2 = new System.Windows.Forms.TextBox();
            this.TB_KHN1 = new System.Windows.Forms.TextBox();
            this.TB_THN7 = new System.Windows.Forms.TextBox();
            this.TB_THN6 = new System.Windows.Forms.TextBox();
            this.TB_THN5 = new System.Windows.Forms.TextBox();
            this.TB_THN4 = new System.Windows.Forms.TextBox();
            this.TB_THN3 = new System.Windows.Forms.TextBox();
            this.TB_THN2 = new System.Windows.Forms.TextBox();
            this.TB_THN1 = new System.Windows.Forms.TextBox();
            this.CB_SP7 = new System.Windows.Forms.ComboBox();
            this.CB_SP6 = new System.Windows.Forms.ComboBox();
            this.CB_SP5 = new System.Windows.Forms.ComboBox();
            this.CB_SP4 = new System.Windows.Forms.ComboBox();
            this.CB_SP3 = new System.Windows.Forms.ComboBox();
            this.CB_SP2 = new System.Windows.Forms.ComboBox();
            this.CB_SP1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // COM
            // 
            this.COM.BaudRate = 38400;
            // 
            // TIMER1
            // 
            this.TIMER1.Tick += new System.EventHandler(this.TIMER1_Tick);
            // 
            // TIMER2
            // 
            this.TIMER2.Interval = 10000;
            this.TIMER2.Tick += new System.EventHandler(this.TIMER2_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.BT_CONNECT);
            this.tabPage1.Controls.Add(this.LISTCOM);
            this.tabPage1.Controls.Add(this.button_GetData);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TB_NSX);
            this.tabPage1.Controls.Add(this.TB_LKT);
            this.tabPage1.Controls.Add(this.TB_NSX2);
            this.tabPage1.Controls.Add(this.TB_TKHT);
            this.tabPage1.Controls.Add(this.TB_TTHT);
            this.tabPage1.Controls.Add(this.TB_TKHN);
            this.tabPage1.Controls.Add(this.TB_TTHN);
            this.tabPage1.Controls.Add(this.TB_KHT7);
            this.tabPage1.Controls.Add(this.TB_KHT6);
            this.tabPage1.Controls.Add(this.TB_KHT5);
            this.tabPage1.Controls.Add(this.TB_KHT4);
            this.tabPage1.Controls.Add(this.TB_KHT3);
            this.tabPage1.Controls.Add(this.TB_KHT2);
            this.tabPage1.Controls.Add(this.TB_KHT1);
            this.tabPage1.Controls.Add(this.TB_THT7);
            this.tabPage1.Controls.Add(this.TB_THT6);
            this.tabPage1.Controls.Add(this.TB_THT5);
            this.tabPage1.Controls.Add(this.TB_THT4);
            this.tabPage1.Controls.Add(this.TB_THT3);
            this.tabPage1.Controls.Add(this.TB_THT2);
            this.tabPage1.Controls.Add(this.TB_THT1);
            this.tabPage1.Controls.Add(this.TB_KHN7);
            this.tabPage1.Controls.Add(this.TB_KHN6);
            this.tabPage1.Controls.Add(this.TB_KHN5);
            this.tabPage1.Controls.Add(this.TB_KHN4);
            this.tabPage1.Controls.Add(this.TB_KHN3);
            this.tabPage1.Controls.Add(this.TB_KHN2);
            this.tabPage1.Controls.Add(this.TB_KHN1);
            this.tabPage1.Controls.Add(this.TB_THN7);
            this.tabPage1.Controls.Add(this.TB_THN6);
            this.tabPage1.Controls.Add(this.TB_THN5);
            this.tabPage1.Controls.Add(this.TB_THN4);
            this.tabPage1.Controls.Add(this.TB_THN3);
            this.tabPage1.Controls.Add(this.TB_THN2);
            this.tabPage1.Controls.Add(this.TB_THN1);
            this.tabPage1.Controls.Add(this.CB_SP7);
            this.tabPage1.Controls.Add(this.CB_SP6);
            this.tabPage1.Controls.Add(this.CB_SP5);
            this.tabPage1.Controls.Add(this.CB_SP4);
            this.tabPage1.Controls.Add(this.CB_SP3);
            this.tabPage1.Controls.Add(this.CB_SP2);
            this.tabPage1.Controls.Add(this.CB_SP1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bảng Hiển Thị";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dữ Liệu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(107, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 32);
            this.label10.TabIndex = 109;
            this.label10.Text = "NHÀ MÁY NHÍP ÔTÔ";
            // 
            // BT_CONNECT
            // 
            this.BT_CONNECT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CONNECT.ForeColor = System.Drawing.Color.Navy;
            this.BT_CONNECT.Location = new System.Drawing.Point(256, 393);
            this.BT_CONNECT.Name = "BT_CONNECT";
            this.BT_CONNECT.Size = new System.Drawing.Size(206, 23);
            this.BT_CONNECT.TabIndex = 108;
            this.BT_CONNECT.Text = "KẾT NỐI";
            this.BT_CONNECT.UseVisualStyleBackColor = true;
            this.BT_CONNECT.Click += new System.EventHandler(this.BT_CONNECT_Click);
            // 
            // LISTCOM
            // 
            this.LISTCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LISTCOM.FormattingEnabled = true;
            this.LISTCOM.Location = new System.Drawing.Point(113, 393);
            this.LISTCOM.Name = "LISTCOM";
            this.LISTCOM.Size = new System.Drawing.Size(121, 24);
            this.LISTCOM.TabIndex = 107;
            // 
            // button_GetData
            // 
            this.button_GetData.Location = new System.Drawing.Point(574, 393);
            this.button_GetData.Name = "button_GetData";
            this.button_GetData.Size = new System.Drawing.Size(100, 23);
            this.button_GetData.TabIndex = 106;
            this.button_GetData.Text = "Lay Du Lieu";
            this.button_GetData.UseVisualStyleBackColor = true;
            this.button_GetData.Click += new System.EventHandler(this.button_GetData_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(110, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 105;
            this.label9.Text = "TỔNG CỘNG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(574, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 104;
            this.label8.Text = "Kế hoạch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(465, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 103;
            this.label7.Text = "Thực hiện";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(359, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 102;
            this.label6.Text = "Kế hoạch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(253, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 101;
            this.label5.Text = "Thực hiện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(465, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 100;
            this.label4.Text = "LUỸ KẾ THÁNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(253, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 99;
            this.label3.Text = "NGÀY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(110, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 98;
            this.label2.Text = "SẢN PHẨM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(145, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 19);
            this.label1.TabIndex = 97;
            this.label1.Text = "BẢNG THEO DÕI KẾT QUẢ NGÀY SẢN XUẤT";
            // 
            // TB_NSX
            // 
            this.TB_NSX.Location = new System.Drawing.Point(468, 79);
            this.TB_NSX.Name = "TB_NSX";
            this.TB_NSX.Size = new System.Drawing.Size(206, 20);
            this.TB_NSX.TabIndex = 96;
            this.TB_NSX.Text = "2015-11-1";
            // 
            // TB_LKT
            // 
            this.TB_LKT.Location = new System.Drawing.Point(574, 118);
            this.TB_LKT.Name = "TB_LKT";
            this.TB_LKT.Size = new System.Drawing.Size(100, 20);
            this.TB_LKT.TabIndex = 95;
            // 
            // TB_NSX2
            // 
            this.TB_NSX2.Location = new System.Drawing.Point(362, 118);
            this.TB_NSX2.Name = "TB_NSX2";
            this.TB_NSX2.Size = new System.Drawing.Size(100, 20);
            this.TB_NSX2.TabIndex = 94;
            // 
            // TB_TKHT
            // 
            this.TB_TKHT.Location = new System.Drawing.Point(574, 359);
            this.TB_TKHT.Name = "TB_TKHT";
            this.TB_TKHT.Size = new System.Drawing.Size(100, 20);
            this.TB_TKHT.TabIndex = 93;
            // 
            // TB_TTHT
            // 
            this.TB_TTHT.Location = new System.Drawing.Point(468, 359);
            this.TB_TTHT.Name = "TB_TTHT";
            this.TB_TTHT.Size = new System.Drawing.Size(100, 20);
            this.TB_TTHT.TabIndex = 92;
            // 
            // TB_TKHN
            // 
            this.TB_TKHN.Location = new System.Drawing.Point(362, 359);
            this.TB_TKHN.Name = "TB_TKHN";
            this.TB_TKHN.Size = new System.Drawing.Size(100, 20);
            this.TB_TKHN.TabIndex = 91;
            // 
            // TB_TTHN
            // 
            this.TB_TTHN.Location = new System.Drawing.Point(256, 359);
            this.TB_TTHN.Name = "TB_TTHN";
            this.TB_TTHN.Size = new System.Drawing.Size(100, 20);
            this.TB_TTHN.TabIndex = 90;
            // 
            // TB_KHT7
            // 
            this.TB_KHT7.Location = new System.Drawing.Point(574, 323);
            this.TB_KHT7.Name = "TB_KHT7";
            this.TB_KHT7.Size = new System.Drawing.Size(100, 20);
            this.TB_KHT7.TabIndex = 89;
            // 
            // TB_KHT6
            // 
            this.TB_KHT6.Location = new System.Drawing.Point(574, 296);
            this.TB_KHT6.Name = "TB_KHT6";
            this.TB_KHT6.Size = new System.Drawing.Size(100, 20);
            this.TB_KHT6.TabIndex = 88;
            // 
            // TB_KHT5
            // 
            this.TB_KHT5.Location = new System.Drawing.Point(574, 269);
            this.TB_KHT5.Name = "TB_KHT5";
            this.TB_KHT5.Size = new System.Drawing.Size(100, 20);
            this.TB_KHT5.TabIndex = 87;
            // 
            // TB_KHT4
            // 
            this.TB_KHT4.Location = new System.Drawing.Point(574, 242);
            this.TB_KHT4.Name = "TB_KHT4";
            this.TB_KHT4.Size = new System.Drawing.Size(100, 20);
            this.TB_KHT4.TabIndex = 86;
            // 
            // TB_KHT3
            // 
            this.TB_KHT3.Location = new System.Drawing.Point(574, 215);
            this.TB_KHT3.Name = "TB_KHT3";
            this.TB_KHT3.Size = new System.Drawing.Size(100, 20);
            this.TB_KHT3.TabIndex = 85;
            // 
            // TB_KHT2
            // 
            this.TB_KHT2.Location = new System.Drawing.Point(574, 188);
            this.TB_KHT2.Name = "TB_KHT2";
            this.TB_KHT2.Size = new System.Drawing.Size(100, 20);
            this.TB_KHT2.TabIndex = 84;
            // 
            // TB_KHT1
            // 
            this.TB_KHT1.Location = new System.Drawing.Point(574, 161);
            this.TB_KHT1.Name = "TB_KHT1";
            this.TB_KHT1.Size = new System.Drawing.Size(100, 20);
            this.TB_KHT1.TabIndex = 83;
            // 
            // TB_THT7
            // 
            this.TB_THT7.Location = new System.Drawing.Point(468, 323);
            this.TB_THT7.Name = "TB_THT7";
            this.TB_THT7.Size = new System.Drawing.Size(100, 20);
            this.TB_THT7.TabIndex = 82;
            // 
            // TB_THT6
            // 
            this.TB_THT6.Location = new System.Drawing.Point(468, 296);
            this.TB_THT6.Name = "TB_THT6";
            this.TB_THT6.Size = new System.Drawing.Size(100, 20);
            this.TB_THT6.TabIndex = 81;
            // 
            // TB_THT5
            // 
            this.TB_THT5.Location = new System.Drawing.Point(468, 269);
            this.TB_THT5.Name = "TB_THT5";
            this.TB_THT5.Size = new System.Drawing.Size(100, 20);
            this.TB_THT5.TabIndex = 80;
            // 
            // TB_THT4
            // 
            this.TB_THT4.Location = new System.Drawing.Point(468, 242);
            this.TB_THT4.Name = "TB_THT4";
            this.TB_THT4.Size = new System.Drawing.Size(100, 20);
            this.TB_THT4.TabIndex = 79;
            // 
            // TB_THT3
            // 
            this.TB_THT3.Location = new System.Drawing.Point(468, 215);
            this.TB_THT3.Name = "TB_THT3";
            this.TB_THT3.Size = new System.Drawing.Size(100, 20);
            this.TB_THT3.TabIndex = 78;
            // 
            // TB_THT2
            // 
            this.TB_THT2.Location = new System.Drawing.Point(468, 188);
            this.TB_THT2.Name = "TB_THT2";
            this.TB_THT2.Size = new System.Drawing.Size(100, 20);
            this.TB_THT2.TabIndex = 77;
            // 
            // TB_THT1
            // 
            this.TB_THT1.Location = new System.Drawing.Point(468, 161);
            this.TB_THT1.Name = "TB_THT1";
            this.TB_THT1.Size = new System.Drawing.Size(100, 20);
            this.TB_THT1.TabIndex = 76;
            // 
            // TB_KHN7
            // 
            this.TB_KHN7.Location = new System.Drawing.Point(362, 323);
            this.TB_KHN7.Name = "TB_KHN7";
            this.TB_KHN7.Size = new System.Drawing.Size(100, 20);
            this.TB_KHN7.TabIndex = 75;
            // 
            // TB_KHN6
            // 
            this.TB_KHN6.Location = new System.Drawing.Point(362, 296);
            this.TB_KHN6.Name = "TB_KHN6";
            this.TB_KHN6.Size = new System.Drawing.Size(100, 20);
            this.TB_KHN6.TabIndex = 74;
            // 
            // TB_KHN5
            // 
            this.TB_KHN5.Location = new System.Drawing.Point(362, 269);
            this.TB_KHN5.Name = "TB_KHN5";
            this.TB_KHN5.Size = new System.Drawing.Size(100, 20);
            this.TB_KHN5.TabIndex = 73;
            // 
            // TB_KHN4
            // 
            this.TB_KHN4.Location = new System.Drawing.Point(362, 242);
            this.TB_KHN4.Name = "TB_KHN4";
            this.TB_KHN4.Size = new System.Drawing.Size(100, 20);
            this.TB_KHN4.TabIndex = 72;
            // 
            // TB_KHN3
            // 
            this.TB_KHN3.Location = new System.Drawing.Point(362, 215);
            this.TB_KHN3.Name = "TB_KHN3";
            this.TB_KHN3.Size = new System.Drawing.Size(100, 20);
            this.TB_KHN3.TabIndex = 71;
            // 
            // TB_KHN2
            // 
            this.TB_KHN2.Location = new System.Drawing.Point(362, 188);
            this.TB_KHN2.Name = "TB_KHN2";
            this.TB_KHN2.Size = new System.Drawing.Size(100, 20);
            this.TB_KHN2.TabIndex = 70;
            // 
            // TB_KHN1
            // 
            this.TB_KHN1.Location = new System.Drawing.Point(362, 161);
            this.TB_KHN1.Name = "TB_KHN1";
            this.TB_KHN1.Size = new System.Drawing.Size(100, 20);
            this.TB_KHN1.TabIndex = 69;
            // 
            // TB_THN7
            // 
            this.TB_THN7.Location = new System.Drawing.Point(256, 323);
            this.TB_THN7.Name = "TB_THN7";
            this.TB_THN7.Size = new System.Drawing.Size(100, 20);
            this.TB_THN7.TabIndex = 68;
            // 
            // TB_THN6
            // 
            this.TB_THN6.Location = new System.Drawing.Point(256, 296);
            this.TB_THN6.Name = "TB_THN6";
            this.TB_THN6.Size = new System.Drawing.Size(100, 20);
            this.TB_THN6.TabIndex = 67;
            // 
            // TB_THN5
            // 
            this.TB_THN5.Location = new System.Drawing.Point(256, 269);
            this.TB_THN5.Name = "TB_THN5";
            this.TB_THN5.Size = new System.Drawing.Size(100, 20);
            this.TB_THN5.TabIndex = 66;
            // 
            // TB_THN4
            // 
            this.TB_THN4.Location = new System.Drawing.Point(256, 242);
            this.TB_THN4.Name = "TB_THN4";
            this.TB_THN4.Size = new System.Drawing.Size(100, 20);
            this.TB_THN4.TabIndex = 65;
            // 
            // TB_THN3
            // 
            this.TB_THN3.Location = new System.Drawing.Point(256, 215);
            this.TB_THN3.Name = "TB_THN3";
            this.TB_THN3.Size = new System.Drawing.Size(100, 20);
            this.TB_THN3.TabIndex = 64;
            // 
            // TB_THN2
            // 
            this.TB_THN2.Location = new System.Drawing.Point(256, 188);
            this.TB_THN2.Name = "TB_THN2";
            this.TB_THN2.Size = new System.Drawing.Size(100, 20);
            this.TB_THN2.TabIndex = 63;
            // 
            // TB_THN1
            // 
            this.TB_THN1.Location = new System.Drawing.Point(256, 161);
            this.TB_THN1.Name = "TB_THN1";
            this.TB_THN1.Size = new System.Drawing.Size(100, 20);
            this.TB_THN1.TabIndex = 62;
            // 
            // CB_SP7
            // 
            this.CB_SP7.DisplayMember = "TenSanPham";
            this.CB_SP7.FormattingEnabled = true;
            this.CB_SP7.Location = new System.Drawing.Point(113, 323);
            this.CB_SP7.Name = "CB_SP7";
            this.CB_SP7.Size = new System.Drawing.Size(121, 21);
            this.CB_SP7.TabIndex = 61;
            this.CB_SP7.Tag = 6;
            this.CB_SP7.SelectedIndexChanged += new System.EventHandler(this.comboBoxSP_SelectedIndexChanged);
            // 
            // CB_SP6
            // 
            this.CB_SP6.DisplayMember = "TenSanPham";
            this.CB_SP6.FormattingEnabled = true;
            this.CB_SP6.Location = new System.Drawing.Point(113, 296);
            this.CB_SP6.Name = "CB_SP6";
            this.CB_SP6.Size = new System.Drawing.Size(121, 21);
            this.CB_SP6.TabIndex = 60;
            this.CB_SP6.Tag = 5;
            this.CB_SP6.SelectedIndexChanged += new System.EventHandler(this.comboBoxSP_SelectedIndexChanged);
            // 
            // CB_SP5
            // 
            this.CB_SP5.DisplayMember = "TenSanPham";
            this.CB_SP5.FormattingEnabled = true;
            this.CB_SP5.Location = new System.Drawing.Point(113, 269);
            this.CB_SP5.Name = "CB_SP5";
            this.CB_SP5.Size = new System.Drawing.Size(121, 21);
            this.CB_SP5.TabIndex = 59;
            this.CB_SP5.Tag = 4;
            this.CB_SP5.SelectedIndexChanged += new System.EventHandler(this.comboBoxSP_SelectedIndexChanged);
            // 
            // CB_SP4
            // 
            this.CB_SP4.DisplayMember = "TenSanPham";
            this.CB_SP4.FormattingEnabled = true;
            this.CB_SP4.Location = new System.Drawing.Point(113, 242);
            this.CB_SP4.Name = "CB_SP4";
            this.CB_SP4.Size = new System.Drawing.Size(121, 21);
            this.CB_SP4.TabIndex = 58;
            this.CB_SP4.Tag = 3;
            this.CB_SP4.SelectedIndexChanged += new System.EventHandler(this.comboBoxSP_SelectedIndexChanged);
            // 
            // CB_SP3
            // 
            this.CB_SP3.DisplayMember = "TenSanPham";
            this.CB_SP3.FormattingEnabled = true;
            this.CB_SP3.Location = new System.Drawing.Point(113, 215);
            this.CB_SP3.Name = "CB_SP3";
            this.CB_SP3.Size = new System.Drawing.Size(121, 21);
            this.CB_SP3.TabIndex = 57;
            this.CB_SP3.Tag = 2;
            this.CB_SP3.SelectedIndexChanged += new System.EventHandler(this.comboBoxSP_SelectedIndexChanged);
            // 
            // CB_SP2
            // 
            this.CB_SP2.DisplayMember = "TenSanPham";
            this.CB_SP2.FormattingEnabled = true;
            this.CB_SP2.Location = new System.Drawing.Point(113, 188);
            this.CB_SP2.Name = "CB_SP2";
            this.CB_SP2.Size = new System.Drawing.Size(121, 21);
            this.CB_SP2.TabIndex = 56;
            this.CB_SP2.Tag = 1;
            this.CB_SP2.SelectedIndexChanged += new System.EventHandler(this.comboBoxSP_SelectedIndexChanged);
            // 
            // CB_SP1
            // 
            this.CB_SP1.DisplayMember = "TenSanPham";
            this.CB_SP1.FormattingEnabled = true;
            this.CB_SP1.Location = new System.Drawing.Point(113, 161);
            this.CB_SP1.Name = "CB_SP1";
            this.CB_SP1.Size = new System.Drawing.Size(121, 21);
            this.CB_SP1.TabIndex = 55;
            this.CB_SP1.Tag = 0;
            this.CB_SP1.SelectedIndexChanged += new System.EventHandler(this.comboBoxSP_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 454);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 486);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "THACO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort COM;
        private System.Windows.Forms.Timer TIMER1;
        private System.Windows.Forms.Timer TIMER2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BT_CONNECT;
        private System.Windows.Forms.ComboBox LISTCOM;
        private System.Windows.Forms.Button button_GetData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_NSX;
        private System.Windows.Forms.TextBox TB_LKT;
        private System.Windows.Forms.TextBox TB_NSX2;
        private System.Windows.Forms.TextBox TB_TKHT;
        private System.Windows.Forms.TextBox TB_TTHT;
        private System.Windows.Forms.TextBox TB_TKHN;
        private System.Windows.Forms.TextBox TB_TTHN;
        private System.Windows.Forms.TextBox TB_KHT7;
        private System.Windows.Forms.TextBox TB_KHT6;
        private System.Windows.Forms.TextBox TB_KHT5;
        private System.Windows.Forms.TextBox TB_KHT4;
        private System.Windows.Forms.TextBox TB_KHT3;
        private System.Windows.Forms.TextBox TB_KHT2;
        private System.Windows.Forms.TextBox TB_KHT1;
        private System.Windows.Forms.TextBox TB_THT7;
        private System.Windows.Forms.TextBox TB_THT6;
        private System.Windows.Forms.TextBox TB_THT5;
        private System.Windows.Forms.TextBox TB_THT4;
        private System.Windows.Forms.TextBox TB_THT3;
        private System.Windows.Forms.TextBox TB_THT2;
        private System.Windows.Forms.TextBox TB_THT1;
        private System.Windows.Forms.TextBox TB_KHN7;
        private System.Windows.Forms.TextBox TB_KHN6;
        private System.Windows.Forms.TextBox TB_KHN5;
        private System.Windows.Forms.TextBox TB_KHN4;
        private System.Windows.Forms.TextBox TB_KHN3;
        private System.Windows.Forms.TextBox TB_KHN2;
        private System.Windows.Forms.TextBox TB_KHN1;
        private System.Windows.Forms.TextBox TB_THN7;
        private System.Windows.Forms.TextBox TB_THN6;
        private System.Windows.Forms.TextBox TB_THN5;
        private System.Windows.Forms.TextBox TB_THN4;
        private System.Windows.Forms.TextBox TB_THN3;
        private System.Windows.Forms.TextBox TB_THN2;
        private System.Windows.Forms.TextBox TB_THN1;
        private System.Windows.Forms.ComboBox CB_SP7;
        private System.Windows.Forms.ComboBox CB_SP6;
        private System.Windows.Forms.ComboBox CB_SP5;
        private System.Windows.Forms.ComboBox CB_SP4;
        private System.Windows.Forms.ComboBox CB_SP3;
        private System.Windows.Forms.ComboBox CB_SP2;
        private System.Windows.Forms.ComboBox CB_SP1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

