using Login.view;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.IO;


namespace Login
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
            // Remove the border if this is meant to be a border-less Form
            // FormBorderStyle = FormBorderStyle.None;
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
            passwordtext.ForeColor = System.Drawing.SystemColors.GrayText;
            usernametext.ForeColor = System.Drawing.SystemColors.GrayText;
            usernametext.Enter += TextBox_Enter;
            usernametext.Leave += TextBox_Leave;
            passwordtext.Enter += TextBox_Enter1;
            passwordtext.Leave += TextBox_Leave1;
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (usernametext.Text == "Username")
            {
                usernametext.Text = string.Empty; // Clear placeholder text
                usernametext.ForeColor = System.Drawing.Color.White; // Set text color to default
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametext.Text))
            {
                usernametext.Text = "Username"; // Restore placeholder text with spaces
                usernametext.ForeColor = System.Drawing.SystemColors.GrayText; // Set text color to gray
            }
        }
        private void TextBox_Enter1(object sender, EventArgs e)
        {
            if (passwordtext.Text == "Password")
            {
                passwordtext.Text = string.Empty; // Clear placeholder text
                passwordtext.PasswordChar = '*';
                passwordtext.ForeColor = System.Drawing.Color.White; // Set text color to default
            }
        }

        private void TextBox_Leave1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordtext.Text))
            {
                passwordtext.Text = "Password"; // Restore placeholder text with spaces
                passwordtext.PasswordChar = '\0';
                passwordtext.ForeColor = System.Drawing.SystemColors.GrayText; // Set text color to gray
            }
        }
        //Moving The Form Whenever or Where i want
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
        //verifica daca avem mai sus de windows vista sau 7
        private bool IsDWMCompositionEnabled() =>
            Environment.OSVersion.Version.Major >= 6 && Dwm.IsCompositionEnabled();

        //ne deschide form-ul cand apasam pe linkul de Register
        private void registerlink_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            this.Visible = false;
        }

        //buttonul de inchidere a aplicatiei
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
