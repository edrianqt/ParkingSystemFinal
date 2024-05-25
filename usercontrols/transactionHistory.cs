using ParkingSystem2.models;
using ParkingSystem2.usercontrols;
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
    public partial class transactionHistory : UserControl
    {
        public transactionHistory()
        {
            InitializeComponent();
            renderHistory();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public static void renderHistory()
        {
            historyPanel.Controls.Clear();

            models.TransactionHistory[] history = TransactionHistory.GetTransactionHistory();

            historyPanel.AutoScroll = history.Length >= 6;

             foreach(TransactionHistory h in history)
             {
                createHistoryComponent(h);
             }

        }

        public static void createHistoryComponent(models.TransactionHistory history)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Margin = new Padding(0, 0, 0, 15);
            panel.Padding = new Padding(0);
            panel.Size = new Size(1328, 75);
            panel.BackColor = Color.White;
            
            Label plateLabel = new Label();
            plateLabel.ForeColor = Color.Black;
            plateLabel.Size = new Size(248, 75);
            plateLabel.TextAlign = ContentAlignment.MiddleCenter;
            plateLabel.Padding = new Padding(0);
            plateLabel.Margin = new Padding(0, 0, 0, 0);
            plateLabel.Text = history.PlateNumber.ToString();
            plateLabel.Font = new Font("Cascadia Mono", 15, FontStyle.Regular);

            Label parkIn = new Label();
            parkIn.ForeColor = Color.Black;
            parkIn.TextAlign = ContentAlignment.MiddleCenter;
            parkIn.Size = new Size(287, 75);
            parkIn.Padding = new Padding(0);
            parkIn.Margin = new Padding(0, 0, 0, 0);
            parkIn.Text = history.ParkInTime.ToString();
            parkIn.Font = new Font("Cascadia Mono", 15, FontStyle.Regular);

            Label parkOut = new Label();
            parkOut.TextAlign = ContentAlignment.MiddleCenter;

            parkOut.ForeColor = Color.Black;
            parkOut.Size = new Size(313, 75);
            parkOut.Padding = new Padding(0);
            parkOut.Margin = new Padding(0, 0, 0, 0);
            parkOut.Text = history.ParkOutTime.ToString();
            parkOut.Font = new Font("Cascadia Mono", 15, FontStyle.Regular);


            Label parkedBy = new Label();
            parkedBy.TextAlign = ContentAlignment.MiddleCenter;

            parkedBy.ForeColor = Color.Black;
            parkedBy.Size = new Size(303, 75);
            parkedBy.Padding = new Padding(0);
            parkedBy.Margin = new Padding(0, 0, 0, 0);
            parkedBy.Text = history.ParkedBy.ToString();
            parkedBy.Font = new Font("Cascadia Mono", 15, FontStyle.Regular);


            Label Fee = new Label();
            Fee.TextAlign = ContentAlignment.MiddleCenter;
            Fee.ForeColor = Color.Black;
            Fee.Size = new Size(177, 75);
            Fee.Padding = new Padding(0);
            Fee.Margin = new Padding(0, 0, 0, 0);
            Fee.Text = history.ParkingFee.ToString();
            Fee.Font = new Font("Cascadia Mono", 15, FontStyle.Regular);

            panel.Controls.Add(plateLabel);
            panel.Controls.Add(parkIn);
            panel.Controls.Add(parkOut);
            panel.Controls.Add(parkedBy);
            panel.Controls.Add(Fee);

            panel.Cursor = Cursors.Hand;
            historyPanel.Controls.Add(panel);
        }
    }
}
