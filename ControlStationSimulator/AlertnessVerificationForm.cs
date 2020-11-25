using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlStationSimulator
{
    public partial class AlertnessVerificationForm : Form
    {
        private int timeCounter = 0;
        SoundPlayer audio = new SoundPlayer(Properties.Resources.alert_sound);

        public AlertnessVerificationForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void timerAlert_Tick(object sender, EventArgs e)
        {
            timeCounter++;
            timerLabel.Text = (30 - timeCounter).ToString();

            if (timeCounter >= 30)
            {
                Application.Exit();
            }
        }

        private void alertButton_Click(object sender, EventArgs e)
        {
            Program.alertOpened = false;
            ControlStationForm.setTimeCounter(0);
            stopAudio();
            this.Close();
        }

        private void AlertnessVerificationForm_Load(object sender, EventArgs e)
        {
            playAudio();
        }

        private void playAudio() 
        {
            if(Program.alertOpened)
            {
                audio.Play();
            }
        }

        private void stopAudio()
        {
            audio.Stop();
        }

        private void AlertnessVerificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.alertOpened = false;
            ControlStationForm.setTimeCounter(0);
            stopAudio();
        }
    }
}