using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing
{
    public partial class Infotingkatkesulitan : Form
    {
        public Infotingkatkesulitan()
        {
            InitializeComponent();
        }

        public string OpeningForm { get; internal set; }

        private void Infotingkatkesulitan_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F1C49D");

            groupBox1.BackColor = ColorTranslator.FromHtml("#9A4700");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (OpeningForm == "testing2")
            {
                testing2 testing2 = new testing2();
                testing2.Show();
            }
            if (OpeningForm == "testing3")
            {
                testing3 testing3 = new testing3();
                testing3.Show();
            }
            else if (OpeningForm == "testing4")
            {
                testing4 testing4 = new testing4();
                testing4.Show();
            }

            this.Close();
        }
    }
}
