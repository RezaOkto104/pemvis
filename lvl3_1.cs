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
    public partial class lvl3_1 : Form
    {
        private int counter = 0;
        private int waktu = 59;
        private string[] soal = new string[] {
        "Pertempuran antara Inggris dengan rakyat Surabaya membuat kerugian besar pada pihak Inggris karena menewaskan salah satu Jenderal Inggris yaitu...",
        "KTN (Komisi Tiga Negara) merupakan komite bentukan PBB yang bertujuan menengahi pertikaian antara Indonesia dengan Belanda. Anggota KTN dari Australia yang menjadi wakil dari Indonesia adalah...",
        "Agresi militer Belanda I terjadi pada tanggal...",
        "Pada tanggal 19 Desember 1948 Belanda melakukan Agresi Militer II yang membuat ibu kota jatuh, untuk menyelamatkan RI Soekarno menugaskan pembentukan PDRI (Pemerintah Darurat Indonesia) kepada...",
        "Selama perjuangan bersenjata menghadapi sekutu dan Belanda TNI dipimpin oleh...",
        "Wilayah Indonesia yang diakui oleh Belanda berdasarkan Hasil dari perundingan Linggar Jati adalah...",
        "Wilayah Indonesia yang diakui oleh Belanda berdasarkan Hasil dari perundingan Renville adalah...",
        "Perjanjian Roem-Royen terjadi pada tanggal...",
        "KMB dimulai di Den Haag Belanda pada tanggal...",
        "Pemimpin delegasi Indonesia dalam Konferensi Meja Bundar dalah adalah...",
        };
        private string[][] jawaban = new string[][] {
        new string[] { "Letnan Jenderal Cristison", "Brigjen A.W.S. Mallaby", "Jenderal Douglas Mc Artur", "Mayjen Manserg" },
        new string[] { "Dr. Frank Graham", "Paul Van Zeelan", "Richard Kirby", "Mr. Roem" },
        new string[] { "29 September 1945", "10 November 1945", "14 Desember 1945", "21 Juli 1947" },
        new string[] { "Mr. Syarifuddin Prawiranegara", "Amir Syarifudin", "Muhammad Natsir", "Moh. Hatta" },
        new string[] { "Jenderal Soeharto", "Jenderal A. Yani", "enderal A. H. Nasution", "Jenderal Soedirman" },
        new string[] { "Jawa, Sumatra, Kalimantan", "Jawa, Sumatra, Sulawesi", "Jawa Tengah, Jogja, Sumatra", "Sumatra, Jawa, Madura" },
        new string[] { "Jawa, Sumatra, Kalimantan", "Jawa, Sumatra, Sulawesi", "Jawa Tengah, Jogja, Sumatra", "Jawa Timur, Jawa Tengah, Jawa Barat" },
        new string[] { "23 Agustus 1949", "14 April 1949", "25 Maret 1947", "7 Mei 1949" },
        new string[] { "23 Agustus 1949", "14 April 1949", "25 Maret 1947", "7 Mei 1949" },
        new string[] { "Sultan Hamid II", "Mr. Roem", "Syafrudin Prawiranegara", "Moh. Hatta" },
        };
        private int[] jawabanBenar = new int[] { 0, 2, 3, 0, 3, 3, 2, 1, 0, 3}; // jawaban benar untuk setiap soal
        private Random random = new Random();

        public lvl3_1()
        {
            InitializeComponent();
        }
        public string OpeningForm { get; internal set; }
        private void lvl3_1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F6D9C0");

            pictureBox1.BackColor = ColorTranslator.FromHtml("#F6D9C0");

            label1.BackColor = ColorTranslator.FromHtml("#F6D9C0");

            label2.BackColor = ColorTranslator.FromHtml("#F5F5F5");

            label3.BackColor = ColorTranslator.FromHtml("#F6D9C0");
            labeltime.BackColor = ColorTranslator.FromHtml("#F6D9C0");

            groupBox1.BackColor = ColorTranslator.FromHtml("#ECAF7A");

            buttonA.BackColor = ColorTranslator.FromHtml("#9A4700");
            buttonB.BackColor = ColorTranslator.FromHtml("#9A4700");
            buttonC.BackColor = ColorTranslator.FromHtml("#9A4700");
            buttonD.BackColor = ColorTranslator.FromHtml("#9A4700");

            AcakSoal();
            muatSoal();
            label3.Text = "0";
            labeldetik.Text = waktu.ToString();
            timer1.Start();
        }

        private void AcakSoal()
        {
            int n = soal.Length;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);

                // Tukar pertanyaan
                string tempSoal = soal[i];
                soal[i] = soal[j];
                soal[j] = tempSoal;

                // Tukar jawaban
                string[] tempJawaban = jawaban[i];
                jawaban[i] = jawaban[j];
                jawaban[j] = tempJawaban;

                // Tukar jawaban benar
                int tempJawabanBenar = jawabanBenar[i];
                jawabanBenar[i] = jawabanBenar[j];
                jawabanBenar[j] = tempJawabanBenar;
            }
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
                if (OpeningForm == "testing4")
                {
                    if (skor >= 100)
                    {
                        MessageBox.Show("Skor akhir kamu untuk tingkat ini adalah " + label3.Text + ". Anda telah memahami materi dengan baik");
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
    }
}
