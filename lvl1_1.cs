using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;




namespace testing
{
    public partial class lvl1_1 : Form
    {
        private int counter = 0;
        private int waktu = 59;
        private string[] soal = new string[] {
        "Pocong apa yang paling jadi favorit ibu-ibu?",
        "Kucing apa yang kuno?",
        "Kota apa yang banyak bapak-bapaknya?",
        "Suku apa yang banyak berkeliaran di mall?",
        "Hewan apa yang bersaudara?",
        "Sayur apa yang pintar nyanyi?",
        "artis luar negeri siapa yang tidak punya bapak?",
        "jus apa yang kekurangan darah?",
        "Kenapa Bebek Goreng Rasanya Enak?",
        "Hewan Apa yang Kaya?",
        "Hewan apa yang yang sering shampoan?",
        "Raja apa yang gemas?",
        "Huruf apa yang paling kedinginan?",
        "Orang orang apa yang gak pernah kebasahan waktu hujan?",
        "Buah apa yang ditakuti mahasiswa"
        };
        private string[][] jawaban = new string[][] {
        new string[] { "Pocong Masak", "Pocong Bebek Angsa", "Pocongan Harga", "Pocong Rambut" },
        new string[] { "Kucing Garong", "Kucing-galan Jaman", "Kucing-Kucingan", "Kucing Persia" },
        new string[] { "DaddyPapan", "Daddyland", "Bapakraya", "Purwadaddy" },
        new string[] { "Suku Riti", "Suku Jawa", "Suku Batak", "Suku Melayu" },
        new string[] { "Angsa Beradik", "Kakak Tua", "Paman Bebek", "Katak Beradik" },
        new string[] { "Komeng", "Sawi Bergoyang", "Kol play", "Greentea" },
        new string[] { "Will Smith", "Mr.Bean", "Drake", "Adele" },
        new string[] { "jus Semangka", "Jus AlPucet", "Jus Naga", "Jus Tomat" },
        new string[] { "Karena Pakai Micin", "Karena Digoreng", "Karena Dia", "Karena Ada B nya" },
        new string[] { "Lumba-Lumba", "Gajah dibalik batu", "Beruang", "Kuda" },
        new string[] { "Pantene", "anZinc", "Emeron", "Sunsilk" },
        new string[] { "Fir'a Unch", "Kim Jong-unch", "King Charles", "Destarasta" },
        new string[] { "Huruf A", "Huruf B", "Huruf C", "Huruf D" },
        new string[] { "Orang Utan", "Orang Sawah", "Orang Jambi", "Orang Gak Hujan pak~" },
        new string[] { "Belimbingan Skripsi", "Alpucat", "Buah Naga", "Apelan" },
        };
        private int[] jawabanBenar = new int[] { 0, 1, 2, 3, 0, 3, 3, 1, 1, 0, 0, 1, 1, 0, 3}; // jawaban benar untuk setiap soal

        public lvl1_1()
        {
            InitializeComponent();
        }

        public string OpeningForm { get; internal set; }

        private void lvl1_1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F6D9C0");

            label1.BackColor = ColorTranslator.FromHtml("#F6D9C0");

            label2.BackColor = ColorTranslator.FromHtml("#F5F5F5");

            label3.BackColor = ColorTranslator.FromHtml("#F6D9C0");
            labeltime.BackColor = ColorTranslator.FromHtml("#F6D9C0");

            groupBox1.BackColor = ColorTranslator.FromHtml("#ECAF7A");

            buttonA.BackColor = ColorTranslator.FromHtml("#9A4700");
            buttonB.BackColor = ColorTranslator.FromHtml("#9A4700");
            buttonC.BackColor = ColorTranslator.FromHtml("#9A4700");
            buttonD.BackColor = ColorTranslator.FromHtml("#9A4700");

            muatSoal();
            label3.Text = "0";
            labeldetik.Text = waktu.ToString();
            timer1.Start();
        }

        private void jawab(int index)
        {
            if (jawabanBenar[counter] == index)
            {
                timer1.Stop();
                MessageBox.Show("Jawaban anda benar!");
                timer1.Start();
                counter++;
                waktu = 59; //reset waktu
                label3.Text = (int.Parse(label3.Text) + 10).ToString(); // Menambahkan 10 ke nilai label3
                muatSoal();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Jawaban anda salah!");
                counter++;
                timer1.Start();
                waktu = 59; //reset waktu
                muatSoal();
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            jawab(0);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            jawab(1);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            jawab(2);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            jawab(3);
        }

        private void muatSoal()
        {
            if (counter >= soal.Length)
            {
                timer1.Stop();
                int skor = int.Parse(label3.Text);
                if (OpeningForm == "testing2")
                {
                    if (skor >= 130)
                    {
                        MessageBox.Show("Skor akhir kamu untuk tingkat ini adalah " + label3.Text + ". Anda dapat masuk ke tingkat selanjutnya.");
                        LoadingScreen loadingScreen = new LoadingScreen();
                        loadingScreen.nextForm = new testing3();
                        loadingScreen.Show();
                    }
                    else
                    {
                        MessageBox.Show("Skor akhir kamu untuk tingkat ini adalah " + label3.Text + ". Silahkan pelajari materi kembali.");
                        LoadingScreen loadingScreen = new LoadingScreen();
                        loadingScreen.nextForm = new testing2();
                        loadingScreen.Show();
                    }
                }
                else if (OpeningForm == "testing3")
                {
                    if (skor >= 130)
                    {
                        MessageBox.Show("Skor akhir kamu untuk tingkat ini adalah " + label3.Text + ". Anda dapat masuk ke tingkat selanjutnya.");
                        LoadingScreen loadingScreen = new LoadingScreen();
                        loadingScreen.nextForm = new testing3();
                        loadingScreen.Show();
                    }
                    else
                    {
                        MessageBox.Show("Skor akhir kamu untuk tingkat ini adalah " + label3.Text + ". Silahkan pelajari materi kembali.");
                        LoadingScreen loadingScreen = new LoadingScreen();
                        loadingScreen.nextForm = new testing3();
                        loadingScreen.Show();
                    }
                }
                else if (OpeningForm == "testing4")
                {
                    if (skor >= 130)
                    {
                        MessageBox.Show("Skor akhir kamu untuk tingkat ini adalah " + label3.Text + ". Anda dapat masuk ke tingkat selanjutnya.");
                        LoadingScreen loadingScreen = new LoadingScreen();
                        loadingScreen.nextForm = new testing4();
                        loadingScreen.Show();
                    }
                    else
                    {
                        MessageBox.Show("Skor akhir kamu untuk tingkat ini adalah " + label3.Text + ". Silahkan pelajari materi kembali.");
                        LoadingScreen loadingScreen = new LoadingScreen();
                        loadingScreen.nextForm = new testing4();
                        loadingScreen.Show();
                    }
                }

                this.Hide();
            }
            else
            {
                labelnomor.Text = (counter + 1).ToString(); // Menampilkan nomor soal
                label1.Text = soal[counter];
                buttonA.Text = jawaban[counter][0];
                buttonB.Text = jawaban[counter][1];
                buttonC.Text = jawaban[counter][2];
                buttonD.Text = jawaban[counter][3];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (waktu > 0)
            {
                waktu--;
                labeldetik.Text = waktu.ToString();
            }
            if (waktu == 0)
            {
                timer1.Stop();
                MessageBox.Show("waktu habis!");
                counter++;
                waktu = 59;
                timer1.Start();
                muatSoal();
            }
            if (waktu > 10)
            {
                return;
            }
            Console.Beep(1000, 100);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}




