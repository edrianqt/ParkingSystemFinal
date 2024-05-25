namespace ParkingSystem2
{
    partial class transactionHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            historyPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 32, 64);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1387, 81);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(32, 32, 64);
            label2.Font = new Font("Cascadia Mono", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 0);
            label2.Name = "label2";
            label2.Size = new Size(606, 81);
            label2.TabIndex = 2;
            label2.Text = "Transaction History";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(255, 192, 192);
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Controls.Add(label10);
            flowLayoutPanel2.Location = new Point(23, 113);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1328, 75);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(32, 32, 64);
            label3.Font = new Font("Cascadia Mono", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(248, 75);
            label3.TabIndex = 2;
            label3.Text = "Plate number";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(32, 32, 64);
            label1.Font = new Font("Cascadia Mono", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(248, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(287, 75);
            label1.TabIndex = 1;
            label1.Text = "Park in time";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(32, 32, 64);
            label4.Font = new Font("Cascadia Mono", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(535, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(313, 75);
            label4.TabIndex = 6;
            label4.Text = "Park out time";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(32, 32, 64);
            label5.Font = new Font("Cascadia Mono", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(848, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(303, 75);
            label5.TabIndex = 4;
            label5.Text = "Parked by";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(32, 32, 64);
            label10.Font = new Font("Cascadia Mono", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(1151, 0);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(177, 75);
            label10.TabIndex = 7;
            label10.Text = "Fee";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // historyPanel
            // 
            historyPanel.Location = new Point(23, 205);
            historyPanel.Margin = new Padding(0);
            historyPanel.Name = "historyPanel";
            historyPanel.Size = new Size(1328, 510);
            historyPanel.TabIndex = 7;
            // 
            // transactionHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(historyPanel);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            Name = "transactionHistory";
            Size = new Size(1387, 740);
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label10;
        static FlowLayoutPanel historyPanel;
    }
}
