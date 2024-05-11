using System.Windows.Forms;

namespace ButtonEmulator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            buttonConnect = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            button7 = new Button();
            button8 = new Button();
            checkBox_button_type = new CheckBox();
            saveFileDialog_create_screen = new SaveFileDialog();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            checkBoxReverseData1 = new CheckBox();
            checkBoxReverseData2 = new CheckBox();
            checkBoxReverseData3 = new CheckBox();
            testbench_button = new Button();
            testbench_name = new TextBox();
            pictureBox1 = new PictureBox();
            button_cam_start = new Button();
            comboBox_cameras = new ComboBox();
            button_cam_scan = new Button();
            button_cam_stop = new Button();
            comboBox_arduino = new ComboBox();
            button_com_scan = new Button();
            label3 = new Label();
            button_create_screen = new Button();
            openFileDialog_load_testbench = new OpenFileDialog();
            button_select_testbench = new Button();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SpecialPanel = new Panel();
            VideoSettingsButton = new Button();
            VideoStopButton = new Button();
            VideoStartButton = new Button();
            ArduinoButton = new Button();
            CloseButton = new Button();
            videoSettings = new Panel();
            loggingCheckBox = new CheckBox();
            qualityChoose = new ComboBox();
            fpsChoose = new ComboBox();
            codecChoose = new ComboBox();
            routeInput = new TextBox();
            folderButton = new PictureBox();
            nameInput = new TextBox();
            fpsText = new Label();
            qualityText = new Label();
            routeText = new Label();
            nameText = new Label();
            SpecialFeaturesButton = new PictureBox();
            LoginUserPicture = new PictureBox();
            arduinoPanel = new Panel();
            arduinoNewCodeButton = new Button();
            arduinoCodePath = new TextBox();
            arduinoCodePathSelector = new PictureBox();
            arduinoCodePathText = new Label();
            arduinoPath = new TextBox();
            arduinoPathSelector = new PictureBox();
            arduinoPathText = new Label();
            _txtCol1 = new TextBox();
            _txtCol2 = new TextBox();
            _txtCol3 = new TextBox();
            _buttonStart = new Button();
            delayBox = new NumericUpDown();
            label5 = new Label();
            label7 = new Label();
            DutyCycleBox = new TextBox();
            StartPWM = new Button();
            buttonSavePWM = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            DelayBoxForPWM = new NumericUpDown();
            label4 = new Label();
            groupBox3 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SpecialPanel.SuspendLayout();
            videoSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)folderButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpecialFeaturesButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoginUserPicture).BeginInit();
            arduinoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)arduinoCodePathSelector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arduinoPathSelector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)delayBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DelayBoxForPWM).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new System.Drawing.Point(5, 139);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(103, 26);
            button2.TabIndex = 1;
            button2.Tag = "1";
            button2.Text = "Кнопка 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            button2.MouseDown += button_MouseDown;
            button2.MouseUp += button_MouseUp;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new System.Drawing.Point(5, 173);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(103, 26);
            button3.TabIndex = 2;
            button3.Tag = "2";
            button3.Text = "Кнопка 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            button3.MouseDown += button_MouseDown;
            button3.MouseUp += button_MouseUp;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new System.Drawing.Point(5, 207);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(103, 26);
            button4.TabIndex = 3;
            button4.Tag = "3";
            button4.Text = "Кнопка 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            button4.MouseDown += button_MouseDown;
            button4.MouseUp += button_MouseUp;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new System.Drawing.Point(168, 18);
            buttonConnect.Margin = new Padding(3, 4, 3, 4);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new System.Drawing.Size(156, 26);
            buttonConnect.TabIndex = 4;
            buttonConnect.Text = "Подключиться";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new System.Drawing.Point(5, 241);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(103, 26);
            button5.TabIndex = 5;
            button5.Tag = "4";
            button5.Text = "Кнопка 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            button5.MouseDown += button_MouseDown;
            button5.MouseUp += button_MouseUp;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new System.Drawing.Point(5, 275);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(103, 26);
            button6.TabIndex = 6;
            button6.Tag = "5";
            button6.Text = "Кнопка 6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            button6.MouseDown += button_MouseDown;
            button6.MouseUp += button_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(38, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 15);
            label1.TabIndex = 8;
            label1.Text = "Порт";
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Location = new System.Drawing.Point(5, 309);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(103, 26);
            button7.TabIndex = 10;
            button7.Tag = "6";
            button7.Text = "Кнопка 7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            button7.MouseDown += button_MouseDown;
            button7.MouseUp += button_MouseUp;
            // 
            // button8
            // 
            button8.Enabled = false;
            button8.Location = new System.Drawing.Point(5, 343);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(103, 26);
            button8.TabIndex = 11;
            button8.Tag = "7";
            button8.Text = "Кнопка 8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            button8.MouseDown += button_MouseDown;
            button8.MouseUp += button_MouseUp;
            // 
            // checkBox_button_type
            // 
            checkBox_button_type.Enabled = false;
            checkBox_button_type.Location = new System.Drawing.Point(6, 23);
            checkBox_button_type.Margin = new Padding(3, 4, 3, 4);
            checkBox_button_type.Name = "checkBox_button_type";
            checkBox_button_type.Size = new System.Drawing.Size(325, 26);
            checkBox_button_type.TabIndex = 12;
            checkBox_button_type.Text = "Использовать кнопки как переключатели";
            checkBox_button_type.UseVisualStyleBackColor = true;
            checkBox_button_type.CheckedChanged += checkBox_button_type_CheckedChanged;
            // 
            // saveFileDialog_create_screen
            // 
            saveFileDialog_create_screen.Filter = "\"image files (*.png)|*.png|All files (*.*)|*.*\"";
            // 
            // button9
            // 
            button9.Enabled = false;
            button9.Location = new System.Drawing.Point(114, 105);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(103, 26);
            button9.TabIndex = 13;
            button9.Tag = "8";
            button9.Text = "Кнопка 9\r\n";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            button9.MouseDown += button_MouseDown;
            button9.MouseUp += button_MouseUp;
            // 
            // button10
            // 
            button10.Enabled = false;
            button10.Location = new System.Drawing.Point(114, 139);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(103, 26);
            button10.TabIndex = 14;
            button10.Tag = "9";
            button10.Text = "Кнопка 10";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_Click;
            button10.MouseDown += button_MouseDown;
            button10.MouseUp += button_MouseUp;
            // 
            // button11
            // 
            button11.Enabled = false;
            button11.Location = new System.Drawing.Point(114, 173);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(103, 26);
            button11.TabIndex = 15;
            button11.Tag = "10";
            button11.Text = "Кнопка 11";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button_Click;
            button11.MouseDown += button_MouseDown;
            button11.MouseUp += button_MouseUp;
            // 
            // button12
            // 
            button12.Enabled = false;
            button12.Location = new System.Drawing.Point(114, 207);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(103, 26);
            button12.TabIndex = 16;
            button12.Tag = "11";
            button12.Text = "Кнопка 12";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button_Click;
            button12.MouseDown += button_MouseDown;
            button12.MouseUp += button_MouseUp;
            // 
            // button13
            // 
            button13.Enabled = false;
            button13.Location = new System.Drawing.Point(112, 241);
            button13.Margin = new Padding(3, 4, 3, 4);
            button13.Name = "button13";
            button13.Size = new System.Drawing.Size(103, 26);
            button13.TabIndex = 17;
            button13.Tag = "12";
            button13.Text = "Кнопка 13";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button_Click;
            button13.MouseDown += button_MouseDown;
            button13.MouseUp += button_MouseUp;
            // 
            // button14
            // 
            button14.Enabled = false;
            button14.Location = new System.Drawing.Point(112, 275);
            button14.Margin = new Padding(3, 4, 3, 4);
            button14.Name = "button14";
            button14.Size = new System.Drawing.Size(103, 26);
            button14.TabIndex = 18;
            button14.Tag = "13";
            button14.Text = "Кнопка 14";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button_Click;
            button14.MouseDown += button_MouseDown;
            button14.MouseUp += button_MouseUp;
            // 
            // button15
            // 
            button15.Enabled = false;
            button15.Location = new System.Drawing.Point(112, 309);
            button15.Margin = new Padding(3, 4, 3, 4);
            button15.Name = "button15";
            button15.Size = new System.Drawing.Size(103, 26);
            button15.TabIndex = 19;
            button15.Tag = "14";
            button15.Text = "Кнопка 15";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button_Click;
            button15.MouseDown += button_MouseDown;
            button15.MouseUp += button_MouseUp;
            // 
            // button16
            // 
            button16.Enabled = false;
            button16.Location = new System.Drawing.Point(112, 343);
            button16.Margin = new Padding(3, 4, 3, 4);
            button16.Name = "button16";
            button16.Size = new System.Drawing.Size(103, 26);
            button16.TabIndex = 20;
            button16.Tag = "15";
            button16.Text = "Кнопка 16";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button_Click;
            button16.MouseDown += button_MouseDown;
            button16.MouseUp += button_MouseUp;
            // 
            // button17
            // 
            button17.Enabled = false;
            button17.Location = new System.Drawing.Point(224, 105);
            button17.Margin = new Padding(3, 4, 3, 4);
            button17.Name = "button17";
            button17.Size = new System.Drawing.Size(103, 26);
            button17.TabIndex = 21;
            button17.Tag = "16";
            button17.Text = "Кнопка 17";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button_Click;
            button17.MouseDown += button_MouseDown;
            button17.MouseUp += button_MouseUp;
            // 
            // button18
            // 
            button18.Enabled = false;
            button18.Location = new System.Drawing.Point(223, 139);
            button18.Margin = new Padding(3, 4, 3, 4);
            button18.Name = "button18";
            button18.Size = new System.Drawing.Size(103, 26);
            button18.TabIndex = 22;
            button18.Tag = "17";
            button18.Text = "Кнопка 18";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button_Click;
            button18.MouseDown += button_MouseDown;
            button18.MouseUp += button_MouseUp;
            // 
            // button19
            // 
            button19.Enabled = false;
            button19.Location = new System.Drawing.Point(223, 173);
            button19.Margin = new Padding(3, 4, 3, 4);
            button19.Name = "button19";
            button19.Size = new System.Drawing.Size(103, 26);
            button19.TabIndex = 23;
            button19.Tag = "18";
            button19.Text = "Кнопка 19";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button_Click;
            button19.MouseDown += button_MouseDown;
            button19.MouseUp += button_MouseUp;
            // 
            // button20
            // 
            button20.Enabled = false;
            button20.Location = new System.Drawing.Point(224, 207);
            button20.Margin = new Padding(3, 4, 3, 4);
            button20.Name = "button20";
            button20.Size = new System.Drawing.Size(103, 26);
            button20.TabIndex = 24;
            button20.Tag = "19";
            button20.Text = "Кнопка 20";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button_Click;
            button20.MouseDown += button_MouseDown;
            button20.MouseUp += button_MouseUp;
            // 
            // button21
            // 
            button21.Enabled = false;
            button21.Location = new System.Drawing.Point(221, 241);
            button21.Margin = new Padding(3, 4, 3, 4);
            button21.Name = "button21";
            button21.Size = new System.Drawing.Size(103, 26);
            button21.TabIndex = 25;
            button21.Tag = "20";
            button21.Text = "Кнопка 21";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button_Click;
            button21.MouseDown += button_MouseDown;
            button21.MouseUp += button_MouseUp;
            // 
            // button22
            // 
            button22.Enabled = false;
            button22.Location = new System.Drawing.Point(221, 275);
            button22.Margin = new Padding(3, 4, 3, 4);
            button22.Name = "button22";
            button22.Size = new System.Drawing.Size(103, 26);
            button22.TabIndex = 26;
            button22.Tag = "21";
            button22.Text = "Кнопка 22";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button_Click;
            button22.MouseDown += button_MouseDown;
            button22.MouseUp += button_MouseUp;
            // 
            // button23
            // 
            button23.Enabled = false;
            button23.Location = new System.Drawing.Point(221, 309);
            button23.Margin = new Padding(3, 4, 3, 4);
            button23.Name = "button23";
            button23.Size = new System.Drawing.Size(103, 26);
            button23.TabIndex = 27;
            button23.Tag = "22";
            button23.Text = "Кнопка 23";
            button23.UseVisualStyleBackColor = true;
            button23.Click += button_Click;
            button23.MouseDown += button_MouseDown;
            button23.MouseUp += button_MouseUp;
            // 
            // button24
            // 
            button24.Enabled = false;
            button24.Location = new System.Drawing.Point(221, 343);
            button24.Margin = new Padding(3, 4, 3, 4);
            button24.Name = "button24";
            button24.Size = new System.Drawing.Size(103, 26);
            button24.TabIndex = 28;
            button24.Tag = "23";
            button24.Text = "Кнопка 24";
            button24.UseVisualStyleBackColor = true;
            button24.Click += button_Click;
            button24.MouseDown += button_MouseDown;
            button24.MouseUp += button_MouseUp;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(106, 55);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(217, 23);
            textBox2.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 15);
            label2.TabIndex = 29;
            label2.Text = "Данные с порта";
            // 
            // checkBoxReverseData1
            // 
            checkBoxReverseData1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            checkBoxReverseData1.Enabled = false;
            checkBoxReverseData1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            checkBoxReverseData1.Location = new System.Drawing.Point(5, 73);
            checkBoxReverseData1.Margin = new Padding(3, 4, 3, 4);
            checkBoxReverseData1.Name = "checkBoxReverseData1";
            checkBoxReverseData1.Size = new System.Drawing.Size(103, 24);
            checkBoxReverseData1.TabIndex = 31;
            checkBoxReverseData1.Tag = "0";
            checkBoxReverseData1.UseVisualStyleBackColor = true;
            checkBoxReverseData1.CheckedChanged += checkBox_group_CheckedChanged;
            // 
            // checkBoxReverseData2
            // 
            checkBoxReverseData2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            checkBoxReverseData2.Enabled = false;
            checkBoxReverseData2.Location = new System.Drawing.Point(112, 73);
            checkBoxReverseData2.Margin = new Padding(3, 4, 3, 4);
            checkBoxReverseData2.Name = "checkBoxReverseData2";
            checkBoxReverseData2.Size = new System.Drawing.Size(103, 23);
            checkBoxReverseData2.TabIndex = 32;
            checkBoxReverseData2.Tag = "1";
            checkBoxReverseData2.UseVisualStyleBackColor = true;
            checkBoxReverseData2.CheckedChanged += checkBox_group_CheckedChanged;
            // 
            // checkBoxReverseData3
            // 
            checkBoxReverseData3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            checkBoxReverseData3.Enabled = false;
            checkBoxReverseData3.Location = new System.Drawing.Point(224, 73);
            checkBoxReverseData3.Margin = new Padding(3, 4, 3, 4);
            checkBoxReverseData3.Name = "checkBoxReverseData3";
            checkBoxReverseData3.Size = new System.Drawing.Size(103, 23);
            checkBoxReverseData3.TabIndex = 33;
            checkBoxReverseData3.Tag = "2";
            checkBoxReverseData3.UseVisualStyleBackColor = true;
            checkBoxReverseData3.CheckedChanged += checkBox_group_CheckedChanged;
            // 
            // testbench_button
            // 
            testbench_button.Location = new System.Drawing.Point(5, 81);
            testbench_button.Margin = new Padding(3, 4, 3, 4);
            testbench_button.Name = "testbench_button";
            testbench_button.Size = new System.Drawing.Size(140, 26);
            testbench_button.TabIndex = 34;
            testbench_button.Text = "Запустить testbench";
            testbench_button.UseVisualStyleBackColor = true;
            testbench_button.Click += testbench_button_Click;
            // 
            // testbench_name
            // 
            testbench_name.Location = new System.Drawing.Point(151, 84);
            testbench_name.Margin = new Padding(3, 4, 3, 4);
            testbench_name.Name = "testbench_name";
            testbench_name.Size = new System.Drawing.Size(142, 23);
            testbench_name.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            pictureBox1.BackgroundImage = Properties.Resources.camera;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new System.Drawing.Point(370, 72);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(647, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // button_cam_start
            // 
            button_cam_start.Location = new System.Drawing.Point(589, 18);
            button_cam_start.Margin = new Padding(3, 4, 3, 4);
            button_cam_start.Name = "button_cam_start";
            button_cam_start.Size = new System.Drawing.Size(140, 26);
            button_cam_start.TabIndex = 37;
            button_cam_start.Text = "Запуск камеры";
            button_cam_start.UseVisualStyleBackColor = true;
            button_cam_start.Click += button_cam_start_Click;
            // 
            // comboBox_cameras
            // 
            comboBox_cameras.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_cameras.FormattingEnabled = true;
            comboBox_cameras.Location = new System.Drawing.Point(362, 21);
            comboBox_cameras.Margin = new Padding(3, 4, 3, 4);
            comboBox_cameras.Name = "comboBox_cameras";
            comboBox_cameras.Size = new System.Drawing.Size(221, 23);
            comboBox_cameras.TabIndex = 39;
            comboBox_cameras.SelectedIndexChanged += comboBox_cameras_SelectedIndexChanged;
            // 
            // button_cam_scan
            // 
            button_cam_scan.BackgroundImage = Properties.Resources.search;
            button_cam_scan.BackgroundImageLayout = ImageLayout.Zoom;
            button_cam_scan.Location = new System.Drawing.Point(330, 18);
            button_cam_scan.Margin = new Padding(3, 4, 3, 4);
            button_cam_scan.Name = "button_cam_scan";
            button_cam_scan.Size = new System.Drawing.Size(26, 26);
            button_cam_scan.TabIndex = 40;
            button_cam_scan.UseVisualStyleBackColor = true;
            button_cam_scan.Click += button_cam_scan_Click;
            // 
            // button_cam_stop
            // 
            button_cam_stop.Location = new System.Drawing.Point(735, 17);
            button_cam_stop.Margin = new Padding(3, 4, 3, 4);
            button_cam_stop.Name = "button_cam_stop";
            button_cam_stop.Size = new System.Drawing.Size(140, 26);
            button_cam_stop.TabIndex = 38;
            button_cam_stop.Text = "Остановка камеры";
            button_cam_stop.UseVisualStyleBackColor = true;
            button_cam_stop.Click += button_cam_stop_Click;
            // 
            // comboBox_arduino
            // 
            comboBox_arduino.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_arduino.FormattingEnabled = true;
            comboBox_arduino.Location = new System.Drawing.Point(79, 20);
            comboBox_arduino.Margin = new Padding(3, 4, 3, 4);
            comboBox_arduino.Name = "comboBox_arduino";
            comboBox_arduino.Size = new System.Drawing.Size(83, 23);
            comboBox_arduino.TabIndex = 41;
            // 
            // button_com_scan
            // 
            button_com_scan.BackgroundImage = Properties.Resources.search;
            button_com_scan.BackgroundImageLayout = ImageLayout.Zoom;
            button_com_scan.Location = new System.Drawing.Point(6, 18);
            button_com_scan.Margin = new Padding(3, 4, 3, 4);
            button_com_scan.Name = "button_com_scan";
            button_com_scan.Size = new System.Drawing.Size(26, 26);
            button_com_scan.TabIndex = 42;
            button_com_scan.UseVisualStyleBackColor = true;
            button_com_scan.Click += button_com_scan_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(5, 54);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(159, 15);
            label3.TabIndex = 46;
            label3.Text = "Принимать данные с плиса";
            // 
            // button_create_screen
            // 
            button_create_screen.BackgroundImage = Properties.Resources.download;
            button_create_screen.BackgroundImageLayout = ImageLayout.Zoom;
            button_create_screen.Location = new System.Drawing.Point(881, 18);
            button_create_screen.Margin = new Padding(3, 4, 3, 4);
            button_create_screen.Name = "button_create_screen";
            button_create_screen.Size = new System.Drawing.Size(26, 26);
            button_create_screen.TabIndex = 47;
            button_create_screen.UseVisualStyleBackColor = true;
            button_create_screen.Click += button_create_screen_Click;
            // 
            // openFileDialog_load_testbench
            // 
            openFileDialog_load_testbench.FileName = "openFileDialog1";
            openFileDialog_load_testbench.Filter = "\"verilog files (*.v)|*.v|text files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // button_select_testbench
            // 
            button_select_testbench.Location = new System.Drawing.Point(299, 81);
            button_select_testbench.Margin = new Padding(3, 4, 3, 4);
            button_select_testbench.Name = "button_select_testbench";
            button_select_testbench.Size = new System.Drawing.Size(30, 26);
            button_select_testbench.TabIndex = 48;
            button_select_testbench.Text = "...";
            button_select_testbench.UseVisualStyleBackColor = true;
            button_select_testbench.Click += button_select_testbench_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new System.Drawing.Point(5, 105);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(103, 26);
            button1.TabIndex = 49;
            button1.Text = "Кнопка 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            button1.MouseDown += button_MouseDown;
            button1.MouseUp += button_MouseUp;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SpecialPanel
            // 
            SpecialPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SpecialPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            SpecialPanel.BorderStyle = BorderStyle.FixedSingle;
            SpecialPanel.Controls.Add(VideoSettingsButton);
            SpecialPanel.Controls.Add(VideoStopButton);
            SpecialPanel.Controls.Add(VideoStartButton);
            SpecialPanel.Controls.Add(ArduinoButton);
            SpecialPanel.Controls.Add(CloseButton);
            SpecialPanel.Enabled = false;
            SpecialPanel.Location = new System.Drawing.Point(1082, 14);
            SpecialPanel.Margin = new Padding(3, 2, 3, 2);
            SpecialPanel.Name = "SpecialPanel";
            SpecialPanel.Size = new System.Drawing.Size(340, 92);
            SpecialPanel.TabIndex = 17;
            SpecialPanel.Visible = false;
            // 
            // VideoSettingsButton
            // 
            VideoSettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            VideoSettingsButton.Location = new System.Drawing.Point(164, 48);
            VideoSettingsButton.Margin = new Padding(3, 2, 3, 2);
            VideoSettingsButton.Name = "VideoSettingsButton";
            VideoSettingsButton.Size = new System.Drawing.Size(138, 37);
            VideoSettingsButton.TabIndex = 0;
            VideoSettingsButton.Text = "Настройки записи";
            VideoSettingsButton.UseVisualStyleBackColor = true;
            VideoSettingsButton.Click += VideoSettingsButton_Click;
            // 
            // VideoStopButton
            // 
            VideoStopButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            VideoStopButton.Location = new System.Drawing.Point(9, 48);
            VideoStopButton.Margin = new Padding(3, 2, 3, 2);
            VideoStopButton.Name = "VideoStopButton";
            VideoStopButton.Size = new System.Drawing.Size(151, 33);
            VideoStopButton.TabIndex = 0;
            VideoStopButton.Text = "Стоп";
            VideoStopButton.UseVisualStyleBackColor = true;
            VideoStopButton.Visible = false;
            VideoStopButton.Click += VideoStopButton_Click;
            // 
            // VideoStartButton
            // 
            VideoStartButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            VideoStartButton.Location = new System.Drawing.Point(9, 48);
            VideoStartButton.Margin = new Padding(3, 2, 3, 2);
            VideoStartButton.Name = "VideoStartButton";
            VideoStartButton.Size = new System.Drawing.Size(151, 37);
            VideoStartButton.TabIndex = 0;
            VideoStartButton.Text = "Начать запись";
            VideoStartButton.UseVisualStyleBackColor = true;
            VideoStartButton.MouseClick += VideoStartButton_MouseClick;
            // 
            // ArduinoButton
            // 
            ArduinoButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ArduinoButton.Location = new System.Drawing.Point(9, 2);
            ArduinoButton.Margin = new Padding(3, 2, 3, 2);
            ArduinoButton.Name = "ArduinoButton";
            ArduinoButton.Size = new System.Drawing.Size(151, 35);
            ArduinoButton.TabIndex = 0;
            ArduinoButton.Text = "Перепрошивка Arduino";
            ArduinoButton.UseVisualStyleBackColor = true;
            ArduinoButton.Click += ArduinoButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CloseButton.Location = new System.Drawing.Point(164, 2);
            CloseButton.Margin = new Padding(3, 2, 3, 2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new System.Drawing.Size(138, 35);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Закрыть программу";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // videoSettings
            // 
            videoSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            videoSettings.BackColor = System.Drawing.SystemColors.MenuBar;
            videoSettings.BorderStyle = BorderStyle.FixedSingle;
            videoSettings.Controls.Add(loggingCheckBox);
            videoSettings.Controls.Add(qualityChoose);
            videoSettings.Controls.Add(fpsChoose);
            videoSettings.Controls.Add(codecChoose);
            videoSettings.Controls.Add(routeInput);
            videoSettings.Controls.Add(folderButton);
            videoSettings.Controls.Add(nameInput);
            videoSettings.Controls.Add(fpsText);
            videoSettings.Controls.Add(qualityText);
            videoSettings.Controls.Add(routeText);
            videoSettings.Controls.Add(nameText);
            videoSettings.Location = new System.Drawing.Point(1082, 235);
            videoSettings.Margin = new Padding(3, 2, 3, 2);
            videoSettings.Name = "videoSettings";
            videoSettings.Size = new System.Drawing.Size(340, 178);
            videoSettings.TabIndex = 18;
            videoSettings.Visible = false;
            // 
            // loggingCheckBox
            // 
            loggingCheckBox.AutoSize = true;
            loggingCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            loggingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            loggingCheckBox.Location = new System.Drawing.Point(16, 152);
            loggingCheckBox.Margin = new Padding(3, 2, 3, 2);
            loggingCheckBox.Name = "loggingCheckBox";
            loggingCheckBox.Size = new System.Drawing.Size(156, 19);
            loggingCheckBox.TabIndex = 17;
            loggingCheckBox.Text = "Логирование нажатий";
            loggingCheckBox.UseVisualStyleBackColor = true;
            loggingCheckBox.CheckedChanged += loggingCheckBox_CheckedChanged;
            // 
            // qualityChoose
            // 
            qualityChoose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            qualityChoose.DropDownStyle = ComboBoxStyle.DropDownList;
            qualityChoose.FormattingEnabled = true;
            qualityChoose.Location = new System.Drawing.Point(89, 88);
            qualityChoose.Margin = new Padding(3, 2, 3, 2);
            qualityChoose.Name = "qualityChoose";
            qualityChoose.Size = new System.Drawing.Size(134, 23);
            qualityChoose.TabIndex = 2;
            // 
            // fpsChoose
            // 
            fpsChoose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            fpsChoose.DropDownStyle = ComboBoxStyle.DropDownList;
            fpsChoose.FormattingEnabled = true;
            fpsChoose.Location = new System.Drawing.Point(89, 122);
            fpsChoose.Margin = new Padding(3, 2, 3, 2);
            fpsChoose.Name = "fpsChoose";
            fpsChoose.Size = new System.Drawing.Size(134, 23);
            fpsChoose.TabIndex = 2;
            // 
            // codecChoose
            // 
            codecChoose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            codecChoose.DropDownStyle = ComboBoxStyle.DropDownList;
            codecChoose.FormattingEnabled = true;
            codecChoose.Location = new System.Drawing.Point(227, 22);
            codecChoose.Margin = new Padding(3, 2, 3, 2);
            codecChoose.Name = "codecChoose";
            codecChoose.Size = new System.Drawing.Size(102, 23);
            codecChoose.TabIndex = 2;
            // 
            // routeInput
            // 
            routeInput.Anchor = AnchorStyles.Top;
            routeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            routeInput.Location = new System.Drawing.Point(86, 53);
            routeInput.Margin = new Padding(3, 2, 3, 2);
            routeInput.Name = "routeInput";
            routeInput.Size = new System.Drawing.Size(214, 21);
            routeInput.TabIndex = 1;
            // 
            // folderButton
            // 
            folderButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            folderButton.BackColor = System.Drawing.SystemColors.Control;
            folderButton.Cursor = Cursors.Hand;
            folderButton.Image = Properties.Resources.folder;
            folderButton.Location = new System.Drawing.Point(307, 53);
            folderButton.Margin = new Padding(3, 2, 3, 2);
            folderButton.Name = "folderButton";
            folderButton.Size = new System.Drawing.Size(20, 17);
            folderButton.SizeMode = PictureBoxSizeMode.Zoom;
            folderButton.TabIndex = 16;
            folderButton.TabStop = false;
            folderButton.Click += folderButton_Click;
            // 
            // nameInput
            // 
            nameInput.Anchor = AnchorStyles.Top;
            nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            nameInput.Location = new System.Drawing.Point(86, 22);
            nameInput.Margin = new Padding(3, 2, 3, 2);
            nameInput.Name = "nameInput";
            nameInput.Size = new System.Drawing.Size(134, 21);
            nameInput.TabIndex = 1;
            nameInput.MouseClick += nameInput_MouseClick;
            nameInput.Leave += nameInput_Leave;
            // 
            // fpsText
            // 
            fpsText.AutoSize = true;
            fpsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            fpsText.Location = new System.Drawing.Point(14, 122);
            fpsText.Name = "fpsText";
            fpsText.Size = new System.Drawing.Size(27, 15);
            fpsText.TabIndex = 0;
            fpsText.Text = "Fps";
            // 
            // qualityText
            // 
            qualityText.AutoSize = true;
            qualityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            qualityText.Location = new System.Drawing.Point(14, 88);
            qualityText.Name = "qualityText";
            qualityText.Size = new System.Drawing.Size(62, 15);
            qualityText.TabIndex = 0;
            qualityText.Text = "Качество";
            // 
            // routeText
            // 
            routeText.AutoSize = true;
            routeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            routeText.Location = new System.Drawing.Point(14, 56);
            routeText.Name = "routeText";
            routeText.Size = new System.Drawing.Size(35, 15);
            routeText.TabIndex = 0;
            routeText.Text = "Путь";
            // 
            // nameText
            // 
            nameText.AutoSize = true;
            nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            nameText.Location = new System.Drawing.Point(14, 24);
            nameText.Name = "nameText";
            nameText.Size = new System.Drawing.Size(64, 15);
            nameText.TabIndex = 0;
            nameText.Text = "Название";
            // 
            // SpecialFeaturesButton
            // 
            SpecialFeaturesButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SpecialFeaturesButton.BackColor = System.Drawing.SystemColors.Control;
            SpecialFeaturesButton.Cursor = Cursors.Hand;
            SpecialFeaturesButton.Enabled = false;
            SpecialFeaturesButton.Image = Properties.Resources.specialFeaturesButton;
            SpecialFeaturesButton.Location = new System.Drawing.Point(1392, 5);
            SpecialFeaturesButton.Margin = new Padding(3, 2, 3, 2);
            SpecialFeaturesButton.Name = "SpecialFeaturesButton";
            SpecialFeaturesButton.Size = new System.Drawing.Size(30, 26);
            SpecialFeaturesButton.SizeMode = PictureBoxSizeMode.Zoom;
            SpecialFeaturesButton.TabIndex = 16;
            SpecialFeaturesButton.TabStop = false;
            SpecialFeaturesButton.Visible = false;
            SpecialFeaturesButton.Click += SpecialFeaturesButton_Click;
            SpecialFeaturesButton.MouseEnter += SpecialFeaturesButton_MouseEnter;
            SpecialFeaturesButton.MouseLeave += SpecialFeaturesButton_MouseLeave;
            // 
            // LoginUserPicture
            // 
            LoginUserPicture.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LoginUserPicture.BackColor = System.Drawing.SystemColors.Control;
            LoginUserPicture.Cursor = Cursors.Hand;
            LoginUserPicture.Image = Properties.Resources.FatUser;
            LoginUserPicture.Location = new System.Drawing.Point(1392, 5);
            LoginUserPicture.Margin = new Padding(3, 2, 3, 2);
            LoginUserPicture.Name = "LoginUserPicture";
            LoginUserPicture.Size = new System.Drawing.Size(30, 26);
            LoginUserPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LoginUserPicture.TabIndex = 15;
            LoginUserPicture.TabStop = false;
            LoginUserPicture.Click += LoginUserPicture_Click;
            LoginUserPicture.MouseEnter += LoginUserPicture_MouseEnter;
            LoginUserPicture.MouseLeave += LoginUserPicture_MouseLeave;
            // 
            // arduinoPanel
            // 
            arduinoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            arduinoPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            arduinoPanel.BorderStyle = BorderStyle.FixedSingle;
            arduinoPanel.Controls.Add(arduinoNewCodeButton);
            arduinoPanel.Controls.Add(arduinoCodePath);
            arduinoPanel.Controls.Add(arduinoCodePathSelector);
            arduinoPanel.Controls.Add(arduinoCodePathText);
            arduinoPanel.Controls.Add(arduinoPath);
            arduinoPanel.Controls.Add(arduinoPathSelector);
            arduinoPanel.Controls.Add(arduinoPathText);
            arduinoPanel.Location = new System.Drawing.Point(1082, 110);
            arduinoPanel.Margin = new Padding(3, 2, 3, 2);
            arduinoPanel.Name = "arduinoPanel";
            arduinoPanel.Size = new System.Drawing.Size(340, 121);
            arduinoPanel.TabIndex = 19;
            arduinoPanel.Visible = false;
            // 
            // arduinoNewCodeButton
            // 
            arduinoNewCodeButton.Location = new System.Drawing.Point(136, 75);
            arduinoNewCodeButton.Margin = new Padding(3, 2, 3, 2);
            arduinoNewCodeButton.Name = "arduinoNewCodeButton";
            arduinoNewCodeButton.Size = new System.Drawing.Size(114, 24);
            arduinoNewCodeButton.TabIndex = 20;
            arduinoNewCodeButton.Text = "Перепрошить";
            arduinoNewCodeButton.UseVisualStyleBackColor = true;
            arduinoNewCodeButton.Click += arduinoNewCodeButton_Click;
            // 
            // arduinoCodePath
            // 
            arduinoCodePath.Anchor = AnchorStyles.Top;
            arduinoCodePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            arduinoCodePath.Location = new System.Drawing.Point(140, 53);
            arduinoCodePath.Margin = new Padding(3, 2, 3, 2);
            arduinoCodePath.Name = "arduinoCodePath";
            arduinoCodePath.Size = new System.Drawing.Size(130, 21);
            arduinoCodePath.TabIndex = 18;
            // 
            // arduinoCodePathSelector
            // 
            arduinoCodePathSelector.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            arduinoCodePathSelector.BackColor = System.Drawing.SystemColors.Control;
            arduinoCodePathSelector.Cursor = Cursors.Hand;
            arduinoCodePathSelector.Image = Properties.Resources.folder;
            arduinoCodePathSelector.Location = new System.Drawing.Point(274, 53);
            arduinoCodePathSelector.Margin = new Padding(3, 2, 3, 2);
            arduinoCodePathSelector.Name = "arduinoCodePathSelector";
            arduinoCodePathSelector.Size = new System.Drawing.Size(20, 17);
            arduinoCodePathSelector.SizeMode = PictureBoxSizeMode.Zoom;
            arduinoCodePathSelector.TabIndex = 19;
            arduinoCodePathSelector.TabStop = false;
            arduinoCodePathSelector.Click += arduinoCodePathSelector_Click;
            // 
            // arduinoCodePathText
            // 
            arduinoCodePathText.AutoSize = true;
            arduinoCodePathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            arduinoCodePathText.Location = new System.Drawing.Point(37, 53);
            arduinoCodePathText.Name = "arduinoCodePathText";
            arduinoCodePathText.Size = new System.Drawing.Size(99, 15);
            arduinoCodePathText.TabIndex = 17;
            arduinoCodePathText.Text = "Файл прошивки";
            // 
            // arduinoPath
            // 
            arduinoPath.Anchor = AnchorStyles.Top;
            arduinoPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            arduinoPath.Location = new System.Drawing.Point(38, 24);
            arduinoPath.Margin = new Padding(3, 2, 3, 2);
            arduinoPath.Name = "arduinoPath";
            arduinoPath.Size = new System.Drawing.Size(232, 21);
            arduinoPath.TabIndex = 1;
            arduinoPath.MouseClick += arduinoPath_MouseClick;
            arduinoPath.Leave += arduinoPath_Leave;
            // 
            // arduinoPathSelector
            // 
            arduinoPathSelector.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            arduinoPathSelector.BackColor = System.Drawing.SystemColors.Control;
            arduinoPathSelector.Cursor = Cursors.Hand;
            arduinoPathSelector.Image = Properties.Resources.folder;
            arduinoPathSelector.Location = new System.Drawing.Point(274, 24);
            arduinoPathSelector.Margin = new Padding(3, 2, 3, 2);
            arduinoPathSelector.Name = "arduinoPathSelector";
            arduinoPathSelector.Size = new System.Drawing.Size(20, 17);
            arduinoPathSelector.SizeMode = PictureBoxSizeMode.Zoom;
            arduinoPathSelector.TabIndex = 16;
            arduinoPathSelector.TabStop = false;
            arduinoPathSelector.Click += arduinoPathSelector_Click;
            // 
            // arduinoPathText
            // 
            arduinoPathText.AutoSize = true;
            arduinoPathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            arduinoPathText.Location = new System.Drawing.Point(37, 7);
            arduinoPathText.Name = "arduinoPathText";
            arduinoPathText.Size = new System.Drawing.Size(252, 15);
            arduinoPathText.TabIndex = 0;
            arduinoPathText.Text = "Папка, в которой установлена Arduino IDE";
            // 
            // _txtCol1
            // 
            _txtCol1.Enabled = false;
            _txtCol1.Location = new System.Drawing.Point(3, 27);
            _txtCol1.Margin = new Padding(3, 2, 3, 2);
            _txtCol1.MaxLength = 8;
            _txtCol1.Name = "_txtCol1";
            _txtCol1.Size = new System.Drawing.Size(103, 23);
            _txtCol1.TabIndex = 50;
            _txtCol1.TextChanged += _txtCol1_TextChanged;
            // 
            // _txtCol2
            // 
            _txtCol2.Enabled = false;
            _txtCol2.Location = new System.Drawing.Point(114, 27);
            _txtCol2.Margin = new Padding(3, 2, 3, 2);
            _txtCol2.MaxLength = 8;
            _txtCol2.Name = "_txtCol2";
            _txtCol2.Size = new System.Drawing.Size(103, 23);
            _txtCol2.TabIndex = 51;
            _txtCol2.TextChanged += _txtCol1_TextChanged;
            // 
            // _txtCol3
            // 
            _txtCol3.Enabled = false;
            _txtCol3.Location = new System.Drawing.Point(222, 27);
            _txtCol3.Margin = new Padding(3, 2, 3, 2);
            _txtCol3.MaxLength = 8;
            _txtCol3.Name = "_txtCol3";
            _txtCol3.Size = new System.Drawing.Size(102, 23);
            _txtCol3.TabIndex = 52;
            _txtCol3.TextChanged += _txtCol1_TextChanged;
            // 
            // _buttonStart
            // 
            _buttonStart.Enabled = false;
            _buttonStart.Location = new System.Drawing.Point(333, 28);
            _buttonStart.Margin = new Padding(3, 2, 3, 2);
            _buttonStart.Name = "_buttonStart";
            _buttonStart.Size = new System.Drawing.Size(82, 22);
            _buttonStart.TabIndex = 53;
            _buttonStart.Text = "AutoClick";
            _buttonStart.UseVisualStyleBackColor = true;
            _buttonStart.Click += _buttonStart_Click;
            // 
            // delayBox
            // 
            delayBox.Enabled = false;
            delayBox.Location = new System.Drawing.Point(215, 71);
            delayBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            delayBox.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            delayBox.Name = "delayBox";
            delayBox.Size = new System.Drawing.Size(120, 23);
            delayBox.TabIndex = 55;
            delayBox.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 73);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(206, 15);
            label5.TabIndex = 56;
            label5.Text = "Ввод задержки нажатия кнопок (мс)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(0, 32);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(73, 15);
            label7.TabIndex = 58;
            label7.Text = "Скважность";
            // 
            // DutyCycleBox
            // 
            DutyCycleBox.Location = new System.Drawing.Point(79, 29);
            DutyCycleBox.Margin = new Padding(3, 2, 3, 2);
            DutyCycleBox.MaxLength = 10000;
            DutyCycleBox.Name = "DutyCycleBox";
            DutyCycleBox.Size = new System.Drawing.Size(103, 23);
            DutyCycleBox.TabIndex = 60;
            DutyCycleBox.Text = "50";
            // 
            // StartPWM
            // 
            StartPWM.Enabled = false;
            StartPWM.Location = new System.Drawing.Point(183, 28);
            StartPWM.Name = "StartPWM";
            StartPWM.Size = new System.Drawing.Size(75, 23);
            StartPWM.TabIndex = 61;
            StartPWM.Text = "Вкл";
            StartPWM.UseVisualStyleBackColor = true;
            StartPWM.Click += StartPWM_Click;
            // 
            // buttonSavePWM
            // 
            buttonSavePWM.Location = new System.Drawing.Point(264, 28);
            buttonSavePWM.Name = "buttonSavePWM";
            buttonSavePWM.Size = new System.Drawing.Size(75, 23);
            buttonSavePWM.TabIndex = 63;
            buttonSavePWM.Text = "save";
            buttonSavePWM.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(_txtCol1);
            groupBox1.Controls.Add(_txtCol2);
            groupBox1.Controls.Add(_txtCol3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(delayBox);
            groupBox1.Controls.Add(_buttonStart);
            groupBox1.Location = new System.Drawing.Point(9, 500);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(431, 104);
            groupBox1.TabIndex = 65;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод бинарного кода";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DelayBoxForPWM);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(DutyCycleBox);
            groupBox2.Controls.Add(buttonSavePWM);
            groupBox2.Controls.Add(StartPWM);
            groupBox2.Location = new System.Drawing.Point(446, 503);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(571, 101);
            groupBox2.TabIndex = 66;
            groupBox2.TabStop = false;
            groupBox2.Text = "ШИМ";
            // 
            // DelayBoxForPWM
            // 
            DelayBoxForPWM.Enabled = false;
            DelayBoxForPWM.Location = new System.Drawing.Point(171, 70);
            DelayBoxForPWM.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            DelayBoxForPWM.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            DelayBoxForPWM.Name = "DelayBoxForPWM";
            DelayBoxForPWM.Size = new System.Drawing.Size(120, 23);
            DelayBoxForPWM.TabIndex = 64;
            DelayBoxForPWM.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(0, 76);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(165, 15);
            label4.TabIndex = 57;
            label4.Text = "Задержка шим-сигнала (мс)";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(checkBoxReverseData1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(checkBoxReverseData2);
            groupBox3.Controls.Add(button17);
            groupBox3.Controls.Add(checkBoxReverseData3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button10);
            groupBox3.Controls.Add(button18);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button11);
            groupBox3.Controls.Add(button19);
            groupBox3.Controls.Add(button12);
            groupBox3.Controls.Add(button20);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(checkBox_button_type);
            groupBox3.Controls.Add(button24);
            groupBox3.Controls.Add(button13);
            groupBox3.Controls.Add(button23);
            groupBox3.Controls.Add(button14);
            groupBox3.Controls.Add(button22);
            groupBox3.Controls.Add(button15);
            groupBox3.Controls.Add(button21);
            groupBox3.Controls.Add(button16);
            groupBox3.Location = new System.Drawing.Point(9, 119);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(338, 379);
            groupBox3.TabIndex = 67;
            groupBox3.TabStop = false;
            groupBox3.Text = "Управление";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button_com_scan);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(testbench_button);
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(testbench_name);
            groupBox4.Controls.Add(button_select_testbench);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(comboBox_arduino);
            groupBox4.Controls.Add(button_create_screen);
            groupBox4.Controls.Add(buttonConnect);
            groupBox4.Controls.Add(button_cam_stop);
            groupBox4.Controls.Add(comboBox_cameras);
            groupBox4.Controls.Add(button_cam_start);
            groupBox4.Controls.Add(button_cam_scan);
            groupBox4.Location = new System.Drawing.Point(8, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(935, 112);
            groupBox4.TabIndex = 68;
            groupBox4.TabStop = false;
            groupBox4.Text = "Настройки";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1431, 706);
            ControlBox = false;
            Controls.Add(groupBox3);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(arduinoPanel);
            Controls.Add(videoSettings);
            Controls.Add(SpecialPanel);
            Controls.Add(SpecialFeaturesButton);
            Controls.Add(LoginUserPicture);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(20, 509);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Button Emulator";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SpecialPanel.ResumeLayout(false);
            videoSettings.ResumeLayout(false);
            videoSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)folderButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpecialFeaturesButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoginUserPicture).EndInit();
            arduinoPanel.ResumeLayout(false);
            arduinoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)arduinoCodePathSelector).EndInit();
            ((System.ComponentModel.ISupportInitialize)arduinoPathSelector).EndInit();
            ((System.ComponentModel.ISupportInitialize)delayBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DelayBoxForPWM).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        private void SpecialFeaturesButton_MouseEnter1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_button_type;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_create_screen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxReverseData1;
        private System.Windows.Forms.CheckBox checkBoxReverseData2;
        private System.Windows.Forms.CheckBox checkBoxReverseData3;
        private System.Windows.Forms.Button testbench_button;
        private System.Windows.Forms.TextBox testbench_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_cam_start;
        private System.Windows.Forms.ComboBox comboBox_cameras;
        private System.Windows.Forms.Button button_cam_scan;
        private System.Windows.Forms.Button button_cam_stop;
        private System.Windows.Forms.ComboBox comboBox_arduino;
        private System.Windows.Forms.Button button_com_scan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_create_screen;
        private System.Windows.Forms.OpenFileDialog openFileDialog_load_testbench;
        private System.Windows.Forms.Button button_select_testbench;
        private System.Windows.Forms.Button button1;

        public PictureBox LoginUserPicture;
        private ContextMenuStrip contextMenuStrip1;
        public PictureBox SpecialFeaturesButton;
        public Panel SpecialPanel;
        private Button VideoSettingsButton;
        private Button ArduinoButton;
        public Button CloseButton;
        private Panel videoSettings;
        private Label nameText;
        private ComboBox codecChoose;
        private TextBox nameInput;
        private Label routeText;
        private TextBox routeInput;
        public PictureBox folderButton;
        private ComboBox fpsChoose;
        private Label fpsText;
        private Label qualityText;
        private ComboBox qualityChoose;
        private CheckBox loggingCheckBox;
        private Button VideoStopButton;
        private Button VideoStartButton;
        private Panel arduinoPanel;
        private TextBox arduinoCodePath;
        public PictureBox arduinoCodePathSelector;
        private Label arduinoCodePathText;
        private TextBox arduinoPath;
        public PictureBox arduinoPathSelector;
        private Label arduinoPathText;
        private Button arduinoNewCodeButton;
        private TextBox _txtCol1;
        private TextBox _txtCol2;
        private TextBox _txtCol3;
        private Button _buttonStart;
        private NumericUpDown delayBox;
        private Label label5;
        private Label label7;
        private TextBox DutyCycleBox;
        private Button StartPWM;
        private Button buttonSavePWM;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown DelayBoxForPWM;
        private Label label4;
        private GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox4;
    }
}

