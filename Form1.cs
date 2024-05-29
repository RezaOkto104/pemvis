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
    public partial class Form1 : Form
    {
        private testing2 testing2Form;
        private testing3 testing3Form;
        private testing4 testing4Form;
        public Form1()
        {
            InitializeComponent();
            testing2Form = new testing2();
            testing3Form = new testing3();
            testing4Form = new testing4();
        }
       
        public string OpeningForm { get; internal set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (OpeningForm == "loading" || OpeningForm == "testing2")
            {
                testing2Form.Show();
                testing3Form.Hide();
                testing4Form.Hide();
            }
            else if (OpeningForm == "testing3")
            {
                testing3Form.Show();
                testing2Form.Hide();
                testing4Form.Hide();
            }
            else if (OpeningForm == "testing4")
            {
                testing4Form.Show();
                testing2Form.Hide();
                testing3Form.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F6D9C0");


            label1.BackColor = ColorTranslator.FromHtml("#F6D9C0");
            // Font labelFont = new Font("Montserrat", 36F, FontStyle.Regular);
            //label1.Font = labelFont;

            button4.BackColor = ColorTranslator.FromHtml("#ECAF7A");
            button1.BackColor = ColorTranslator.FromHtml("#ECAF7A");
            button2.BackColor = ColorTranslator.FromHtml("#ECAF7A");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            materi materiForm = new materi(this);
            materiForm.Show();
        }
    }
}
