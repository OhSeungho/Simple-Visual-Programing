using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2019VisualProgramingProject
{
    public partial class AirlineTicket : Form
    {
        public string result { set; get; }

        public AirlineTicket()
        {
            InitializeComponent();
        }
        
        private void q10bt1_Click(object sender, EventArgs e)
        {
            string startingpoint, destination, boardingday, passengers, flightclass, resultsave;
            startingpoint = q10lb1.Text;
            destination = q10lb2.Text;
            boardingday = q10lb3.Text;
            passengers = q10lb4.Text;
            flightclass = q10lb5.Text;
            result = "Startingpoint :  " + startingpoint + ", Destination : " + destination + ", Boardingday : " + boardingday + ", Passenger : " + passengers + ", Flightclass : " + flightclass + "입니다";
            resultsave = "출발지는 " + startingpoint + ", 목적지는 " + destination + ", 탑승일은 " + boardingday + "일, 승객수는 " + passengers + ", 좌석등급은 " + flightclass + "입니다";
            MessageBox.Show(resultsave);
            
            Close();
        }
    }
}
