using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem2.models
{
    internal class Vehicle
    {
        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkingSystemDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public string PlateNumber { get; set; } 
        public string VehicleBrand { get; set; }
        public string VehicleType { get; set; }

        public Vehicle(string plateNumber, string vehicleType, string vehicleBrand)
        {
            PlateNumber = plateNumber;
            VehicleType = vehicleType;
            VehicleBrand = vehicleBrand;
        }

        public static int addVehicle(Vehicle vehicle)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    connection.Open();
                    string query = "INSERT INTO vehicles(plateNumber, vehicleType, vehicleBrand) " +
                        "VALUES(@PlateNumber, @VehicleType, @VehicleBrand); SELECT SCOPE_IDENTITY();";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PlateNumber", vehicle.PlateNumber);
                    command.Parameters.AddWithValue("@VehicleType", vehicle.VehicleType);
                    command.Parameters.AddWithValue("@VehicleBrand", vehicle.VehicleBrand);
                    int vehicleId = Convert.ToInt32(command.ExecuteScalar());

                    return vehicleId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Vehicle with plate number {vehicle.PlateNumber} already parked.");
                return 0;
            }
        }


        public static void DeleteVehicle(string plateNumber)
        {
            String query = "DELETE FROM vehicles WHERE plateNumber = @PlateNumber;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                        int rowsAffected = command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static Vehicle GetVehicleById(int vehicleId)
        {
            Vehicle vehicle = null;

            string query = "SELECT * FROM vehicles WHERE vehicleId = @VehicleId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@vehicleId", vehicleId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string plateNumber = reader["plateNumber"].ToString();
                                string vehicleType = reader["vehicleType"].ToString();
                                string vehicleBrand = reader["vehicleBrand"].ToString();

                                vehicle = new Vehicle(plateNumber, vehicleType, vehicleBrand);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return vehicle;
        }
    }
}
