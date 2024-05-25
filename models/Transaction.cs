using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ParkingSystem2.models
{
    public class Transaction
    {
        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkingSystemDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public int TransactionId { get; set; }
        public string PlateNumber { get; set; }
        public string VehicleBrand { get; set; }
        public string VehicleType { get; set; }
        public string ParkedBy { get; set; }
        public DateTime ParkInTime { get; set; }
        public DateTime? ParkOutTime { get; set; }
        public int? Duration { get; set; }
        public int FlagDown { get; set; }
        public int? ParkingFee { get; set; }

        public Transaction()
        {

        }
        public Transaction(
        int transactionId,
        string plateNumber,
        string vehicleType,
        string vehicleBrand,
        string parkedBy,
        DateTime parkInTime,
        DateTime? parkOutTime,
        int flagDown,
        int? duration,
        int? parkingFee)
        {
            TransactionId = transactionId;
            PlateNumber = plateNumber;
            VehicleBrand = vehicleBrand;
            VehicleType = vehicleType;
            ParkedBy = parkedBy;
            ParkInTime = parkInTime;
            ParkOutTime = parkOutTime;
            Duration = duration;
            FlagDown = flagDown;
            ParkingFee = parkingFee;
        }

        public static Transaction GetTransactionById(int? transactionId)
        {
            Transaction transaction = null;

            string query = @"
            SELECT 
                t.transactionId,
                t.duration,
                t.flagDown,
                t.parkingFee,
                t.parkInTime,
                t.parkOutTime,
                v.plateNumber,
                v.vehicleType,
                v.vehicleBrand,
                CONCAT(u.firstName, ' ', u.lastName) AS parkedBy
            FROM 
                transactions t
            INNER JOIN 
                vehicles v ON t.vehicleId = v.vehicleId
            INNER JOIN 
                users u ON t.parkedBy = u.userId
            WHERE 
                t.transactionId = @TransactionId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransactionId", transactionId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int? duration = reader["duration"] as int?;
                    int flagDown = (int)reader["flagdown"];
                    int? parkingFee = reader["parkingFee"] as int?;
                    int transaction_id = (int)reader["transactionId"];
                    DateTime parkInTime = (DateTime)reader["parkInTime"];
                    DateTime? parkOutTime = reader.IsDBNull(reader.GetOrdinal("parkOutTime"))
                                    ? (DateTime?)null
                                    : (DateTime)reader["parkOutTime"];
                    string plateNumber = reader["plateNumber"] as string;
                    string vehicleType = reader["vehicleType"] as string;
                    string vehicleBrand = reader["vehicleBrand"] as string;
                    string parkedBy = reader["parkedBy"] as string;

                    transaction =
                        new Transaction(transaction_id, plateNumber,
                        vehicleType, vehicleBrand, parkedBy, parkInTime, parkOutTime, flagDown, duration, parkingFee);

                }

                return transaction;
            }
        }

        public static int AddNewTransaction(int vehicleId)
        {
            int transactionId = -1; // Default value if insertion fails

            string query = "INSERT INTO transactions (vehicleId, parkedBy, parkInTime, flagDown) " +
                           "OUTPUT INSERTED.transactionId " +
                           "VALUES (@VehicleId, @ParkedBy, @ParkInTime, @FlagDown)";

            Vehicle vehicle = Vehicle.GetVehicleById(vehicleId);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                int flagDown = 0;


                switch (vehicle.VehicleType)
                {
                    case "Van":
                    case "SUV":
                        flagDown = 40;
                        break;
                    case "Sedan":
                        flagDown = 30;
                        break;
                    case "Motorbike":
                        flagDown = 20;
                        break;
                    default:
                        break;
                }

                // Add parameters to the command
                command.Parameters.AddWithValue("@FlagDown", flagDown);
                command.Parameters.AddWithValue("@VehicleId", vehicleId);
                command.Parameters.AddWithValue("@ParkedBy", Dashboard.userId); // Assuming parkedBy is always 1 for now
                command.Parameters.AddWithValue("@ParkInTime", DateTime.Now);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    transactionId = (int)result;
                }
            }

            return transactionId;
        }

        public static Transaction UpdateTransaction(int transactionId)
        {
 
            string query = "UPDATE transactions SET parkOutTime = @ParkOut, duration = DATEDIFF(second, parkInTime, @ParkOut)" +
                "WHERE transactionId = @TransactionId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ParkOut", DateTime.Now);
                command.Parameters.AddWithValue("@TransactionId", transactionId);

                connection.Open(); // Open the connection
                command.ExecuteNonQuery(); // Execute the update command
                connection.Close(); // Close the connection

                Transaction transaction = Transaction.GetTransactionById(transactionId);
                transaction = calculateFee(transaction);
                return transaction; 
            }
        }

        public static Transaction calculateFee(Transaction transaction)
        {
            int addPerHour = 0;

            switch (transaction.FlagDown)
            {
                case 40:
                    addPerHour = 20;
                    break;
                case 30:
                    addPerHour = 15;
                    break;
                case 20:
                    addPerHour = 5;
                    break;
                default:
                    break;

            }

            String query = "UPDATE transactions SET parkingFee = @ParkingFee " +
                "WHERE transactionId = @TransactionId";

            int duration = transaction.Duration ?? 0;
            int parkingFee = transaction.FlagDown + ( (duration / 3600) * addPerHour );
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ParkingFee", parkingFee);
                command.Parameters.AddWithValue("@TransactionId", transaction.TransactionId);

                connection.Open(); // Open the connection
                command.ExecuteNonQuery(); // Execute the update command
                connection.Close(); // Close the connection

                transaction = Transaction.GetTransactionById(transaction.TransactionId);
                return transaction;
            }
        }

        public static void DeleteTransaction (Transaction transaction)
        {
            string query = "DELETE FROM transactions " +
                "WHERE transactionId = @TransactionId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransactionId", transaction.TransactionId);

                connection.Open(); // Open the connection
                command.ExecuteNonQuery(); // Execute the update command
                connection.Close(); // Close the connection


                TransactionHistory.AddTransactionHistory(transaction.PlateNumber, transaction.ParkedBy,
                    transaction.ParkInTime, transaction.ParkOutTime, transaction.ParkingFee);
                
                Vehicle.DeleteVehicle(transaction.PlateNumber);
            }
        }



    }
}
