using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem2.models
{
    public class TransactionHistory
    {
        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkingSystemDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public int Id { set; get; }
        public string PlateNumber { set; get; }

        public string ParkedBy { set; get; }
        public DateTime ParkInTime { set; get; }
        public DateTime ParkOutTime { set; get; }

        public int ParkingFee {  set; get; }

        public TransactionHistory(int id, string plateNumber, string parkedBy,
            DateTime parkInTime,
            DateTime parkOutTime, int parkingFee) 
        {
            Id = id;
            PlateNumber = plateNumber;
            ParkedBy = parkedBy;
            ParkInTime = parkInTime;
            ParkOutTime = parkOutTime;
            ParkingFee = parkingFee;
        }


        public static void AddTransactionHistory(string plateNumber, string parkedBy,
    DateTime parkInTime,
    DateTime? parkOutTime, int? parkingFee)
        {
            // Construct the SQL query for insertion
            string query = @"INSERT INTO transactionHistory (PlateNumber, ParkedBy, ParkInTime, ParkOutTime, ParkingFee)
                     VALUES (@PlateNumber, @ParkedBy, @ParkInTime, @ParkOutTime, @ParkingFee)";

            // Create a SqlConnection and SqlCommand to execute the query
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the SqlCommand
                    command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                    command.Parameters.AddWithValue("@ParkedBy", parkedBy);
                    command.Parameters.AddWithValue("@ParkInTime", parkInTime);

                    // Check if parkOutTime is null before adding it as a parameter
                    if (parkOutTime.HasValue)
                    {
                        command.Parameters.AddWithValue("@ParkOutTime", parkOutTime.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ParkOutTime", DBNull.Value);
                    }
                    if (parkingFee.HasValue)
                    {
                        command.Parameters.AddWithValue("@ParkingFee", parkingFee.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ParkingFee", DBNull.Value);
                    }

                    // Open the connection and execute the query
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static TransactionHistory[] GetTransactionHistory()
        {
            List<TransactionHistory> transactionHistoryList = new List<TransactionHistory>();
            string query = "SELECT * FROM transactionHistory";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string plateNumber = reader["plateNumber"] as string;
                        string parkedby = reader["parkedBy"] as string;
                        DateTime parkIn = (DateTime) reader["parkInTime"];
                        DateTime parkOut = (DateTime)reader["parkOutTime"];
                        int parkingFee = (int)reader["parkingFee"];

                        TransactionHistory history = new TransactionHistory(id, plateNumber, parkedby,
                            parkIn, parkOut, parkingFee);

                        transactionHistoryList.Add(history);
                    }

                    reader.Close();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return transactionHistoryList.ToArray();
        }


    }
}
