using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019VisualProgramingProject
{
    public partial class Check : Form
    {
        public string checkresult { set; get; }

        public Check()
        {
            InitializeComponent();
        }

        private void q7bt1_Click(object sender, EventArgs e)
        {
            string checklist = "";
            string nchecklist = "";
            if (q7cb1.Checked)
            {
                checklist = checklist + q7cb1.Text + ", ";
            }
            if (q7cb2.Checked)
            {
                checklist = checklist + q7cb2.Text + ", ";
            }
            if (q7cb3.Checked)
            {
                checklist = checklist + q7cb3.Text + ", ";
            }
            if (q7cb4.Checked)
            {
                checklist = checklist + q7cb4.Text + ", ";
            }
            if (q7cb5.Checked)
            {
                checklist = checklist + q7cb5.Text + ", ";
            }
            if (q7cb6.Checked)
            {
                checklist = checklist + q7cb6.Text + ", ";
            }
            if (q7cb7.Checked)
            {
                checklist = checklist + q7cb7.Text + ", ";
            }
            if (q7cb8.Checked)
            {
                checklist = checklist + q7cb8.Text + ", ";
            }
            if (q7cb9.Checked)
            {
                checklist = checklist + q7cb9.Text + ", ";
            }
            if (q7cb10.Checked)
            {
                checklist = checklist + q7cb10.Text + ", ";
            }
            if (q7cb11.Checked)
            {
                checklist = checklist + q7cb11.Text + ", ";
            }
            if (q7cb12.Checked)
            {
                checklist = checklist + q7cb12.Text + ", ";
            }
            if (q7cb13.Checked)
            {
                checklist = checklist + q7cb13.Text + ", ";
            }
            if (q7cb14.Checked)
            {
                checklist = checklist + q7cb14.Text + ", ";
            }
            if (q7cb15.Checked)
            {
                checklist = checklist + q7cb15.Text + ", ";
            }
            if (q7cb16.Checked)
            {
                checklist = checklist + q7cb16.Text + ", ";
            }
            if (q7cb17.Checked)
            {
                checklist = checklist + q7cb17.Text + ", ";
            }
            if (q7cb18.Checked)
            {
                checklist = checklist + q7cb18.Text + ", ";
            }
            if (q7cb19.Checked)
            {
                checklist = checklist + q7cb19.Text + ", ";
            }
            if (q7cb20.Checked)
            {
                checklist = checklist + q7cb20.Text + ", ";
            }
            if (q7cb21.Checked)
            {
                checklist = checklist + q7cb21.Text + ", ";
            }
            if (q7cb22.Checked)
            {
                checklist = checklist + q7cb22.Text + ", ";
            }
            if (q7cb1.Checked == false)
            {
                nchecklist = nchecklist + q7cb1.Text + ", ";
            }
            if (q7cb2.Checked == false)
            {
                nchecklist = nchecklist + q7cb2.Text + ", ";
            }
            if (q7cb3.Checked == false)
            {
                nchecklist = nchecklist + q7cb3.Text + ", ";
            }
            if (q7cb4.Checked == false)
            {
                nchecklist = nchecklist + q7cb4.Text + ", ";
            }
            if (q7cb5.Checked == false)
            {
                nchecklist = nchecklist + q7cb5.Text + ", ";
            }
            if (q7cb6.Checked == false)
            {
                nchecklist = nchecklist + q7cb6.Text + ", ";
            }
            if (q7cb7.Checked == false)
            {
                nchecklist = nchecklist + q7cb7.Text + ", ";
            }
            if (q7cb8.Checked == false)
            {
                nchecklist = nchecklist + q7cb8.Text + ", ";
            }
            if (q7cb9.Checked == false)
            {
                nchecklist = nchecklist + q7cb9.Text + ", ";
            }
            if (q7cb10.Checked == false)
            {
                nchecklist = nchecklist + q7cb10.Text + ", ";
            }
            if (q7cb11.Checked == false)
            {
                nchecklist = nchecklist + q7cb11.Text + ", ";
            }
            if (q7cb12.Checked == false)
            {
                nchecklist = nchecklist + q7cb12.Text + ", ";
            }
            if (q7cb13.Checked == false)
            {
                nchecklist = nchecklist + q7cb13.Text + ", ";
            }
            if (q7cb14.Checked == false)
            {
                nchecklist = nchecklist + q7cb14.Text + ", ";
            }
            if (q7cb15.Checked == false)
            {
                nchecklist = nchecklist + q7cb15.Text + ", ";
            }
            if (q7cb16.Checked == false)
            {
                nchecklist = nchecklist + q7cb16.Text + ", ";
            }
            if (q7cb17.Checked == false)
            {
                nchecklist = nchecklist + q7cb17.Text + ", ";
            }
            if (q7cb18.Checked == false)
            {
                nchecklist = nchecklist + q7cb18.Text + ", ";
            }
            if (q7cb19.Checked == false)
            {
                nchecklist = nchecklist + q7cb19.Text + ", ";
            }
            if (q7cb20.Checked == false)
            {
                nchecklist = nchecklist + q7cb20.Text + ", ";
            }
            if (q7cb21.Checked == false)
            {
                nchecklist = nchecklist + q7cb21.Text + ", ";
            }
            if (q7cb22.Checked == false)
            {
                nchecklist = nchecklist + q7cb22.Text + ", ";
            }
            checkresult = nchecklist;
            MessageBox.Show("선택한 물품은 " + checklist + "입니다");
            MessageBox.Show("선택하지 않은 물품은 " + nchecklist + "입니다");

            Close();
        }
    }
}
