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
    public partial class lvl2_1 : Form
    {
        private int counter = 0;
        private int waktu = 59;
        private string[] soal = new string[] {
        "Janji kemerdekaan atas wilayah jajahan termasuk Indonesia disampaikan PM Koiso di depan parlemen Jepang pada tanggal 7 September 1944. Keluarnya janji kemerdekaan Jepang bertujuan....",
        "Ketidaktstabilan politik di Jepang menyebabkan Marsekal Terauchi mengadakan pertemuan dengan tokoh-tokoh Indonesia di Dalat Vietnam. Pertemuan tersebut membahas....",
        "Sambil menunggu penyerahan kekuasaan di Indonesia kepada Sekutu, Jepang diwajibkan untuk menjaga status quo yang artinya...",
        "Reaksi golongan tua dan golongan muda berbeda ketika mendengar kekalahan Jepang atas Sekutu. Reaksi golongan muda terhadap ketua PPKI setelah mengetahui Jepang meyerah kepada sekutu adalah...",
        "Jaminan yang diberikan oleh Achmad Subarjo kepada pemuda pada saat menjemput Soekarno-Hatta di Rengasdengklok adalah...",
        "Setelah peristiwa Rengasdengklok, Soekarno-Hatta bertemu dengan Nishimura yang menjabat sebagai kepala Urusan Umum Pemerintahan Jepang di Indonesia. Pertemuan tersebut bertujuan...",
        "Informasi yang tidak tepat berikut ini terkait dengan pelaksanaan proklamasi kemerdekaan Indonesia adalah...",
        "\"Kami bangsa Indonesia dengan ini menyatakan kemerdekaan Indonesia\". Makna penggalan pernyataan Proklamasi Kemerdekaan Indonesia bagi bangsa Indonesia adalah....",
        "Setelah Proklamasi kemerdekaan Indonesia, dilanjutkan penyebaran berita Proklamasi agar cepat dan segera diketahui banyak orang. Berikut ini sarana penyebaran berita Proklamasi kemerdekaan yang pertama, yaitu...",
        "Berita Proklamasi menyebar ke berbagai daerah di Indonesi melalui utusan daerah yang menjadi anggota PPKI. Anggota PPKI yang berasal dari daerah Aceh adalah...",
        };
        private string[][] jawaban = new string[][] {
        new string[] { "menarik simpati rakyat jajahan agar mendukung Jepang", "melakukan dekolonisasi pasca Perang Pasifik", "mencegah jatuhnya wilayah jajahan Jepang ke tangan Sekutu", "mempersiapkan pembentukan pemerintahan bagi Indonesia" },
        new string[] { "dampak kekalahan Jepang dalam perang pasifik bagi Indonesia", "rencana Jepang untuk mengakhiri pendudukannya di Indonesia", "keikutsertaan rakyat Indonesia untuk membantu Jepang dalam Perang Pasifik", "rencana pemberian kemerdekaan bagi Indonesia" },
        new string[] { "Jepang memastikan tidak akan bertahan di Indonesia", "Jepang membiarkan Indonesia dikuasai Belanda", "Jepang wajib menjaga Indonesia dan tidak merubah keadaan", "Sekutu menjamin mengembalikan semua aset Jepang saat tiba di Indonesia" },
        new string[] { "menuntut Soekarno-Hatta segera memproklamirkan kemerdekaaan Indonesia", "menghendaki kemerdekaan Indonesia dilaksanakan pada tanggal 17 Agustus 1945", "mendesak Soekarno-Hatta untuk memutuskan ikatan-ikatanya dengan Jepang", "mendesak Soekarno-Hatta cepat-cepat mengambil alih kekuasaan dari Jepang" },
        new string[] { "akan melaksanakan lobi politik kepada Mayor Jenderal Nishimura agar proklamasi dapat dideklarasikan di Lapangan Ikada", "akan mendapatkan izin dari pemerintah Jepang karena telah ada kesepakatan dengan Jenderal Terauchi di Dalat", "menjamin proklamasi akan dibacakan setelah mengantar Soekarno berobat karena sakit malaria", "menjamin proklamasi akan dilaksanakan selambat-lambatnya tanggal 17 Agustus 1945" },
        new string[] { "mendorong pemerintah militer Jepang meringkus gerakan bawah tanah", "meminta masukan Jepang mengenai naskah Proklamasi Kemerdekaan  Indonesia", "meminta pasukan keamanan Jepang dalam rapat-rapat PPKI", "menjajaki sikap Jepang terhadap rencana persiapan kemerdekaan Indonesia" },
        new string[] { "didahului dengan pidato singkat yang disampaikan Soekarno", "lagu Indonesia Raya dinyanyikan dengan spontan", "sebelumnya meminta jaminan keamanan dari pihak Jepang", "bendera dijahit Ibu Fatmawati, tiang bendera terbuat dari batang bamboo" },
        new string[] { "Jepang telah memenuhi janji kemerdekaan kepada masyarakat Indonesia", "Indonesia segera menyusun pemerintahan dan ketatanegaraan yang baru", "Proklamasi kemerdekaan merupakan puncak perjuangan", "Saatnya membangun kehidupan yang lebih modern" },
        new string[] { "TVRI", "pamflet dan selembaran kertas", "radio kantor berita Domei", "RRI" },
        new string[] { "Gusti Ketut Pudja", "Muhammad Noor", "Sam Ratulangi", "Teuku Moh Hasan" },
        };
        private int[] jawabanBenar = new int[] { 0, 3, 2, 0, 3, 3, 0, 2, 3, 3}; // jawaban benar untuk setiap soal
        public lvl2_1()
        {
            InitializeComponent();
        }
        public string OpeningForm { get; internal set; }

        private void lvl2_1_Load(object sender, EventArgs e)
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
                if (OpeningForm == "testing3")
                {
                    if (skor >= 90)
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
                        loadingScreen.nextForm = new testing3();
                        loadingScreen.Show();
                    }
                }
                else if (OpeningForm == "testing4")
                {
                    if (skor >= 90)
                    {
                        MessageBox.Show("Skor akhir kamu untuk tingkat ini adalah " + label3.Text + ". Anda dapat masuk ke tingkat selanjutnya");
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
