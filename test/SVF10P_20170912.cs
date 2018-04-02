using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace test
{
    public partial class SVF10P_20170912 : Form
    {
 //       bool RELEASE_VERSION = false;
        bool RELEASE_VERSION = true;
        bool auto_save_mode = false;
        bool save_folder_selected = false;
        UInt32 auto_save_count = 0;

        public SVF10P_20170912()
        {
            InitializeComponent();
            ms_timer_tick = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            port_combo_Box.Items.AddRange(ports);
            port_combo_Box.SelectedIndex = 0;

            close_serial_Button.Enabled = false;
            manual_save_Button.Enabled = true;
            Set_Resister_Button.Enabled = false;
            manual_save_Button.Enabled = false;
            auto_save_Button.Enabled = false;
            cancle_save_Button.Enabled = false;

            open_serial_Button.BackColor = Color.LightGray;

            DLY2X_OSC_ComboBox.SelectedIndex = 0;
            S_GAIN_ComboBox.SelectedIndex = 3;

            if (RELEASE_VERSION == true)
                label12.Enabled = false;
            ADC_RSEL_ComboBox.SelectedIndex = 0;
            if (RELEASE_VERSION == true)
                ADC_RSEL_ComboBox.Enabled = false;

            if (RELEASE_VERSION == true)
                label7.Enabled = false;
            DYL2X_ComboBox.SelectedIndex = 1;
            if (RELEASE_VERSION == true)
                DYL2X_ComboBox.Enabled = false;

            if (RELEASE_VERSION == true)
                label8.Enabled = false;
            CLK_SEL_ComboBox.SelectedIndex = 0;
            if (RELEASE_VERSION==true)
                CLK_SEL_ComboBox.Enabled = false;

            PERIOD_ComboBox.SelectedIndex = 1;
            ISOL_ComboBox.SelectedIndex = 0;
            SL_TIME_ComboBox.SelectedIndex = 3;

            if (RELEASE_VERSION == true)
                label15.Enabled = false;
            NAVI_ComboBox.SelectedIndex = 0;
            if (RELEASE_VERSION == true)
                NAVI_ComboBox.Enabled = false;

            SCK_UT_ComboBox.SelectedIndex = 0;

            if (RELEASE_VERSION == true)
                label17.Enabled = false;
            SLV_STU_ComboBox.SelectedIndex = 0;
            if (RELEASE_VERSION == true)
                SLV_STU_ComboBox.Enabled = false;

            if (RELEASE_VERSION == true)
                label5.Enabled = false;
            Multiplying_TextBox.Text = "5";
            if (RELEASE_VERSION == true)
                Multiplying_TextBox.Enabled = false;

            if (RELEASE_VERSION == true)
                label13.Enabled = false;
            ADC_REF_TextBox.Text = "5";
            if (RELEASE_VERSION == true)
                ADC_REF_TextBox.Enabled = false;
 
            if (RELEASE_VERSION == true)
                label11.Enabled = false;
            GPB_REG_TextBox.Text = "11100000";
            if (RELEASE_VERSION == true)
                GPB_REG_TextBox.Enabled = false;

            Display_Threshold_TextBox.Text = "100";
            SensingMode_ComboBox.SelectedIndex = 0;
            ImageFilter_comboBox.SelectedIndex = 0;

            textBox1.Text = "C:\\Temp\\FP_Image";
            Control.CheckForIllegalCrossThreadCalls = false;
            bitmap_picture_Box.SizeMode = PictureBoxSizeMode.StretchImage;

        }


        private void close_serial_Button_Click_1(object sender, EventArgs e)
        {
            open_serial_Button.Enabled = true;
            close_serial_Button.Enabled = false;
            manual_save_Button.Enabled = true;
            Set_Resister_Button.Enabled = false;
            manual_save_Button.Enabled = false;
            auto_save_Button.Enabled = false;
            cancle_save_Button.Enabled = false;
            open_serial_Button.BackColor = Color.LightGray;

            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void open_serial_Button_Click_1(object sender, EventArgs e)
        {

            open_serial_Button.Enabled = false;
            close_serial_Button.Enabled = true;
            manual_save_Button.Enabled = false;
            Set_Resister_Button.Enabled = true;
            if (save_folder_selected)
            {
                
                manual_save_Button.Enabled = true;
                auto_save_Button.Enabled = true;

            }
            

            if (chip_id_read_OK)
            {
                
            }
            else
            {
                chip_id_read_OK = false;
                timer1.Start();
            }
            

            try
            {
                serialPort1.PortName = port_combo_Box.Text;
                serialPort1.Open();
                open_serial_Button.BackColor = Color.LightSkyBlue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        byte [] BMP_Image_Buffer = new Byte[10296];
        byte receive_data_buffer;
        UInt16 Data_Save_count = 0;
        bool Data_Save_Mode = false;
        Bitmap Finger_Print_Image = new Bitmap(96,96);

        bool chip_id_read = false;
        bool chip_id_read_OK = false;
        byte[] Chip_ID_Buffer = new Byte[6];

        delegate void Histogram_Graph_Callback();




        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            int buffer_count = serialPort1.BytesToRead;

            byte[] rx_buffer = new byte[buffer_count];

            try
            {
                serialPort1.Read(rx_buffer, 0, buffer_count);
            }
            
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "포트 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


            for (int i=0; i< buffer_count; i++)
            {

                receive_data_buffer = rx_buffer[i];


                if ((Data_Save_Mode == false) && (chip_id_read == false) && (rx_buffer[i] == 0x42))
                {
                    Data_Save_count = 0;
                    Data_Save_Mode = true;
                }

                if ((Data_Save_Mode == false) && (chip_id_read == false) && (chip_id_read_OK == false) && (rx_buffer[i] == Convert.ToByte('S')))
                {
                    Data_Save_count = 0;
                    chip_id_read = true;
                }

                if (Data_Save_Mode)
                {

                    try
                    {
                        BMP_Image_Buffer[Data_Save_count] = rx_buffer[i];
                    }
                    catch (IndexOutOfRangeException ex)
                    {

                        MessageBox.Show(ex.Message, "배열 버퍼 초과", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    

                    if (Data_Save_count == 3)
                    {
                        if ((BMP_Image_Buffer[0] == 0x42) && (BMP_Image_Buffer[1] == 0x4d) && (BMP_Image_Buffer[2] == 0x38) && (BMP_Image_Buffer[3] == 0x28))
                        { }
                        else
                        {
                            Data_Save_Mode = false;
                            Data_Save_count = 0;
                        }
                    }

                    Data_Save_count++;

                    if (Data_Save_count == 10296)
                    {

                        Finger_Print_Image = DecodeImage(BMP_Image_Buffer);

                        ///**************************************** 2018.01.12 수정 부분 *********************************************************//
                        ///
                        Bitmap Finger_Print_Image2 = new Bitmap(Finger_Print_Image); // Finger_Print_Image2 비트맵 변수 추가, 

                        bitmap_picture_Box.Image = Finger_Print_Image;// picture_Box 에 비트맵 이미지를 표시를 할때 Finger_Print_Image 변수만 사용하도록 Finger_Print_Image2 변수를 추가 선언

                        Data_Save_Mode = false;
                        Data_Save_count = 0;

                        /*
                        try
                        {
                            if (bitmap_picture_Box != null) bitmap_picture_Box.Image.Dispose();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "clear error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //return;
                            //break;
                        }*/




                        if (auto_save_mode)
                        {
                            Bitmap Temp_bitmap = new Bitmap(Finger_Print_Image2); // picture_Box 에서 Finger_Print_Image 변수를 Read 하는 과정에서 중복 Read 하지 않도록 비트맵 저장 변수인 Temp_bitmap
                                                                                  // 에는 Finger_Print_Image2 변수를 사용하여 저장, 5시간 정도 테스트 결과 멈춤현상 발생하지 않았음

                            //Finger_Print_Image.Dispose();

                            try
                            {
                                
                                Temp_bitmap.Save(fd.SelectedPath + @"\" + "SVF10_" + Convert.ToString(auto_save_count) + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                                //Temp_bitmap.Dispose();


                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message, "save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //return;
                            }
                            auto_save_count++;


                        }
                        

                        Thread histogramThread = new Thread(new ThreadStart(Histogram_Graph));   // Histogram 호출
                        histogramThread.Start();







                    }
                    
                }

                if(chip_id_read)
                {
                    try
                    {
                        Chip_ID_Buffer[Data_Save_count] = rx_buffer[i];
                    }
                    catch (IndexOutOfRangeException ex)
                    {

                        MessageBox.Show(ex.Message, "배열 버퍼 초과", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    if (Data_Save_count == 5)
                    {
                        if ((Chip_ID_Buffer[0] == Convert.ToByte('S')) && (Chip_ID_Buffer[1] == Convert.ToByte('V')) && (Chip_ID_Buffer[2] == Convert.ToByte('F')))
                        {
                            chip_id_read = false;
                            chip_id_read_OK = true;
                            Data_Save_count = 0;

                            SVF_ID_TextBox.Text = Encoding.UTF8.GetString(Chip_ID_Buffer);

                            timer1.Stop();

                            // YHCTEST

                            //Set_Resister_Button_Click(sender, e);


                        }
                        else
                        {
                            chip_id_read = false;
                            Data_Save_count = 0;
                        }
                    }

                    Data_Save_count++;
                }
            }
        }


        ///histogram 출력 함수
        private void Histogram_Graph()
        {
            int[] histogram_buffer = new int[256];

            

            for (int j = 1078; j < 10294; j++)
            {
                histogram_buffer[Convert.ToInt32(BMP_Image_Buffer[j])]++;
            }

            
            
                
            if(histogram_Chart.InvokeRequired)
            {
                try
                {
                    histogram_Chart.Invoke(new Histogram_Graph_Callback(Histogram_Graph));
                }
                catch (Exception ex)
                { }
            }
            else
            {
                histogram_Chart.Series["Histogram"].Points.Clear();
                for (int h = 0; h < 256; h++)
                {

                    histogram_Chart.Series["Histogram"].Points.AddXY(Convert.ToString(h), histogram_buffer[h]);
                }
                        
            }
                
            
        }




        static public string To_Hex(byte[] bin_data)
        {
            string result = "";
            foreach (byte ch in bin_data)
            {
                result += string.Format("{0:x2} ", ch);
            }

            return result;
        }



        public Bitmap DecodeImage(byte[] Source)

        { 
            using (var Stream = new System.IO.MemoryStream(Source))
            return new Bitmap(Stream); 
        }


        private void image_save_Button_Click(object sender, EventArgs e)
        {
            Bitmap Temp_bitmap = new Bitmap(Finger_Print_Image);

            Temp_bitmap.Save(fd.SelectedPath + @"\" + "SVF10_" + Convert.ToString(auto_save_count) + ".bmp");
            auto_save_count++;


        }

        byte[] Send_Frame_Buffer = new Byte[21];

        private void Set_Resister_Button_Click(object sender, EventArgs e)
        {

            Set_Resister_Button.Enabled = false;
            ms_timer_tick = 0;
            timer1.Enabled = true;

            Send_Frame_Buffer[0] = Convert.ToByte('R');
            Send_Frame_Buffer[1] = Convert.ToByte('E');
            Send_Frame_Buffer[2] = Convert.ToByte('S');
            Send_Frame_Buffer[3] = Convert.ToByte(DLY2X_OSC_ComboBox.SelectedIndex);
            Send_Frame_Buffer[4] = Convert.ToByte(S_GAIN_ComboBox.SelectedIndex);
            Send_Frame_Buffer[5] = Convert.ToByte(ADC_RSEL_ComboBox.SelectedIndex);
            Send_Frame_Buffer[6] = Convert.ToByte(DYL2X_ComboBox.SelectedIndex);
            Send_Frame_Buffer[7] = Convert.ToByte(CLK_SEL_ComboBox.SelectedIndex);
            Send_Frame_Buffer[8] = Convert.ToByte(PERIOD_ComboBox.SelectedIndex);
            Send_Frame_Buffer[9] = Convert.ToByte(ISOL_ComboBox.SelectedIndex);
            Send_Frame_Buffer[10] = Convert.ToByte(SL_TIME_ComboBox.SelectedIndex);
            Send_Frame_Buffer[11] = Convert.ToByte(NAVI_ComboBox.SelectedIndex);
            Send_Frame_Buffer[12] = Convert.ToByte(SCK_UT_ComboBox.SelectedIndex);
            Send_Frame_Buffer[13] = Convert.ToByte(SLV_STU_ComboBox.SelectedIndex);


            try
            {
                if (int.Parse(Multiplying_TextBox.Text) < 64)
                {
                    Send_Frame_Buffer[14] = byte.Parse(Multiplying_TextBox.Text);
                }
                else
                {
                    Send_Frame_Buffer[14] = 63;
                    Multiplying_TextBox.Text = "63";
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Multiplying 0~63값 입력", "입력값 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            try
            {
                if (int.Parse(ADC_REF_TextBox.Text) < 256)
                {
                    Send_Frame_Buffer[15] = byte.Parse(ADC_REF_TextBox.Text);
                }
                else
                {
                    Send_Frame_Buffer[15] = 255;
                    ADC_REF_TextBox.Text = "255";
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("ADC_REF 0~255값 입력", "입력값 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (int.Parse(Display_Threshold_TextBox.Text) < 10000)
                {
                    int int_temp;

                    int_temp = int.Parse(Display_Threshold_TextBox.Text);

                    Send_Frame_Buffer[16] = Convert.ToByte((int_temp >> 8) & 0x000000ff);
                    Send_Frame_Buffer[17] = Convert.ToByte(int_temp & 0x000000ff);
                }
                else
                {
                    Send_Frame_Buffer[16] = 0x27;
                    Send_Frame_Buffer[17] = 0x10;
                    Display_Threshold_TextBox.Text = "10000";
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ADC_REF 0~255값 입력", "입력값 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                Send_Frame_Buffer[18] = Convert.ToByte(this.GPB_REG_TextBox.Text, 2);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("GPB_REG 0또는1 입력", "입력값 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Send_Frame_Buffer[19] = Convert.ToByte(SensingMode_ComboBox.SelectedIndex);
            Send_Frame_Buffer[20] = Convert.ToByte(ImageFilter_comboBox.SelectedIndex);

            serialPort1.Write(Send_Frame_Buffer, 0, 21);
        }


        int ms_timer_tick;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ms_timer_tick > 2) 
            {
                timer1.Enabled = false;
                Set_Resister_Button.Enabled = true;
                if(chip_id_read_OK == false)
                {
                    Send_Frame_Buffer[0] = Convert.ToByte('R');
                    Send_Frame_Buffer[1] = Convert.ToByte('I');
                    Send_Frame_Buffer[2] = Convert.ToByte('D');

                    serialPort1.Write(Send_Frame_Buffer, 0, 21);
                }
            }
            else
            {
                ms_timer_tick++;
            }
        }

        FolderBrowserDialog fd = new FolderBrowserDialog();
        
       

        private void Select_Folder_Button_Click(object sender, EventArgs e)
        {

            save_folder_selected = true;
            Set_Resister_Button.Enabled = true;
            manual_save_Button.Enabled = true;
            auto_save_Button.Enabled = true;
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox1.Text = fd.SelectedPath;

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void auto_save_Button_Click(object sender, EventArgs e)
        {
            auto_save_mode = true;
            manual_save_Button.Enabled = false;
            auto_save_Button.Enabled = false;
            cancle_save_Button.Enabled = true;
        }

        private void cancle_save_Button_Click(object sender, EventArgs e)
        {
            auto_save_mode = false;
            manual_save_Button.Enabled = true;
            auto_save_Button.Enabled = true;
            cancle_save_Button.Enabled = false;
            
        }

        private void histogram_Chart_Click(object sender, EventArgs e)
        {

        }

        private void DLY2X_OSC_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PERIOD_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PERIOD_ComboBox.SelectedIndex == 0)
            {
                SCK_UT_ComboBox.Enabled = true;
            }
            else
            {
                SCK_UT_ComboBox.SelectedIndex = 0;
                SCK_UT_ComboBox.Enabled = false;
            }
        }
    }


}
