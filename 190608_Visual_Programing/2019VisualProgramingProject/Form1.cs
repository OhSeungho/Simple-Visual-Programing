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
    public partial class Form1 : Form
    {
        AirlineTicket at = new AirlineTicket();
        Profile pf = new Profile();
        Check ck = new Check();
        CalculatorForm cf = new CalculatorForm();
        Random r = new Random();
        Date dt = new Date();
        Database db = new Database();

        public Form1()
        {
            InitializeComponent();
            // 난수 입력으로 프로그램 실행시마다 각기 다른 이미지 출력
            rdpb.Image = imageList1.Images[r.Next(0, 3)];
        }

        // 퀘스트 1 - 이미지 변경 1
        private void q1pb1_Click(object sender, EventArgs e)
        {
            q1pb1.Image = Properties.Resources.q1pb인천나고야;
        }
        private void q1pb2_Click(object sender, EventArgs e)
        {
            q1pb2.Image = Properties.Resources.q1pb인천상하이;
        }
        private void q1pb3_Click(object sender, EventArgs e)
        {
            q1pb3.Image = Properties.Resources.q1pb인천사이판;
        }
        private void q1pb4_Click(object sender, EventArgs e)
        {
            q1pb4.Image = Properties.Resources.q1pb인천런던;
        }
        private void q1pb5_Click(object sender, EventArgs e)
        {
            q1pb5.Image = Properties.Resources.q1pb인천나고야;
        }

        // 퀘스트 1 - 이미지변경 2
        private void q1bt1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이미지를 선택하세요", "변경");
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.ShowDialog();
            Image img = Image.FromFile(ofg.FileName);
            q1pb1.Image = img;
        }
        private void q1bt2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이미지를 선택하세요", "변경");
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.ShowDialog();
            Image img = Image.FromFile(ofg.FileName);
            q1pb2.Image = img;
        }
        private void q1bt3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이미지를 선택하세요", "변경");
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.ShowDialog();
            Image img = Image.FromFile(ofg.FileName);
            q1pb3.Image = img;
        }
        private void q1bt4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이미지를 선택하세요", "변경");
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.ShowDialog();
            Image img = Image.FromFile(ofg.FileName);
            q1pb4.Image = img;
        }
        private void q1bt5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이미지를 선택하세요", "변경");
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.ShowDialog();
            Image img = Image.FromFile(ofg.FileName);
            q1pb5.Image = img;
        }

        // X
        private void q4bt1_Click(object sender, EventArgs e)
        {
        }
        private void q4tb1_TextChanged(object sender, EventArgs e)
        {
        }
        private void q5bt1_Click(object sender, EventArgs e)
        {
        }
        private void q6rbKOR_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void q6rbJPN_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void q6rbCHN_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void q6rbUSD_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void q6rbAUD_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void q6rbIDR_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void q6rbWEUR_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void q6rbEEUR_CheckedChanged(object sender, EventArgs e)
        {
        }        
        private void button1_Click(object sender, EventArgs e)
        {            
        }
        private void 전부실행ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // 메뉴에서 기능 호출
        private void 체크리스트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ck.ShowDialog();
        }
        private void 환율계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            cf.ShowDialog();
        }
        private void 날짜추천ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            dt.ShowDialog();
        }

        // X
        private void q10lbItem(object sender, EventArgs e)
        {
        }
        private void q10bt1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void q10bt1_Click_1(object sender, EventArgs e)
        {
        }
        private void q12bt_Click(object sender, EventArgs e)
        {            
        }

        // 프로퍼티 보관

        private void 조회및수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblout2.Text = pf.profiledata;
        }

        private void 항공권예약ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            at.ShowDialog();
        }
        private void btGetAirlineTicket_Click(object sender, EventArgs e)
        {
            lblout.Text = at.result;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lbloutCk.Text = ck.checkresult;
        }

        private void 자료조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save sv = new Save();
            sv.ShowDialog();
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "텍스트 파일|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine("사용자 정보\n" + pf.profiledata + "\n" + "항공권 예약 내역\n" + at.result + "\n" + "챙겨야 할 물품\n" + ck.checkresult + "\n" + cf.Caldata + "\n" + "환전금액 : " + cf.baseWondata + "원\n" + cf.Wondata);
                sw.Close();
            }
        }

        private void 데이터베이스열람ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.ShowDialog();
        }
    }
}