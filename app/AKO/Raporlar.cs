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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=AracKiralamaOtomasyonu;Integrated Security=True");
        string ocak = "Ocak";
        string subat = "Şubat";
        string mart = "Mart";
        string nisan = "Nisan";
        string mayis = "Mayıs";
        string haziran = "Haziran";
        string temmuz = "Temmuz";
        string agustos = "Ağustos";
        string eylul = "Eylük";
        string ekim = "Ekim";
        string kasim = "Kasım";
        string aralik = "Aralık";
        private void Raporlar_Load(object sender, EventArgs e)
        {
            alttarih();
            usttarih();
            cmbxusttarih.SelectedIndex = 0;
            cmbxalttarih.SelectedIndex = 0;
        }

        void alttarih()
        {
            cmbxalttarih.Items.Add("Tarih");
            cmbxalttarih.Items.Add(ocak);
            cmbxalttarih.Items.Add(subat);
            cmbxalttarih.Items.Add(mart);
            cmbxalttarih.Items.Add(nisan);
            cmbxalttarih.Items.Add(mayis);
            cmbxalttarih.Items.Add(haziran);
            cmbxalttarih.Items.Add(temmuz);
            cmbxalttarih.Items.Add(agustos);
            cmbxalttarih.Items.Add(eylul);
            cmbxalttarih.Items.Add(ekim);
            cmbxalttarih.Items.Add(kasim);
            cmbxalttarih.Items.Add(aralik);
        }

        void usttarih()
        {
            cmbxusttarih.Items.Add("Tarih");
            cmbxusttarih.Items.Add(ocak);
            cmbxusttarih.Items.Add(subat);
            cmbxusttarih.Items.Add(mart);
            cmbxusttarih.Items.Add(nisan);
            cmbxusttarih.Items.Add(mayis);
            cmbxusttarih.Items.Add(haziran);
            cmbxusttarih.Items.Add(temmuz);
            cmbxusttarih.Items.Add(agustos);
            cmbxusttarih.Items.Add(eylul);
            cmbxusttarih.Items.Add(ekim);
            cmbxusttarih.Items.Add(kasim);
            cmbxusttarih.Items.Add(aralik);
        }
 
        private void btnbul_Click(object sender, EventArgs e)
        {
            if (cmbxusttarih.SelectedIndex == 0)
            {
                baglanti.Open();
                SqlCommand listele = new SqlCommand("select plaka,marka,seri,model,TC,Adi,Soyadi,Gun,Fiyat,ToplamTutar,AlisTarihi,TeslimTarihi from Satislar where TeslimAy=@TeslimTarihi", baglanti);
                listele.Parameters.AddWithValue("@TeslimTarihi", cmbxalttarih.SelectedIndex);
                SqlDataAdapter musterilistele = new SqlDataAdapter(listele);
                DataTable tablola = new DataTable();
                musterilistele.Fill(tablola);
                dataGridView1.DataSource = tablola;

                DataGridViewRow satir = dataGridView1.CurrentRow;

                SqlCommand tplmtutar = new SqlCommand("select sum(ToplamTutar) from Satislar where TeslimAy=@TeslimTarihi", baglanti);
                tplmtutar.Parameters.AddWithValue("@TeslimTarihi", cmbxalttarih.SelectedIndex);
                lbltutar.Text = "" + tplmtutar.ExecuteScalar();
                baglanti.Close();
            }
            else if (cmbxusttarih.SelectedIndex > 0 && cmbxalttarih.SelectedIndex > 0)
            {
                int alt, ust;
                alt = cmbxalttarih.SelectedIndex;
                ust = cmbxusttarih.SelectedIndex;
                if (alt < ust)
                {
                    baglanti.Open();
                    SqlCommand listele = new SqlCommand("select plaka,marka,seri,model,TC,Adi,Soyadi,Gun,Fiyat,ToplamTutar,AlisTarihi,TeslimTarihi from Satislar where TeslimAy between @TeslimTarihi and @TeslimTarihi1", baglanti);
                    listele.Parameters.AddWithValue("@TeslimTarihi", cmbxalttarih.SelectedIndex);
                    listele.Parameters.AddWithValue("@TeslimTarihi1", cmbxusttarih.SelectedIndex);
                    SqlDataAdapter musterilistele = new SqlDataAdapter(listele);
                    DataTable tablola = new DataTable();
                    musterilistele.Fill(tablola);
                    dataGridView1.DataSource = tablola;

                    DataGridViewRow satir = dataGridView1.CurrentRow;

                    SqlCommand tplmtutar = new SqlCommand("select sum(ToplamTutar) from Satislar where TeslimAy between @TeslimTarihi and @TeslimTarihi1", baglanti);
                    tplmtutar.Parameters.AddWithValue("@TeslimTarihi", cmbxalttarih.SelectedIndex);
                    tplmtutar.Parameters.AddWithValue("@TeslimTarihi1", cmbxusttarih.SelectedIndex);

                    lbltutar.Text = "" + tplmtutar.ExecuteScalar();


                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Ay'ı sol dan başlayarak seçiniz");
                    cmbxalttarih.SelectedIndex = 0;
                    cmbxusttarih.SelectedIndex = 0;
                }
            }
        }

        private void btnyazdır_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount>0)
            {
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Rapor Seçiniz");
            }

            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);

            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

  

           //private void button1_Click(object sender, EventArgs e)
        //{

        //    openFileDialog1.ShowDialog();
        //    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

        //    //MemoryStream ms = new MemoryStream();
        //    //pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    //byte[] resim = ms.GetBuffer();

        //    //// Parametre eklemek için...
        //    //komut.Parameters.Add("@resim", SqlDbType.Image, resim.Length).Value = resim;
        //}
    }
}
