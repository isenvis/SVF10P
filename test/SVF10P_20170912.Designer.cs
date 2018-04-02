namespace test
{
    partial class SVF10P_20170912
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.port_combo_Box = new System.Windows.Forms.ComboBox();
            this.close_serial_Button = new System.Windows.Forms.Button();
            this.open_serial_Button = new System.Windows.Forms.Button();
            this.manual_save_Button = new System.Windows.Forms.Button();
            this.bitmap_picture_Box = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.process1 = new System.Diagnostics.Process();
            this.SVF_RESISTER = new System.Windows.Forms.GroupBox();
            this.ImageFilter_comboBox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.SensingMode_ComboBox = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Display_Threshold_TextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GPB_REG_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CLK_SEL_ComboBox = new System.Windows.Forms.ComboBox();
            this.ADC_REF_TextBox = new System.Windows.Forms.TextBox();
            this.Multiplying_TextBox = new System.Windows.Forms.TextBox();
            this.SLV_STU_ComboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SCK_UT_ComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.NAVI_ComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SL_TIME_ComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ISOL_ComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PERIOD_ComboBox = new System.Windows.Forms.ComboBox();
            this.DYL2X_ComboBox = new System.Windows.Forms.ComboBox();
            this.ADC_RSEL_ComboBox = new System.Windows.Forms.ComboBox();
            this.S_GAIN_ComboBox = new System.Windows.Forms.ComboBox();
            this.DLY2X_OSC_ComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Set_Resister_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.SVF_ID_TextBox = new System.Windows.Forms.TextBox();
            this.Select_Folder_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.auto_save_Button = new System.Windows.Forms.Button();
            this.cancle_save_Button = new System.Windows.Forms.Button();
            this.histogram_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bitmap_picture_Box)).BeginInit();
            this.SVF_RESISTER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogram_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(35, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Finger Print Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(290, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "COM Port";
            // 
            // port_combo_Box
            // 
            this.port_combo_Box.FormattingEnabled = true;
            this.port_combo_Box.Location = new System.Drawing.Point(294, 72);
            this.port_combo_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.port_combo_Box.Name = "port_combo_Box";
            this.port_combo_Box.Size = new System.Drawing.Size(114, 23);
            this.port_combo_Box.TabIndex = 13;
            // 
            // close_serial_Button
            // 
            this.close_serial_Button.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.close_serial_Button.Location = new System.Drawing.Point(293, 180);
            this.close_serial_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close_serial_Button.Name = "close_serial_Button";
            this.close_serial_Button.Size = new System.Drawing.Size(81, 50);
            this.close_serial_Button.TabIndex = 12;
            this.close_serial_Button.Text = "CLOSE";
            this.close_serial_Button.UseVisualStyleBackColor = true;
            this.close_serial_Button.Click += new System.EventHandler(this.close_serial_Button_Click_1);
            // 
            // open_serial_Button
            // 
            this.open_serial_Button.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.open_serial_Button.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.open_serial_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.open_serial_Button.Location = new System.Drawing.Point(293, 114);
            this.open_serial_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.open_serial_Button.Name = "open_serial_Button";
            this.open_serial_Button.Size = new System.Drawing.Size(81, 50);
            this.open_serial_Button.TabIndex = 11;
            this.open_serial_Button.Text = "OPEN";
            this.open_serial_Button.UseVisualStyleBackColor = true;
            this.open_serial_Button.Click += new System.EventHandler(this.open_serial_Button_Click_1);
            // 
            // manual_save_Button
            // 
            this.manual_save_Button.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.manual_save_Button.Location = new System.Drawing.Point(594, 641);
            this.manual_save_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manual_save_Button.Name = "manual_save_Button";
            this.manual_save_Button.Size = new System.Drawing.Size(94, 50);
            this.manual_save_Button.TabIndex = 10;
            this.manual_save_Button.Text = "MANUAL SAVE";
            this.manual_save_Button.UseVisualStyleBackColor = true;
            this.manual_save_Button.Click += new System.EventHandler(this.image_save_Button_Click);
            // 
            // bitmap_picture_Box
            // 
            this.bitmap_picture_Box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bitmap_picture_Box.Location = new System.Drawing.Point(38, 59);
            this.bitmap_picture_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bitmap_picture_Box.Name = "bitmap_picture_Box";
            this.bitmap_picture_Box.Size = new System.Drawing.Size(219, 240);
            this.bitmap_picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bitmap_picture_Box.TabIndex = 9;
            this.bitmap_picture_Box.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 921600;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // SVF_RESISTER
            // 
            this.SVF_RESISTER.Controls.Add(this.ImageFilter_comboBox);
            this.SVF_RESISTER.Controls.Add(this.label21);
            this.SVF_RESISTER.Controls.Add(this.SensingMode_ComboBox);
            this.SVF_RESISTER.Controls.Add(this.label23);
            this.SVF_RESISTER.Controls.Add(this.Display_Threshold_TextBox);
            this.SVF_RESISTER.Controls.Add(this.label11);
            this.SVF_RESISTER.Controls.Add(this.GPB_REG_TextBox);
            this.SVF_RESISTER.Controls.Add(this.label4);
            this.SVF_RESISTER.Controls.Add(this.CLK_SEL_ComboBox);
            this.SVF_RESISTER.Controls.Add(this.ADC_REF_TextBox);
            this.SVF_RESISTER.Controls.Add(this.Multiplying_TextBox);
            this.SVF_RESISTER.Controls.Add(this.SLV_STU_ComboBox);
            this.SVF_RESISTER.Controls.Add(this.label17);
            this.SVF_RESISTER.Controls.Add(this.SCK_UT_ComboBox);
            this.SVF_RESISTER.Controls.Add(this.label16);
            this.SVF_RESISTER.Controls.Add(this.NAVI_ComboBox);
            this.SVF_RESISTER.Controls.Add(this.label15);
            this.SVF_RESISTER.Controls.Add(this.SL_TIME_ComboBox);
            this.SVF_RESISTER.Controls.Add(this.label14);
            this.SVF_RESISTER.Controls.Add(this.ISOL_ComboBox);
            this.SVF_RESISTER.Controls.Add(this.label10);
            this.SVF_RESISTER.Controls.Add(this.PERIOD_ComboBox);
            this.SVF_RESISTER.Controls.Add(this.DYL2X_ComboBox);
            this.SVF_RESISTER.Controls.Add(this.ADC_RSEL_ComboBox);
            this.SVF_RESISTER.Controls.Add(this.S_GAIN_ComboBox);
            this.SVF_RESISTER.Controls.Add(this.DLY2X_OSC_ComboBox);
            this.SVF_RESISTER.Controls.Add(this.label5);
            this.SVF_RESISTER.Controls.Add(this.label13);
            this.SVF_RESISTER.Controls.Add(this.label9);
            this.SVF_RESISTER.Controls.Add(this.label8);
            this.SVF_RESISTER.Controls.Add(this.label7);
            this.SVF_RESISTER.Controls.Add(this.label12);
            this.SVF_RESISTER.Controls.Add(this.Set_Resister_Button);
            this.SVF_RESISTER.Controls.Add(this.label6);
            this.SVF_RESISTER.Controls.Add(this.label2);
            this.SVF_RESISTER.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SVF_RESISTER.Location = new System.Drawing.Point(449, 21);
            this.SVF_RESISTER.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SVF_RESISTER.Name = "SVF_RESISTER";
            this.SVF_RESISTER.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SVF_RESISTER.Size = new System.Drawing.Size(438, 610);
            this.SVF_RESISTER.TabIndex = 18;
            this.SVF_RESISTER.TabStop = false;
            this.SVF_RESISTER.Text = "SVF REGISTER SET";
            // 
            // ImageFilter_comboBox
            // 
            this.ImageFilter_comboBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold);
            this.ImageFilter_comboBox.FormattingEnabled = true;
            this.ImageFilter_comboBox.Items.AddRange(new object[] {
            "Not Used",
            "Wiener filter"});
            this.ImageFilter_comboBox.Location = new System.Drawing.Point(199, 570);
            this.ImageFilter_comboBox.Name = "ImageFilter_comboBox";
            this.ImageFilter_comboBox.Size = new System.Drawing.Size(115, 22);
            this.ImageFilter_comboBox.TabIndex = 148;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(87, 576);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 14);
            this.label21.TabIndex = 147;
            this.label21.Text = "Image Filtering";
            // 
            // SensingMode_ComboBox
            // 
            this.SensingMode_ComboBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold);
            this.SensingMode_ComboBox.FormattingEnabled = true;
            this.SensingMode_ComboBox.Items.AddRange(new object[] {
            "Normal",
            "Wet",
            "Dry"});
            this.SensingMode_ComboBox.Location = new System.Drawing.Point(199, 532);
            this.SensingMode_ComboBox.Name = "SensingMode_ComboBox";
            this.SensingMode_ComboBox.Size = new System.Drawing.Size(115, 22);
            this.SensingMode_ComboBox.TabIndex = 146;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(88, 537);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(114, 14);
            this.label23.TabIndex = 145;
            this.label23.Text = "Sensing Mode";
            // 
            // Display_Threshold_TextBox
            // 
            this.Display_Threshold_TextBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Display_Threshold_TextBox.Location = new System.Drawing.Point(199, 496);
            this.Display_Threshold_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Display_Threshold_TextBox.MaxLength = 5;
            this.Display_Threshold_TextBox.Name = "Display_Threshold_TextBox";
            this.Display_Threshold_TextBox.Size = new System.Drawing.Size(117, 23);
            this.Display_Threshold_TextBox.TabIndex = 142;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(37, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 14);
            this.label11.TabIndex = 141;
            this.label11.Text = "GPB_REG[b00000000]";
            // 
            // GPB_REG_TextBox
            // 
            this.GPB_REG_TextBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GPB_REG_TextBox.Location = new System.Drawing.Point(199, 395);
            this.GPB_REG_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GPB_REG_TextBox.MaxLength = 8;
            this.GPB_REG_TextBox.Name = "GPB_REG_TextBox";
            this.GPB_REG_TextBox.Size = new System.Drawing.Size(116, 23);
            this.GPB_REG_TextBox.TabIndex = 140;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(77, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 14);
            this.label4.TabIndex = 139;
            this.label4.Text = "Disp. Threshold";
            // 
            // CLK_SEL_ComboBox
            // 
            this.CLK_SEL_ComboBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CLK_SEL_ComboBox.FormattingEnabled = true;
            this.CLK_SEL_ComboBox.ItemHeight = 14;
            this.CLK_SEL_ComboBox.Items.AddRange(new object[] {
            "CK_SYS",
            "Divided by 2 CK_SYS",
            "Divided by 4 CK_SYS",
            "Divided by 8 CK_SYS"});
            this.CLK_SEL_ComboBox.Location = new System.Drawing.Point(162, 164);
            this.CLK_SEL_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CLK_SEL_ComboBox.MaxDropDownItems = 6;
            this.CLK_SEL_ComboBox.Name = "CLK_SEL_ComboBox";
            this.CLK_SEL_ComboBox.Size = new System.Drawing.Size(189, 22);
            this.CLK_SEL_ComboBox.TabIndex = 137;
            // 
            // ADC_REF_TextBox
            // 
            this.ADC_REF_TextBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ADC_REF_TextBox.Location = new System.Drawing.Point(199, 462);
            this.ADC_REF_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ADC_REF_TextBox.MaxLength = 3;
            this.ADC_REF_TextBox.Name = "ADC_REF_TextBox";
            this.ADC_REF_TextBox.Size = new System.Drawing.Size(117, 23);
            this.ADC_REF_TextBox.TabIndex = 136;
            // 
            // Multiplying_TextBox
            // 
            this.Multiplying_TextBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Multiplying_TextBox.Location = new System.Drawing.Point(199, 429);
            this.Multiplying_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Multiplying_TextBox.MaxLength = 2;
            this.Multiplying_TextBox.Name = "Multiplying_TextBox";
            this.Multiplying_TextBox.Size = new System.Drawing.Size(117, 23);
            this.Multiplying_TextBox.TabIndex = 135;
            // 
            // SLV_STU_ComboBox
            // 
            this.SLV_STU_ComboBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SLV_STU_ComboBox.FormattingEnabled = true;
            this.SLV_STU_ComboBox.ItemHeight = 14;
            this.SLV_STU_ComboBox.Items.AddRange(new object[] {
            "CAP_O",
            "CAP_N",
            "SLEEP",
            "MEM_R"});
            this.SLV_STU_ComboBox.Location = new System.Drawing.Point(162, 359);
            this.SLV_STU_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SLV_STU_ComboBox.MaxDropDownItems = 6;
            this.SLV_STU_ComboBox.Name = "SLV_STU_ComboBox";
            this.SLV_STU_ComboBox.Size = new System.Drawing.Size(86, 22);
            this.SLV_STU_ComboBox.TabIndex = 134;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(89, 364);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 14);
            this.label17.TabIndex = 133;
            this.label17.Text = "SLV_STU";
            // 
            // SCK_UT_ComboBox
            // 
            this.SCK_UT_ComboBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SCK_UT_ComboBox.FormattingEnabled = true;
            this.SCK_UT_ComboBox.ItemHeight = 14;
            this.SCK_UT_ComboBox.Items.AddRange(new object[] {
            "MODE 00",
            "MODE 01",
            "MODE 10",
            "MODE 11"});
            this.SCK_UT_ComboBox.Location = new System.Drawing.Point(162, 326);
            this.SCK_UT_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SCK_UT_ComboBox.MaxDropDownItems = 6;
            this.SCK_UT_ComboBox.Name = "SCK_UT_ComboBox";
            this.SCK_UT_ComboBox.Size = new System.Drawing.Size(150, 22);
            this.SCK_UT_ComboBox.TabIndex = 132;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(79, 330);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 14);
            this.label16.TabIndex = 131;
            this.label16.Text = "Low Noise";
            // 
            // NAVI_ComboBox
            // 
            this.NAVI_ComboBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_ComboBox.FormattingEnabled = true;
            this.NAVI_ComboBox.ItemHeight = 14;
            this.NAVI_ComboBox.Items.AddRange(new object[] {
            "Nomal",
            "Navigation"});
            this.NAVI_ComboBox.Location = new System.Drawing.Point(162, 294);
            this.NAVI_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NAVI_ComboBox.MaxDropDownItems = 6;
            this.NAVI_ComboBox.Name = "NAVI_ComboBox";
            this.NAVI_ComboBox.Size = new System.Drawing.Size(119, 22);
            this.NAVI_ComboBox.TabIndex = 130;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(124, 300);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 14);
            this.label15.TabIndex = 129;
            this.label15.Text = "NAVI";
            // 
            // SL_TIME_ComboBox
            // 
            this.SL_TIME_ComboBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SL_TIME_ComboBox.FormattingEnabled = true;
            this.SL_TIME_ComboBox.ItemHeight = 14;
            this.SL_TIME_ComboBox.Items.AddRange(new object[] {
            "Deep Sleep",
            "50 ms",
            "400 ms",
            "1000 ms"});
            this.SL_TIME_ComboBox.Location = new System.Drawing.Point(162, 261);
            this.SL_TIME_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SL_TIME_ComboBox.MaxDropDownItems = 6;
            this.SL_TIME_ComboBox.Name = "SL_TIME_ComboBox";
            this.SL_TIME_ComboBox.Size = new System.Drawing.Size(119, 22);
            this.SL_TIME_ComboBox.TabIndex = 128;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(93, 265);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 14);
            this.label14.TabIndex = 127;
            this.label14.Text = "SL_TIME";
            // 
            // ISOL_ComboBox
            // 
            this.ISOL_ComboBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ISOL_ComboBox.FormattingEnabled = true;
            this.ISOL_ComboBox.ItemHeight = 14;
            this.ISOL_ComboBox.Items.AddRange(new object[] {
            "Strong",
            "Weak"});
            this.ISOL_ComboBox.Location = new System.Drawing.Point(162, 229);
            this.ISOL_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ISOL_ComboBox.MaxDropDownItems = 6;
            this.ISOL_ComboBox.Name = "ISOL_ComboBox";
            this.ISOL_ComboBox.Size = new System.Drawing.Size(134, 22);
            this.ISOL_ComboBox.TabIndex = 126;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(6, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 14);
            this.label10.TabIndex = 125;
            this.label10.Text = "Drv. Signal Strength";
            // 
            // PERIOD_ComboBox
            // 
            this.PERIOD_ComboBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PERIOD_ComboBox.FormattingEnabled = true;
            this.PERIOD_ComboBox.ItemHeight = 14;
            this.PERIOD_ComboBox.Items.AddRange(new object[] {
            "000",
            "001",
            "010",
            "011",
            "100",
            "101",
            "110"});
            this.PERIOD_ComboBox.Location = new System.Drawing.Point(162, 196);
            this.PERIOD_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PERIOD_ComboBox.MaxDropDownItems = 6;
            this.PERIOD_ComboBox.Name = "PERIOD_ComboBox";
            this.PERIOD_ComboBox.Size = new System.Drawing.Size(86, 22);
            this.PERIOD_ComboBox.TabIndex = 124;
            this.PERIOD_ComboBox.SelectedIndexChanged += new System.EventHandler(this.PERIOD_ComboBox_SelectedIndexChanged);
            // 
            // DYL2X_ComboBox
            // 
            this.DYL2X_ComboBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DYL2X_ComboBox.FormattingEnabled = true;
            this.DYL2X_ComboBox.ItemHeight = 14;
            this.DYL2X_ComboBox.Items.AddRange(new object[] {
            "10ns",
            "15ns"});
            this.DYL2X_ComboBox.Location = new System.Drawing.Point(162, 131);
            this.DYL2X_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DYL2X_ComboBox.MaxDropDownItems = 6;
            this.DYL2X_ComboBox.Name = "DYL2X_ComboBox";
            this.DYL2X_ComboBox.Size = new System.Drawing.Size(86, 22);
            this.DYL2X_ComboBox.TabIndex = 123;
            // 
            // ADC_RSEL_ComboBox
            // 
            this.ADC_RSEL_ComboBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ADC_RSEL_ComboBox.FormattingEnabled = true;
            this.ADC_RSEL_ComboBox.ItemHeight = 14;
            this.ADC_RSEL_ComboBox.Items.AddRange(new object[] {
            "Internal",
            "External"});
            this.ADC_RSEL_ComboBox.Location = new System.Drawing.Point(162, 99);
            this.ADC_RSEL_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ADC_RSEL_ComboBox.MaxDropDownItems = 6;
            this.ADC_RSEL_ComboBox.Name = "ADC_RSEL_ComboBox";
            this.ADC_RSEL_ComboBox.Size = new System.Drawing.Size(103, 22);
            this.ADC_RSEL_ComboBox.TabIndex = 122;
            // 
            // S_GAIN_ComboBox
            // 
            this.S_GAIN_ComboBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.S_GAIN_ComboBox.FormattingEnabled = true;
            this.S_GAIN_ComboBox.ItemHeight = 14;
            this.S_GAIN_ComboBox.Items.AddRange(new object[] {
            "1X",
            "1.2X",
            "1.5X",
            "2X"});
            this.S_GAIN_ComboBox.Location = new System.Drawing.Point(162, 66);
            this.S_GAIN_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.S_GAIN_ComboBox.MaxDropDownItems = 6;
            this.S_GAIN_ComboBox.Name = "S_GAIN_ComboBox";
            this.S_GAIN_ComboBox.Size = new System.Drawing.Size(86, 22);
            this.S_GAIN_ComboBox.TabIndex = 121;
            // 
            // DLY2X_OSC_ComboBox
            // 
            this.DLY2X_OSC_ComboBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DLY2X_OSC_ComboBox.FormattingEnabled = true;
            this.DLY2X_OSC_ComboBox.ItemHeight = 14;
            this.DLY2X_OSC_ComboBox.Items.AddRange(new object[] {
            "10MHz",
            "5MHz"});
            this.DLY2X_OSC_ComboBox.Location = new System.Drawing.Point(162, 34);
            this.DLY2X_OSC_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DLY2X_OSC_ComboBox.MaxDropDownItems = 6;
            this.DLY2X_OSC_ComboBox.Name = "DLY2X_OSC_ComboBox";
            this.DLY2X_OSC_ComboBox.Size = new System.Drawing.Size(86, 22);
            this.DLY2X_OSC_ComboBox.TabIndex = 120;
            this.DLY2X_OSC_ComboBox.SelectedIndexChanged += new System.EventHandler(this.DLY2X_OSC_ComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(16, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 14);
            this.label5.TabIndex = 119;
            this.label5.Text = "Multiplying factor[0~63]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(72, 471);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 14);
            this.label13.TabIndex = 118;
            this.label13.Text = "ADC_REF[0~255]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(39, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 14);
            this.label9.TabIndex = 117;
            this.label9.Text = "Integration Gain";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(90, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 14);
            this.label8.TabIndex = 116;
            this.label8.Text = "CLK_SEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(109, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 115;
            this.label7.Text = "DYL2X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(76, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 14);
            this.label12.TabIndex = 114;
            this.label12.Text = "ADC_RSEL";
            // 
            // Set_Resister_Button
            // 
            this.Set_Resister_Button.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Set_Resister_Button.Location = new System.Drawing.Point(333, 545);
            this.Set_Resister_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Set_Resister_Button.Name = "Set_Resister_Button";
            this.Set_Resister_Button.Size = new System.Drawing.Size(95, 50);
            this.Set_Resister_Button.TabIndex = 113;
            this.Set_Resister_Button.Text = "SET REGISTER";
            this.Set_Resister_Button.UseVisualStyleBackColor = true;
            this.Set_Resister_Button.Click += new System.EventHandler(this.Set_Resister_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(57, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 14);
            this.label6.TabIndex = 112;
            this.label6.Text = "Sensing Gain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(39, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 14);
            this.label2.TabIndex = 111;
            this.label2.Text = "Internal CK Freq";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(297, 246);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 15);
            this.label18.TabIndex = 143;
            this.label18.Text = "ID READ";
            // 
            // SVF_ID_TextBox
            // 
            this.SVF_ID_TextBox.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SVF_ID_TextBox.Location = new System.Drawing.Point(296, 276);
            this.SVF_ID_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SVF_ID_TextBox.MaxLength = 8;
            this.SVF_ID_TextBox.Name = "SVF_ID_TextBox";
            this.SVF_ID_TextBox.ReadOnly = true;
            this.SVF_ID_TextBox.Size = new System.Drawing.Size(93, 26);
            this.SVF_ID_TextBox.TabIndex = 143;
            this.SVF_ID_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Select_Folder_Button
            // 
            this.Select_Folder_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Select_Folder_Button.Location = new System.Drawing.Point(550, 648);
            this.Select_Folder_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Select_Folder_Button.Name = "Select_Folder_Button";
            this.Select_Folder_Button.Size = new System.Drawing.Size(39, 34);
            this.Select_Folder_Button.TabIndex = 144;
            this.Select_Folder_Button.Text = "...";
            this.Select_Folder_Button.UseVisualStyleBackColor = true;
            this.Select_Folder_Button.Click += new System.EventHandler(this.Select_Folder_Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(96, 653);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(442, 23);
            this.textBox1.TabIndex = 145;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(23, 667);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(70, 14);
            this.label19.TabIndex = 143;
            this.label19.Text = "FOLDER";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // auto_save_Button
            // 
            this.auto_save_Button.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.auto_save_Button.Location = new System.Drawing.Point(691, 639);
            this.auto_save_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.auto_save_Button.Name = "auto_save_Button";
            this.auto_save_Button.Size = new System.Drawing.Size(93, 50);
            this.auto_save_Button.TabIndex = 146;
            this.auto_save_Button.Text = "AUTO  SAVE";
            this.auto_save_Button.UseVisualStyleBackColor = true;
            this.auto_save_Button.Click += new System.EventHandler(this.auto_save_Button_Click);
            // 
            // cancle_save_Button
            // 
            this.cancle_save_Button.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancle_save_Button.Location = new System.Drawing.Point(787, 639);
            this.cancle_save_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancle_save_Button.Name = "cancle_save_Button";
            this.cancle_save_Button.Size = new System.Drawing.Size(86, 50);
            this.cancle_save_Button.TabIndex = 147;
            this.cancle_save_Button.Text = "SAVE CANCLE";
            this.cancle_save_Button.UseVisualStyleBackColor = true;
            this.cancle_save_Button.Click += new System.EventHandler(this.cancle_save_Button_Click);
            // 
            // histogram_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.histogram_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.histogram_Chart.Legends.Add(legend1);
            this.histogram_Chart.Location = new System.Drawing.Point(34, 339);
            this.histogram_Chart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.histogram_Chart.Name = "histogram_Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "Histogram";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.histogram_Chart.Series.Add(series1);
            this.histogram_Chart.Size = new System.Drawing.Size(395, 220);
            this.histogram_Chart.TabIndex = 148;
            this.histogram_Chart.Click += new System.EventHandler(this.histogram_Chart_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(34, 649);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label20.Size = new System.Drawing.Size(47, 14);
            this.label20.TabIndex = 149;
            this.label20.Text = "SAVE";
            // 
            // SVF10P_20170912
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 697);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.histogram_Chart);
            this.Controls.Add(this.cancle_save_Button);
            this.Controls.Add(this.auto_save_Button);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Select_Folder_Button);
            this.Controls.Add(this.SVF_ID_TextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.SVF_RESISTER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port_combo_Box);
            this.Controls.Add(this.close_serial_Button);
            this.Controls.Add(this.open_serial_Button);
            this.Controls.Add(this.manual_save_Button);
            this.Controls.Add(this.bitmap_picture_Box);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SVF10P_20170912";
            this.Text = "Finger Print Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bitmap_picture_Box)).EndInit();
            this.SVF_RESISTER.ResumeLayout(false);
            this.SVF_RESISTER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogram_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox port_combo_Box;
        private System.Windows.Forms.Button close_serial_Button;
        private System.Windows.Forms.Button open_serial_Button;
        private System.Windows.Forms.Button manual_save_Button;
        private System.Windows.Forms.PictureBox bitmap_picture_Box;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.GroupBox SVF_RESISTER;
        private System.Windows.Forms.TextBox ADC_REF_TextBox;
        private System.Windows.Forms.TextBox Multiplying_TextBox;
        private System.Windows.Forms.ComboBox SLV_STU_ComboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox SCK_UT_ComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox NAVI_ComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox SL_TIME_ComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ISOL_ComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox PERIOD_ComboBox;
        private System.Windows.Forms.ComboBox DYL2X_ComboBox;
        private System.Windows.Forms.ComboBox ADC_RSEL_ComboBox;
        private System.Windows.Forms.ComboBox S_GAIN_ComboBox;
        private System.Windows.Forms.ComboBox DLY2X_OSC_ComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Set_Resister_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CLK_SEL_ComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox GPB_REG_TextBox;
        private System.Windows.Forms.TextBox Display_Threshold_TextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox SVF_ID_TextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Select_Folder_Button;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button cancle_save_Button;
        private System.Windows.Forms.Button auto_save_Button;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogram_Chart;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox SensingMode_ComboBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox ImageFilter_comboBox;
        private System.Windows.Forms.Label label21;
    }
}

