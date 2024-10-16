using Login.model;

namespace Login
{
    partial class loginform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            usernametext = new RoundTextBox();
            passwordtext = new RoundTextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btlogin = new RoundButton();
            label1 = new Label();
            registerlink = new Label();
            RemembermeCheck = new CheckBox();
            pictureBox3 = new PictureBox();
            wronglbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // usernametext
            // 
            usernametext.BackColor = Color.Black;
            usernametext.BorderStyle = BorderStyle.FixedSingle;
            usernametext.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernametext.ForeColor = Color.Gray;
            usernametext.Location = new Point(41, 149);
            usernametext.Name = "usernametext";
            usernametext.Size = new Size(357, 65);
            usernametext.TabIndex = 0;
            usernametext.Text = "Username";
            usernametext.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordtext
            // 
            passwordtext.BackColor = Color.Black;
            passwordtext.BorderStyle = BorderStyle.FixedSingle;
            passwordtext.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordtext.ForeColor = Color.Gray;
            passwordtext.Location = new Point(41, 239);
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
            label2.Location = new Point(166, 64);
            label2.Name = "label2";
            label2.Size = new Size(127, 54);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(363, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(363, 254);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btlogin
            // 
            btlogin.BackColor = Color.White;
            btlogin.FlatStyle = FlatStyle.System;
            btlogin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btlogin.Location = new Point(41, 348);
            btlogin.Name = "btlogin";
            btlogin.Padding = new Padding(10, 5, 10, 5);
            btlogin.Size = new Size(357, 56);
            btlogin.TabIndex = 4;
            btlogin.Text = "Login";
            btlogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 418);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 5;
            label1.Text = "Don't have account?";
            // 
            // registerlink
            // 
            registerlink.AutoSize = true;
            registerlink.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerlink.ForeColor = Color.White;
            registerlink.Location = new Point(263, 418);
            registerlink.Name = "registerlink";
            registerlink.Size = new Size(67, 20);
            registerlink.TabIndex = 5;
            registerlink.Text = "Register";
            registerlink.Click += registerlink_Click;
            // 
            // RemembermeCheck
            // 
            RemembermeCheck.AutoSize = true;
            RemembermeCheck.ForeColor = Color.White;
            RemembermeCheck.Location = new Point(41, 310);
            RemembermeCheck.Name = "RemembermeCheck";
            RemembermeCheck.Size = new Size(129, 24);
            RemembermeCheck.TabIndex = 6;
            RemembermeCheck.Text = "Remember Me";
            RemembermeCheck.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(416, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // wronglbl
            // 
            wronglbl.AutoSize = true;
            wronglbl.ForeColor = Color.Red;
            wronglbl.Location = new Point(189, 311);
            wronglbl.Name = "wronglbl";
            wronglbl.Size = new Size(209, 20);
            wronglbl.TabIndex = 8;
            wronglbl.Text = "Wrong Password Or Username";
            wronglbl.Visible = false;
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(455, 455);
            Controls.Add(wronglbl);
            Controls.Add(pictureBox3);
            Controls.Add(RemembermeCheck);
            Controls.Add(registerlink);
            Controls.Add(label1);
            Controls.Add(btlogin);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(passwordtext);
            Controls.Add(usernametext);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "loginform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseDown += lblMoveForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundTextBox usernametext;
        private RoundTextBox passwordtext;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RoundButton btlogin;
        private Label label1;
        private Label registerlink;
        private CheckBox RemembermeCheck;
        private PictureBox pictureBox3;
        private Label wronglbl;
    }
}
