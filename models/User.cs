using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ParkingSystem2.models
{
    internal class User
    {
        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkingSystemDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        SqlConnection connection = new SqlConnection(connectionString);

        public User()
        {

        }

        public int RegisterNewUser(string firstName, string lastName, string userName, string password)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO users(firstName, lastName, userName, password) OUTPUT INSERTED.userId VALUES(@FirstName, @LastName, @UserName, @Password)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", password);

                int userId = (int)command.ExecuteScalar();
                UserLogs.AddNewUserLogs(userId);
                return userId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Username already taken.");
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public int LoginUser(String username, String password)
        {

            try
            {
                String query = $"SELECT * from users WHERE username = '{username}' and password = '{password}'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                // Check if any rows were returned
                if (dataTable.Rows.Count > 0)
                {
                    // Authentication successful, do something with the retrieved data
                    // For example, access specific columns of the first row:
                    int userId = Convert.ToInt32(dataTable.Rows[0]["userId"]);
                    UserLogs.AddNewUserLogs(userId);
                    return userId;

                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
            finally
            {
                connection.Close();
            }

            return 0;
        }
    }

}
