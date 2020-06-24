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
    public partial class Date : Form
    {
        public Date()
        {
            InitializeComponent();
        }
        private void q6rbKOR_CheckedChanged_1(object sender, EventArgs e)
        {
            q6lbl1.Text = "1월 ~ 12월";
        }

        private void q6rbKOR_CheckedChanged(object sender, EventArgs e)
        {
            q6lbl1.Text = "1월 ~ 12월";
        }

        private void q6rbJPN_CheckedChanged(object sender, EventArgs e)
        {
            q6lbl1.Text = "3월 ~ 6월, 10월 ~ 12월";
        }

        private void q6rbCHN_CheckedChanged(object sender, EventArgs e)
        {
            q6lbl1.Text = "4월 ~ 6월, 9월 ~ 11월";
        }

        private void q6rbUSD_CheckedChanged(object sender, EventArgs e)
        {
            q6lbl1.Text = "4월 ~ 11월";
        }

        private void q6rbAUD_CheckedChanged(object sender, EventArgs e)
        {
            q6lbl1.Text = "3월~6월, 9월~11월";
        }

        private void q6rbIDR_CheckedChanged(object sender, EventArgs e)
        {
            q6lbl1.Text = "5월 ~ 8월";
        }

        private void q6rbWEUR_CheckedChanged(object sender, EventArgs e)
        {
            q6lbl1.Text = "3월 ~ 6월";
        }

        private void q6rbEEUR_CheckedChanged(object sender, EventArgs e)
        {
            q6lbl1.Text = "10월 ~ 2월";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
