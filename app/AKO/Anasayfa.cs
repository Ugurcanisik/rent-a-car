using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AKO
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=AracKiralamaOtomasyonu;Integrated Security=True");

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

           
        }

        void boyut()
        {
            this.dataGridView1.Columns["TC"].Width = 165;
            this.dataGridView1.Columns["Adi"].Width = 170;
            this.dataGridView1.Columns["Soyadi"].Width = 165;
            this.dataGridView1.Columns["TelefonNumarasi"].Width = 170;
            this.dataGridView1.Columns["Email"].Width = 168;
            this.dataGridView1.Columns["Adres"].Width = 168;
            this.dataGridView1.Columns["EhliyetNumarasi"].Width = 165;
        }
        private void müşteriEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriekle = new MusteriEkle();

            musteriekle.ShowDialog();

        }

        private void müşteriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteriler musteriguncelle = new Musteriler();

            musteriguncelle.ShowDialog();
        }

    

        private void araçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracEkle aracekle = new AracEkle();
            aracekle.ShowDialog();
        }

        private void araçGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Araclar aracguncelle = new Araclar();
            aracguncelle.ShowDialog();
        }
 
        private void sözleşmeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SozlesmeEkle sozlesmeekle = new SozlesmeEkle();
            sozlesmeekle.ShowDialog();
        }

        private void sözleşmeGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sozlesmeler2 szlsme2 = new Sozlesmeler2();
            //szlsme2.ShowDialog();



            Sozlesmeler sozlesmegucenlle = new Sozlesmeler();
            sozlesmegucenlle.ShowDialog();
        }

        private void btnmusterilistele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand listele = new SqlCommand("select TC,Adi,Soyadi,TelefonNumarasi,Email,Adres,EhliyetNumarasi from Musteriler where Silindimi='False'", baglanti);
            SqlDataAdapter musterilistele = new SqlDataAdapter(listele);
            DataTable tablola = new DataTable();
            musterilistele.Fill(tablola);
            dataGridView1.DataSource = tablola;
            baglanti.Close();
            boyut();
        }

        private void btnaraclistele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand listele = new SqlCommand("select Plaka,Marka,Seri,Model,VitesTipi,YakitTipi,KM,Renk,SaseNumarasi,FiyatiG,FiyatiH,FiyatiA,EklemeTarihi,Durumu from Araclar where Silindimi='False'", baglanti);
            SqlDataAdapter Araclistele = new SqlDataAdapter(listele);
            DataTable tablola = new DataTable();
            Araclistele.Fill(tablola);
            dataGridView1.DataSource = tablola;
            baglanti.Close();
        }

        private void btnsozlesmelistele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand szlsmgtr = new SqlCommand("select MSAPlaka,Marka,Seri,Model,VitesTipi,YakitTipi,KM,Renk,FiyatiG,FiyatiH,FiyatiA,TC,Adi,Soyadi,TelefonNumarasi,EhliyetNumarasi,KiralamaSekli,AlisTarihi,TeslimTarihi,ToplamGun,KiraUcreti,ToplamTutar from Sozlesmeler where Silindimi='False'", baglanti);
            SqlDataAdapter sozlesmegetir = new SqlDataAdapter(szlsmgtr);
            DataTable tabloekle = new DataTable();
            sozlesmegetir.Fill(tabloekle);
            dataGridView1.DataSource = tabloekle;
            baglanti.Close();
        }

        private void istatisliklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlar rpr = new Raporlar();
            rpr.ShowDialog();
        }

        private void btnkirabtnarc_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand szlsmgtr = new SqlCommand("select Plaka,Marka,Seri,Model,Gun,Fiyat,ToplamTutar,TC,Adi,Soyadi,EhliyetNumarasi,AlisTarihi,TeslimTarihi from Satislar ", baglanti);
            SqlDataAdapter sozlesmegetir = new SqlDataAdapter(szlsmgtr);
            DataTable tabloekle = new DataTable();
            sozlesmegetir.Fill(tabloekle);
            dataGridView1.DataSource = tabloekle;
            baglanti.Close();
        }

        private void araçTeslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracTeslimAl arcteslimal = new AracTeslimAl();
            arcteslimal.ShowDialog();
        }
    }
}
