namespace ParkingSystem2
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            sidebarPanel = new Panel();
            historyBox = new PictureBox();
            logOutBox = new PictureBox();
            parkBox = new PictureBox();
            homeBox = new PictureBox();
            logoBox1 = new PictureBox();
            userLogs2 = new usercontrols.userLogs();
            transactionHistory1 = new transactionHistory();
            home1 = new Home();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)historyBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logOutBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)parkBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoBox1).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(32, 32, 66);
            sidebarPanel.BorderStyle = BorderStyle.FixedSingle;
            sidebarPanel.Controls.Add(historyBox);
            sidebarPanel.Controls.Add(logOutBox);
            sidebarPanel.Controls.Add(parkBox);
            sidebarPanel.Controls.Add(homeBox);
            sidebarPanel.Controls.Add(logoBox1);
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(3, 4, 3, 4);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(78, 740);
            sidebarPanel.TabIndex = 3;
            // 
            // historyBox
            // 
            historyBox.BorderStyle = BorderStyle.FixedSingle;
            historyBox.Cursor = Cursors.Hand;
            historyBox.Image = (Image)resources.GetObject("historyBox.Image");
            historyBox.Location = new Point(0, 233);
            historyBox.Margin = new Padding(3, 4, 3, 4);
            historyBox.Name = "historyBox";
            historyBox.Padding = new Padding(20);
            historyBox.Size = new Size(79, 80);
            historyBox.SizeMode = PictureBoxSizeMode.StretchImage;
            historyBox.TabIndex = 4;
            historyBox.TabStop = false;
            historyBox.Click += historyBox_Click_1;
            // 
            // logOutBox
            // 
            logOutBox.BorderStyle = BorderStyle.FixedSingle;
            logOutBox.Cursor = Cursors.Hand;
            logOutBox.Image = (Image)resources.GetObject("logOutBox.Image");
            logOutBox.Location = new Point(-1, 660);
            logOutBox.Margin = new Padding(3, 4, 3, 4);
            logOutBox.Name = "logOutBox";
            logOutBox.Padding = new Padding(25);
            logOutBox.Size = new Size(79, 80);
            logOutBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logOutBox.TabIndex = 3;
            logOutBox.TabStop = false;
            logOutBox.Click += logOutBox_Click;
            // 
            // parkBox
            // 
            parkBox.BorderStyle = BorderStyle.FixedSingle;
            parkBox.Cursor = Cursors.Hand;
            parkBox.Image = (Image)resources.GetObject("parkBox.Image");
            parkBox.Location = new Point(0, 155);
            parkBox.Margin = new Padding(3, 4, 3, 4);
            parkBox.Name = "parkBox";
            parkBox.Padding = new Padding(23);
            parkBox.Size = new Size(79, 80);
            parkBox.SizeMode = PictureBoxSizeMode.StretchImage;
            parkBox.TabIndex = 2;
            parkBox.TabStop = false;
            parkBox.Click += parkBox_Click;
            // 
            // homeBox
            // 
            homeBox.BackColor = Color.FromArgb(58, 59, 89);
            homeBox.BorderStyle = BorderStyle.FixedSingle;
            homeBox.Cursor = Cursors.Hand;
            homeBox.Image = (Image)resources.GetObject("homeBox.Image");
            homeBox.Location = new Point(0, 79);
            homeBox.Margin = new Padding(3, 4, 3, 4);
            homeBox.Name = "homeBox";
            homeBox.Padding = new Padding(23);
            homeBox.Size = new Size(79, 80);
            homeBox.SizeMode = PictureBoxSizeMode.StretchImage;
            homeBox.TabIndex = 1;
            homeBox.TabStop = false;
            homeBox.Click += homeBox_Click;
            // 
            // logoBox1
            // 
            logoBox1.Image = (Image)resources.GetObject("logoBox1.Image");
            logoBox1.Location = new Point(3, -1);
            logoBox1.Margin = new Padding(0);
            logoBox1.Name = "logoBox1";
            logoBox1.Size = new Size(76, 81);
            logoBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox1.TabIndex = 0;
            logoBox1.TabStop = false;
            // 
            // userLogs2
            // 
            userLogs2.BackColor = Color.WhiteSmoke;
            userLogs2.Location = new Point(76, 0);
            userLogs2.Name = "userLogs2";
            userLogs2.Size = new Size(1387, 740);
            userLogs2.TabIndex = 7;
            // 
            // transactionHistory1
            // 
            transactionHistory1.BackColor = Color.WhiteSmoke;
            transactionHistory1.Location = new Point(76, 0);
            transactionHistory1.Name = "transactionHistory1";
            transactionHistory1.Size = new Size(1387, 740);
            transactionHistory1.TabIndex = 5;
            // 
            // home1
            // 
            home1.BackColor = Color.White;
            home1.Location = new Point(76, 0);
            home1.Name = "home1";
            home1.Size = new Size(1387, 740);
            home1.TabIndex = 8;
            home1.Load += home1_Load;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1456, 738);
            Controls.Add(home1);
            Controls.Add(sidebarPanel);
            Controls.Add(transactionHistory1);
            Controls.Add(userLogs2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)historyBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logOutBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)parkBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarPanel;
        private PictureBox historyBox;
        private PictureBox logOutBox;
        private PictureBox parkBox;
        private PictureBox homeBox;
        private PictureBox logoBox1;
        private usercontrols.userLogs userLogs2;
        private transactionHistory transactionHistory1;
        private Home home1;
    }
}