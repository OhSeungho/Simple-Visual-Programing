using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _2019VisualProgramingProject
{
    public partial class Database : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Database()
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=C:\Users\tmdgh\Documents\dbAirline.mdb";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from AirN";
            OleDbDataReader reader = cmd.ExecuteReader();
            string line = "";
            while (reader.Read())
            {
                line = reader["항공사"].ToString() + " | " + reader["항공편"].ToString() + " | " + reader["출발시간"].ToString() + " | " + reader["도착시간"].ToString() + "\r\n";
                tb.Text += line;
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from AirL";
            OleDbDataReader reader = cmd.ExecuteReader();
            string line = "";
            while (reader.Read())
            {
                line = reader["항공사"].ToString() + " | " + reader["항공편"].ToString() + " | " + reader["출발시간"].ToString() + " | " + reader["도착시간"].ToString() + "\r\n";
                tb.Text += line;
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from AirE";
            OleDbDataReader reader = cmd.ExecuteReader();
            string line = "";
            while (reader.Read())
            {
                line = reader["항공사"].ToString() + " | " + reader["항공편"].ToString() + " | " + reader["출발시간"].ToString() + " | " + reader["도착시간"].ToString() + "\r\n";
                tb.Text += line;
            }
            con.Close();
        }
    }
}
