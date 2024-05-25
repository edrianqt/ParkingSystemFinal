using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ParkingSystem2;
using ParkingSystem2.models;

namespace ParkingSystemGUI
{
    public partial class LoginForm : Form
    {
        RegisterForm registerForm;


        public LoginForm()
        {
            registerForm = new RegisterForm();
            InitializeComponent();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            registerForm.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String username = GetUsernameInput().Text.ToString();
            String password = GetPasswordInput().Text.ToString();

            if (username == "" || password == "")
            {
                MessageBox.Show("All inputs must be filled.");
            }

            else
            {
                User admin = new User();
                int isLoginSuccess = admin.LoginUser(username, password);
                if (isLoginSuccess != 0)
                {
                    Dashboard dashboard = new Dashboard(isLoginSuccess);
                    MessageBox.Show($"Welcome, {username}");
                    this.Hide();
                    dashboard.Show();
                }
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
