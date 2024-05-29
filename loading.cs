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
    public partial class loading : Form
    {
        private string[] Quotes = new string[] {
        "\"Bangsa yang tidak percaya kepada kekuatan dirinya sebagai suatu bangsa, tidak dapat berdiri sebagai suatu bangsa yang merdeka.\"" +
            " -Soekarno",
        "\"Terkadang, kesulitan harus kamu rasakan terlebih dulu sebelum kebahagiaan yang sempurna datang kepadamu.\" " +
            "-R. A. Kartini",
        "\"Biarlah pengalaman masa lalu kita menjadi tonggak petunjuk, dan bukan tonggak yang membelenggu kita.\" " +
            "–Bung Hatta",
        "\"Berpedomanlah pada harapan dan ketetapan hati. Berpedomanlah pada cita-cita, berpedomanlah pada impian dan angan-angan.\" " +
            "-IR. Soekarno",
        "\"Untuk mencapai sesuatu, harus diperjuangkan dulu. Seperti mengambil buah kelapa, dan tidak menunggu saja seperti jatuh durian yang telah masak.\" " +
            "–Mohammad Natsir",
        };
        public loading()
        {
            InitializeComponent();
        }

        //public Form nextForm { get; set; }

        private void loading_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F6D9C0");
            label2.BackColor = ColorTranslator.FromHtml("#F6D9C0");

            timer1.Interval = 50;
            timer1.Start();
            ShowRandomQuote();
        }

        private void ShowRandomQuote()
        {
            Random random = new Random();
            int index = random.Next(0, Quotes.Length);
            label1.Text = Quotes[index];
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Form1 Form1 = new Form1();
                Form1.OpeningForm = "loading";
                Form1.Show();
                this.Hide();
            }
        }
    }
}
