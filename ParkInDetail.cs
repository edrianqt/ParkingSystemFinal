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

namespace ParkingSystem2
{
    public partial class ParkInDetail : Form
    {
        ParkingSlot slot = new ParkingSlot();
        Transaction transaction = null;
        public ParkInDetail(ParkingSlot slot)
        {
            transaction = Transaction.GetTransactionById(slot.TransactionId);
            this.slot = slot;
            InitializeComponent();
            plateNumber.Text = transaction.PlateNumber;
            vType.Text = transaction.VehicleType;
            brand.Text = transaction.VehicleBrand;
            parkin.Text = transaction.ParkInTime.ToString();
            flagdown.Text = transaction.FlagDown.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParkingSlot.ParkOut(slot);
            Transaction updatedTransaction = Transaction.UpdateTransaction(transaction.TransactionId);
            Receipt receipt = new Receipt(updatedTransaction, slot.FloorId);
            receipt.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vType_Click(object sender, EventArgs e)
        {

        }
    }
}
