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
    public partial class Profile : Form
    {       
        ProfileClass pc;

        public string profiledata { set; get; }

        public Profile()
        {           
            pc = new ProfileClass();
            InitializeComponent();
        }

        private void btIN_Click(object sender, EventArgs e)
        {
            pc.firstname = tbFN.Text;
            pc.lastname = tbLN.Text;
            pc.personalnumber = int.Parse(tbP.Text);
            pc.nation = tbN.Text;
            pc.passportnumber = int.Parse(tbPN.Text);
            profiledata = "이름 : " + pc.firstname + " 성 : " + pc.lastname + "\n" + "주민등록번호 : " + pc.personalnumber + "\n" + "국적 : " + pc.nation + "\n" + "여권번호 : " + pc.passportnumber;
            MessageBox.Show("저장되었습니다");
            
            Close();
        }

        private void btOUT_Click(object sender, EventArgs e)
        {
        }
    }
}
