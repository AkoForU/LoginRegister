using Login.model;

namespace Login.view
{
    partial class Register
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
            usernametext = new RoundTextBox();
            passwordtext = new RoundTextBox();
            label2 = new Label();
            btregister = new RoundButton();
            rptpsswd = new RoundTextBox();
            label1 = new Label();
            loginlink = new Label();
            usernamechecker = new Label();
            SuspendLayout();
            // 
            // usernametext
            // 
            usernametext.BackColor = Color.Black;
            usernametext.BorderStyle = BorderStyle.FixedSingle;
            usernametext.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernametext.ForeColor = Color.Gray;
            usernametext.Location = new Point(54, 145);
            usernametext.Name = "usernametext";
            usernametext.Size = new Size(357, 65);
            usernametext.TabIndex = 0;
            usernametext.Text = "Username";
            usernametext.TextAlign = HorizontalAlignment.Center;
            usernametext.TextChanged += verifyusername;
            // 
            // passwordtext
            // 
            passwordtext.BackColor = Color.Black;
            passwordtext.BorderStyle = BorderStyle.FixedSingle;
            passwordtext.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordtext.ForeColor = Color.Gray;
            passwordtext.Location = new Point(54, 212);
            passwordtext.Name = "passwordtext";
            passwordtext.Size = new Size(357, 65);
            passwordtext.TabIndex = 0;
            passwordtext.Text = "Password";
            passwordtext.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(141, 60);
            label2.Name = "label2";
            label2.Size = new Size(178, 54);
            label2.TabIndex = 2;
            label2.Text = "Register";
            // 
            // btregister
            // 
            btregister.BackColor = Color.White;
            btregister.FlatStyle = FlatStyle.System;
            btregister.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btregister.Location = new Point(54, 344);
            btregister.Name = "btregister";
            btregister.Padding = new Padding(10, 5, 10, 5);
            btregister.Size = new Size(357, 56);
            btregister.TabIndex = 4;
            btregister.Text = "Register";
            btregister.UseVisualStyleBackColor = false;
            btregister.Click += e_Click;
            // 
            // rptpsswd
            // 
            rptpsswd.BackColor = Color.Black;
            rptpsswd.BorderStyle = BorderStyle.FixedSingle;
            rptpsswd.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rptpsswd.ForeColor = Color.Gray;
            rptpsswd.Location = new Point(54, 283);
            rptpsswd.Name = "rptpsswd";
            rptpsswd.Size = new Size(357, 65);
            rptpsswd.TabIndex = 0;
            rptpsswd.Text = "Repeat Password";
            rptpsswd.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(141, 409);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 5;
            label1.Text = "Have account?";
            // 
            // loginlink
            // 
            loginlink.AutoSize = true;
            loginlink.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginlink.ForeColor = Color.White;
            loginlink.Location = new Point(256, 409);
            loginlink.Name = "loginlink";
            loginlink.Size = new Size(48, 20);
            loginlink.TabIndex = 5;
            loginlink.Text = "Login";
            loginlink.Click += loginlink_Click;
            // 
            // usernamechecker
            // 
            usernamechecker.AutoSize = true;
            usernamechecker.ForeColor = Color.Lime;
            usernamechecker.Location = new Point(76, 122);
            usernamechecker.Name = "usernamechecker";
            usernamechecker.Size = new Size(0, 20);
            usernamechecker.TabIndex = 6;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(455, 455);
            Controls.Add(usernamechecker);
            Controls.Add(loginlink);
            Controls.Add(label1);
            Controls.Add(btregister);
            Controls.Add(label2);
            Controls.Add(rptpsswd);
            Controls.Add(passwordtext);
            Controls.Add(usernametext);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseMove += lblMoveForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundTextBox usernametext;
        private RoundTextBox passwordtext;
        private Label label2;
        private RoundButton btregister;
        private RoundTextBox rptpsswd;
        private Label label1;
        private Label loginlink;
        private Label usernamechecker;
    }
}