using ParkingSystem2;
using ParkingSystem2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystemGUI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkingSystemDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            SqlConnection conn = new SqlConnection(connectionString);

            string firstname = firstnameInput.Text;
            string lastname = lastnameInput.Text;
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            if (firstname == "" || lastname == "" || username == "" || password == "")
            {
                MessageBox.Show("All inputs must be filled.");
            }

            else
            {
                User user = new User();
                int isRegisterSuccess = user.RegisterNewUser(firstname, lastname, username, password);

                if (isRegisterSuccess != 0)
                {
                    MessageBox.Show($"Registered Successfully. Welcome {username}");
                    Dashboard dashboard = new Dashboard(isRegisterSuccess);
                    this.Hide();
                    dashboard.Show();
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

