using ParkingSystem2.models;
using ParkingSystemGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ParkingSystem2
{
    public partial class Home : UserControl
    {
        static Color primary = Color.FromArgb(32, 32, 66);
        static Color secondary = Color.FromArgb(58, 59, 89);
        public Home()
        {
            InitializeComponent();
            renderParkingSlots(1);
            renderFloors();
        }

        public static void renderVehicleCount()
        {
            button2.Text = $"{ParkingSlot.GetCountOfParkedVehicles().ToString()} Vehicles parked.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (flowLayoutPanel1.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2; // Set the thickness as desired
                int halfThickness = thickness / 2;

                // Define the border color (change Color.Black to your desired color)
                Color borderColor = Color.FromArgb(32, 32, 64);

                using (Pen p = new Pen(borderColor, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              flowLayoutPanel1.ClientSize.Width - thickness,
                                                              flowLayoutPanel1.ClientSize.Height - thickness));
                }
            }
        }

        public static void renderParkingSlots(int floorId)
        {
            flowLayoutPanel1.Controls.Clear();
            ParkingSlot[] parkingSlots = ParkingSlot.GetParkingSlots(floorId);

            foreach (var slot in parkingSlots)
            {
                Label label = new Label();
                label.BorderStyle = BorderStyle.None;
                label.ForeColor = Color.White;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Margin = new Padding(0, 0, 9, 9);
                label.Cursor = Cursors.Hand;

                label.Width = 426;
                label.Height = 126;
                label.Font = new Font("Cascadia Code", 18, FontStyle.Bold); // Change the font size as needed

                if (slot.IsAvailable == 0)
                {

                    label.BackColor = ColorTranslator.FromHtml("#F5F5F5");
                    label.BorderStyle = BorderStyle.FixedSingle;
                    Transaction transaction = Transaction.GetTransactionById(slot.TransactionId);

                    Label plateLabel = new Label();
                    plateLabel.Size = new Size(label.Width, label.Height / 2);
                    plateLabel.Location = new Point(0, label.Height / 2);
                    plateLabel.TextAlign = ContentAlignment.TopCenter;
                    plateLabel.Text = "Plate Number: " + transaction.PlateNumber;
                    plateLabel.ForeColor = Color.FromArgb(32, 32, 64);

                    Label pictureLabel = new Label();
                    pictureLabel.Size = new Size(label.Width, label.Height / 2);
                    pictureLabel.Location = new Point(0, 0);
                    pictureLabel.TextAlign = ContentAlignment.MiddleCenter;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new Size(100, 65);
               
                    switch (transaction.VehicleType)
                    {
                        case "Motorbike":
                            pictureBox.Image = Image.FromFile(@"../../../images/motorbike.png");
                            break;
                        case "Sedan":
                            pictureBox.Image = Image.FromFile(@"../../../images/sedan.png");
                            break;
                        case "SUV":
                            pictureBox.Image = Image.FromFile(@"../../../images/suv.png");
                            break;
                        case "Van":
                            pictureBox.Image = Image.FromFile(@"../../../images/van.png");
                            break;
                        default: break;
                    }

                    int x = (pictureLabel.Width - pictureBox.Width) / 2;
                    int y = (pictureLabel.Height - pictureBox.Height) / 2;

                    pictureBox.Location = new Point(x, y + 15);

                    pictureLabel.Controls.Add(pictureBox);
                    label.Controls.Add(pictureLabel);
                    label.Controls.Add(plateLabel);

                    pictureLabel.Click += (sender, e) =>
                    {
                        ParkInDetail parkinDetail = new ParkInDetail(slot);
                        parkinDetail.Show();
                    };

                    plateLabel.Click += (sender, e) =>
                    {
                        ParkInDetail parkinDetail = new ParkInDetail(slot);
                        parkinDetail.Show();
                    };

                    pictureBox.Click += (sender, e) =>
                    {
                        ParkInDetail parkinDetail = new ParkInDetail(slot);
                        parkinDetail.Show();
                    };


                }
                else
                {
                    label.Text = "Available";
                    label.BackColor = ColorTranslator.FromHtml("#17B169");
                    //label.BackColor = primary;
                    label.ForeColor = Color.White;
                    label.BorderStyle = BorderStyle.FixedSingle;

                    label.MouseEnter += (sender, e) =>
                    {
                        label.BackColor = secondary;
                    };

                    label.MouseLeave += (sender, e) =>
                    {
                        //label.BackColor = ColorTranslator.FromHtml("#3CB043");
                        label.BackColor = ColorTranslator.FromHtml("#17B169");
                        label.ForeColor = Color.White;
                    };

                    label.Click += (sender, e) =>
                    {
                        AddCarForm addCarForm = new AddCarForm(floorId, slot.ParkingSlotID);
                        addCarForm.Show();
                    };


                }

                flowLayoutPanel1.Controls.Add(label);
            }

            if (parkingSlots.Length < 9)
            {
                Button addSlotButton = new Button();
                addSlotButton.FlatStyle = FlatStyle.Flat;
                addSlotButton.FlatAppearance.BorderSize = 2;
                addSlotButton.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 64);
                addSlotButton.ForeColor = Color.Black;
                addSlotButton.TextAlign = ContentAlignment.MiddleCenter;
                addSlotButton.Cursor = Cursors.Hand;
                addSlotButton.FlatAppearance.BorderColor = primary; // Set the border color using a hexadecimal color code
                //addSlotButton.BackColor = ColorTranslator.FromHtml("#03C03C");

                addSlotButton.Width = 426;
                addSlotButton.Height = 126;
                addSlotButton.Font = new Font("Cascadia Code", 18, FontStyle.Bold);
                addSlotButton.Text = "Add new parking slot";

                addSlotButton.Click += (sender, e) =>
                {
                    ParkingSlot.AddNewParkingSlot(floorId);
                    renderParkingSlots(floorId);
                };

                flowLayoutPanel1.Controls.Add(addSlotButton);
            }
            renderVehicleCount();
        }

        public static void renderFloors()
        {
            floorPanel.Controls.Clear();
            Floor[] floors = Floor.GetFloors();

            floorPanel.AutoScroll = floors.Length > 4;

            Button selectedButton = null;

            foreach (Floor f in floors)
            {
                Button button = new Button();
                button.Width = 225;
                button.BackColor = Color.White;
                button.Height = floorPanel.Height;
                button.Cursor = Cursors.Hand;
                button.ForeColor = Color.FromArgb(32, 32, 64);
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Margin = new Padding(0, 0, 5, 0);
                button.Text = "Floor " + f.FloorId.ToString();
                button.Font = new Font("Cascadia Code", 18, FontStyle.Bold);

                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 2;
                button.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 64);

                button.Click += (sender, e) =>
                {
                    // Reset appearance of all buttons
                    foreach (Control control in floorPanel.Controls)
                    {
                        if (control is Button)
                        {
                            control.BackColor = Color.White;
                            control.ForeColor = Color.FromArgb(32, 32, 64);
                        }
                    }

                    button.BackColor = primary;
                    button.ForeColor = Color.White;

                    selectedButton = button;

                    renderParkingSlots(f.FloorId);
                };

                floorPanel.Controls.Add(button);

                if (selectedButton == null)
                {
                    selectedButton = button;
                    selectedButton.BackColor = primary;
                    selectedButton.ForeColor = Color.White;
                }
            }
        }


        private void floorPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Floor.AddNewFloor();
            renderFloors();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Matrix matrix = new Matrix();
            matrix.Show();
        }
    }
}
