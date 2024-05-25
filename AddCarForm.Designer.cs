namespace ParkingSystemGUI
{
    partial class AddCarForm
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
            panel1 = new Panel();
            plateNumberInput = new TextBox();
            label3 = new Label();
            backButton = new Button();
            brandComboBox = new ComboBox();
            label2 = new Label();
            addCarButton = new Button();
            label4 = new Label();
            vTypeComboBox = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(plateNumberInput);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(brandComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addCarButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(vTypeComboBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 331);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // plateNumberInput
            // 
            plateNumberInput.BorderStyle = BorderStyle.None;
            plateNumberInput.Font = new Font("Cascadia Mono ExtraLight", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plateNumberInput.Location = new Point(248, 52);
            plateNumberInput.Margin = new Padding(3, 2, 3, 2);
            plateNumberInput.Multiline = true;
            plateNumberInput.Name = "plateNumberInput";
            plateNumberInput.PlaceholderText = "Plate Number";
            plateNumberInput.Size = new Size(445, 27);
            plateNumberInput.TabIndex = 13;
            plateNumberInput.TextChanged += plateNumberInput_TextChanged;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(237, 45);
            label3.Name = "label3";
            label3.Size = new Size(468, 43);
            label3.TabIndex = 12;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(102, 0, 0);
            backButton.Cursor = Cursors.Hand;
            backButton.Font = new Font("Cascadia Mono", 13.8F);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(318, 236);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(186, 53);
            backButton.TabIndex = 11;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // brandComboBox
            // 
            brandComboBox.Font = new Font("Cascadia Mono ExtraLight", 19F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brandComboBox.FormattingEnabled = true;
            brandComboBox.Location = new Point(237, 163);
            brandComboBox.Margin = new Padding(3, 2, 3, 2);
            brandComboBox.Name = "brandComboBox";
            brandComboBox.Size = new Size(468, 41);
            brandComboBox.TabIndex = 10;
            brandComboBox.Text = "Select Brand";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(32, 32, 66);
            label2.Font = new Font("Cascadia Mono", 13.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 163);
            label2.Name = "label2";
            label2.Size = new Size(184, 41);
            label2.TabIndex = 8;
            label2.Text = "Brand";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addCarButton
            // 
            addCarButton.BackColor = Color.FromArgb(32, 32, 66);
            addCarButton.Cursor = Cursors.Hand;
            addCarButton.Font = new Font("Cascadia Mono", 13.8F);
            addCarButton.ForeColor = Color.White;
            addCarButton.Location = new Point(519, 236);
            addCarButton.Margin = new Padding(3, 2, 3, 2);
            addCarButton.Name = "addCarButton";
            addCarButton.Size = new Size(186, 53);
            addCarButton.TabIndex = 7;
            addCarButton.Text = "Park in";
            addCarButton.UseVisualStyleBackColor = false;
            addCarButton.Click += addCarButton_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(32, 32, 66);
            label4.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 105);
            label4.Name = "label4";
            label4.Size = new Size(184, 41);
            label4.TabIndex = 4;
            label4.Text = "Vehicle Type";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vTypeComboBox
            // 
            vTypeComboBox.DropDownHeight = 1000;
            vTypeComboBox.Font = new Font("Cascadia Mono ExtraLight", 19F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vTypeComboBox.FormattingEnabled = true;
            vTypeComboBox.IntegralHeight = false;
            vTypeComboBox.Items.AddRange(new object[] { "Motorbike", "Van", "SUV", "Sedan" });
            vTypeComboBox.Location = new Point(237, 105);
            vTypeComboBox.Margin = new Padding(3, 2, 3, 2);
            vTypeComboBox.Name = "vTypeComboBox";
            vTypeComboBox.Size = new Size(468, 41);
            vTypeComboBox.TabIndex = 3;
            vTypeComboBox.TabStop = false;
            vTypeComboBox.Text = "Select Vehicle";
            vTypeComboBox.SelectedIndexChanged += vTypeComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(32, 32, 66);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 45);
            label1.Name = "label1";
            label1.Size = new Size(184, 43);
            label1.TabIndex = 1;
            label1.Text = "Plate Number";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.White;
            ClientSize = new Size(742, 328);
            ControlBox = false;
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCarForm";
            Load += AddCarForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox vTypeComboBox;
        private Label label4;
        private Button addCarButton;
        private Label label2;
        private Button backButton;
        private ComboBox brandComboBox;
        private TextBox plateNumberInput;
        private Label label3;

        public TextBox GetPlateNumber()
        {
            return plateNumberInput;
        }

        public ComboBox GetVehicleType()
        {
            return vTypeComboBox;
        }

        public ComboBox GetBrand()
        {
            return brandComboBox;
        }

        public Button GetAddCarButton()
        {
            return addCarButton;
        }
    }
}