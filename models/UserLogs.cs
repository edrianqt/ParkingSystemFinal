using System;
using System.Data.SqlClient;
using System.Windows.Forms; // Required for MessageBox if you're using WinForms

namespace ParkingSystem2.models
{
    internal class UserLogs
    {
        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkingSystemDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public int LogId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public DateTime LogDate { get; set; }

        public UserLogs(int logId, string firstName, string lastName, string userName, DateTime logDate)
        {
            LogId = logId;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            LogDate = logDate;
        }

        public UserLogs() { }

        public static void AddNewUserLogs(int userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO userLogs(userId, logDate) VALUES(@UserId, @LogDate)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@LogDate", DateTime.Now);
                    command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public static UserLogs[] GetUserLogs()
        {
            var list = new List<UserLogs>();
            string query = @"
                    SELECT userLogs.logId, users.firstName, users.lastName, users.userName, userLogs.logDate
                    FROM userLogs
                    INNER JOIN users ON userLogs.userId = users.userId";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int logId = (int)reader["logId"];
                    string firstname = (string)reader["firstName"];
                    string lastName = (string)reader["lastName"];
                    string username = (string)reader["userName"];
                    DateTime logDate = (DateTime)reader["logDate"];

                    UserLogs userLog = new UserLogs(logId, firstname, lastName, username, logDate);
                    list.Add(userLog);
                }

                return list.ToArray();
            }
        }


        public static UserLogs[] GetUserLogsByFilter(string filterType, string filter)
        {
            var list = new List<UserLogs>();

            string query;

            if (filterType == "userLogs.logDate")
            {
                query = $@"SELECT userLogs.logId, users.firstName, users.lastName, users.userName, userLogs.logDate
                   FROM userLogs
                   INNER JOIN users ON userLogs.userId = users.userId
                   WHERE CAST(userLogs.logDate AS DATE) = @Filter";
            }
            else
            {
                query = $@"SELECT userLogs.logId, users.firstName, users.lastName, users.userName, userLogs.logDate
                   FROM userLogs
                   INNER JOIN users ON userLogs.userId = users.userId
                   WHERE {filterType} = @Filter";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (filterType == "userLogs.logDate")
                {
                    if (DateTime.TryParse(filter, out DateTime filteredDate))
                    {
                        command.Parameters.AddWithValue("@Filter", filteredDate.Date);
                    }
                    else
                    {
                        MessageBox.Show("Invalid date format.");
                        return null;
                    }
                }
                else
                {
                    command.Parameters.AddWithValue("@Filter", filter);
                }

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int logId = (int)reader["logId"];
                    string firstName = (string)reader["firstName"];
                    string lastName = (string)reader["lastName"];
                    string userName = (string)reader["userName"];
                    DateTime logDate = (DateTime)reader["logDate"];

                    UserLogs userLog = new UserLogs(logId, firstName, lastName, userName, logDate);
                    list.Add(userLog);

                }

                return list.ToArray();
            }

        }
    }
}
