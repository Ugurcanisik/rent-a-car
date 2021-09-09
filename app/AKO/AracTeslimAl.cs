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
    public partial class AracTeslimAl : Form
    {
        public AracTeslimAl()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=AracKiralamaOtomasyonu;Integrated Security=True");
        private void AracTeslimAl_Load(object sender, EventArgs e)
        {
            kiradaarac();
        }


        void kiradaarac()
        {
            baglanti.Open();

            SqlCommand szlsmgtr = new SqlCommand("select MSAPlaka,Marka,Seri,Model,VitesTipi,YakitTipi,KM,Renk,FiyatiG,FiyatiH,FiyatiA,TC,Adi,Soyadi,TelefonNumarasi,EhliyetNumarasi,KiralamaSekli,AlisTarihi,TeslimTarihi,ToplamGun,KiraUcreti,ToplamTutar from Sozlesmeler where Silindimi='False'", baglanti);

            SqlDataAdapter sozlesmegetir = new SqlDataAdapter(szlsmgtr);
            DataTable tabloekle = new DataTable();

            sozlesmegetir.Fill(tabloekle);
            dataGridView1.DataSource = tabloekle;

            baglanti.Close();
        }

        void alacak_verecek()
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            baglanti.Open();

            SqlCommand toplamgun = new SqlCommand("select ToplamGun from Sozlesmeler where ToplamGun=@ToplamGun", baglanti);
            toplamgun.Parameters.AddWithValue("@ToplamGun", satir.Cells["ToplamGun"].Value.ToString());

            SqlDataReader toplamoku = toplamgun.ExecuteReader();

            if(toplamoku.Read())
            {
                int kacgun = Convert.ToInt32 (toplamoku["ToplamGun"]);

                if(kacgun==0)
                {
                    DateTime bugun = DateTime.Parse(DateTime.Now.ToString());
                    DateTime donus = DateTime.Parse(satir.Cells["TeslimTarihi"].Value.ToString());
                    int tutar = int.Parse(satir.Cells["KiraUcreti"].Value.ToString());
                    TimeSpan gunfarki = bugun - donus;
                    int _gunfarki = Convert.ToInt32(gunfarki.TotalHours);
                    //MessageBox.Show(_gunfarki.ToString());
                    int ucretfarki = _gunfarki * tutar;

                    txtalckvrckdrm.Text = ucretfarki.ToString();
                }
                else
                {
                    DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
                    DateTime donus = DateTime.Parse(satir.Cells["TeslimTarihi"].Value.ToString());
                    int tutar = int.Parse(satir.Cells["KiraUcreti"].Value.ToString());
                    TimeSpan gunfarki = bugun - donus;
                    int _gunfarki = Convert.ToInt32(gunfarki.TotalDays);
                    int ucretfarki = _gunfarki * tutar;

                    txtalckvrckdrm.Text = ucretfarki.ToString();
                }

            }



            baglanti.Close();


            

           
        }

        private void btnteslimal_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Sözleşme Ekleyiniz");
            }
            else
            {
                if (txtalckvrckdrm.Text != "")
                {
                    DataGridViewRow satir = dataGridView1.CurrentRow;

                    string AlisTarihi = satir.Cells["AlisTarihi"].Value.ToString();


                    DateTime teslimtarihi = DateTime.Now;
                    string format = "g";

       
                    string TeslimTarihi = teslimtarihi.ToString(format);

                    DateTime teslim = Convert.ToDateTime(teslimtarihi);
                    DateTime alis = Convert.ToDateTime(satir.Cells["AlisTarihi"].Value);
                    TimeSpan Sonuc = teslim - alis;
                    int tplmgn = Convert.ToInt32(Sonuc.TotalDays);
                    int tutar = int.Parse(satir.Cells["KiraUcreti"].Value.ToString());
                    int tplmtutar = tutar * tplmgn;

                    int teslimay = DateTime.Now.Month;




                    baglanti.Open();

                    SqlCommand satslrekle = new SqlCommand("SatisEkle", baglanti);
                    satslrekle.CommandType = CommandType.StoredProcedure;
                    satslrekle.Parameters.AddWithValue("@TC", satir.Cells["TC"].Value.ToString());
                    satslrekle.Parameters.AddWithValue("@Adi", satir.Cells["Adi"].Value.ToString());
                    satslrekle.Parameters.AddWithValue("@Soyadi", satir.Cells["Soyadi"].Value.ToString());
                    satslrekle.Parameters.AddWithValue("@EhliyetNumarasi", satir.Cells["EhliyetNumarasi"].Value.ToString());
                    satslrekle.Parameters.AddWithValue("@Plaka", satir.Cells["MSAPlaka"].Value.ToString());
                    satslrekle.Parameters.AddWithValue("@Marka", satir.Cells["Marka"].Value.ToString());
                    satslrekle.Parameters.AddWithValue("@Seri", satir.Cells["Seri"].Value.ToString());
                    satslrekle.Parameters.AddWithValue("@Model", satir.Cells["Model"].Value.ToString());
                    satslrekle.Parameters.AddWithValue("@Gun", tplmgn);
                    satslrekle.Parameters.AddWithValue("@Fiyat", satir.Cells["KiraUcreti"].Value.ToString());
                    satslrekle.Parameters.AddWithValue("@ToplamTutar", tplmtutar);
                    satslrekle.Parameters.AddWithValue("@AlisTarihi", AlisTarihi);
                    satslrekle.Parameters.AddWithValue("@TeslimTarihi", TeslimTarihi);
                    satslrekle.Parameters.AddWithValue("@TeslimAy", teslimay);

                    DialogResult tslall;
                    tslall = MessageBox.Show("Aracı Teslim almak İstediğinize Emin Misiniz", "Teslim Al!!", MessageBoxButtons.YesNo);
                    if (tslall == DialogResult.Yes)
                    {
                        satslrekle.ExecuteNonQuery();

                        SqlCommand sozlesmesilidnimi = new SqlCommand("Update Sozlesmeler Set Silindimi='True' Where MSAPlaka='" + satir.Cells["MSAPlaka"].Value.ToString() + "'", baglanti);

                        SqlCommand teslimtarihguncelle = new SqlCommand("Update Sozlesmeler set TeslimTarihi=@TeslimTarihi,ToplamGun=@ToplamGun, ToplamTutar=@ToplamTutar  where MSAPlaka='" + satir.Cells["MSAPlaka"].Value.ToString() + "'", baglanti);
                        teslimtarihguncelle.Parameters.AddWithValue("@TeslimTarihi", TeslimTarihi);
                        teslimtarihguncelle.Parameters.AddWithValue("@ToplamGun", tplmgn);
                        teslimtarihguncelle.Parameters.AddWithValue("@ToplamTutar", tplmtutar);

                        SqlCommand aracdurumu = new SqlCommand("Update Araclar Set Durumu='Musait' where Plaka='" + satir.Cells["MSAPlaka"].Value.ToString() + "'", baglanti);
                        aracdurumu.ExecuteNonQuery();
                        teslimtarihguncelle.ExecuteNonQuery();
                        sozlesmesilidnimi.ExecuteNonQuery();
                        baglanti.Close();
                        kiradaarac();
                        txtalckvrckdrm.Text = "";
                        MessageBox.Show("Araç Teslim Alındı");

                    }
                    else if (tslall == DialogResult.No)
                    {
                        baglanti.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Sözleşme Seçimi Yapınız!!");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            alacak_verecek();
        }

        private void txtplakasorgu_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand tcsorgu = new SqlCommand("select * from Sozlesmeler where MSAPlaka like @MSAPlaka and Silindimi='False'", baglanti);
            tcsorgu.Parameters.AddWithValue("@MSAPlaka", txtplakasorgu.Text + "%");
            SqlDataAdapter tcnosorgu = new SqlDataAdapter(tcsorgu);
            DataTable tablo = new DataTable();
            tcnosorgu.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void txttcsorgu_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand tcsorgu = new SqlCommand("select * from Sozlesmeler where TC like @TC and Silindimi='False'", baglanti);
            tcsorgu.Parameters.AddWithValue("@tc", txttcsorgu.Text + "%");
            SqlDataAdapter tcnosorgu = new SqlDataAdapter(tcsorgu);
            DataTable tablo = new DataTable();
            tcnosorgu.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
