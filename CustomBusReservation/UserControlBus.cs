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
        public event EventHandler SeatsClearEvent;
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

            valFreeSeats--;
            OnSeatsTaken(EventArgs.Empty);
        }

        protected virtual void OnSeatsTaken(EventArgs e)
        {
            SeatsTakenEvent?.Invoke(this, e);
        }

        protected virtual void OnSeatsClear(EventArgs e)
        {
            SeatsClearEvent?.Invoke(this, e);
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            limpiarBotones();
            valFreeSeats = valCapacity;
        }

        public void limpiarBotones()
        {
            button1.Text = "Free";
            button1.BackColor = Color.Empty;
            button1.Enabled = true;

            button2.Text = "Free";
            button2.BackColor = Color.Empty;
            button2.Enabled = true;

            button3.Text = "Free";
            button3.BackColor = Color.Empty;
            button3.Enabled = true;

            button4.Text = "Free";
            button4.BackColor = Color.Empty;
            button4.Enabled = true;

            button5.Text = "Free";
            button5.BackColor = Color.Empty;
            button5.Enabled = true;

            button6.Text = "Free";
            button6.BackColor = Color.Empty;
            button6.Enabled = true;

            button7.Text = "Free";
            button7.BackColor = Color.Empty;
            button7.Enabled = true;

            button8.Text = "Free";
            button8.BackColor = Color.Empty;
            button8.Enabled = true;
        }
    }
}
