using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using Emgu.CV;
using DirectShowLib;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
// using Firmata;

namespace ButtonEmulator
{
    public partial class Form1 : Form
    {
        private System.IO.Ports.SerialPort sp;

        // для подключения по Serial
        private bool is_connected = false;
        private string[] portnames;

        // для работы камеры
        private VideoCapture capture = null;
        private DsDevice[] webcam = null;
        private int cameraId = 0;
        private Mat m;

        // для управления направлением работы кнопок (прием/передача)
        private List<CheckBox> checkBoxes;
        private bool[] button_group_reverse_status;

        // для управления работой кнопок (кнопка/переключатель)
        private bool is_switches = false;

        // состояние кнопки (нажата/отпущена)
        private bool[] button_state;
        private List<Button> buttons;
        private Color default_backcolor = SystemColors.Control;
        private Color active_backcolor = Color.Green;


        private bool is_receive_1 = false;
        private bool is_receive_2 = false;
        private bool is_receive_3 = false;

        private delegate void SetTextDeleg(string text);


        private DateTime timeBegin;
        private bool adminCloseFlag = false;
        private bool videoWriteFlag = false;
        private bool keyLogFlag = false;
        private NoTaskManager taskManager = new();
        private Recorder rec = new();

        private LoginForm loginform = new();

        private Timer _pwmTimer = new Timer();

        public Form1()
        {
            InitializeComponent();

            sp = new System.IO.Ports.SerialPort(components)
            {
                BaudRate = 9600,
                DataBits = 8,
                DiscardNull = false,
                DtrEnable = false,
                Handshake = System.IO.Ports.Handshake.None,
                NewLine = "\n",
                Parity = System.IO.Ports.Parity.None,
                ParityReplace = 63,
                PortName = "COM1",
                ReadBufferSize = 4096,
                ReadTimeout = 300,
                ReceivedBytesThreshold = 1,
                RtsEnable = false,
                StopBits = System.IO.Ports.StopBits.One,
                WriteBufferSize = 2048,
                WriteTimeout = -1
            };
            sp.DataReceived += sp_DataReceived;

            checkBoxes =
            [
                checkBoxReverseData1,
                checkBoxReverseData2,
                checkBoxReverseData3
            ];

            button_group_reverse_status = new bool[3];
            for (int i = 0; i < 3; i++)
            {
                button_group_reverse_status[i] = false;
            }

            button_state = new bool[24];
            for (int i = 0; i < 24; i++)
            {
                button_state[i] = false;
            }

            buttons =
            [
                button1,
                button2,
                button3,
                button4,
                button5,
                button6,
                button7,
                button8,
                button9,
                button10,
                button11,
                button12,
                button13,
                button14,
                button15,
                button16,
                button17,
                button18,
                button19,
                button20,
                button21,
                button22,
                button23,
                button24
            ];

            //варианты настройки видео
            codecChoose.Items.AddRange(new object[] { ".avi" });
            qualityChoose.Items.AddRange(new object[] { "720p | 1280x720" });
            fpsChoose.Items.AddRange(new object[] { 13 });

            //базовые настройки для видео
            nameInput.Text = "Видео";
            nameInput.ForeColor = Color.Gray;
            routeInput.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            nameInput.ForeColor = Color.Gray;
            codecChoose.SelectedIndex = 0;
            qualityChoose.SelectedIndex = 0;
            fpsChoose.SelectedIndex = 0;

            arduinoPath.Text = @"C:\Program Files (x86)\Arduino\arduino.exe";
            taskManager.CheckProcess();

            var help1 = new ToolTip();
            help1.SetToolTip(SpecialFeaturesButton, "Специальные Возможности");

            var help2 = new ToolTip();
            help2.SetToolTip(LoginUserPicture, "Авторизация");

            if (taskManager.DisableLock)
            {
                TopMost = false;
            }

            //pwm
            //todo: kiad pwm data
            _pwmTimer.Tick += _pwmTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            portnames = SerialPort.GetPortNames();
            foreach (string s in portnames)
            {
                if (s != "COM1")
                {
                    comboBox_arduino.Items.Add(s);
                }
            }

            if (comboBox_arduino.Items.Count > 0)
            {
                comboBox_arduino.SelectedItem = comboBox_arduino.Items[0];
            }

            webcam = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            foreach (var t in webcam)
            {
                comboBox_cameras.Items.Add(t.Name);
            }

            if (comboBox_cameras.Items.Count > 0)
            {
                comboBox_cameras.SelectedItem = comboBox_cameras.Items[0];
                cameraId = comboBox_cameras.SelectedIndex;
            }
        }

        #region Поключение и работа с Serial
        private void button_com_scan_Click(object sender, EventArgs e)
        {
            comboBox_arduino.Items.Clear();
            comboBox_arduino.SelectedItem = null;
            //comboBox_arduino.Text = null;

            portnames = SerialPort.GetPortNames();
            foreach (string s in portnames)
            {
                if (s != "COM1")
                {
                    comboBox_arduino.Items.Add(s);
                }
            }

            if (comboBox_arduino.Items.Count == 0)
            {
                MessageBox.Show("Доступных COM портов не обнаружено");
            }

            if (comboBox_arduino.Items.Count > 0)
            {
                comboBox_arduino.SelectedItem = comboBox_arduino.Items[0];
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            var controls = new List<Control>()
            {
                _buttonStart,
                StartPWM,
                buttonSavePWM,
                DutyCycleBox,
                _txtCol1,
                _txtCol2,
                _txtCol3,
                delayBox,
                DelayBoxForPWM
            };


            if (is_connected)
            {
                try
                {
                    for (int i = 0; i < 24; i++)
                    {
                        string send_data = (i + 1).ToString() + "L";
                        sp.Write(send_data);
                        button_state[i] = false;
                        buttons[i].BackColor = default_backcolor;
                        buttons[i].UseVisualStyleBackColor = true;
                    }
                }
                catch
                {
                    // ignored
                }

                sp.Close();
                buttonConnect.Text = "Подключиться";
                is_connected = false;

                for (int i = 0; i < 24; i++)
                {
                    buttons[i].Enabled = false;
                }

                checkBox_button_type.Enabled = false;
                foreach (var t in checkBoxes)
                {
                    t.Enabled = false;
                }

                foreach(var c in  controls)
                {
                    c.Enabled = false;
                }
            }
            else
            {
                try
                {
                    sp.PortName = comboBox_arduino.Items[comboBox_arduino.SelectedIndex].ToString();
                    sp.Open();
                    sp.ReadTimeout = 1000;
                    sp.Write("Hello");
                    char[] buffer = new char[5];
                    sp.Read(buffer, 0, 1);
                    sp.Read(buffer, 1, 1);
                    sp.Read(buffer, 2, 1);
                    sp.Read(buffer, 3, 1);
                    sp.Read(buffer, 4, 1);

                    string spResponse = new string(buffer);
                    MessageBox.Show("Устройство подключено");

                    if (spResponse == "ardok")
                    {
                        is_connected = true;
                        buttonConnect.Text = "Отключиться";

                        for (int i = 0; i < 24; i++)
                        {
                            buttons[i].Enabled = true;
                        }

                        checkBox_button_type.Enabled = true;
                        foreach (var t in checkBoxes)
                        {
                            t.Enabled = true;
                        }

                        foreach (var c in controls)
                        {
                            c.Enabled = true;
                        }
                    }
                    else
                    {
                        throw new Exception("нет ответа от устройства");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Проблемы с подключением.\nВыбран неправильный порт или устройство не подключено.\n" + ex.Message);
                    sp.Close();
                }
            }
        }

        #endregion

        #region Поключение и работа с камерой
        private void comboBox_cameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            cameraId = comboBox_cameras.SelectedIndex;
        }

        private void button_cam_scan_Click(object sender, EventArgs e)
        {
            comboBox_cameras.Items.Clear();
            comboBox_cameras.SelectedItem = null;
            //comboBox_cameras.Text = null;

            webcam = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            if (webcam.Length == 0)
            {
                MessageBox.Show("Доступных камер не обнаружено");
            }
            else
            {
                foreach (var t in webcam)
                {
                    comboBox_cameras.Items.Add(t.Name);
                }

                if (comboBox_cameras.Items.Count > 0)
                {
                    comboBox_cameras.SelectedItem = comboBox_cameras.Items[0];
                    cameraId = comboBox_cameras.SelectedIndex;
                }
            }
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                capture.Retrieve(m);
                pictureBox1.Image = m.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cam_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (webcam.Length == 0)
                {
                    throw new Exception("No cameras available");
                }
                else if (comboBox_cameras.SelectedItem == null)
                {
                    throw new Exception("Please, select camera");
                }
                else
                {
                    capture = new VideoCapture(cameraId);
                    capture.ImageGrabbed += Capture_ImageGrabbed;
                    m = new Mat();
                    capture.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cam_stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (capture != null)
                {
                    capture.Pause();
                    capture.Dispose();
                    capture = null;
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                    cameraId = 0;
                    m.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_create_screen_Click(object sender, EventArgs e)
        {
            //saveFileDialog_create_screen.FileName = null;
            if (saveFileDialog_create_screen.ShowDialog() == DialogResult.OK)
            {
                using Bitmap save_bmp = (Bitmap)pictureBox1.Image;
                if (save_bmp != null)
                {
                    save_bmp.Save(saveFileDialog_create_screen.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    MessageBox.Show("Изображение сохранено");
                }
                else
                {
                    MessageBox.Show("Камера не включена, нет изображения для сохранения");
                }
            }
            saveFileDialog_create_screen.Dispose();
        }

        #endregion

        #region Определение типа и состояния элементов передачи данных
        private void checkBox_button_type_CheckedChanged(object sender, EventArgs e)
        {
            is_switches = checkBox_button_type.Checked;
        }

        private void checkBox_group_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox senderbox = (CheckBox)sender;

            int checkBox_id = Convert.ToInt32(senderbox.Tag);

            button_group_reverse_status[checkBox_id] = checkBoxes[checkBox_id].Checked;
            if (button_group_reverse_status[checkBox_id])
            {
                for (int i = 0; i < 8; i++)
                {
                    buttons[(checkBox_id) * 8 + i].Text = "Светодиод " + ((checkBox_id) * 8 + i).ToString();
                }
                string sendtext = (checkBox_id + 1).ToString() + "in";
                sp.Write(sendtext);
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    buttons[(checkBox_id) * 8 + i].Text = "Кнопка " + ((checkBox_id) * 8 + i).ToString();
                }
                string sendtext = (checkBox_id + 1).ToString() + "out";
                sp.Write(sendtext);
            }
        }

        #endregion

        #region Обработка нажатий на кнопки для приема/передачи данных

        private void button_Click(object sender, EventArgs e)
        {
            Button senderbutton = (Button)sender;
            int button_id = Convert.ToInt32(senderbutton.Tag);
            int reverse_group_id = button_id / 8;

            if (!button_group_reverse_status[reverse_group_id])
            {
                if (is_switches && sp != null && sp.IsOpen)
                {
                    if (!button_state[button_id])
                    {
                        string send_text = (button_id + 1).ToString() + "H";
                        sp.Write(send_text);
                        buttons[button_id].BackColor = active_backcolor;
                        button_state[button_id] = true;
                    }
                    else
                    {
                        string send_text = (button_id + 1).ToString() + "L";
                        sp.Write(send_text);
                        buttons[button_id].BackColor = default_backcolor;
                        buttons[button_id].UseVisualStyleBackColor = true;
                        button_state[button_id] = false;
                    }
                }
            }
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            Button senderbutton = (Button)sender;
            int button_id = Convert.ToInt32(senderbutton.Tag);
            int reverse_group_id = button_id / 8;

            if (!button_group_reverse_status[reverse_group_id])
            {
                if (!is_switches)
                {
                    string send_text = (button_id + 1).ToString() + "H";
                    sp.Write(send_text);
                    button_state[button_id] = true;
                }
            }
        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            Button senderbutton = (Button)sender;
            int button_id = Convert.ToInt32(senderbutton.Tag);
            int reverse_group_id = button_id / 8;

            if (!button_group_reverse_status[reverse_group_id])
            {
                if (!is_switches)
                {
                    string send_text = (button_id + 1).ToString() + "L";
                    sp.Write(send_text);
                    button_state[button_id] = false;
                }
            }
        }

        #endregion

        #region serial

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Thread.Sleep(500);
            char[] buffer = new char[5];
            /*sp.ReadTimeout = 1000;
            sp.Read(buffer, 0, 1);
            sp.Read(buffer, 1, 1);
            sp.Read(buffer, 2, 1);
            sp.Read(buffer, 3, 1);
            sp.Read(buffer, 4, 1);
            string data = new string(buffer);*/
            sp.ReadTimeout = 3000;
            string data = "";
            try
            {
                sp.Read(buffer, 0, 1);
                sp.Read(buffer, 1, 1);
                sp.Read(buffer, 2, 1);
                sp.Read(buffer, 3, 1);
                sp.Read(buffer, 4, 1);
                sp.Read(buffer, 5, 1);
                sp.Read(buffer, 6, 1);
                sp.Read(buffer, 7, 1);
                sp.Read(buffer, 8, 1);
                sp.Read(buffer, 9, 1);
                sp.Read(buffer, 10, 1);
                sp.Read(buffer, 11, 1);
                sp.Read(buffer, 12, 1);
                sp.Read(buffer, 13, 1);
                sp.Read(buffer, 14, 1);
                sp.Read(buffer, 15, 1);
                sp.Read(buffer, 16, 1);
                sp.Read(buffer, 17, 1);
                sp.Read(buffer, 18, 1);
                sp.Read(buffer, 19, 1);
                sp.Read(buffer, 20, 1);
                sp.Read(buffer, 21, 1);
                sp.Read(buffer, 22, 1);
                sp.Read(buffer, 23, 1);
                sp.Read(buffer, 24, 1);
                sp.Read(buffer, 25, 1);
                sp.Read(buffer, 26, 1);
                sp.Read(buffer, 27, 1);
                sp.Read(buffer, 28, 1);
                sp.Read(buffer, 29, 1);
                sp.Read(buffer, 30, 1);
                sp.Read(buffer, 31, 1);

                data = new string(buffer);
                //data = sp.ReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            // Привлечение делегата на потоке UI, и отправка данных, которые
            // были приняты привлеченным методом.
            // ---- Метод "si_DataReceived" будет выполнен в потоке UI,
            // который позволит заполнить текстовое поле TextBox.
            BeginInvoke(new SetTextDeleg(si_DataReceived), data);
        }

        private void si_DataReceived(string data)
        {
            data = data.Trim();
            textBox2.Text = data;
            if ((is_receive_1) && (data == "1LH")) button1.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "1LL")) button1.BackColor = default_backcolor;
            if ((is_receive_1) && (data == "2LH")) button2.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "2LL")) button2.BackColor = default_backcolor;
            if ((is_receive_1) && (data == "3LH")) button3.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "3LL")) button3.BackColor = default_backcolor;
            if ((is_receive_1) && (data == "4LH")) button4.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "4LL")) button4.BackColor = default_backcolor;
            if ((is_receive_1) && (data == "5LH")) button5.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "5LL")) button5.BackColor = default_backcolor;
            if ((is_receive_1) && (data == "6LH")) button6.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "6LL")) button6.BackColor = default_backcolor;
            if ((is_receive_1) && (data == "7LH")) button7.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "7LL")) button7.BackColor = default_backcolor;
            if ((is_receive_1) && (data == "8LH")) button8.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "8LL")) button8.BackColor = default_backcolor;

            if ((is_receive_2) && (data == "9LH")) button9.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "9LL")) button9.BackColor = default_backcolor;
            if ((is_receive_2) && (data == "10LH")) button10.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "10LL")) button10.BackColor = default_backcolor;
            if ((is_receive_2) && (data == "11LH")) button11.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "11LL")) button11.BackColor = default_backcolor;
            if ((is_receive_2) && (data == "12LH")) button12.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "12LL")) button12.BackColor = default_backcolor;
            if ((is_receive_2) && (data == "13LH")) button13.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "13LL")) button13.BackColor = default_backcolor;
            if ((is_receive_2) && (data == "14LH")) button14.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "14LL")) button14.BackColor = default_backcolor;
            if ((is_receive_2) && (data == "15LH")) button15.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "15LL")) button15.BackColor = default_backcolor;
            if ((is_receive_2) && (data == "16LH")) button16.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "16LL")) button16.BackColor = default_backcolor;

            if ((is_receive_3) && (data == "17LH")) button17.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "17LL")) button17.BackColor = default_backcolor;
            if ((is_receive_3) && (data == "18LH")) button18.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "18LL")) button18.BackColor = default_backcolor;
            if ((is_receive_3) && (data == "19LH")) button19.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "19LL")) button19.BackColor = default_backcolor;
            if ((is_receive_3) && (data == "20LH")) button20.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "20LL")) button20.BackColor = default_backcolor;
            if ((is_receive_3) && (data == "21LH")) button21.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "21LL")) button21.BackColor = default_backcolor;
            if ((is_receive_3) && (data == "22LH")) button22.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "22LL")) button22.BackColor = default_backcolor;
            if ((is_receive_3) && (data == "23LH")) button23.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "23LL")) button23.BackColor = default_backcolor;
            if ((is_receive_3) && (data == "24LH")) button24.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "24LL")) button24.BackColor = default_backcolor;
        }

        private void testbench_button_Click(object sender, EventArgs e)
        {
            if (testbench_name.Text != null)
            {
                string file_name = testbench_name.Text;
                string filetext = File.ReadAllText(file_name);

                Regex reg_regex = new Regex(@"\s*^\s*reg\s*((.*\])\s*(\w*)\s*;\s*\/\/\s*(\w+)\s*\n)");
                MatchCollection matches_reg = reg_regex.Matches(filetext);

                Regex initial_regex = new Regex(@"initial\s*\n\s*begin\s*\n(.*\n)*\s*end\n");
                MatchCollection matches_initial = initial_regex.Matches(filetext);
                Regex data_regex = new Regex(@"\s*^\s*(\w*)\s*=\s*(\d*)'([bdh])(\d*)\n*");
                Regex delay_regex = new Regex(@"\s*(#)(\w*)\n*");

                if (matches_reg.Count > 0)
                {
                    foreach (Match match in matches_reg)
                    {
                        //Console.WriteLine(match.Groups[1].Value);
                        string data = match.Groups[3].Value + " " + match.Groups[4].Value;
                        Console.WriteLine(data);
                    }
                }
                else
                {
                    MessageBox.Show("Не найдено reg портов");
                }

                if (matches_initial.Count > 0)
                {
                    foreach (Match match in matches_initial)
                    {
                        Group gr = match.Groups[1];
                        for (int i = 0; i < gr.Captures.Count; i++)
                        {
                            //Console.WriteLine(gr.Captures[i].Value);
                            MatchCollection matches_data = data_regex.Matches(gr.Captures[i].Value);
                            MatchCollection matches_delay = delay_regex.Matches(gr.Captures[i].Value);
                            if (matches_data.Count > 0)
                            {
                                foreach (Match match1 in matches_data)
                                {
                                    //Console.WriteLine(match1.Groups[1].Value);
                                    string data = match1.Groups[1].Value + " " + match1.Groups[2].Value + " " + match1.Groups[4].Value;
                                    sp.Write(data);
                                    Console.WriteLine(data);
                                }
                            }
                            else if (matches_delay.Count > 0)
                            {
                                foreach (Match match1 in matches_delay)
                                {
                                    string delay = match1.Groups[1].Value + match1.Groups[2].Value;
                                    sp.Write(delay);
                                    Console.WriteLine(delay);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не найдено блока initial");
                }
            }
        }

        private void button_select_testbench_Click(object sender, EventArgs e)
        {
            //openFileDialog_load_testbench.FileName = null;
            if (openFileDialog_load_testbench.ShowDialog() == DialogResult.OK)
            {
                testbench_name.Text = openFileDialog_load_testbench.FileName;
            }
        }

        #endregion

        #region запрет на перемещение/закрытие окна

        protected override void WndProc(ref Message message)
        {
            if (taskManager.DisableLock)
            {
                base.WndProc(ref message);
                return;
            }

            const int sustemCommand = 0x0112;
            const int formMove = 0xF010;
            switch (message.Msg)
            {
                case sustemCommand:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == formMove)
                        return;
                    break;
            }
            base.WndProc(ref message);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (taskManager.DisableLock)
            {
                return;
            }

            if (adminCloseFlag == false)
            {
                e.Cancel = true;
                taskManager.CheckProcess();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            adminCloseFlag = true;
            Application.Exit();
        }

        #endregion

        #region лог клавишей

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyLogFlag && videoWriteFlag)
            {
                using var streamWriter = new StreamWriter(Path.GetFullPath(routeInput.Text + @"\" + nameInput.Text + " Нажатые клавиши.txt"), true, Encoding.UTF8);
                streamWriter.WriteLine($"{(DateTime.Now - timeBegin).Minutes}" +
                                       $":{(DateTime.Now - timeBegin).Seconds}" + "\t\t" + e.KeyCode.ToString());
            }
        }

        #endregion

        #region SpecialFeaturesButton

        private void SpecialFeaturesButton_MouseEnter(object sender, EventArgs e)
        {
            SpecialFeaturesButton.BackColor = Color.LightGray;
        }

        private void SpecialFeaturesButton_MouseLeave(object sender, EventArgs e)
        {
            SpecialFeaturesButton.BackColor = BackColor;
        }

        private void SpecialFeaturesButton_Click(object sender, EventArgs e)
        {
            if (SpecialPanel.Visible)
            {
                SpecialPanel.Hide();
                videoSettings.Hide();
            }
            else
                SpecialPanel.Show();
        }

        #endregion

        #region login

        private void LoginUserPicture_MouseEnter(object sender, EventArgs e)
        {
            LoginUserPicture.BackColor = Color.LightGray;
        }

        private void LoginUserPicture_MouseLeave(object sender, EventArgs e)
        {
            LoginUserPicture.BackColor = BackColor;
        }

        private void LoginUserPicture_Click(object sender, EventArgs e)
        {
            if (loginform.Visible)
                loginform.Hide();
            else
                loginform.Show();
        }

        #endregion

        #region videoRecord

        private void VideoSettingsButton_Click(object sender, EventArgs e)
        {
            if (arduinoPanel.Visible)
            {
                arduinoPanel.Visible = false;
            }
            if (videoSettings.Visible)
            {
                videoSettings.Hide();
            }
            else
            {
                videoSettings.Show();
            }
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                routeInput.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void nameInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameInput.Text))
            {
                nameInput.Text = "Видео";
                nameInput.ForeColor = Color.Gray;
            }
        }

        private void nameInput_MouseClick(object sender, MouseEventArgs e)
        {
            if (nameInput.Text == "Видео")
            {
                nameInput.Text = "";
                nameInput.ForeColor = Color.Black;
            }
        }

        private void VideoStartButton_MouseClick(object sender, MouseEventArgs e)
        {
            VideoStopButton.Visible = true;
            VideoStartButton.Visible = false;
            CloseButton.Enabled = false;
            CloseButton.ForeColor = Color.Gray;
            rec.Params = new RecorderParams(Path.GetFullPath(routeInput.Text + @"\" + nameInput.Text + codecChoose.Text), 13, 70);
            videoWriteFlag = true;
            if (keyLogFlag)
            {
                using var streamWriter = new StreamWriter(routeInput.Text + @"\" + nameInput.Text + " Нажатые клавиши.txt", false, Encoding.UTF8);
                timeBegin = DateTime.Now;
            }
            try
            {
                rec.StartRecord(); //вот это ломает окно
            }
            catch (Exception)
            {
                MessageBox.Show("Запись видео сейчас невозможна");
            }
        }

        private void VideoStopButton_Click(object sender, EventArgs e)
        {
            VideoStopButton.Visible = false;
            VideoStartButton.Visible = true;
            CloseButton.ForeColor = Color.Black;
            CloseButton.Enabled = true;
            videoWriteFlag = false;
            rec.Dispose();
        }

        private void loggingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            keyLogFlag = loggingCheckBox.Checked;
        }

        #endregion

        #region arduino

        private void ArduinoButton_Click(object sender, EventArgs e)
        {
            if (videoSettings.Visible)
            {
                videoSettings.Visible = false;
            }
            arduinoPanel.Visible = !arduinoPanel.Visible;
        }

        private void arduinoPathSelector_Click(object sender, EventArgs e)
        {
            var folderPath = new OpenFileDialog();
            if (folderPath.ShowDialog() == DialogResult.OK)
            {
                arduinoPath.Text = folderPath.FileName;
            }
            else
            {
                arduinoPath.Text = @"C:\Program Files (x86)\Arduino\arduino-builder.exe";
            }
        }

        private void arduinoCodePathSelector_Click(object sender, EventArgs e)
        {
            var filePath = new OpenFileDialog();
            if (filePath.ShowDialog() == DialogResult.OK)
            {
                arduinoCodePath.Text = filePath.FileName;
            }
            else
            {
                arduinoCodePath.Text = "";
            }
        }

        private void arduinoPath_MouseClick(object sender, MouseEventArgs e)
        {
            if (arduinoPath.Text == @"C:\Program Files (x86)\Arduino\arduino")
            {
                arduinoPath.Text = "";
            }
        }

        private void arduinoPath_Leave(object sender, EventArgs e)
        {
            if (arduinoPath.Text == "")
            {
                arduinoPath.Text = @"C:\Program Files (x86)\Arduino\arduino-builder.exe";
            }
        }

        private void arduinoNewCodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string myPath = arduinoPath.Text;
                var arduinoConsole = new Process();
                arduinoConsole.StartInfo.FileName = myPath;
                arduinoConsole.StartInfo.Arguments = @"--upload " + arduinoCodePath.Text;
                arduinoConsole.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                arduinoConsole.StartInfo.CreateNoWindow = true;
                arduinoConsole.StartInfo.RedirectStandardOutput = true;
                arduinoConsole.StartInfo.UseShellExecute = false;
                arduinoConsole.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Указана неверная папка или файл не подходит");
                arduinoCodePathSelector_Click(sender, e);
            }
        }
        #endregion

        #region BinaryTextBoxes
        // дописывание последующих нулей, если пользователь ввёл не все 8 знаков
        private string BinaryLineToEightDigits(string inputString)
        {
            return inputString.PadRight(8, '0');
        }
        // 'клики' на кнопки путём бинарного кода
        private async void _buttonStart_Click(object sender, EventArgs e)
        {
            string textFromFirstColumn1 = _txtCol1.Text;
            string textFromFirstColumn2 = _txtCol2.Text;
            string textFromFirstColumn3 = _txtCol3.Text;

            textFromFirstColumn1 = BinaryLineToEightDigits(textFromFirstColumn1);
            textFromFirstColumn2 = BinaryLineToEightDigits(textFromFirstColumn2);
            textFromFirstColumn3 = BinaryLineToEightDigits(textFromFirstColumn3);

            string binaryInput = textFromFirstColumn1 + textFromFirstColumn2 + textFromFirstColumn3;

            int delay = (int)delayBox.Value;

            _buttonStart.Enabled = false;

            for (int i = 0; i < binaryInput.Length; i++)
            {
                if (binaryInput[i] == '1')
                {
                    buttons[i].BackColor = Color.Green;
                    int iTmp = i;
                    if(is_switches)
                    {
                        button_Click(buttons[iTmp], EventArgs.Empty);
                    }
                    else
                    {
                        button_MouseDown(buttons[iTmp], new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                        button_MouseUp(buttons[iTmp], new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                    }
                    await Task.Delay(delay);
                }
                else
                {
                    buttons[i].BackColor = default_backcolor;
                }
            }
            _buttonStart.Enabled = true;
        }

        // обработчик символов отличных от 1 и 0 (все остальные символы считает 0)
        private void _txtCol1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            StringBuilder changedText = new StringBuilder();

            foreach (char c in textBox.Text)
            {
                if (c == '0' || c == '1')
                {
                    changedText.Append(c);
                }
                else
                {
                    changedText.Append('0');
                }
            }
            textBox.Text = changedText.ToString();

            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;
        }
        #endregion

        #region PWM

        private void SendPWMCommand(int dutyCycle)
        {
            string command = $"PWM {dutyCycle}";
            sp.WriteLine(command);
        }

        private async void StartPWM_Click(object sender, EventArgs e)
        {
            if (IsPwmSending())
            {
                OnStopPWM();
            }
            else
            {
                // start pwm
                int timeInMs = int.Parse(TimeBox.Text);
                int dutyCycle = int.Parse(DutyCycleBox.Text);

                if (dutyCycle < 0 || dutyCycle > 255)
                {
                    MessageBox.Show("Скважность должна быть в пределах от 0 до 255");
                    return;
                }
                if (timeInMs < 0)
                {
                    MessageBox.Show("Время должно быть положительным");
                    return;
                }

                StartPWM.Text = "off";
                _pwmTimer.Interval = timeInMs;
                int delay = (int)DelayBoxForPWM.Value; 
                _pwmTimer.Start();

                while (IsPwmSending())
                {
                    SendPWMCommand(dutyCycle);
                    await Task.Delay(delay);
                }
            }
        }

        private void _pwmTimer_Tick(object sender, EventArgs e)
        {
            OnStopPWM();
        }

        private void OnStopPWM()
        {
            _pwmTimer.Stop();
            StartPWM.Text = "on";
        }

        private bool IsPwmSending()
        {
            return _pwmTimer.Enabled;
        }

        #endregion
    }
}