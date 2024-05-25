using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem2.models
{
    public class ParkingSlot
    {
        public int ParkingSlotID { get; set; }
        public int FloorId { get; set; }
        public int? TransactionId { get; set; }
        public int IsAvailable { get; set; }


        public ParkingSlot(int floorId, int 
            parkingId, int? transactionId, int isAvailable) 
        {
            FloorId = floorId;
            ParkingSlotID = parkingId;
            TransactionId = transactionId;
            IsAvailable = isAvailable;
        }

        public ParkingSlot()
        {

        }

        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkingSystemDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public static void AddNewParkingSlot(int floorId)
        {
            string query = "INSERT INTO parkingSlot (floorId) VALUES (@FloorId)";
       
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FloorId", floorId);
                    try
                    {
                        connection.Open();
                        var result = command.ExecuteScalar();
                        MessageBox.Show("New parking slot added successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        public static ParkingSlot[] GetParkingSlots(int floorId)
        {
            List<ParkingSlot> parkingSlots = new List<ParkingSlot>();
            string query = "SELECT * from parkingSlot WHERE FloorId = @FloorId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FloorId", floorId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    int floor_id = (int)reader["floorId"];
                    int parking_id = (int)reader["parkingSlotId"];
                    int? transactionId = reader["transactionId"] == DBNull.Value ? (int?)null : (int)reader["transactionId"]; // Nullable int

                    int isAvailable = (int)reader["isAvailable"];

                    ParkingSlot slot = new ParkingSlot(floor_id, parking_id, transactionId, isAvailable);
                    parkingSlots.Add(slot);
                }

                reader.Close();
                return parkingSlots.ToArray();

            }

        }

        public static void ParkVehicle(int transactionId, int parkingSlotId)
        {
            string query = "UPDATE parkingSlot SET transactionId = @TransactionId, IsAvailable = 0 " +
                           "WHERE parkingSlotId = @ParkingSlotId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransactionId", transactionId);
                command.Parameters.AddWithValue("@ParkingSlotId", parkingSlotId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Vehicle parked successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to park vehicle.");
                }

                connection.Close();
            }
        }

        public static int GetCountOfParkedVehicles()
        {
            int count = 0;
            string query = "SELECT * FROM parkingSlot WHERE isAvailable = 0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    count++;
                }

            }

            return count;
        }

        public static void ParkOut(ParkingSlot slot)
        {
            string query = "UPDATE parkingSlot SET IsAvailable = 1, transactionId = null " +
                           "WHERE parkingSlotId = @ParkingSlotId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ParkingSlotId", slot.ParkingSlotID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }


}
