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
    public partial class testing3 : Form
    {
        public testing3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lvl1_1 lvl1_1 = new lvl1_1();
            //lvl1_1.Show();
            //this.Close();

            lvl1_1 lvl1_1 = new lvl1_1();
            lvl1_1.OpeningForm = "testing3";
            lvl1_1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lvl2_1 lvl2_1 = new lvl2_1();
            lvl2_1.OpeningForm = "testing3";
            lvl2_1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //materi materi = new materi();
            //materi.OpeningForm = "testing3";
            //materi.Show();
            //this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Infotingkatkesulitan Infotingkatkesulitan = new Infotingkatkesulitan();
            Infotingkatkesulitan.OpeningForm = "testing3";
            Infotingkatkesulitan.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.OpeningForm = "testing3";
            Form1.Show();
            //Form1.Hide();
            this.Hide();
        }

        private void testing3_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F1C49D");

            label1.BackColor = ColorTranslator.FromHtml("#F1C49D");

            button1.BackColor = ColorTranslator.FromHtml("#9A4700");
            button2.BackColor = ColorTranslator.FromHtml("#9A4700");
            button3.BackColor = ColorTranslator.FromHtml("#9A4700");
        }

        
    }
}
