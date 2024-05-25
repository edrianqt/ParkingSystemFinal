using ParkingSystem2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ParkingSystem2
{
    public partial class Receipt : Form
    {
        int floorId;
        ParkingSystem2.models.Transaction transaction = new ParkingSystem2.models.Transaction();
        public Receipt(ParkingSystem2.models.Transaction transaction, int floorId)
        {
            
            InitializeComponent();
            plateNumber.Text = transaction.PlateNumber;
            parkedBy.Text = transaction.ParkedBy;
            parkIn.Text = transaction.ParkInTime.ToString();
            parkOut.Text = transaction.ParkOutTime.ToString();
            duration.Text = DurationToWords(transaction.Duration);
            flagDown.Text = transaction.FlagDown.ToString();
            fee.Text = transaction.ParkingFee.ToString();
            this.floorId = floorId;
            this.transaction = transaction;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public string DurationToWords(int? duration)
        {
            if (!duration.HasValue)
            {
                return "Duration not available"; // or any other default message you want
            }

            int durationInSeconds = duration.Value;

            string durationText;

            if (durationInSeconds >= 3600)
            {
                int hours = durationInSeconds / 3600;
                int minutes = (durationInSeconds % 3600) / 60;
                int seconds = durationInSeconds % 60;
                durationText = $"{hours} hour{(hours > 1 ? "s" : "")}, {minutes} minute{(minutes > 1 ? "s" : "")}, {seconds} second{(seconds > 1 ? "s" : "")}";
            }
            else if (durationInSeconds >= 60)
            {
                int minutes = durationInSeconds / 60;
                int seconds = durationInSeconds % 60;
                durationText = $"{minutes} minute{(minutes > 1 ? "s" : "")}, {seconds} second{(seconds > 1 ? "s" : "")}";
            }
            else
            {
                durationText = $"{durationInSeconds} second{(durationInSeconds > 1 ? "s" : "")}";
            }

            return durationText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParkingSystem2.models.Transaction.DeleteTransaction(transaction);
            Home.renderParkingSlots(floorId);
            transactionHistory.renderHistory();
            this.Close();
        }
    }
}
