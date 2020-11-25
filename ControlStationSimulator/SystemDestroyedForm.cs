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
    public partial class SystemDestroyedForm : Form
    {
        private int timerCounter = 0;

        public SystemDestroyedForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = (10 - timerCounter).ToString();
            if(timerCounter > 10)
            {
                Application.Exit();
            }
            timerCounter++;
        }

        private void SystemDestroyedForm_Load(object sender, EventArgs e)
        {
            Program.alertOpened = true;
        }
    }
}
