using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testing
{
    public partial class LoadingScreen : Form
    {
        public Form nextForm { get; set; }

        private string[] poinutama = new string[]{
        "Bung Karno Tidak Puasa Saat Proklamasi",
        "Draf Naskah Proklamasi Sempat Hilang",
        "Bendera Pusaka dari Sprei dan Penjual Soto",
        };

        private string[] isi = new string[]{
        "Bung Karno Tidak Puasa Saat Proklamasi mungkin kamu tahu bahwa hari proklamasi kemerdekaan RI jatuh pada bulan Ramadhan. Namun, saat itu Bung Karno tidak berpuasa karena sedang sakit akibat gejala malaria tertiana. Ketika dibangunkan di pagi hari, Bung Karno mengeluh badannya terasa seperti meriang. Setelah disuntik dan minum obat, beliau kembali tidur dan bangun pada pukul 09.00 WIB untuk bersiap-siap memroklamirkan kemerdekaan RI pada pukul 10.00 WIB.",
        "Draf naskah proklamasi ditulis tangan oleh Bung Karno dan dibantu Bung Hatta dalam pemilihan kata-katanya. Setelah acara proklamasi selesai, draf tersebut menghilang. Wartawan senior Indonesia bernama BM Diah menemukan draf tersebut terbuang di tempat sampah. BM Diah lalu menyimpan draft tersebut selama 46 tahun 9 bulan 19 hari, sebelum akhirnya diserahkan ke pemerintah pada 29 Mei 1992.",
        "Bendera merah putih untuk keperluan kemerdekaan sebenarnya telah dibuat oleh Fatmawati, istri Bung Karno, sebelum tanggal 16 Agustus 1945. Akan tetapi, bendera tersebut dianggap terlalu kecil untuk dikibarkan. Akhirnya, Fatmawati membongkar lemari mencari kain untuk membuat bendera baru. Ia menemukan kain sprei berwarna putih. Bagian merahnya dibeli dari seorang penjual soto oleh pemuda bernama Lukas Kastaryo.",
        };

        private Random random = new Random();

        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            // Menampilkan poin utama dan isi secara acak
            int randomIndex = random.Next(poinutama.Length);
            label5.Text = poinutama[randomIndex];
            label6.Text = isi[randomIndex];

            // Menyembunyikan picture box sesuai dengan nilai array
            if (randomIndex == 0)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            else if (randomIndex == 1)
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
            else if (randomIndex == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }

            timer1.Interval = 50;
            timer1.Start();
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
                if (nextForm != null)
                {
                    nextForm.Show();
                }
                this.Hide();
            }
        }

        //gambar soekarno
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //gambar naskah proklamasi
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //gambar bendera pustaka
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

    }
}
