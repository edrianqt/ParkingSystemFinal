namespace ParkingSystemGUI
{
    partial class RegisterForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            panel5 = new Panel();
            firstnameInput = new TextBox();
            panel4 = new Panel();
            passwordInput = new TextBox();
            loginButton = new Button();
            panel3 = new Panel();
            lastnameInput = new TextBox();
            panel2 = new Panel();
            usernameInput = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(101, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 416);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(224, 224, 224);
            panel5.Controls.Add(firstnameInput);
            panel5.Location = new Point(28, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(370, 64);
            panel5.TabIndex = 2;
            // 
            // firstnameInput
            // 
            firstnameInput.AcceptsTab = true;
            firstnameInput.BackColor = Color.FromArgb(224, 224, 224);
            firstnameInput.BorderStyle = BorderStyle.None;
            firstnameInput.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            firstnameInput.Location = new Point(15, 21);
            firstnameInput.Name = "firstnameInput";
            firstnameInput.PlaceholderText = "first name";
            firstnameInput.Size = new Size(335, 18);
            firstnameInput.TabIndex = 1;
            firstnameInput.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(passwordInput);
            panel4.Location = new Point(28, 218);
            panel4.Name = "panel4";
            panel4.Size = new Size(761, 64);
            panel4.TabIndex = 2;
            // 
            // passwordInput
            // 
            passwordInput.AcceptsTab = true;
            passwordInput.BackColor = Color.FromArgb(224, 224, 224);
            passwordInput.BorderStyle = BorderStyle.None;
            passwordInput.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            passwordInput.Location = new Point(18, 23);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.PlaceholderText = "password";
            passwordInput.Size = new Size(335, 18);
            passwordInput.TabIndex = 2;
            passwordInput.TabStop = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(32, 32, 66);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(28, 308);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(761, 64);
            loginButton.TabIndex = 2;
            loginButton.Text = "CREATE ACCOUNT";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(lastnameInput);
            panel3.Location = new Point(419, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 64);
            panel3.TabIndex = 1;
            // 
            // lastnameInput
            // 
            lastnameInput.AcceptsTab = true;
            lastnameInput.BackColor = Color.FromArgb(224, 224, 224);
            lastnameInput.BorderStyle = BorderStyle.None;
            lastnameInput.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            lastnameInput.Location = new Point(15, 20);
            lastnameInput.Name = "lastnameInput";
            lastnameInput.PlaceholderText = "last name";
            lastnameInput.Size = new Size(335, 18);
            lastnameInput.TabIndex = 1;
            lastnameInput.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(usernameInput);
            panel2.Location = new Point(28, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(761, 64);
            panel2.TabIndex = 0;
            // 
            // usernameInput
            // 
            usernameInput.AcceptsTab = true;
            usernameInput.BackColor = Color.FromArgb(224, 224, 224);
            usernameInput.BorderStyle = BorderStyle.None;
            usernameInput.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            usernameInput.Location = new Point(15, 22);
            usernameInput.Name = "usernameInput";
            usernameInput.PlaceholderText = "username";
            usernameInput.Size = new Size(726, 18);
            usernameInput.TabIndex = 2;
            usernameInput.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 663);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1001, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 64);
            ClientSize = new Size(1042, 714);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel4;
        private Button loginButton;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private TextBox firstnameInput;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox lastnameInput;
        private TextBox passwordInput;
        private TextBox usernameInput;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}