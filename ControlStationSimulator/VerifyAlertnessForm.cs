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
    public partial class VerifyAlertnessForm : Form
    {
        private int timeCounter = 0;

        public VerifyAlertnessForm()
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

            if(timeCounter >= 30)
            {
                Application.Exit();
            }
        }

        private void alertButton_Click(object sender, EventArgs e)
        {
            Program.alertOpened = false;
            this.Close();
        }
    }
}
