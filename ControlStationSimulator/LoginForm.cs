using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlStationSimulator
{
    public partial class LogInForm : Form
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        static int maxAttempts = 3;

        string correctLogin = "Operator";
        string correctPassword = "production";

        public LogInForm()
        {
            InitializeComponent();

            // Placeholder
            SendMessage(loginBox.Handle, EM_SETCUEBANNER, 0, "Username");
            SendMessage(passwordBox.Handle, EM_SETCUEBANNER, 0, "Password");

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void loginButton_click(object sender, EventArgs e)
        {
            MessageBoxButtons buttonOk = MessageBoxButtons.OK;

            string username = loginBox.Text;
            string password = passwordBox.Text;

            if (username.Equals(correctLogin) && password.Equals(correctPassword))
            {
                
            }
            else
            {
                maxAttempts--;
                DialogResult result = MessageBox.Show("Wrong username or password. \n Try again! \n Left attempts: " + maxAttempts.ToString(), "Wrong", buttonOk, MessageBoxIcon.Warning);
               
                if (maxAttempts == 0)
                {
                    this.Close();
                }
              
            }

        }
    }
}
