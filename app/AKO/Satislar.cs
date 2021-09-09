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
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(18, 40);
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=AracKiralamaOtomasyonu;Integrated Security=True");


        void ststpltutar()
        {
            baglanti.Open();
            DataGridViewRow satir = dataGridView1.CurrentRow;
            
            SqlCommand tplmtutar = new SqlCommand("select sum(ToplamTutar) from Sozlesmeler", baglanti);

            lblhslt.Text = "" + tplmtutar.ExecuteScalar();
            baglanti.Close();
            
        }

        void satislistele ()
        {
            baglanti.Open();
            SqlCommand satislistele = new SqlCommand("select MSAPlaka,Marka,Seri,Model,VitesTipi,YakitTipi,KM,Renk,FiyatiG,FiyatiH,FiyatiA,TC,Adi,Soyadi,TelefonNumarasi,EhliyetNumarasi,KiralamaSekli,AlisTarihi,TeslimTarihi,ToplamGun,KiraUcreti,ToplamTutar from Sozlesmeler where Silindimi='True'", baglanti);
            SqlDataAdapter stslstl = new SqlDataAdapter(satislistele);
            DataTable tablola = new DataTable();
            stslstl.Fill(tablola);
            dataGridView1.DataSource = tablola;
            baglanti.Close();
        }


        void databoyut()
        {
            //this.dataGridView1.Columns["TC"].Width = 107;
            //this.dataGridView1.Columns["Adi"].Width = 107;
            //this.dataGridView1.Columns["Soyadi"].Width = 107;
            //this.dataGridView1.Columns["EhliyetNumarasi"].Width = 107;
            //this.dataGridView1.Columns["MSAPlaka"].Width = 107;
            //this.dataGridView1.Columns["Marka"].Width = 107;
            //this.dataGridView1.Columns["Seri"].Width = 107;
            //this.dataGridView1.Columns["Model"].Width = 107;
            //this.dataGridView1.Columns["Renk"].Width = 107;
            //this.dataGridView1.Columns["ToplamGun"].Width = 107;
            //this.dataGridView1.Columns["KiraUcreti"].Width = 108;
            //this.dataGridView1.Columns["ToplamTutar"].Width = 109;
            //this.dataGridView1.Columns["AlisTarihi"].Width = 109;
            //this.dataGridView1.Columns["TeslimTarihi"].Width = 109;

        }
        private void Satislar_Load(object sender, EventArgs e)
        {
            this.Width = 1564;
            this.Height = 810;
            satislistele();
            ststpltutar();
            databoyut();
        }

        private void txtplksrg_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand tcsorgu = new SqlCommand("select * from Sozlesmeler where MSAPlaka like @Plaka", baglanti);
            tcsorgu.Parameters.AddWithValue("@Plaka", txtplksrg.Text + "%");
            SqlDataAdapter tcnosorgu = new SqlDataAdapter(tcsorgu);
            DataTable tablo = new DataTable();
            tcnosorgu.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void txttcsrg_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand tcsorgu = new SqlCommand("select * from Sozlesmeler where TC like @TC", baglanti);
            tcsorgu.Parameters.AddWithValue("@tc", txttcsrg.Text + "%");
            SqlDataAdapter tcnosorgu = new SqlDataAdapter(tcsorgu);
            DataTable tablo = new DataTable();
            tcnosorgu.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btnlstle_Click(object sender, EventArgs e)
        {
            satislistele();
        }
    }
}
