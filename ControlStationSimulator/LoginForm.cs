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
        private bool [] loginAllowed = { false, false };

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private static int maxAttempts = 3;
        
        private string correctLogin = "Operator";
        private string correctPassword = "line";

       
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
                Form1 form = new Form1();
                form.ShowDialog();
             
            }
            else
            {
                maxAttempts--;
                MessageBox.Show("Wrong username or password. \n Try again! \n Left attempts: " 
                    + maxAttempts.ToString(), "Wrong credentials", buttonOk, MessageBoxIcon.Warning);

                loginBox.Clear();
                passwordBox.Clear();
                loginBox.Focus();
                loginButton.Enabled = false;


                if (maxAttempts == 0)
                {
                    Application.Exit();
                }
              
            }

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            loginAllowed[0] = true;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            loginAllowed[1] = true;

            if (loginAllowed[0] && loginAllowed[1])
            {
                loginButton.Enabled = true;
            }

        }

        private void loginButton_EnabledChanged(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.Black;
        }
    }
}
