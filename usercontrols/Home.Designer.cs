namespace ParkingSystem2
{
    partial class Home
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            floorPanel = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(28, 283);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(15, 15, 0, 15);
            flowLayoutPanel1.Size = new Size(1327, 425);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // floorPanel
            // 
            floorPanel.BackColor = Color.Transparent;
            floorPanel.Location = new Point(28, 203);
            floorPanel.Margin = new Padding(0);
            floorPanel.Name = "floorPanel";
            floorPanel.Size = new Size(1069, 50);
            floorPanel.TabIndex = 2;
            floorPanel.Paint += floorPanel_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 64);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(32, 32, 64);
            button1.Location = new Point(1111, 203);
            button1.Name = "button1";
            button1.Size = new Size(244, 50);
            button1.TabIndex = 3;
            button1.Text = "Add New floor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 64);
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cascadia Mono", 50F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(32, 32, 64);
            button2.Location = new Point(28, 26);
            button2.Name = "button2";
            button2.Size = new Size(870, 146);
            button2.TabIndex = 4;
            button2.Text = "10 VEHICLES PARKED.";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(32, 32, 64);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cascadia Mono", 29F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(919, 26);
            button3.Name = "button3";
            button3.Size = new Size(436, 146);
            button3.TabIndex = 5;
            button3.Text = "View Payment Matrix";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(floorPanel);
            Controls.Add(flowLayoutPanel1);
            Name = "Home";
            Size = new Size(1387, 740);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button3;
        static Button button2;
        static FlowLayoutPanel floorPanel;
        static FlowLayoutPanel flowLayoutPanel1;
    }
}
