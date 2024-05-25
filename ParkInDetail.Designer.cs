namespace ParkingSystem2
{
    partial class ParkInDetail
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            plateNumber = new Label();
            button1 = new Button();
            button2 = new Button();
            vType = new Label();
            brand = new Label();
            parkin = new Label();
            label6 = new Label();
            flagdown = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(32, 32, 64);
            label1.Font = new Font("Cascadia Mono", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-7, -4);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(977, 160);
            label1.TabIndex = 0;
            label1.Text = "Parkin Details";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(32, 32, 64);
            label2.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 176);
            label2.Name = "label2";
            label2.Size = new Size(306, 48);
            label2.TabIndex = 1;
            label2.Text = "Plate Number";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(32, 32, 64);
            label3.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 242);
            label3.Name = "label3";
            label3.Size = new Size(306, 48);
            label3.TabIndex = 2;
            label3.Text = "Vehicle Type";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(32, 32, 64);
            label4.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 307);
            label4.Name = "label4";
            label4.Size = new Size(306, 48);
            label4.TabIndex = 3;
            label4.Text = "Vehicle Brand";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(32, 32, 64);
            label5.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 371);
            label5.Name = "label5";
            label5.Size = new Size(306, 48);
            label5.TabIndex = 4;
            label5.Text = "Park in";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plateNumber
            // 
            plateNumber.BackColor = Color.FromArgb(32, 32, 64);
            plateNumber.Font = new Font("Cascadia Mono SemiLight", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plateNumber.ForeColor = Color.White;
            plateNumber.Location = new Point(345, 176);
            plateNumber.Name = "plateNumber";
            plateNumber.Size = new Size(592, 48);
            plateNumber.TabIndex = 5;
            plateNumber.Text = "data";
            plateNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(553, 502);
            button1.Name = "button1";
            button1.Size = new Size(189, 63);
            button1.TabIndex = 9;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(748, 502);
            button2.Name = "button2";
            button2.Size = new Size(189, 63);
            button2.TabIndex = 10;
            button2.Text = "Park out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // vType
            // 
            vType.BackColor = Color.FromArgb(32, 32, 64);
            vType.Font = new Font("Cascadia Mono SemiLight", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vType.ForeColor = Color.White;
            vType.Location = new Point(345, 242);
            vType.Name = "vType";
            vType.Size = new Size(592, 48);
            vType.TabIndex = 11;
            vType.Text = "data";
            vType.TextAlign = ContentAlignment.MiddleCenter;
            vType.Click += vType_Click;
            // 
            // brand
            // 
            brand.BackColor = Color.FromArgb(32, 32, 64);
            brand.Font = new Font("Cascadia Mono SemiLight", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brand.ForeColor = Color.White;
            brand.Location = new Point(345, 307);
            brand.Name = "brand";
            brand.Size = new Size(592, 48);
            brand.TabIndex = 12;
            brand.Text = "data";
            brand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parkin
            // 
            parkin.BackColor = Color.FromArgb(32, 32, 64);
            parkin.Font = new Font("Cascadia Mono SemiLight", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkin.ForeColor = Color.White;
            parkin.Location = new Point(345, 371);
            parkin.Name = "parkin";
            parkin.Size = new Size(592, 48);
            parkin.TabIndex = 13;
            parkin.Text = "data";
            parkin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(32, 32, 64);
            label6.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 434);
            label6.Name = "label6";
            label6.Size = new Size(306, 48);
            label6.TabIndex = 14;
            label6.Text = "Flag Down";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flagdown
            // 
            flagdown.BackColor = Color.FromArgb(32, 32, 64);
            flagdown.Font = new Font("Cascadia Mono SemiLight", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flagdown.ForeColor = Color.White;
            flagdown.Location = new Point(345, 434);
            flagdown.Name = "flagdown";
            flagdown.Size = new Size(592, 48);
            flagdown.TabIndex = 15;
            flagdown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ParkInDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(962, 589);
            Controls.Add(label1);
            Controls.Add(flagdown);
            Controls.Add(label6);
            Controls.Add(parkin);
            Controls.Add(brand);
            Controls.Add(vType);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(plateNumber);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ParkInDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkInDetail";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label plateNumber;
        private Button button1;
        private Button button2;
        private Label vType;
        private Label brand;
        private Label parkin;
        private Label label6;
        private Label flagdown;
    }
}