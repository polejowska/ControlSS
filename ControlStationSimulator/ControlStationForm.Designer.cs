namespace ControlStationSimulator
{
    partial class ControlStationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlStationForm));
            this.runFansButton = new System.Windows.Forms.Button();
            this.warningsTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.core1TempLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.core1UsageLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.core2TempLabel = new System.Windows.Forms.Label();
            this.runExtraFans2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.core2UsageLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.core3TempLabel = new System.Windows.Forms.Label();
            this.runExtraFans3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.core3UsageLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.randomAccident = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.fanSpeedLabel = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.coreTempTimer = new System.Windows.Forms.Timer(this.components);
            this.coreUsageTimer = new System.Windows.Forms.Timer(this.components);
            this.fansSpeedTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.core4TempLabel = new System.Windows.Forms.Label();
            this.runExtraFans4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.core4UsageLabel = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.riseTemperatureTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // runFansButton
            // 
            this.runFansButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.runFansButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runFansButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runFansButton.Location = new System.Drawing.Point(8, 23);
            this.runFansButton.Margin = new System.Windows.Forms.Padding(4);
            this.runFansButton.Name = "runFansButton";
            this.runFansButton.Size = new System.Drawing.Size(151, 89);
            this.runFansButton.TabIndex = 0;
            this.runFansButton.TabStop = false;
            this.runFansButton.Text = "RUN EXTRA FANS";
            this.runFansButton.UseVisualStyleBackColor = false;
            this.runFansButton.Click += new System.EventHandler(this.runFansButton_Click);
            // 
            // warningsTimer
            // 
            this.warningsTimer.Enabled = true;
            this.warningsTimer.Interval = 1000;
            this.warningsTimer.Tick += new System.EventHandler(this.warningsTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU #1 Core Temperature";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.core1TempLabel);
            this.groupBox1.Controls.Add(this.runFansButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(59, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1";
            // 
            // core1TempLabel
            // 
            this.core1TempLabel.AutoSize = true;
            this.core1TempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core1TempLabel.ForeColor = System.Drawing.Color.Green;
            this.core1TempLabel.Location = new System.Drawing.Point(219, 87);
            this.core1TempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.core1TempLabel.Name = "core1TempLabel";
            this.core1TempLabel.Size = new System.Drawing.Size(108, 25);
            this.core1TempLabel.TabIndex = 2;
            this.core1TempLabel.Text = "NORMAL: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.core1UsageLabel);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(616, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(484, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1";
            // 
            // core1UsageLabel
            // 
            this.core1UsageLabel.AutoSize = true;
            this.core1UsageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core1UsageLabel.ForeColor = System.Drawing.Color.Green;
            this.core1UsageLabel.Location = new System.Drawing.Point(219, 87);
            this.core1UsageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.core1UsageLabel.Name = "core1UsageLabel";
            this.core1UsageLabel.Size = new System.Drawing.Size(97, 25);
            this.core1UsageLabel.TabIndex = 2;
            this.core1UsageLabel.Text = "NORMAL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 89);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "REDUCE USAGE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "CPU #1 Core Usage";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.core2TempLabel);
            this.groupBox3.Controls.Add(this.runExtraFans2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(59, 158);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(484, 123);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2";
            // 
            // core2TempLabel
            // 
            this.core2TempLabel.AutoSize = true;
            this.core2TempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core2TempLabel.ForeColor = System.Drawing.Color.Green;
            this.core2TempLabel.Location = new System.Drawing.Point(219, 87);
            this.core2TempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.core2TempLabel.Name = "core2TempLabel";
            this.core2TempLabel.Size = new System.Drawing.Size(97, 25);
            this.core2TempLabel.TabIndex = 2;
            this.core2TempLabel.Text = "NORMAL";
            // 
            // runExtraFans2
            // 
            this.runExtraFans2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.runExtraFans2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runExtraFans2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runExtraFans2.Location = new System.Drawing.Point(8, 23);
            this.runExtraFans2.Margin = new System.Windows.Forms.Padding(4);
            this.runExtraFans2.Name = "runExtraFans2";
            this.runExtraFans2.Size = new System.Drawing.Size(151, 89);
            this.runExtraFans2.TabIndex = 0;
            this.runExtraFans2.TabStop = false;
            this.runExtraFans2.Text = "RUN EXTRA FANS";
            this.runExtraFans2.UseVisualStyleBackColor = false;
            this.runExtraFans2.Click += new System.EventHandler(this.runExtraFans2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "CPU #2 Core Temperature";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.core2UsageLabel);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(616, 158);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(484, 123);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "2";
            // 
            // core2UsageLabel
            // 
            this.core2UsageLabel.AutoSize = true;
            this.core2UsageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core2UsageLabel.ForeColor = System.Drawing.Color.Green;
            this.core2UsageLabel.Location = new System.Drawing.Point(219, 87);
            this.core2UsageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.core2UsageLabel.Name = "core2UsageLabel";
            this.core2UsageLabel.Size = new System.Drawing.Size(97, 25);
            this.core2UsageLabel.TabIndex = 2;
            this.core2UsageLabel.Text = "NORMAL";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(8, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 89);
            this.button3.TabIndex = 0;
            this.button3.TabStop = false;
            this.button3.Text = "REDUCE USAGE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(219, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "CPU #2 Core Usage";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.core3TempLabel);
            this.groupBox5.Controls.Add(this.runExtraFans3);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(59, 289);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(484, 123);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "3";
            // 
            // core3TempLabel
            // 
            this.core3TempLabel.AutoSize = true;
            this.core3TempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core3TempLabel.ForeColor = System.Drawing.Color.Green;
            this.core3TempLabel.Location = new System.Drawing.Point(219, 87);
            this.core3TempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.core3TempLabel.Name = "core3TempLabel";
            this.core3TempLabel.Size = new System.Drawing.Size(97, 25);
            this.core3TempLabel.TabIndex = 2;
            this.core3TempLabel.Text = "NORMAL";
            // 
            // runExtraFans3
            // 
            this.runExtraFans3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.runExtraFans3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runExtraFans3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runExtraFans3.Location = new System.Drawing.Point(8, 23);
            this.runExtraFans3.Margin = new System.Windows.Forms.Padding(4);
            this.runExtraFans3.Name = "runExtraFans3";
            this.runExtraFans3.Size = new System.Drawing.Size(151, 89);
            this.runExtraFans3.TabIndex = 0;
            this.runExtraFans3.TabStop = false;
            this.runExtraFans3.Text = "RUN EXTRA FANS";
            this.runExtraFans3.UseVisualStyleBackColor = false;
            this.runExtraFans3.Click += new System.EventHandler(this.runExtraFans3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(219, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(246, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "CPU #3 Core Temperature";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.core3UsageLabel);
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(616, 289);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(484, 123);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "3";
            // 
            // core3UsageLabel
            // 
            this.core3UsageLabel.AutoSize = true;
            this.core3UsageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core3UsageLabel.ForeColor = System.Drawing.Color.Green;
            this.core3UsageLabel.Location = new System.Drawing.Point(219, 87);
            this.core3UsageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.core3UsageLabel.Name = "core3UsageLabel";
            this.core3UsageLabel.Size = new System.Drawing.Size(97, 25);
            this.core3UsageLabel.TabIndex = 2;
            this.core3UsageLabel.Text = "NORMAL";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(8, 23);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 89);
            this.button5.TabIndex = 0;
            this.button5.TabStop = false;
            this.button5.Text = "REDUCE USAGE";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(219, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "CPU #3 Core Usage";
            // 
            // randomAccident
            // 
            this.randomAccident.BackColor = System.Drawing.Color.DarkRed;
            this.randomAccident.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.randomAccident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomAccident.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.randomAccident.Location = new System.Drawing.Point(59, 574);
            this.randomAccident.Margin = new System.Windows.Forms.Padding(4);
            this.randomAccident.Name = "randomAccident";
            this.randomAccident.Size = new System.Drawing.Size(151, 89);
            this.randomAccident.TabIndex = 8;
            this.randomAccident.TabStop = false;
            this.randomAccident.Text = "CHANGE RANDOM PARAMETERS";
            this.randomAccident.UseVisualStyleBackColor = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.fanSpeedLabel);
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Location = new System.Drawing.Point(616, 563);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(484, 123);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "FANS SPEED";
            // 
            // fanSpeedLabel
            // 
            this.fanSpeedLabel.AutoSize = true;
            this.fanSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fanSpeedLabel.ForeColor = System.Drawing.Color.Green;
            this.fanSpeedLabel.Location = new System.Drawing.Point(219, 87);
            this.fanSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fanSpeedLabel.Name = "fanSpeedLabel";
            this.fanSpeedLabel.Size = new System.Drawing.Size(97, 25);
            this.fanSpeedLabel.TabIndex = 2;
            this.fanSpeedLabel.Text = "NORMAL";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(8, 23);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 89);
            this.button6.TabIndex = 0;
            this.button6.TabStop = false;
            this.button6.Text = "REDUCE SPEED";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(219, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "FANS SPEED";
            // 
            // coreTempTimer
            // 
            this.coreTempTimer.Enabled = true;
            this.coreTempTimer.Interval = 750;
            this.coreTempTimer.Tick += new System.EventHandler(this.coreTempTimer_Tick);
            // 
            // coreUsageTimer
            // 
            this.coreUsageTimer.Enabled = true;
            this.coreUsageTimer.Interval = 1000;
            this.coreUsageTimer.Tick += new System.EventHandler(this.coreUsageTimer_Tick);
            // 
            // fansSpeedTimer
            // 
            this.fansSpeedTimer.Enabled = true;
            this.fansSpeedTimer.Interval = 1200;
            this.fansSpeedTimer.Tick += new System.EventHandler(this.fansSpeedTimer_Tick);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.core4TempLabel);
            this.groupBox8.Controls.Add(this.runExtraFans4);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Location = new System.Drawing.Point(59, 420);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(484, 123);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "4";
            // 
            // core4TempLabel
            // 
            this.core4TempLabel.AutoSize = true;
            this.core4TempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core4TempLabel.ForeColor = System.Drawing.Color.Green;
            this.core4TempLabel.Location = new System.Drawing.Point(219, 87);
            this.core4TempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.core4TempLabel.Name = "core4TempLabel";
            this.core4TempLabel.Size = new System.Drawing.Size(97, 25);
            this.core4TempLabel.TabIndex = 2;
            this.core4TempLabel.Text = "NORMAL";
            // 
            // runExtraFans4
            // 
            this.runExtraFans4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.runExtraFans4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runExtraFans4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runExtraFans4.Location = new System.Drawing.Point(8, 23);
            this.runExtraFans4.Margin = new System.Windows.Forms.Padding(4);
            this.runExtraFans4.Name = "runExtraFans4";
            this.runExtraFans4.Size = new System.Drawing.Size(151, 89);
            this.runExtraFans4.TabIndex = 0;
            this.runExtraFans4.TabStop = false;
            this.runExtraFans4.Text = "RUN EXTRA FANS";
            this.runExtraFans4.UseVisualStyleBackColor = false;
            this.runExtraFans4.Click += new System.EventHandler(this.runExtraFans4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(219, 23);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(246, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "CPU #4 Core Temperature";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.core4UsageLabel);
            this.groupBox9.Controls.Add(this.button8);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Location = new System.Drawing.Point(616, 420);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox9.Size = new System.Drawing.Size(484, 123);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "3";
            // 
            // core4UsageLabel
            // 
            this.core4UsageLabel.AutoSize = true;
            this.core4UsageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core4UsageLabel.ForeColor = System.Drawing.Color.Green;
            this.core4UsageLabel.Location = new System.Drawing.Point(219, 87);
            this.core4UsageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.core4UsageLabel.Name = "core4UsageLabel";
            this.core4UsageLabel.Size = new System.Drawing.Size(97, 25);
            this.core4UsageLabel.TabIndex = 2;
            this.core4UsageLabel.Text = "NORMAL";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(8, 23);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(151, 89);
            this.button8.TabIndex = 0;
            this.button8.TabStop = false;
            this.button8.Text = "REDUCE USAGE";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(219, 23);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(191, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "CPU #4 Core Usage";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkRed;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(224, 574);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(151, 89);
            this.button9.TabIndex = 12;
            this.button9.TabStop = false;
            this.button9.Text = "CHANGE RANDOM PARAMETERS";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkRed;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Location = new System.Drawing.Point(392, 574);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(151, 89);
            this.button10.TabIndex = 13;
            this.button10.TabStop = false;
            this.button10.Text = "CHANGE RANDOM PARAMETERS";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // riseTemperatureTimer
            // 
            this.riseTemperatureTimer.Interval = 1200;
            this.riseTemperatureTimer.Tick += new System.EventHandler(this.riseTemperatureTimer_Tick);
            // 
            // ControlStationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 713);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.randomAccident);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ControlStationForm";
            this.Text = "Control Station Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button runFansButton;
        private System.Windows.Forms.Timer warningsTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label core1TempLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label core1UsageLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label core2TempLabel;
        private System.Windows.Forms.Button runExtraFans2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label core2UsageLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label core3TempLabel;
        private System.Windows.Forms.Button runExtraFans3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label core3UsageLabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button randomAccident;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label fanSpeedLabel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer coreTempTimer;
        private System.Windows.Forms.Timer coreUsageTimer;
        private System.Windows.Forms.Timer fansSpeedTimer;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label core4TempLabel;
        private System.Windows.Forms.Button runExtraFans4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label core4UsageLabel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Timer riseTemperatureTimer;
    }
}

