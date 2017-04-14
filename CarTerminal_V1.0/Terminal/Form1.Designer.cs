namespace Terminal
{
    partial class main_form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_baudrate = new System.Windows.Forms.ComboBox();
            this.btn_open_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_recieved = new System.Windows.Forms.RichTextBox();
            this.rtb_send = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.tb_send_command = new System.Windows.Forms.TextBox();
            this.btn_send_file = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_path = new System.Windows.Forms.Label();
            this.btn_open_file = new System.Windows.Forms.Button();
            this.of_dialog = new System.Windows.Forms.OpenFileDialog();
            this.tab_mode = new System.Windows.Forms.TabControl();
            this.manual = new System.Windows.Forms.TabPage();
            this.lbl_led = new System.Windows.Forms.Label();
            this.lbl_left = new System.Windows.Forms.Label();
            this.lbl_right = new System.Windows.Forms.Label();
            this.lbl_back = new System.Windows.Forms.Label();
            this.lbl_forward = new System.Windows.Forms.Label();
            this.semiauto = new System.Windows.Forms.TabPage();
            this.btn_semi_start_stop = new System.Windows.Forms.Button();
            this.nud_semi_freq = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_semi_a = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_semi_midspeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.auto = new System.Windows.Forms.TabPage();
            this.btn_auto_start_stop = new System.Windows.Forms.Button();
            this.nud_auto_rd = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nud_auto_rs = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nud_auto_imp = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nud_auto_coe = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nud_auto_freq = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nud_auto_weight = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_graph = new System.Windows.Forms.Button();
            this.trb_man_speed = new System.Windows.Forms.TrackBar();
            this.nud_man_speed = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tab_mode.SuspendLayout();
            this.manual.SuspendLayout();
            this.semiauto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_semi_freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_semi_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_semi_midspeed)).BeginInit();
            this.auto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_auto_rd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_auto_rs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_auto_imp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_auto_coe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_auto_freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_auto_weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_man_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_man_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_baudrate);
            this.groupBox1.Controls.Add(this.btn_open_close);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_port);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки соединения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BaudRate";
            // 
            // cb_baudrate
            // 
            this.cb_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_baudrate.FormattingEnabled = true;
            this.cb_baudrate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cb_baudrate.Location = new System.Drawing.Point(118, 32);
            this.cb_baudrate.Name = "cb_baudrate";
            this.cb_baudrate.Size = new System.Drawing.Size(73, 21);
            this.cb_baudrate.TabIndex = 2;
            // 
            // btn_open_close
            // 
            this.btn_open_close.Location = new System.Drawing.Point(210, 32);
            this.btn_open_close.Name = "btn_open_close";
            this.btn_open_close.Size = new System.Drawing.Size(67, 21);
            this.btn_open_close.TabIndex = 1;
            this.btn_open_close.Text = "Открыть";
            this.btn_open_close.UseVisualStyleBackColor = true;
            this.btn_open_close.Click += new System.EventHandler(this.btn_open_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // cb_port
            // 
            this.cb_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(6, 32);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(88, 21);
            this.cb_port.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Получено";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Отправлено";
            // 
            // rtb_recieved
            // 
            this.rtb_recieved.Location = new System.Drawing.Point(182, 188);
            this.rtb_recieved.Name = "rtb_recieved";
            this.rtb_recieved.ReadOnly = true;
            this.rtb_recieved.Size = new System.Drawing.Size(164, 180);
            this.rtb_recieved.TabIndex = 9;
            this.rtb_recieved.Text = "";
            // 
            // rtb_send
            // 
            this.rtb_send.Location = new System.Drawing.Point(12, 188);
            this.rtb_send.Name = "rtb_send";
            this.rtb_send.ReadOnly = true;
            this.rtb_send.Size = new System.Drawing.Size(164, 180);
            this.rtb_send.TabIndex = 8;
            this.rtb_send.Text = "";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(223, 91);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(72, 23);
            this.btn_send.TabIndex = 12;
            this.btn_send.Text = "Отправить";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tb_send_command
            // 
            this.tb_send_command.Location = new System.Drawing.Point(13, 94);
            this.tb_send_command.Name = "tb_send_command";
            this.tb_send_command.Size = new System.Drawing.Size(204, 20);
            this.tb_send_command.TabIndex = 13;
            // 
            // btn_send_file
            // 
            this.btn_send_file.Location = new System.Drawing.Point(123, 120);
            this.btn_send_file.Name = "btn_send_file";
            this.btn_send_file.Size = new System.Drawing.Size(106, 23);
            this.btn_send_file.TabIndex = 15;
            this.btn_send_file.Text = "Отправить файл";
            this.btn_send_file.UseVisualStyleBackColor = true;
            this.btn_send_file.Click += new System.EventHandler(this.btn_send_file_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Путь:";
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(49, 146);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(22, 13);
            this.lbl_path.TabIndex = 17;
            this.lbl_path.Text = "C:/";
            // 
            // btn_open_file
            // 
            this.btn_open_file.Location = new System.Drawing.Point(14, 120);
            this.btn_open_file.Name = "btn_open_file";
            this.btn_open_file.Size = new System.Drawing.Size(98, 23);
            this.btn_open_file.TabIndex = 18;
            this.btn_open_file.Text = "Открыть файл...";
            this.btn_open_file.UseVisualStyleBackColor = true;
            this.btn_open_file.Click += new System.EventHandler(this.btn_open_file_Click);
            // 
            // of_dialog
            // 
            this.of_dialog.Filter = "Текстовый файл (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // tab_mode
            // 
            this.tab_mode.Controls.Add(this.manual);
            this.tab_mode.Controls.Add(this.semiauto);
            this.tab_mode.Controls.Add(this.auto);
            this.tab_mode.Location = new System.Drawing.Point(362, 12);
            this.tab_mode.Name = "tab_mode";
            this.tab_mode.SelectedIndex = 0;
            this.tab_mode.Size = new System.Drawing.Size(273, 224);
            this.tab_mode.TabIndex = 19;
            this.tab_mode.SelectedIndexChanged += new System.EventHandler(this.tab_mode_SelectedIndexChanged);
            this.tab_mode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tab_mode_KeyDown);
            this.tab_mode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tab_mode_KeyUp);
            // 
            // manual
            // 
            this.manual.Controls.Add(this.label15);
            this.manual.Controls.Add(this.nud_man_speed);
            this.manual.Controls.Add(this.trb_man_speed);
            this.manual.Controls.Add(this.lbl_led);
            this.manual.Controls.Add(this.lbl_left);
            this.manual.Controls.Add(this.lbl_right);
            this.manual.Controls.Add(this.lbl_back);
            this.manual.Controls.Add(this.lbl_forward);
            this.manual.Location = new System.Drawing.Point(4, 22);
            this.manual.Name = "manual";
            this.manual.Padding = new System.Windows.Forms.Padding(3);
            this.manual.Size = new System.Drawing.Size(265, 198);
            this.manual.TabIndex = 0;
            this.manual.Text = "Ручной";
            this.manual.UseVisualStyleBackColor = true;
            // 
            // lbl_led
            // 
            this.lbl_led.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_led.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_led.Location = new System.Drawing.Point(92, 56);
            this.lbl_led.MinimumSize = new System.Drawing.Size(35, 35);
            this.lbl_led.Name = "lbl_led";
            this.lbl_led.Size = new System.Drawing.Size(80, 35);
            this.lbl_led.TabIndex = 4;
            this.lbl_led.Text = "Фары";
            this.lbl_led.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_left
            // 
            this.lbl_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_left.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_left.Location = new System.Drawing.Point(6, 56);
            this.lbl_left.MinimumSize = new System.Drawing.Size(35, 35);
            this.lbl_left.Name = "lbl_left";
            this.lbl_left.Size = new System.Drawing.Size(80, 35);
            this.lbl_left.TabIndex = 3;
            this.lbl_left.Text = "Налево";
            this.lbl_left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_right
            // 
            this.lbl_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_right.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_right.Location = new System.Drawing.Point(178, 56);
            this.lbl_right.MinimumSize = new System.Drawing.Size(35, 35);
            this.lbl_right.Name = "lbl_right";
            this.lbl_right.Size = new System.Drawing.Size(80, 35);
            this.lbl_right.TabIndex = 2;
            this.lbl_right.Text = "Направо";
            this.lbl_right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_back
            // 
            this.lbl_back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_back.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_back.Location = new System.Drawing.Point(92, 99);
            this.lbl_back.MinimumSize = new System.Drawing.Size(35, 35);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(80, 35);
            this.lbl_back.TabIndex = 1;
            this.lbl_back.Text = "Назад";
            this.lbl_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_forward
            // 
            this.lbl_forward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_forward.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_forward.Location = new System.Drawing.Point(92, 12);
            this.lbl_forward.MinimumSize = new System.Drawing.Size(35, 35);
            this.lbl_forward.Name = "lbl_forward";
            this.lbl_forward.Size = new System.Drawing.Size(80, 35);
            this.lbl_forward.TabIndex = 0;
            this.lbl_forward.Text = "Вперед";
            this.lbl_forward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // semiauto
            // 
            this.semiauto.Controls.Add(this.btn_semi_start_stop);
            this.semiauto.Controls.Add(this.nud_semi_freq);
            this.semiauto.Controls.Add(this.label8);
            this.semiauto.Controls.Add(this.nud_semi_a);
            this.semiauto.Controls.Add(this.label7);
            this.semiauto.Controls.Add(this.nud_semi_midspeed);
            this.semiauto.Controls.Add(this.label4);
            this.semiauto.Location = new System.Drawing.Point(4, 22);
            this.semiauto.Name = "semiauto";
            this.semiauto.Padding = new System.Windows.Forms.Padding(3);
            this.semiauto.Size = new System.Drawing.Size(265, 198);
            this.semiauto.TabIndex = 1;
            this.semiauto.Text = "Полуавтоматический";
            this.semiauto.UseVisualStyleBackColor = true;
            // 
            // btn_semi_start_stop
            // 
            this.btn_semi_start_stop.Location = new System.Drawing.Point(122, 89);
            this.btn_semi_start_stop.Name = "btn_semi_start_stop";
            this.btn_semi_start_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_semi_start_stop.TabIndex = 24;
            this.btn_semi_start_stop.Text = "Старт";
            this.btn_semi_start_stop.UseVisualStyleBackColor = true;
            // 
            // nud_semi_freq
            // 
            this.nud_semi_freq.Location = new System.Drawing.Point(138, 63);
            this.nud_semi_freq.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_semi_freq.Name = "nud_semi_freq";
            this.nud_semi_freq.Size = new System.Drawing.Size(59, 20);
            this.nud_semi_freq.TabIndex = 8;
            this.nud_semi_freq.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Частота (Гц)";
            // 
            // nud_semi_a
            // 
            this.nud_semi_a.Location = new System.Drawing.Point(138, 37);
            this.nud_semi_a.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_semi_a.Name = "nud_semi_a";
            this.nud_semi_a.Size = new System.Drawing.Size(59, 20);
            this.nud_semi_a.TabIndex = 6;
            this.nud_semi_a.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Амплитуда (у.е.)";
            // 
            // nud_semi_midspeed
            // 
            this.nud_semi_midspeed.Location = new System.Drawing.Point(138, 11);
            this.nud_semi_midspeed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_semi_midspeed.Name = "nud_semi_midspeed";
            this.nud_semi_midspeed.Size = new System.Drawing.Size(59, 20);
            this.nud_semi_midspeed.TabIndex = 4;
            this.nud_semi_midspeed.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cредняя скорость (у.е.)";
            // 
            // auto
            // 
            this.auto.Controls.Add(this.btn_auto_start_stop);
            this.auto.Controls.Add(this.nud_auto_rd);
            this.auto.Controls.Add(this.label14);
            this.auto.Controls.Add(this.nud_auto_rs);
            this.auto.Controls.Add(this.label13);
            this.auto.Controls.Add(this.nud_auto_imp);
            this.auto.Controls.Add(this.label12);
            this.auto.Controls.Add(this.nud_auto_coe);
            this.auto.Controls.Add(this.label10);
            this.auto.Controls.Add(this.nud_auto_freq);
            this.auto.Controls.Add(this.label9);
            this.auto.Controls.Add(this.nud_auto_weight);
            this.auto.Controls.Add(this.label11);
            this.auto.Location = new System.Drawing.Point(4, 22);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(265, 198);
            this.auto.TabIndex = 2;
            this.auto.Text = "Автоматический";
            this.auto.UseVisualStyleBackColor = true;
            // 
            // btn_auto_start_stop
            // 
            this.btn_auto_start_stop.Location = new System.Drawing.Point(148, 167);
            this.btn_auto_start_stop.Name = "btn_auto_start_stop";
            this.btn_auto_start_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_auto_start_stop.TabIndex = 23;
            this.btn_auto_start_stop.Text = "Старт";
            this.btn_auto_start_stop.UseVisualStyleBackColor = true;
            // 
            // nud_auto_rd
            // 
            this.nud_auto_rd.Location = new System.Drawing.Point(164, 141);
            this.nud_auto_rd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_auto_rd.Name = "nud_auto_rd";
            this.nud_auto_rd.Size = new System.Drawing.Size(59, 20);
            this.nud_auto_rd.TabIndex = 22;
            this.nud_auto_rd.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Динамический радиус (мм)";
            // 
            // nud_auto_rs
            // 
            this.nud_auto_rs.Location = new System.Drawing.Point(164, 115);
            this.nud_auto_rs.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_auto_rs.Name = "nud_auto_rs";
            this.nud_auto_rs.Size = new System.Drawing.Size(59, 20);
            this.nud_auto_rs.TabIndex = 20;
            this.nud_auto_rs.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Статический радиус (мм)";
            // 
            // nud_auto_imp
            // 
            this.nud_auto_imp.Location = new System.Drawing.Point(164, 89);
            this.nud_auto_imp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_auto_imp.Name = "nud_auto_imp";
            this.nud_auto_imp.Size = new System.Drawing.Size(59, 20);
            this.nud_auto_imp.TabIndex = 18;
            this.nud_auto_imp.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Передаточное число";
            // 
            // nud_auto_coe
            // 
            this.nud_auto_coe.Location = new System.Drawing.Point(164, 63);
            this.nud_auto_coe.Name = "nud_auto_coe";
            this.nud_auto_coe.Size = new System.Drawing.Size(59, 20);
            this.nud_auto_coe.TabIndex = 16;
            this.nud_auto_coe.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "КПД передачи (%)";
            // 
            // nud_auto_freq
            // 
            this.nud_auto_freq.Location = new System.Drawing.Point(164, 35);
            this.nud_auto_freq.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_auto_freq.Name = "nud_auto_freq";
            this.nud_auto_freq.Size = new System.Drawing.Size(59, 20);
            this.nud_auto_freq.TabIndex = 14;
            this.nud_auto_freq.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Частота импульсов (Гц)";
            // 
            // nud_auto_weight
            // 
            this.nud_auto_weight.Location = new System.Drawing.Point(164, 8);
            this.nud_auto_weight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_auto_weight.Name = "nud_auto_weight";
            this.nud_auto_weight.Size = new System.Drawing.Size(59, 20);
            this.nud_auto_weight.TabIndex = 10;
            this.nud_auto_weight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Вес (гр.)";
            // 
            // btn_graph
            // 
            this.btn_graph.Location = new System.Drawing.Point(560, 242);
            this.btn_graph.Name = "btn_graph";
            this.btn_graph.Size = new System.Drawing.Size(75, 23);
            this.btn_graph.TabIndex = 20;
            this.btn_graph.Text = "Графики";
            this.btn_graph.UseVisualStyleBackColor = true;
            // 
            // trb_man_speed
            // 
            this.trb_man_speed.Location = new System.Drawing.Point(6, 147);
            this.trb_man_speed.Maximum = 255;
            this.trb_man_speed.Name = "trb_man_speed";
            this.trb_man_speed.Size = new System.Drawing.Size(252, 45);
            this.trb_man_speed.TabIndex = 5;
            this.trb_man_speed.ValueChanged += new System.EventHandler(this.trb_man_speed_ValueChanged);
            // 
            // nud_man_speed
            // 
            this.nud_man_speed.BackColor = System.Drawing.SystemColors.Control;
            this.nud_man_speed.Location = new System.Drawing.Point(111, 172);
            this.nud_man_speed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_man_speed.Name = "nud_man_speed";
            this.nud_man_speed.Size = new System.Drawing.Size(44, 20);
            this.nud_man_speed.TabIndex = 7;
            this.nud_man_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_man_speed.ValueChanged += new System.EventHandler(this.nud_man_speed_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(15, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Скорость (у.е.)";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 380);
            this.Controls.Add(this.btn_graph);
            this.Controls.Add(this.tab_mode);
            this.Controls.Add(this.btn_open_file);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_send_file);
            this.Controls.Add(this.tb_send_command);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtb_recieved);
            this.Controls.Add(this.rtb_send);
            this.Controls.Add(this.groupBox1);
            this.Name = "main_form";
            this.Text = "Терминал V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_mode.ResumeLayout(false);
            this.manual.ResumeLayout(false);
            this.manual.PerformLayout();
            this.semiauto.ResumeLayout(false);
            this.semiauto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_semi_freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_semi_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_semi_midspeed)).EndInit();
            this.auto.ResumeLayout(false);
            this.auto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_auto_rd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_auto_rs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_auto_imp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_auto_coe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_auto_freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_auto_weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_man_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_man_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_baudrate;
        private System.Windows.Forms.Button btn_open_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_recieved;
        private System.Windows.Forms.RichTextBox rtb_send;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox tb_send_command;
        private System.Windows.Forms.Button btn_send_file;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Button btn_open_file;
        private System.Windows.Forms.OpenFileDialog of_dialog;
        private System.Windows.Forms.TabControl tab_mode;
        private System.Windows.Forms.TabPage manual;
        private System.Windows.Forms.Label lbl_led;
        private System.Windows.Forms.Label lbl_left;
        private System.Windows.Forms.Label lbl_right;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.Label lbl_forward;
        private System.Windows.Forms.TabPage semiauto;
        private System.Windows.Forms.Button btn_semi_start_stop;
        private System.Windows.Forms.NumericUpDown nud_semi_freq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_semi_a;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_semi_midspeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage auto;
        private System.Windows.Forms.Button btn_auto_start_stop;
        private System.Windows.Forms.NumericUpDown nud_auto_rd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nud_auto_rs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nud_auto_imp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nud_auto_coe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nud_auto_freq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nud_auto_weight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_graph;
        private System.Windows.Forms.TrackBar trb_man_speed;
        private System.Windows.Forms.NumericUpDown nud_man_speed;
        private System.Windows.Forms.Label label15;
    }
}

