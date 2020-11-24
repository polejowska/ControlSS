namespace ControlStationSimulator
{
    partial class VerifyAlertnessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyAlertnessForm));
            this.alertButton = new System.Windows.Forms.Button();
            this.alertLabel = new System.Windows.Forms.Label();
            this.alertLabel2 = new System.Windows.Forms.Label();
            this.timerAlert = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alertButton
            // 
            this.alertButton.BackColor = System.Drawing.Color.Black;
            this.alertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.alertButton.Location = new System.Drawing.Point(163, 229);
            this.alertButton.Name = "alertButton";
            this.alertButton.Size = new System.Drawing.Size(252, 41);
            this.alertButton.TabIndex = 4;
            this.alertButton.Text = "OK";
            this.alertButton.UseVisualStyleBackColor = false;
            this.alertButton.Click += new System.EventHandler(this.alertButton_Click);
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertLabel.ForeColor = System.Drawing.Color.Crimson;
            this.alertLabel.Location = new System.Drawing.Point(157, 62);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(288, 31);
            this.alertLabel.TabIndex = 5;
            this.alertLabel.Text = "Alertness verification";
            // 
            // alertLabel2
            // 
            this.alertLabel2.AutoSize = true;
            this.alertLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertLabel2.Location = new System.Drawing.Point(125, 124);
            this.alertLabel2.Name = "alertLabel2";
            this.alertLabel2.Size = new System.Drawing.Size(344, 29);
            this.alertLabel2.TabIndex = 6;
            this.alertLabel2.Text = "Click \"OK\" to confirm alertness.";
            // 
            // timerAlert
            // 
            this.timerAlert.Enabled = true;
            this.timerAlert.Interval = 1000;
            this.timerAlert.Tick += new System.EventHandler(this.timerAlert_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.Red;
            this.timerLabel.Location = new System.Drawing.Point(271, 168);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(39, 29);
            this.timerLabel.TabIndex = 7;
            this.timerLabel.Text = "30";
            // 
            // VerifyAlertnessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.alertLabel2);
            this.Controls.Add(this.alertLabel);
            this.Controls.Add(this.alertButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerifyAlertnessForm";
            this.Text = "Warning | Alertness verification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button alertButton;
        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.Label alertLabel2;
        private System.Windows.Forms.Timer timerAlert;
        private System.Windows.Forms.Label timerLabel;
    }
}