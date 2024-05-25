namespace ParkingSystem2
{
    partial class Receipt
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            label7 = new Label();
            plateNumber = new Label();
            parkIn = new Label();
            parkOut = new Label();
            flagDown = new Label();
            parkedBy = new Label();
            duration = new Label();
            fee = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 32, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Mono SemiBold", 70F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-5, -3);
            button1.Name = "button1";
            button1.Size = new Size(986, 164);
            button1.TabIndex = 0;
            button1.Text = "RECEIPT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(32, 32, 64);
            label1.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 189);
            label1.Name = "label1";
            label1.Size = new Size(217, 45);
            label1.TabIndex = 1;
            label1.Text = "Plate number";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(32, 32, 64);
            label2.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 244);
            label2.Name = "label2";
            label2.Size = new Size(217, 45);
            label2.TabIndex = 2;
            label2.Text = "Parkin Time";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(32, 32, 64);
            label3.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 301);
            label3.Name = "label3";
            label3.Size = new Size(217, 45);
            label3.TabIndex = 3;
            label3.Text = "Parkout Time";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(32, 32, 64);
            label4.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(26, 359);
            label4.Name = "label4";
            label4.Size = new Size(217, 45);
            label4.TabIndex = 4;
            label4.Text = "Flagdown";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(32, 32, 64);
            label5.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(26, 476);
            label5.Name = "label5";
            label5.Size = new Size(217, 45);
            label5.TabIndex = 5;
            label5.Text = "Duration";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(32, 32, 64);
            label6.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(26, 537);
            label6.Name = "label6";
            label6.Size = new Size(217, 45);
            label6.TabIndex = 6;
            label6.Text = "Fee";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(102, 0, 0);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(774, 602);
            button2.Name = "button2";
            button2.Size = new Size(176, 56);
            button2.TabIndex = 13;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(32, 32, 64);
            label7.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(26, 418);
            label7.Name = "label7";
            label7.Size = new Size(217, 45);
            label7.TabIndex = 14;
            label7.Text = "Parked by";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plateNumber
            // 
            plateNumber.BorderStyle = BorderStyle.FixedSingle;
            plateNumber.Font = new Font("Cascadia Mono SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plateNumber.Location = new Point(258, 189);
            plateNumber.Name = "plateNumber";
            plateNumber.Size = new Size(692, 45);
            plateNumber.TabIndex = 16;
            plateNumber.Text = "label8";
            plateNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parkIn
            // 
            parkIn.BorderStyle = BorderStyle.FixedSingle;
            parkIn.Font = new Font("Cascadia Mono SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkIn.Location = new Point(258, 244);
            parkIn.Name = "parkIn";
            parkIn.Size = new Size(692, 45);
            parkIn.TabIndex = 17;
            parkIn.Text = "label8";
            parkIn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parkOut
            // 
            parkOut.BorderStyle = BorderStyle.FixedSingle;
            parkOut.Font = new Font("Cascadia Mono SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkOut.Location = new Point(258, 301);
            parkOut.Name = "parkOut";
            parkOut.Size = new Size(692, 45);
            parkOut.TabIndex = 18;
            parkOut.Text = "label8";
            parkOut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flagDown
            // 
            flagDown.BorderStyle = BorderStyle.FixedSingle;
            flagDown.Font = new Font("Cascadia Mono SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flagDown.Location = new Point(258, 359);
            flagDown.Name = "flagDown";
            flagDown.Size = new Size(692, 45);
            flagDown.TabIndex = 19;
            flagDown.Text = "label8";
            flagDown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parkedBy
            // 
            parkedBy.BorderStyle = BorderStyle.FixedSingle;
            parkedBy.Font = new Font("Cascadia Mono SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkedBy.Location = new Point(258, 418);
            parkedBy.Name = "parkedBy";
            parkedBy.Size = new Size(692, 45);
            parkedBy.TabIndex = 20;
            parkedBy.Text = "label8";
            parkedBy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // duration
            // 
            duration.BorderStyle = BorderStyle.FixedSingle;
            duration.Font = new Font("Cascadia Mono SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duration.Location = new Point(258, 476);
            duration.Name = "duration";
            duration.Size = new Size(692, 45);
            duration.TabIndex = 21;
            duration.Text = "label8";
            duration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fee
            // 
            fee.BorderStyle = BorderStyle.FixedSingle;
            fee.Font = new Font("Cascadia Mono SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fee.Location = new Point(258, 537);
            fee.Name = "fee";
            fee.Size = new Size(692, 45);
            fee.TabIndex = 22;
            fee.Text = "label8";
            fee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(979, 673);
            Controls.Add(fee);
            Controls.Add(duration);
            Controls.Add(parkedBy);
            Controls.Add(flagDown);
            Controls.Add(parkOut);
            Controls.Add(parkIn);
            Controls.Add(plateNumber);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Receipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Label label7;
        private Label plateNumber;
        private Label parkIn;
        private Label parkOut;
        private Label flagDown;
        private Label parkedBy;
        private Label duration;
        private Label fee;
    }
}