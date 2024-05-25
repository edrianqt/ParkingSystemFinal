using ParkingSystem2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem2.usercontrols
{
    public partial class userLogs : UserControl
    {
        public userLogs()
        {
            InitializeComponent();
            renderUserLogs();
            exitIcon.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void renderUserLogs()
        {
            userLogsPanel.Controls.Clear();

            models.UserLogs[] adminLogs = models.UserLogs.GetUserLogs();
            userLogsPanel.AutoScroll = (adminLogs.Length > 6);
            userLogsPanel.WrapContents = true;

            foreach (models.UserLogs adminLog in adminLogs)
            {
                createUserLogComponent(adminLog);
            }
        }

        private void createUserLogComponent(models.UserLogs adminLog)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Margin = new Padding(0);
            panel.Padding = new Padding(0);
            panel.Size = new Size(1328, 71);

            if (adminLog.LogId % 2 == 0)
            {
                panel.BackColor = Color.WhiteSmoke;
            }
            else
            {
                panel.BackColor = Color.White;
            }


            Label firstNameLabel = new Label();
            firstNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            firstNameLabel.Size = new Size(314, 71);
            firstNameLabel.Padding = new Padding(0);
            firstNameLabel.Margin = new Padding(0, 0, 0, 0);
            firstNameLabel.Text = adminLog.FirstName.ToString();
            firstNameLabel.Font = new Font("Cascadia Mono", 15, FontStyle.Regular);

            Label lastNameLabel = new Label();
            lastNameLabel.Size = new Size(290, 71);
            lastNameLabel.Padding = new Padding(0);
            lastNameLabel.Margin = new Padding(0, 0, 0, 0);
            lastNameLabel.Text = adminLog.LastName.ToString();
            lastNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            lastNameLabel.Font = new Font("Cascadia Mono", 15, FontStyle.Regular);

            Label usernameLabel = new Label();
            usernameLabel.Size = new Size(315, 71);
            usernameLabel.Padding = new Padding(0);
            usernameLabel.Margin = new Padding(0, 0, 0, 0);
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            usernameLabel.Text = adminLog.UserName.ToString();
            usernameLabel.Font = new Font("Cascadia Mono", 15, FontStyle.Regular);

            Label logDateLabel = new Label();
            logDateLabel.Size = new Size(406, 71);
            logDateLabel.Padding = new Padding(0);
            logDateLabel.TextAlign = ContentAlignment.MiddleCenter;
            logDateLabel.Margin = new Padding(0, 0, 0, 0);
            logDateLabel.Text = adminLog.LogDate.ToString();
            logDateLabel.Font = new Font("Cascadia Mono", 15, FontStyle.Regular);

            panel.Controls.Add(lastNameLabel);
            panel.Controls.Add(firstNameLabel);
            panel.Controls.Add(usernameLabel);
            panel.Controls.Add(logDateLabel);

            userLogsPanel.Controls.Add(panel);
        }

        public void renderByFilter()
        {
            
            string filter = filterInput.Text;

            if (filterTypeBox.SelectedItem == null)
            {
                MessageBox.Show("Select the right filter type.");
                return;
            }

            searchIcon.Visible = false;
            exitIcon.Visible = true;

            string filterType = filterTypeBox.SelectedItem.ToString();

            switch (filterType)
            {
                case "Last Name":
                    filterType = "users.lastName";
                    break;
                case "First Name":
                    filterType = "users.firstName";
                    break;
                case "Date":
                    filterType = "userLogs.logDate";
                    break;
                case "Username":
                    filterType = "users.userName";
                    break;
            }

            models.UserLogs[] adminLogs = models.UserLogs.GetUserLogsByFilter(filterType, filter);

            if (adminLogs == null) return;

            userLogsPanel.Controls.Clear();

            userLogsPanel.AutoScroll = (adminLogs.Length > 6);
            userLogsPanel.WrapContents = true;

            foreach (models.UserLogs adminLog in adminLogs)
            {
                createUserLogComponent(adminLog);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            renderByFilter();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (panel1.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 3;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panel1.ClientSize.Width - thickness,
                                                              panel1.ClientSize.Height - thickness));
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            exitIcon.Visible = false;
            searchIcon.Visible = true;
            filterTypeBox.SelectedItem = null;
            filterTypeBox.Text = "Filter";
            filterInput.Text = "";
            filterInput.PlaceholderText = "Search";
            renderUserLogs();
        }
    }
}
