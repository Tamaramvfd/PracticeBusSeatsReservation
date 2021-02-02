using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBusSeats
{
    
    public partial class Form1 : Form
    {
        private int sillasLibres = 8;
        private Boolean control = false;
        int seatsFree;
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = sillasLibres.ToString();
        }

        private void userControlBus1_SeatsTakenEvent(object sender, EventArgs e)
        {
           
                
                sillasLibres--;
            textBox2.Text = sillasLibres.ToString();
            control = false;
        }

        private void userControlBus1_SeatsClearEvent(object sender, EventArgs e)
        {
            control = true;
            sillasLibres = 8;
            textBox2.Text = sillasLibres.ToString();
        }
    }
}
