using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem2.models
{
    internal class Floor
    {
        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkingSystemDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public int FloorId { get; private set; }
        public Floor(int floorId) 
        {
            this.FloorId = floorId;
        }

        public static Floor[] GetFloors()
        {
            var list = new List<Floor>();
            String query = "SELECT * from floors";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Open the connection asynchronously
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader(); // Execute the query asynchronously

                while (reader.Read())
                {
                    int floorId = (int)reader["floorId"];
                    Floor floor = new Floor(floorId);
                    list.Add(floor);    
                }
            }

            return list.ToArray();
        }

        public static void AddNewFloor()
        {
            string query = "INSERT INTO floors DEFAULT VALUES";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Open the connection asynchronously
                SqlCommand command = new SqlCommand(query, connection);
                int rowsAffected = command.ExecuteNonQuery(); // Execute the INSERT operation

                if (rowsAffected > 0) {
                    MessageBox.Show("New floor added successfully!");
                }
                else {
                    MessageBox.Show("Failed to add a new floor.");
                }

            }
        }
    }
}
