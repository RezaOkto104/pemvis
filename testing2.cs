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
    public partial class testing2 : Form
    {
        public testing2()
        {
            InitializeComponent();
        }
        private void testing2_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F1C49D");

            label1.BackColor = ColorTranslator.FromHtml("#F1C49D");

            button1.BackColor = ColorTranslator.FromHtml("#9A4700");
            button2.BackColor = ColorTranslator.FromHtml("#9A4700");
            button3.BackColor = ColorTranslator.FromHtml("#9A4700");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lvl1_1 lvl1_1= new lvl1_1();
            //lvl1_1.Show();
            //this.Close();

            lvl1_1 lvl1_1 = new lvl1_1();
            lvl1_1.OpeningForm = "testing2";
            lvl1_1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            //lvl2_1 lvl2_1 = new lvl2_1();
            //lvl2_1.OpeningForm = "testing2";
            //lvl2_1.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //lvl3_1 lvl3_1 = new lvl3_1();
            //lvl3_1.OpeningForm = "testing2";
            //lvl3_1.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //materi materi = new materi();
            //materi.OpeningForm = "testing2";
            //materi.Show();
            //this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Infotingkatkesulitan Infotingkatkesulitan = new Infotingkatkesulitan();
            Infotingkatkesulitan.OpeningForm = "testing2";
            Infotingkatkesulitan.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.OpeningForm = "testing2";
            Form1.Show();
            Form1.Hide();
            this.Hide();
        }
    }
}
