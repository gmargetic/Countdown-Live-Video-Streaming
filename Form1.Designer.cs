namespace Countdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnMinutesPlus = new System.Windows.Forms.Button();
            this.btnMinutesMinus = new System.Windows.Forms.Button();
            this.labelCountMinutes = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnSeccondsPlus = new System.Windows.Forms.Button();
            this.btnSeccondsMinus = new System.Windows.Forms.Button();
            this.labelCountSeconds = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnHoursPlus = new System.Windows.Forms.Button();
            this.btnHoursMinus = new System.Windows.Forms.Button();
            this.labelCountHours = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbCount = new System.Windows.Forms.ProgressBar();
            this.labelTimeRemaining = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbHideProgress = new System.Windows.Forms.CheckBox();
            this.cbHideClock = new System.Windows.Forms.CheckBox();
            this.cbShowTest = new System.Windows.Forms.CheckBox();
            this.cbHideOutput = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timerCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.btnMsg = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnPreset12 = new System.Windows.Forms.Button();
            this.btnPreset9 = new System.Windows.Forms.Button();
            this.btnPreset6 = new System.Windows.Forms.Button();
            this.btnPreset3 = new System.Windows.Forms.Button();
            this.btnPreset11 = new System.Windows.Forms.Button();
            this.btnPreset8 = new System.Windows.Forms.Button();
            this.btnPreset5 = new System.Windows.Forms.Button();
            this.btnPreset2 = new System.Windows.Forms.Button();
            this.btnPreset10 = new System.Windows.Forms.Button();
            this.btnPreset7 = new System.Windows.Forms.Button();
            this.btnPreset4 = new System.Windows.Forms.Button();
            this.btnPreset1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLbl = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDefaultSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(9, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Duration";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnMinutesPlus);
            this.groupBox8.Controls.Add(this.btnMinutesMinus);
            this.groupBox8.Controls.Add(this.labelCountMinutes);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox8.Location = new System.Drawing.Point(113, 24);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(98, 91);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Minutes";
            // 
            // btnMinutesPlus
            // 
            this.btnMinutesPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinutesPlus.BackgroundImage")));
            this.btnMinutesPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinutesPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinutesPlus.ForeColor = System.Drawing.Color.Black;
            this.btnMinutesPlus.Location = new System.Drawing.Point(54, 19);
            this.btnMinutesPlus.Name = "btnMinutesPlus";
            this.btnMinutesPlus.Size = new System.Drawing.Size(37, 28);
            this.btnMinutesPlus.TabIndex = 9;
            this.btnMinutesPlus.UseVisualStyleBackColor = true;
            this.btnMinutesPlus.Click += new System.EventHandler(this.btnMinutesPlus_Click);
            // 
            // btnMinutesMinus
            // 
            this.btnMinutesMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinutesMinus.BackgroundImage")));
            this.btnMinutesMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinutesMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinutesMinus.ForeColor = System.Drawing.Color.Black;
            this.btnMinutesMinus.Location = new System.Drawing.Point(54, 53);
            this.btnMinutesMinus.Name = "btnMinutesMinus";
            this.btnMinutesMinus.Size = new System.Drawing.Size(37, 28);
            this.btnMinutesMinus.TabIndex = 10;
            this.btnMinutesMinus.Text = "-";
            this.btnMinutesMinus.UseVisualStyleBackColor = true;
            this.btnMinutesMinus.Click += new System.EventHandler(this.btnMinutesMinus_Click);
            // 
            // labelCountMinutes
            // 
            this.labelCountMinutes.AutoSize = true;
            this.labelCountMinutes.BackColor = System.Drawing.Color.Transparent;
            this.labelCountMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountMinutes.ForeColor = System.Drawing.Color.LightGray;
            this.labelCountMinutes.Location = new System.Drawing.Point(-2, 27);
            this.labelCountMinutes.Name = "labelCountMinutes";
            this.labelCountMinutes.Size = new System.Drawing.Size(62, 42);
            this.labelCountMinutes.TabIndex = 13;
            this.labelCountMinutes.Text = "00";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnSeccondsPlus);
            this.groupBox9.Controls.Add(this.btnSeccondsMinus);
            this.groupBox9.Controls.Add(this.labelCountSeconds);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox9.Location = new System.Drawing.Point(219, 24);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(98, 91);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Seconds";
            // 
            // btnSeccondsPlus
            // 
            this.btnSeccondsPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeccondsPlus.BackgroundImage")));
            this.btnSeccondsPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeccondsPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeccondsPlus.ForeColor = System.Drawing.Color.Black;
            this.btnSeccondsPlus.Location = new System.Drawing.Point(54, 19);
            this.btnSeccondsPlus.Name = "btnSeccondsPlus";
            this.btnSeccondsPlus.Size = new System.Drawing.Size(37, 28);
            this.btnSeccondsPlus.TabIndex = 11;
            this.btnSeccondsPlus.UseVisualStyleBackColor = true;
            this.btnSeccondsPlus.Click += new System.EventHandler(this.btnSeccondsPlus_Click);
            // 
            // btnSeccondsMinus
            // 
            this.btnSeccondsMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeccondsMinus.BackgroundImage")));
            this.btnSeccondsMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeccondsMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeccondsMinus.ForeColor = System.Drawing.Color.Black;
            this.btnSeccondsMinus.Location = new System.Drawing.Point(54, 53);
            this.btnSeccondsMinus.Name = "btnSeccondsMinus";
            this.btnSeccondsMinus.Size = new System.Drawing.Size(37, 28);
            this.btnSeccondsMinus.TabIndex = 12;
            this.btnSeccondsMinus.Text = "-";
            this.btnSeccondsMinus.UseVisualStyleBackColor = true;
            this.btnSeccondsMinus.Click += new System.EventHandler(this.btnSeccondsMinus_Click);
            // 
            // labelCountSeconds
            // 
            this.labelCountSeconds.AutoSize = true;
            this.labelCountSeconds.BackColor = System.Drawing.Color.Transparent;
            this.labelCountSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountSeconds.ForeColor = System.Drawing.Color.LightGray;
            this.labelCountSeconds.Location = new System.Drawing.Point(-2, 27);
            this.labelCountSeconds.Name = "labelCountSeconds";
            this.labelCountSeconds.Size = new System.Drawing.Size(62, 42);
            this.labelCountSeconds.TabIndex = 5;
            this.labelCountSeconds.Text = "00";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnHoursPlus);
            this.groupBox7.Controls.Add(this.btnHoursMinus);
            this.groupBox7.Controls.Add(this.labelCountHours);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox7.Location = new System.Drawing.Point(7, 24);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(98, 91);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Hours";
            // 
            // btnHoursPlus
            // 
            this.btnHoursPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHoursPlus.BackgroundImage")));
            this.btnHoursPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoursPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoursPlus.ForeColor = System.Drawing.Color.Black;
            this.btnHoursPlus.Location = new System.Drawing.Point(55, 19);
            this.btnHoursPlus.Name = "btnHoursPlus";
            this.btnHoursPlus.Size = new System.Drawing.Size(37, 28);
            this.btnHoursPlus.TabIndex = 7;
            this.btnHoursPlus.UseVisualStyleBackColor = true;
            this.btnHoursPlus.Click += new System.EventHandler(this.btnHoursPlus_Click);
            // 
            // btnHoursMinus
            // 
            this.btnHoursMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHoursMinus.BackgroundImage")));
            this.btnHoursMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoursMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoursMinus.ForeColor = System.Drawing.Color.Black;
            this.btnHoursMinus.Location = new System.Drawing.Point(55, 53);
            this.btnHoursMinus.Name = "btnHoursMinus";
            this.btnHoursMinus.Size = new System.Drawing.Size(37, 28);
            this.btnHoursMinus.TabIndex = 8;
            this.btnHoursMinus.Text = "-";
            this.btnHoursMinus.UseVisualStyleBackColor = true;
            this.btnHoursMinus.Click += new System.EventHandler(this.btnHoursMinus_Click);
            // 
            // labelCountHours
            // 
            this.labelCountHours.AutoSize = true;
            this.labelCountHours.BackColor = System.Drawing.Color.Transparent;
            this.labelCountHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountHours.ForeColor = System.Drawing.Color.LightGray;
            this.labelCountHours.Location = new System.Drawing.Point(-1, 27);
            this.labelCountHours.Name = "labelCountHours";
            this.labelCountHours.Size = new System.Drawing.Size(62, 42);
            this.labelCountHours.TabIndex = 14;
            this.labelCountHours.Text = "00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbCount);
            this.groupBox2.Controls.Add(this.labelTimeRemaining);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(339, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time Remaining";
            // 
            // pbCount
            // 
            this.pbCount.Location = new System.Drawing.Point(8, 140);
            this.pbCount.Name = "pbCount";
            this.pbCount.Size = new System.Drawing.Size(284, 23);
            this.pbCount.TabIndex = 2;
            // 
            // labelTimeRemaining
            // 
            this.labelTimeRemaining.AutoSize = true;
            this.labelTimeRemaining.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeRemaining.ForeColor = System.Drawing.Color.Lime;
            this.labelTimeRemaining.Location = new System.Drawing.Point(5, 48);
            this.labelTimeRemaining.Name = "labelTimeRemaining";
            this.labelTimeRemaining.Size = new System.Drawing.Size(292, 73);
            this.labelTimeRemaining.TabIndex = 1;
            this.labelTimeRemaining.Text = "00:00:00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelCurrentTime);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox3.Location = new System.Drawing.Point(645, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 174);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Time";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTime.ForeColor = System.Drawing.Color.LightGray;
            this.labelCurrentTime.Location = new System.Drawing.Point(6, 48);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(292, 73);
            this.labelCurrentTime.TabIndex = 0;
            this.labelCurrentTime.Text = "00:00:00";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbHideProgress);
            this.groupBox5.Controls.Add(this.cbHideClock);
            this.groupBox5.Controls.Add(this.cbShowTest);
            this.groupBox5.Controls.Add(this.cbHideOutput);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox5.Location = new System.Drawing.Point(645, 216);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 181);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controls";
            // 
            // cbHideProgress
            // 
            this.cbHideProgress.AutoSize = true;
            this.cbHideProgress.Location = new System.Drawing.Point(7, 70);
            this.cbHideProgress.Name = "cbHideProgress";
            this.cbHideProgress.Size = new System.Drawing.Size(127, 20);
            this.cbHideProgress.TabIndex = 3;
            this.cbHideProgress.Text = "Hide Progress";
            this.cbHideProgress.UseVisualStyleBackColor = true;
            this.cbHideProgress.CheckedChanged += new System.EventHandler(this.cbHideProgress_CheckedChanged);
            // 
            // cbHideClock
            // 
            this.cbHideClock.AutoSize = true;
            this.cbHideClock.Location = new System.Drawing.Point(7, 46);
            this.cbHideClock.Name = "cbHideClock";
            this.cbHideClock.Size = new System.Drawing.Size(103, 20);
            this.cbHideClock.TabIndex = 2;
            this.cbHideClock.Text = "Hide Clock";
            this.cbHideClock.UseVisualStyleBackColor = true;
            this.cbHideClock.CheckedChanged += new System.EventHandler(this.cbHideClock_CheckedChanged);
            // 
            // cbShowTest
            // 
            this.cbShowTest.AutoSize = true;
            this.cbShowTest.Location = new System.Drawing.Point(7, 154);
            this.cbShowTest.Name = "cbShowTest";
            this.cbShowTest.Size = new System.Drawing.Size(146, 20);
            this.cbShowTest.TabIndex = 1;
            this.cbShowTest.Text = "Show Test Image";
            this.cbShowTest.UseVisualStyleBackColor = true;
            this.cbShowTest.CheckedChanged += new System.EventHandler(this.cbShowTest_CheckedChanged);
            // 
            // cbHideOutput
            // 
            this.cbHideOutput.AutoSize = true;
            this.cbHideOutput.Location = new System.Drawing.Point(7, 22);
            this.cbHideOutput.Name = "cbHideOutput";
            this.cbHideOutput.Size = new System.Drawing.Size(108, 20);
            this.cbHideOutput.TabIndex = 0;
            this.cbHideOutput.Text = "Hide Output";
            this.cbHideOutput.UseVisualStyleBackColor = true;
            this.cbHideOutput.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(339, 222);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(146, 175);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(493, 222);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(146, 175);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // timerCurrentTime
            // 
            this.timerCurrentTime.Interval = 1000;
            this.timerCurrentTime.Tick += new System.EventHandler(this.timerCurrentTime_Tick);
            // 
            // rtbMsg
            // 
            this.rtbMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMsg.ForeColor = System.Drawing.Color.White;
            this.rtbMsg.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.rtbMsg.Location = new System.Drawing.Point(6, 19);
            this.rtbMsg.MaxLength = 100;
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(806, 22);
            this.rtbMsg.TabIndex = 5;
            this.rtbMsg.Text = "";
            this.rtbMsg.TextChanged += new System.EventHandler(this.rtbMsg_TextChanged);
            // 
            // btnMsg
            // 
            this.btnMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMsg.Location = new System.Drawing.Point(821, 12);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(111, 34);
            this.btnMsg.TabIndex = 6;
            this.btnMsg.Text = "Send";
            this.btnMsg.UseVisualStyleBackColor = true;
            this.btnMsg.Click += new System.EventHandler(this.btnMsg_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rtbMsg);
            this.groupBox6.Controls.Add(this.btnMsg);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox6.Location = new System.Drawing.Point(9, 403);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(936, 52);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Send Message";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnPreset12);
            this.groupBox10.Controls.Add(this.btnPreset9);
            this.groupBox10.Controls.Add(this.btnPreset6);
            this.groupBox10.Controls.Add(this.btnPreset3);
            this.groupBox10.Controls.Add(this.btnPreset11);
            this.groupBox10.Controls.Add(this.btnPreset8);
            this.groupBox10.Controls.Add(this.btnPreset5);
            this.groupBox10.Controls.Add(this.btnPreset2);
            this.groupBox10.Controls.Add(this.btnPreset10);
            this.groupBox10.Controls.Add(this.btnPreset7);
            this.groupBox10.Controls.Add(this.btnPreset4);
            this.groupBox10.Controls.Add(this.btnPreset1);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox10.Location = new System.Drawing.Point(9, 175);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(324, 222);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Presets";
            // 
            // btnPreset12
            // 
            this.btnPreset12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset12.Location = new System.Drawing.Point(219, 176);
            this.btnPreset12.Name = "btnPreset12";
            this.btnPreset12.Size = new System.Drawing.Size(98, 37);
            this.btnPreset12.TabIndex = 19;
            this.btnPreset12.Text = "00:00:00";
            this.btnPreset12.UseVisualStyleBackColor = true;
            this.btnPreset12.Click += new System.EventHandler(this.btnPreset12_Click);
            // 
            // btnPreset9
            // 
            this.btnPreset9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset9.Location = new System.Drawing.Point(219, 131);
            this.btnPreset9.Name = "btnPreset9";
            this.btnPreset9.Size = new System.Drawing.Size(98, 37);
            this.btnPreset9.TabIndex = 18;
            this.btnPreset9.Text = "00:00:00";
            this.btnPreset9.UseVisualStyleBackColor = true;
            this.btnPreset9.Click += new System.EventHandler(this.btnPreset9_Click);
            // 
            // btnPreset6
            // 
            this.btnPreset6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset6.Location = new System.Drawing.Point(219, 86);
            this.btnPreset6.Name = "btnPreset6";
            this.btnPreset6.Size = new System.Drawing.Size(98, 37);
            this.btnPreset6.TabIndex = 17;
            this.btnPreset6.Text = "00:00:00";
            this.btnPreset6.UseVisualStyleBackColor = true;
            this.btnPreset6.Click += new System.EventHandler(this.btnPreset6_Click);
            // 
            // btnPreset3
            // 
            this.btnPreset3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset3.Location = new System.Drawing.Point(219, 41);
            this.btnPreset3.Name = "btnPreset3";
            this.btnPreset3.Size = new System.Drawing.Size(98, 37);
            this.btnPreset3.TabIndex = 16;
            this.btnPreset3.Text = "00:00:00";
            this.btnPreset3.UseVisualStyleBackColor = true;
            this.btnPreset3.Click += new System.EventHandler(this.btnPreset3_Click);
            // 
            // btnPreset11
            // 
            this.btnPreset11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset11.Location = new System.Drawing.Point(113, 176);
            this.btnPreset11.Name = "btnPreset11";
            this.btnPreset11.Size = new System.Drawing.Size(98, 37);
            this.btnPreset11.TabIndex = 15;
            this.btnPreset11.Text = "00:00:00";
            this.btnPreset11.UseVisualStyleBackColor = true;
            this.btnPreset11.Click += new System.EventHandler(this.btnPreset11_Click);
            // 
            // btnPreset8
            // 
            this.btnPreset8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset8.Location = new System.Drawing.Point(113, 131);
            this.btnPreset8.Name = "btnPreset8";
            this.btnPreset8.Size = new System.Drawing.Size(98, 37);
            this.btnPreset8.TabIndex = 14;
            this.btnPreset8.Text = "00:00:00";
            this.btnPreset8.UseVisualStyleBackColor = true;
            this.btnPreset8.Click += new System.EventHandler(this.btnPreset8_Click);
            // 
            // btnPreset5
            // 
            this.btnPreset5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset5.Location = new System.Drawing.Point(113, 86);
            this.btnPreset5.Name = "btnPreset5";
            this.btnPreset5.Size = new System.Drawing.Size(98, 37);
            this.btnPreset5.TabIndex = 13;
            this.btnPreset5.Text = "00:00:00";
            this.btnPreset5.UseVisualStyleBackColor = true;
            this.btnPreset5.Click += new System.EventHandler(this.btnPreset5_Click);
            // 
            // btnPreset2
            // 
            this.btnPreset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset2.Location = new System.Drawing.Point(113, 41);
            this.btnPreset2.Name = "btnPreset2";
            this.btnPreset2.Size = new System.Drawing.Size(98, 37);
            this.btnPreset2.TabIndex = 12;
            this.btnPreset2.Text = "00:00:00";
            this.btnPreset2.UseVisualStyleBackColor = true;
            this.btnPreset2.Click += new System.EventHandler(this.btnPreset2_Click);
            // 
            // btnPreset10
            // 
            this.btnPreset10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset10.Location = new System.Drawing.Point(7, 176);
            this.btnPreset10.Name = "btnPreset10";
            this.btnPreset10.Size = new System.Drawing.Size(98, 37);
            this.btnPreset10.TabIndex = 11;
            this.btnPreset10.Text = "00:00:00";
            this.btnPreset10.UseVisualStyleBackColor = true;
            this.btnPreset10.Click += new System.EventHandler(this.btnPreset10_Click);
            // 
            // btnPreset7
            // 
            this.btnPreset7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset7.Location = new System.Drawing.Point(7, 131);
            this.btnPreset7.Name = "btnPreset7";
            this.btnPreset7.Size = new System.Drawing.Size(98, 37);
            this.btnPreset7.TabIndex = 10;
            this.btnPreset7.Text = "00:00:00";
            this.btnPreset7.UseVisualStyleBackColor = true;
            this.btnPreset7.Click += new System.EventHandler(this.btnPreset7_Click);
            // 
            // btnPreset4
            // 
            this.btnPreset4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset4.Location = new System.Drawing.Point(7, 86);
            this.btnPreset4.Name = "btnPreset4";
            this.btnPreset4.Size = new System.Drawing.Size(98, 37);
            this.btnPreset4.TabIndex = 9;
            this.btnPreset4.Text = "00:00:00";
            this.btnPreset4.UseVisualStyleBackColor = true;
            this.btnPreset4.Click += new System.EventHandler(this.btnPreset4_Click);
            // 
            // btnPreset1
            // 
            this.btnPreset1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset1.Location = new System.Drawing.Point(7, 41);
            this.btnPreset1.Name = "btnPreset1";
            this.btnPreset1.Size = new System.Drawing.Size(98, 37);
            this.btnPreset1.TabIndex = 0;
            this.btnPreset1.Text = "00:00:00";
            this.btnPreset1.UseVisualStyleBackColor = true;
            this.btnPreset1.Click += new System.EventHandler(this.btnPreset1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(67, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "CTRL + Click to set preset";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.linkLbl);
            this.panel1.Location = new System.Drawing.Point(-8, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 32);
            this.panel1.TabIndex = 6;
            // 
            // linkLbl
            // 
            this.linkLbl.AutoSize = true;
            this.linkLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLbl.Location = new System.Drawing.Point(793, 7);
            this.linkLbl.Name = "linkLbl";
            this.linkLbl.Size = new System.Drawing.Size(160, 13);
            this.linkLbl.TabIndex = 8;
            this.linkLbl.TabStop = true;
            this.linkLbl.Text = "https://www.goranmargetic.com";
            this.linkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.loadDefaultSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            // 
            // loadDefaultSettingsToolStripMenuItem
            // 
            this.loadDefaultSettingsToolStripMenuItem.Name = "loadDefaultSettingsToolStripMenuItem";
            this.loadDefaultSettingsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.loadDefaultSettingsToolStripMenuItem.Text = "Load Default Settings";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(956, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countdown - www.GoranMargetic.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labelTimeRemaining;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Timer timerCurrentTime;
        private System.Windows.Forms.ProgressBar pbCount;
        private System.Windows.Forms.RichTextBox rtbMsg;
        private System.Windows.Forms.Button btnMsg;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSeccondsPlus;
        private System.Windows.Forms.Button btnSeccondsMinus;
        private System.Windows.Forms.Button btnHoursPlus;
        private System.Windows.Forms.Button btnHoursMinus;
        private System.Windows.Forms.Button btnMinutesPlus;
        private System.Windows.Forms.Button btnMinutesMinus;
        private System.Windows.Forms.Label labelCountSeconds;
        private System.Windows.Forms.Label labelCountHours;
        private System.Windows.Forms.Label labelCountMinutes;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnPreset12;
        private System.Windows.Forms.Button btnPreset9;
        private System.Windows.Forms.Button btnPreset6;
        private System.Windows.Forms.Button btnPreset3;
        private System.Windows.Forms.Button btnPreset11;
        private System.Windows.Forms.Button btnPreset8;
        private System.Windows.Forms.Button btnPreset5;
        private System.Windows.Forms.Button btnPreset2;
        private System.Windows.Forms.Button btnPreset10;
        private System.Windows.Forms.Button btnPreset7;
        private System.Windows.Forms.Button btnPreset4;
        private System.Windows.Forms.Button btnPreset1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadDefaultSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLbl;
        private System.Windows.Forms.CheckBox cbHideClock;
        private System.Windows.Forms.CheckBox cbShowTest;
        private System.Windows.Forms.CheckBox cbHideOutput;
        private System.Windows.Forms.CheckBox cbHideProgress;
    }
}

