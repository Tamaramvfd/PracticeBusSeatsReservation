using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomBusReservation
{
    public partial class UserControlBus : UserControl
    {
        private int valFreeSeats;
        private int valCapacity = 8;

        public event EventHandler SeatsTakenEvent;
        public UserControlBus()
        {
            InitializeComponent();
            valFreeSeats = valCapacity;
        }
        public int FreeSeats
        {
            get { return valFreeSeats; }
            set { valFreeSeats = value; }
        }
        public int Capacity
        {
            get { return valCapacity; }
            set { valCapacity = value; }
        }

        private void button_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Taken";
            ((Button)sender).BackColor = Color.Red;
            ((Button)sender).Enabled = false;

            FreeSeats--;
            OnSeatsTaken(EventArgs.Empty);
        }

        protected virtual void OnSeatsTaken(EventArgs e)
        {
            SeatsTakenEvent?.Invoke(this, e);
        }
    }
}
