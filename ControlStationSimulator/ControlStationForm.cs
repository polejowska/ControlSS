using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlStationSimulator
{
    public partial class ControlStationForm : Form
    {
        private const int ALERT_FREQ = 17;
        private int timeCounter = 0;
        private int timeTempCounter = 0;
        private int timeTempRiseCounter = 0;

        private readonly Random randomNumber = new Random();

        private List<Label> labelsCoreTemp= new List<Label>();
        private List<Label> labelsCoreUsage = new List<Label>();

        private int coreFlagTemp = -1;

        public ControlStationForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            labelsCoreTemp.Add(core1TempLabel);
            labelsCoreTemp.Add(core2TempLabel);
            labelsCoreTemp.Add(core3TempLabel);
            labelsCoreTemp.Add(core4TempLabel);

            labelsCoreUsage.Add(core1UsageLabel);
            labelsCoreUsage.Add(core2UsageLabel);
            labelsCoreUsage.Add(core3UsageLabel);
            labelsCoreUsage.Add(core4UsageLabel);
        }

        private void warningsTimer_Tick(object sender, EventArgs e)
        {
            timeCounter++;

            if (timeCounter % ALERT_FREQ == 0 && !Program.alertOpened)
            {
                Program.alertOpened = true;
                AlertnessVerificationForm vaForm = new AlertnessVerificationForm();
                vaForm.Show();
                timeCounter = 0;
            }   
        }

        public int RandomNumber(int min, int max)
        {
            return randomNumber.Next(min, max);
        }

        private void coreTempTimer_Tick(object sender, EventArgs e)
        {
            timeTempCounter++;
            int currentTemp;

            // TO DO:  SET WIDER RANGE AND CHECK IF GREATER

            if(coreFlagTemp != -1)
            {
                labelsCoreTemp[coreFlagTemp - 1].ForeColor = Color.Green;
                labelsCoreTemp[coreFlagTemp - 1].Text = "NORMAL: ";
                labelsCoreTemp[coreFlagTemp - 1].Text += RandomNumber(50, 65);
                labelsCoreTemp[coreFlagTemp - 1].Text += " °C ";
            }
            else
            {
                foreach (Label coreTempLabel in labelsCoreTemp)
                {
                    coreTempLabel.ForeColor = Color.Green;
                    coreTempLabel.Text = "NORMAL: ";
                    currentTemp = RandomNumber(50, 65);
                    coreTempLabel.Text += currentTemp;
                    coreTempLabel.Text += " °C ";
                }
            }

            if (timeTempCounter % 10 == 0)
            {
                riseTemperatureTimer.Enabled = true;
                coreTempTimer.Enabled = false;
                coreFlagTemp = -1;
            }

        }

        private void riseTemperatureTimer_Tick(object sender, EventArgs e)
        {   
            int currentTemp;
            int coreHighTemp = RandomNumber(0, 4);

            for (int i = 0; i < 4; i++)
            {
                if (i == coreHighTemp && i != coreFlagTemp)
                {
                    labelsCoreTemp[i].ForeColor = Color.Red;
                    labelsCoreTemp[i].Text = "HIGH: ";
                    currentTemp = RandomNumber(70, 100);
                    labelsCoreTemp[i].Text += currentTemp;
                    labelsCoreTemp[i].Text += " °C ";
                }
            }
            
        }

        private void coreUsageTimer_Tick(object sender, EventArgs e)
        {
            foreach (Label coreUsageLabel in labelsCoreUsage)
            {
                coreUsageLabel.Text = "NORMAL: ";
                coreUsageLabel.Text += RandomNumber(0, 70);
                coreUsageLabel.Text += " % ";
            }
        }

        private void fansSpeedTimer_Tick(object sender, EventArgs e)
        {
            fanSpeedLabel.Text = "NORMAL: ";
            fanSpeedLabel.Text += RandomNumber(3000, 4000);
            fanSpeedLabel.Text += " RPM ";
        }

        private void runFansButton_Click(object sender, EventArgs e)
        {
            //changeMainFansSpeed("slower");
            coreFlagTemp = 1;
            coreTempTimer.Enabled = true;
        }

        private void changeMainFansSpeed(String operation)
        {
            throw new NotImplementedException();
        }

        private void runExtraFans2_Click(object sender, EventArgs e)
        {
            //changeMainFansSpeed("slower");
            coreFlagTemp = 2;
            coreTempTimer.Enabled = true;
        }

        private void runExtraFans3_Click(object sender, EventArgs e)
        {
            coreFlagTemp = 3;
            coreTempTimer.Enabled = true;
        }

        private void runExtraFans4_Click(object sender, EventArgs e)
        {
            coreFlagTemp = 4;
            coreTempTimer.Enabled = true;
        }
    }
}
