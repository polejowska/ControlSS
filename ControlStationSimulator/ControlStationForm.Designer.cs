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
            this.usage1Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.core2TempLabel = new System.Windows.Forms.Label();
            this.runExtraFans2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.core2UsageLabel = new System.Windows.Forms.Label();
            this.usage2Button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.core3TempLabel = new System.Windows.Forms.Label();
            this.runExtraFans3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.core3UsageLabel = new System.Windows.Forms.Label();
            this.usage3Button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.randomAccident = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.fanSpeedLabel = new System.Windows.Forms.Label();
            this.fansSpeedButton = new System.Windows.Forms.Button();
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
            this.usage4Button = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.stopProcesses = new System.Windows.Forms.Button();
            this.riseTemperatureTimer = new System.Windows.Forms.Timer(this.components);
            this.systemDestroyedTimer = new System.Windows.Forms.Timer(this.components);
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
            this.groupBox2.Controls.Add(this.usage1Button);
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
            // usage1Button
            // 
            this.usage1Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usage1Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usage1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usage1Button.Location = new System.Drawing.Point(8, 23);
            this.usage1Button.Margin = new System.Windows.Forms.Padding(4);
            this.usage1Button.Name = "usage1Button";
            this.usage1Button.Size = new System.Drawing.Size(151, 89);
            this.usage1Button.TabIndex = 0;
            this.usage1Button.TabStop = false;
            this.usage1Button.Text = "REDUCE USAGE";
            this.usage1Button.UseVisualStyleBackColor = false;
            this.usage1Button.Click += new System.EventHandler(this.usage1Button_Click);
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
            this.groupBox4.Controls.Add(this.usage2Button);
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
            // usage2Button
            // 
            this.usage2Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usage2Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usage2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usage2Button.Location = new System.Drawing.Point(8, 23);
            this.usage2Button.Margin = new System.Windows.Forms.Padding(4);
            this.usage2Button.Name = "usage2Button";
            this.usage2Button.Size = new System.Drawing.Size(151, 89);
            this.usage2Button.TabIndex = 0;
            this.usage2Button.TabStop = false;
            this.usage2Button.Text = "REDUCE USAGE";
            this.usage2Button.UseVisualStyleBackColor = false;
            this.usage2Button.Click += new System.EventHandler(this.usage2Button_Click);
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
            this.groupBox6.Controls.Add(this.usage3Button);
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
            // usage3Button
            // 
            this.usage3Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usage3Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usage3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usage3Button.Location = new System.Drawing.Point(8, 23);
            this.usage3Button.Margin = new System.Windows.Forms.Padding(4);
            this.usage3Button.Name = "usage3Button";
            this.usage3Button.Size = new System.Drawing.Size(151, 89);
            this.usage3Button.TabIndex = 0;
            this.usage3Button.TabStop = false;
            this.usage3Button.Text = "REDUCE USAGE";
            this.usage3Button.UseVisualStyleBackColor = false;
            this.usage3Button.Click += new System.EventHandler(this.usage3Button_Click);
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
            this.randomAccident.Size = new System.Drawing.Size(224, 89);
            this.randomAccident.TabIndex = 8;
            this.randomAccident.TabStop = false;
            this.randomAccident.Text = "CHANGE RANDOM PARAMETERS";
            this.randomAccident.UseVisualStyleBackColor = false;
            this.randomAccident.Click += new System.EventHandler(this.randomAccident_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.fanSpeedLabel);
            this.groupBox7.Controls.Add(this.fansSpeedButton);
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
            this.fanSpeedLabel.Size = new System.Drawing.Size(0, 25);
            this.fanSpeedLabel.TabIndex = 2;
            // 
            // fansSpeedButton
            // 
            this.fansSpeedButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fansSpeedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fansSpeedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fansSpeedButton.Location = new System.Drawing.Point(8, 23);
            this.fansSpeedButton.Margin = new System.Windows.Forms.Padding(4);
            this.fansSpeedButton.Name = "fansSpeedButton";
            this.fansSpeedButton.Size = new System.Drawing.Size(151, 89);
            this.fansSpeedButton.TabIndex = 0;
            this.fansSpeedButton.TabStop = false;
            this.fansSpeedButton.Text = "REDUCE SPEED";
            this.fansSpeedButton.UseVisualStyleBackColor = false;
            this.fansSpeedButton.Click += new System.EventHandler(this.fansSpeedButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(219, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "MAIN FANS SPEED";
            // 
            // coreTempTimer
            // 
            this.coreTempTimer.Enabled = true;
            this.coreTempTimer.Interval = 1500;
            this.coreTempTimer.Tick += new System.EventHandler(this.coreTempTimer_Tick);
            // 
            // coreUsageTimer
            // 
            this.coreUsageTimer.Enabled = true;
            this.coreUsageTimer.Interval = 1200;
            this.coreUsageTimer.Tick += new System.EventHandler(this.coreUsageTimer_Tick);
            // 
            // fansSpeedTimer
            // 
            this.fansSpeedTimer.Enabled = true;
            this.fansSpeedTimer.Interval = 2500;
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
            this.groupBox9.Controls.Add(this.usage4Button);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Location = new System.Drawing.Point(616, 420);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox9.Size = new System.Drawing.Size(484, 123);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "4";
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
            // usage4Button
            // 
            this.usage4Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usage4Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usage4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usage4Button.Location = new System.Drawing.Point(8, 23);
            this.usage4Button.Margin = new System.Windows.Forms.Padding(4);
            this.usage4Button.Name = "usage4Button";
            this.usage4Button.Size = new System.Drawing.Size(151, 89);
            this.usage4Button.TabIndex = 0;
            this.usage4Button.TabStop = false;
            this.usage4Button.Text = "REDUCE USAGE";
            this.usage4Button.UseVisualStyleBackColor = false;
            this.usage4Button.Click += new System.EventHandler(this.usage4Button_Click);
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
            // stopProcesses
            // 
            this.stopProcesses.BackColor = System.Drawing.Color.Black;
            this.stopProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopProcesses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopProcesses.Location = new System.Drawing.Point(319, 574);
            this.stopProcesses.Margin = new System.Windows.Forms.Padding(4);
            this.stopProcesses.Name = "stopProcesses";
            this.stopProcesses.Size = new System.Drawing.Size(224, 89);
            this.stopProcesses.TabIndex = 13;
            this.stopProcesses.TabStop = false;
            this.stopProcesses.Text = "STOP ALL RUNNING PROCESSES AND EXIT";
            this.stopProcesses.UseVisualStyleBackColor = false;
            this.stopProcesses.Click += new System.EventHandler(this.stopProcesses_Click);
            // 
            // riseTemperatureTimer
            // 
            this.riseTemperatureTimer.Interval = 1500;
            this.riseTemperatureTimer.Tick += new System.EventHandler(this.riseTemperatureTimer_Tick);
            // 
            // systemDestroyedTimer
            // 
            this.systemDestroyedTimer.Enabled = true;
            this.systemDestroyedTimer.Interval = 1000;
            this.systemDestroyedTimer.Tick += new System.EventHandler(this.systemDestroyedTimer_Tick);
            // 
            // ControlStationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 713);
            this.Controls.Add(this.stopProcesses);
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
        private System.Windows.Forms.Button usage1Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label core2TempLabel;
        private System.Windows.Forms.Button runExtraFans2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label core2UsageLabel;
        private System.Windows.Forms.Button usage2Button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label core3TempLabel;
        private System.Windows.Forms.Button runExtraFans3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label core3UsageLabel;
        private System.Windows.Forms.Button usage3Button;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button randomAccident;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label fanSpeedLabel;
        private System.Windows.Forms.Button fansSpeedButton;
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
        private System.Windows.Forms.Button usage4Button;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button stopProcesses;
        private System.Windows.Forms.Timer riseTemperatureTimer;
        private System.Windows.Forms.Timer systemDestroyedTimer;
    }
}

