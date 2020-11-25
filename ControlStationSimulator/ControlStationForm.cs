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
        private static int timeCounter = 0;
        private int timeTempCounter = 0;
        private int timeUsageCounter = 0;

        private List<Label> labelsCoreTemp = new List<Label>();
        private List<Label> labelsCoreUsage = new List<Label>();

        private List<Boolean> systemDestroyedFlag = new List<Boolean>();

        private readonly Random randomNumber = new Random();

        private int randAccident = -1;

        private int coreFlagTemp = -1;
        private int tempDelay = -1;
        private int [] fansFlag = {-1, -1, -1, -1};

        private int fansOperation = -1;

        private int[] usageFlags = {-1, -1, -1, -1 };
        private int usageDelay = -1;
        private int getRandomCore = -1;

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

            for(int i = 0; i < (labelsCoreUsage.Count + labelsCoreTemp.Count); i++)
            {
                systemDestroyedFlag.Add((Boolean)false);
            }
        }

        private void warningsTimer_Tick(object sender, EventArgs e)
        {
            timeCounter++;

            if (timeCounter % ALERT_FREQ == 0 && !Program.alertOpened)
            {
                Program.alertOpened = true;
                AlertnessVerificationForm vaForm = new AlertnessVerificationForm();
                vaForm.Show();
            }   
        }

        public static void setTimeCounter(int timeCounter)
        {
            ControlStationForm.timeCounter = timeCounter;
        }

        public int RandomNumber(int min, int max)
        {
            return randomNumber.Next(min, max);
        }

        private void coreTempTimer_Tick(object sender, EventArgs e)
        {
            timeTempCounter++;
            int currentTemp;

            if(tempDelay == 1)
            {
                coreTempTimer.Interval = 2000;
            }
            else
            {
                coreTempTimer.Interval = 1200;
            }

            if (randAccident != -1)
            {
                labelsCoreTemp[randAccident].ForeColor = Color.Red;
                labelsCoreTemp[randAccident].Text = "HIGH: ";
                labelsCoreTemp[randAccident].Text += RandomNumber(100, 120);
                labelsCoreTemp[randAccident].Text += " °C ";
                randAccident = -1;
            }

            if (coreFlagTemp != -1)
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

            if (timeTempCounter % 22 == 0)
            {
                riseTemperatureTimer.Enabled = true;
                coreTempTimer.Enabled = false;
                coreFlagTemp = -1;
                tempDelay = -1;
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

                    changeMainFansSpeed("faster");
                }
            }
            
        }

        private void fansSpeedTimer_Tick(object sender, EventArgs e)
        {
            if(fansOperation == 0 || fansOperation == -1)
            {
                fanSpeedLabel.ForeColor = Color.Green;
                fanSpeedLabel.Text = "NORMAL: ";
                fanSpeedLabel.Text += RandomNumber(3000, 4000);
                fanSpeedLabel.Text += " RPM ";
            }
            else if (fansOperation == 1)
            {
                fanSpeedLabel.ForeColor = Color.Red;
                fanSpeedLabel.Text = "HIGH: ";
                fanSpeedLabel.Text += RandomNumber(6000, 8000);
                fanSpeedLabel.Text += " RPM ";
            }

        }

        private void runFansButton_Click(object sender, EventArgs e)
        {
            changeMainFansSpeed("slower");
            coreFlagTemp = 1;
            coreTempTimer.Enabled = true;
        }

        private void changeMainFansSpeed(String operation)
        {
            switch (operation)
            {
                case "slower":
                    fansOperation = 0;
                    break;
                case "faster":
                    fansOperation = 1;
                    break;
            }  
        }

        private void runExtraFans2_Click(object sender, EventArgs e)
        {
            changeMainFansSpeed("slower");
            coreFlagTemp = 2;
            coreTempTimer.Enabled = true;
            tempDelay = 1;
        }

        private void runExtraFans3_Click(object sender, EventArgs e)
        {
            changeMainFansSpeed("slower");
            coreFlagTemp = 3;
            coreTempTimer.Enabled = true;
            tempDelay = 1;
        }

        private void runExtraFans4_Click(object sender, EventArgs e)
        {
            changeMainFansSpeed("slower");
            coreFlagTemp = 4;
            coreTempTimer.Enabled = true;
            tempDelay = 1;
        }

        private void fansSpeedButton_Click(object sender, EventArgs e)
        {
            changeMainFansSpeed("slower");
        }

        private void coreUsageTimer_Tick(object sender, EventArgs e)
        {
            timeUsageCounter++;

            if(usageDelay == 1)
            {
                coreUsageTimer.Interval = 2000;
            }
            else
            {
                coreUsageTimer.Interval = 1200;
            }

            if (randAccident != -1)
            {
                labelsCoreUsage[randAccident].ForeColor = Color.Red;
                labelsCoreUsage[randAccident].Text = "HIGH: ";
                labelsCoreUsage[randAccident].Text += RandomNumber(90, 100);
                labelsCoreUsage[randAccident].Text += " % ";
                randAccident = -1;
            }


            for (int j = 0; j < usageFlags.Length; j++)
            {
                if (usageFlags[j] == 1)
                {
                    labelsCoreUsage[j].ForeColor = Color.Green;
                    labelsCoreUsage[j].Text = "NORMAL: ";
                    labelsCoreUsage[j].Text += RandomNumber(0, 70);
                    labelsCoreUsage[j].Text += " % ";
                    usageDelay = -1;
                }
            }

            if (timeUsageCounter % 12 == 0)
            {
                for (int i = 0; i < labelsCoreUsage.Count; i++)
                {
                    getRandomCore = RandomNumber(0, 4);
                    for (int j = 0; j < usageFlags.Length; j++)
                    {
                        if(usageFlags[j] == 1 && j == getRandomCore)
                        {
                            getRandomCore = RandomNumber(0, 4);
                        }
                    }
                    labelsCoreUsage[getRandomCore].ForeColor = Color.Red;
                    labelsCoreUsage[getRandomCore].Text = "HIGH: ";
                    labelsCoreUsage[getRandomCore].Text += RandomNumber(75, 100);
                    labelsCoreUsage[getRandomCore].Text += " % ";
                    usageFlags[i] = -1;
                }
            }
            else
            {
                for (int i = 0; i < labelsCoreUsage.Count; i++)
                {
                    if ((getRandomCore == -1 && i != getRandomCore))
                    {
                        labelsCoreUsage[i].ForeColor = Color.Green;
                        labelsCoreUsage[i].Text = "NORMAL: ";
                        labelsCoreUsage[i].Text += RandomNumber(0, 70);
                        labelsCoreUsage[i].Text += " % ";
                    }
                }
            }
        }


        private void usage1Button_Click(object sender, EventArgs e)
        {
            usageFlags[0] = 1;
            usageDelay = 1;
        }

        private void usage2Button_Click(object sender, EventArgs e)
        {
            usageFlags[1] = 1;
            usageDelay = 1;
        }

        private void usage3Button_Click(object sender, EventArgs e)
        {
            usageFlags[2] = 1;
            usageDelay = 1;
        }

        private void usage4Button_Click(object sender, EventArgs e)
        {
            usageFlags[3] = 1;
            usageDelay = 1;
        }

        private void stopProcesses_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void randomAccident_Click(object sender, EventArgs e)
        {
            randAccident = RandomNumber(0, 4);
        }

        private void systemDestroyedTimer_Tick(object sender, EventArgs e)
        {
            int counter = 4;
      
            for(int i = 0; i < labelsCoreTemp.Count; i++)
            {
                if(labelsCoreTemp[i].Text.StartsWith("HIGH"))
                {
                    systemDestroyedFlag[i] = true;
                }
                else if(labelsCoreTemp[i].Text.StartsWith("NORMAL"))
                {
                    systemDestroyedFlag[i] = false;
                }
            }

            foreach(Label labelUsage in labelsCoreUsage)
            {
                if(labelUsage.Text.StartsWith("HIGH"))
                {
                    systemDestroyedFlag[counter] = true;
                }
                else if (labelUsage.Text.StartsWith("NORMAL"))
                {
                    systemDestroyedFlag[counter] = false;
                }
                counter++;
            }

            // Check if all values true (Every label starts with "HIGH")
            if (!systemDestroyedFlag.Contains(false) && Program.systemDestroyed == false)
            {
                this.Hide();
                Program.systemDestroyed = true;
                SystemDestroyedForm sdForm = new SystemDestroyedForm();
                sdForm.Show();
            }

        }

    }
}
