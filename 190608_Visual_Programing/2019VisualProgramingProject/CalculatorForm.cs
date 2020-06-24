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
    public partial class CalculatorForm : Form
    {
        public float baseWondata;
        public string Wondata;
        public string Caldata;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void q4bt1_Click(object sender, EventArgs e)
        {
            float q4won = float.Parse(q4tb1.Text);
            float usb = q4won / 1185;
            float jpy = q4won / 10;
            float cny = q4won / 170;
            float gbp = q4won / 1507;
            float eur = q4won / 1335;
            float aud = q4won / 826;
            q4lbl1.Text = usb.ToString() + " 달러" + "\n" + jpy + " 엔" + "\n" + cny + " 위안" + "\n" + gbp + " 파운드" + "\n" + eur + " 유로" + "\n" + aud + " 호주달러";
            baseWondata = q4won;
            Wondata = usb.ToString() + " 달러" + "\n" + jpy + " 엔" + "\n" + cny + " 위안" + "\n" + gbp + " 파운드" + "\n" + eur + " 유로" + "\n" + aud + " 호주달러";
        }

        private void q5bt1_Click(object sender, EventArgs e)
        {
            int money = int.Parse(q4tb1.Text);
            // 연산 적용
            Calculator cal = new Calculator();
            int sum = cal.CalOut(money);
            // 연산 결과를 출력 레이블에 표시
            q4lbl1.Text = "7일 여행에 지출될 비용은 약\n" + sum.ToString() + "원 입니다\n";
            Caldata = "7일 여행에 지출될 비용은 약\n" + sum.ToString() + "원 입니다\n";
        }
    }
}
