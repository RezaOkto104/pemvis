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
        "Setelah tamat dari sekolah Hogere Burber School di tahun 1915, Soekarno selanjutnya tinggal bersama teman dari ayahnya yang juga dikenal pendiri Serikat Islam. Saat dirumah tokoh tersebut, Soekarno yang masih muda pun mulai belajar dalam bidang politik, tokoh yang dimaksud adalah...",
        "Beliau adalah negarawan sekaligus tokoh ekonomi Indonesia, lahir di Bukit Tinggi, 12 Agustus 1902 bersama Soekarno, beliau memainkan peranan sentral dalam perjuangan kemerdekaan Indonesia, beliau mendapat julukan ‘Bapak Koperasi’ tokoh yang dimaksud adalah....",
        "Tokoh ini merupakan salah satu tokoh pendidikan Indonesia, Ing Ngarso Sung Tulodo, Ing Madyo Mangun Karso, Tut Wuri Hkalianyani, adalah qoute terkenal dari Beliau, lebih terkenal dengan sebutan Ki Hajar Dewantara, tokoh yang dimaksud adalah ...",
        "Pada masa kolonial, tokoh ini aktif dalam gerakan organisasi pemuda. Pada masa Jepang menempuh jalur perjuangan ‘Bawah Tanah’ dan Perdana Menteri Indonesia pasca kemerdekaan. Tokoh yang dimaksud adalah...",
        "Pemikiran-pemikiran beliau memberi sumbangsih besar terhadap Indonesia. Beliau tergabung dalam BPUPKI dan dikenal sebagai salah satu dari 3 tokoh yang mengusulkan dasar negara Indonesia. Tokoh yang dimaksud adalah...",
        "Keberanian Adipati Unus dalam menyerang Portugis yang kuat, terdengar beritanya ke penjuru pulau Jawa. Ia bahkan diberikan gelar...",
        "Ia tetap melanjutkan perjuangan suaminya dengan berjuang sendiri memimpin perang di daerah pedalaman Meulaboh bersama dengan pasukannya. Belkalian selalu berusaha untuk menangkapnya karena merasa bahwa Ia sangat berpengaruh pada masyarakatnya dalam berperang, namun sayang Belkalian seringkali gagal menangkapnya karena taktik yang dimilikinya. Tokoh pejuang yang dimaksud adalah...",
        "Perang Padri yang terjadi tahun 1803 sampai 1838 merupakan perlawanan rakyat yang terjadi di...",
        "Si Singamangaraja XII adalah tokoh perlawanan rakyat di daerah...",
        "Salah satu latar belakang dari perang Diponegoro adalah...",
        "Faletehan, merupakan Panglima Pasukan kerajaan...",
        "Raja dari Kerajaan Mataram yang berkali-kali menyerang pasukan Belkalian di Batavia adalah...",
        "Perang Padri diawali dengan perpecahan di kalangan rakyat Indonesia sendiri, yaitu...",
        "Strategi Belkalian yang paling ampuh menghadapi perlawanan dari penguasa lokal adalah dengan melakukan politik...",
        "Pejuang yang memimpin perlawanan rakyat Palembang terhadap Inggris dan Belkalian, yang namanya diabadikan menjadi nama Bkalianra Udara Internasional di Palembang adalah..."
        };
        private string[][] jawaban = new string[][] {
        new string[] { "Hos Tjokroaminoto", "Mohammad Hatta", "Mohammad Yamin", "Ahmad Soebardjo" },
        new string[] { "Soekarno", "Mohammad Hatta", "Mohammad Yamin", "Ki Hajar Dewantara" },
        new string[] { "Mohammad Hatta", "Tjipto Mangunkusumo", "Suwardi Suryaningrat", "Mohammad Yamin" },
        new string[] { "Mohammad Hatta", "Soekarno", "Mohammad Yamin", "Sutan Sjahrir" },
        new string[] { "Mohammad Yamin", "Mohammad Hatta", "Supomo", "Ir. Soekarno" },
        new string[] { "Pangeran Mangkubumi", "Pangeran Samber Nyowo", "Pangeran Adipati", "Pangeran Sabrang Lor" },
        new string[] { "Pangeran Diponegoro", "Sisingamangaraja XII", "Pangeran Antasari", "Tjut Nyak’ Dien" },
        new string[] { "Maluku", "Sumatera Barat", "Aceh", "Jawa Timur" },
        new string[] { "Bali", "Tapanuli", "Makassar", "Jakarta" },
        new string[] { "rakyat dibelit oleh berbagai bentuk pajak dan pungutan", "pelanggaran perang atas Traktat London1824", "dampak dari perang Padri yang pertama", "balasan Diponegoro atas serangan dari pemerintah colonial" },
        new string[] { "Cirebon", "Pajajaran", "Demak", "Majapahit" },
        new string[] { "Sultan Iskandar Muda", "Sultan Agung", "Sultan Hairun", "Sultan Hasanudin" },
        new string[] { "munculnya gerakan Wahabi di Sumatra Barat", "konflik antara Kaum Paderi dan Kaum Adat", "persaingan di antara pendukung gerakan Wahabiah", "dukungan pemerintah kolonial terhadap kaum adat" },
        new string[] { "pecah belah", "aliansi", "gerilya", "balas budi" },
        new string[] { "Pangerang Antasari", "Pangerang Diponegoro", "Sisinga Mangaraja XII", "Sultan Mahmud Badarauddin II" },
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

    }

}




