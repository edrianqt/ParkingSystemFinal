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

namespace ParkingSystem2
{
    public partial class Dashboard : Form
    {
        public static int userId;
        Color primary = Color.FromArgb(32, 32, 66);
        Color secondary = Color.FromArgb(58, 59, 89);

        public Dashboard(int userId)
        {
            InitializeComponent();
            Dashboard.userId = userId;
        }

        private void homeBox_Click(object sender, EventArgs e)
        {
            homeBox.BackColor = secondary;
            parkBox.BackColor = primary;
            historyBox.BackColor = primary;
            home1.Visible = true;
            transactionHistory1.Visible = false;
            userLogs2.Visible = false;
        }

        private void parkBox_Click(object sender, EventArgs e)
        {
            parkBox.BackColor = secondary;
            homeBox.BackColor = primary;
            historyBox.BackColor = primary;
            home1.Visible = false;
            userLogs2.Visible = false;
            transactionHistory1.Visible = true;
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            home1.Visible = true;
            transactionHistory1.Visible = false;
            userLogs2.Visible = false;
        }


        private void historyBox_Click_1(object sender, EventArgs e)
        {
            historyBox.BackColor = secondary;
            homeBox.BackColor = primary;
            parkBox.BackColor = primary;
            userLogs2.Visible = true;
            home1.Visible = false;
            transactionHistory1.Visible = false;
        }

        private void logOutBox_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
    }
}
