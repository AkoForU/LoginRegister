using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.Data.Sqlite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login.view
{
    public partial class Register : Form
    {
        public List<string> list = new List<string>();
        private readonly loginform _form;
        public Register(loginform form)
        {
            InitializeComponent();
            _form = form;
            if (IsDWMCompositionEnabled())
            {
                if (Environment.OSVersion.Version.Major > 6)
                {
                    Dwm.Windows10EnableBlurBehind(Handle);
                }
                else
                {
                    Dwm.WindowEnableBlurBehind(Handle);
                }
                // Set Drop shadow of a border-less Form
                if (FormBorderStyle == FormBorderStyle.None)
                {
                    Dwm.WindowBorderlessDropShadow(Handle, 2);
                }
            }
            rptpsswd.Enter += TextBox_Enter3;
            rptpsswd.Leave += TextBox_Leave3;
            passwordtext.Enter += TextBox_Enter2;
            passwordtext.Leave += TextBox_Leave2;
            usernametext.Enter += TextBox_Enter;
            usernametext.Leave += TextBox_Leave;
            this.Shown += focus;
        }
        public Register() 
        {

        }
        private void focus(object sender, EventArgs e)
        {
            btregister.Focus();
        }
        private void verifyusername(object sender, EventArgs e)
        {
            bool check = false;
            foreach(var item in list)
            {
                if (item == usernametext.Text)check = true;
            }
            if (check)
            {
                usernamechecker.Text = ("Username Already Taken"); usernamechecker.ForeColor = Color.Red;
            }
            else
            {
                usernamechecker.Text = ("The username is not used"); usernamechecker.ForeColor = Color.Lime;
            }
            if (usernametext.ForeColor == SystemColors.GrayText||usernametext.Text=="Username"||usernametext.Text=="") usernamechecker.Text = null;
        }
        private void loginlink_Click(object sender, EventArgs e)
        {
            _form.Visible = true;
            this.Close();
        }
        private bool IsDWMCompositionEnabled() =>
            Environment.OSVersion.Version.Major >= 6 && Dwm.IsCompositionEnabled();
        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametext.Text))
            {
                usernametext.Text = "Username"; // Restore placeholder text with spaces
                usernametext.ForeColor = System.Drawing.SystemColors.GrayText; // Set text color to gray
            }
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (usernametext.Text == "Username")
            {
                usernametext.Text = string.Empty; // Clear placeholder text
                usernametext.ForeColor = System.Drawing.Color.White; // Set text color to default
            }
        }
        private void TextBox_Leave2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordtext.Text))
            {
                passwordtext.Text = "Password"; // Restore placeholder text with spaces
                passwordtext.PasswordChar = '\0';
                passwordtext.ForeColor = System.Drawing.SystemColors.GrayText; // Set text color to gray
            }
        }
        private void TextBox_Enter2(object sender, EventArgs e)
        {
            if (passwordtext.Text == "Password")
            {
                passwordtext.Text = string.Empty; // Clear placeholder text
                passwordtext.PasswordChar = '*';
                passwordtext.ForeColor = System.Drawing.Color.White; // Set text color to default
            }
        }
        private void lblMoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                this.Capture = false; //select control

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }
        private void TextBox_Leave3(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rptpsswd.Text))
            {
                rptpsswd.Text = "Repeat Password"; // Restore placeholder text with spaces
                rptpsswd.PasswordChar = '\0';
                rptpsswd.ForeColor = System.Drawing.SystemColors.GrayText; // Set text color to gray
            }
        }
        private void TextBox_Enter3(object sender, EventArgs e)
        {
            if (rptpsswd.Text == "Repeat Password")
            {
                rptpsswd.Text = string.Empty; // Clear placeholder text
                rptpsswd.PasswordChar = '*';
                rptpsswd.ForeColor = System.Drawing.Color.White; // Set text color to default
            }
        }
        private void e_Click(object sender, EventArgs e)
        {
            if (rptpsswd.ForeColor == SystemColors.GrayText || passwordtext.ForeColor == SystemColors.GrayText)MessageBox.Show("Dont leave empty inputs");
            else if (rptpsswd.Text != passwordtext.Text)MessageBox.Show("The Password is not the same");
            else if (rptpsswd.Text.Length < 6)MessageBox.Show("The Password need to be at least 6 characters long");
        }
    }
}
