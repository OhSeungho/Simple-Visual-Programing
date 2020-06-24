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
    public partial class Save : Form
    {
        public Save()
        {
            InitializeComponent();
        }

        private void q12bt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                q12tb.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
