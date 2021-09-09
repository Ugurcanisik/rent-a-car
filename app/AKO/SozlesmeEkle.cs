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
    public partial class SozlesmeEkle : Form
    {
        public SozlesmeEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=AracKiralamaOtomasyonu;Integrated Security=True");

        void araclistele()
        {
            baglanti.Open();

            SqlCommand araclistele = new SqlCommand("select Plaka from Araclar where durumu='Musait' and Silindimi='False'", baglanti);

            SqlDataReader arclst = araclistele.ExecuteReader();

            while (arclst.Read())
            {
                cmbxmstarclr.Items.Add(arclst["plaka"]);
            }
            baglanti.Close();
        }

        void musterilistele()
        {
            baglanti.Open();

            SqlCommand musterilistele = new SqlCommand("select TC from Musteriler where Silindimi='False'", baglanti);

            SqlDataReader mstrlst = musterilistele.ExecuteReader();

            while (mstrlst.Read())
            {
                cmbxmlst.Items.Add(mstrlst["TC"]);
            }
            baglanti.Close();
        }


        private void btniptl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string AlisTarihi = dtpalstrh.Value.ToString("g");
            string TeslimTarihi = dtptslmtrh.Value.ToString("g");

            DateTime alissaat = DateTime.Now;

            if (dtptslmtrh.Enabled == false)
            {
                alissaat = DateTime.Now.AddHours(Convert.ToDouble(txtsaat.Text));
            }



            //DateTime alissaat = DateTime.Now;
            //alissaat = DateTime.Now.AddHours(Convert.ToDouble(txtsaat.Text));



            SqlCommand stsekle = new SqlCommand("SozlesmeEkle",baglanti);
            stsekle.CommandType = CommandType.StoredProcedure;
            stsekle.Parameters.AddWithValue("@MSAPlaka", cmbxmstarclr.SelectedItem);
            stsekle.Parameters.AddWithValue("@Marka", txtmarka.Text);
            stsekle.Parameters.AddWithValue("@Seri", txtseri.Text);
            stsekle.Parameters.AddWithValue("@Model", txtmodel.Text);
            stsekle.Parameters.AddWithValue("@VitesTipi", txtvtstp.Text);
            stsekle.Parameters.AddWithValue("@YakitTipi", txtykttp.Text);
            stsekle.Parameters.AddWithValue("@KM", txtkm.Text);
            stsekle.Parameters.AddWithValue("@Renk", txtrenk.Text);
            stsekle.Parameters.AddWithValue("@FiyatiSaat", txtfiyatsaat.Text);
            stsekle.Parameters.AddWithValue("@FiyatiG", txtgnlk.Text);
            stsekle.Parameters.AddWithValue("@FiyatiH", txthftlk.Text);
            stsekle.Parameters.AddWithValue("@FiyatiA", txtaylk.Text);
            stsekle.Parameters.AddWithValue("@TC", cmbxmlst.SelectedItem);
            stsekle.Parameters.AddWithValue("@Adi", txtadi.Text);
            stsekle.Parameters.AddWithValue("@Soyadi", txtsoyadi.Text);
            stsekle.Parameters.AddWithValue("@TelefonNumarasi", txttelno.Text);
            stsekle.Parameters.AddWithValue("@EhliyetNumarasi", txtehlytno.Text);
            stsekle.Parameters.AddWithValue("@KiralamaSekli", cmbxkiraskli.SelectedItem);
            stsekle.Parameters.AddWithValue("@AlisTarihi", AlisTarihi);
            if(dtptslmtrh.Enabled==false)
            {
                stsekle.Parameters.AddWithValue("@TeslimTarihi", alissaat.ToString());
                stsekle.Parameters.AddWithValue("@ToplamSaat", txtsaat.Text);
                stsekle.Parameters.AddWithValue("@ToplamGun", "0");
                stsekle.Parameters.AddWithValue("@KiraUcreti", txtkraucrti.Text);
                stsekle.Parameters.AddWithValue("@ToplamTutar", txttplmttr.Text);
                stsekle.Parameters.AddWithValue("Silindimi", "False");
            }
            else if(dtptslmtrh.Enabled==true)
            {
            stsekle.Parameters.AddWithValue("@ToplamSaat", "0");
            stsekle.Parameters.AddWithValue("@TeslimTarihi", TeslimTarihi);
            stsekle.Parameters.AddWithValue("@ToplamGun", txttplmgn.Text);
            stsekle.Parameters.AddWithValue("@KiraUcreti", txtkraucrti.Text);
            stsekle.Parameters.AddWithValue("@ToplamTutar", txttplmttr.Text);
            stsekle.Parameters.AddWithValue("Silindimi", "False");
            }


            if (cmbxmstarclr.SelectedIndex>-1 && cmbxmlst.SelectedIndex>-1 && cmbxkiraskli.SelectedIndex>-1 && cmbxmlst.SelectedIndex>-1 && txtadi.Text!="" )
            {
 
                if(dtptslmtrh.Enabled==false)
                {
                    if (txtkraucrti.Text != "" && txttplmttr.Text == "" && txtsaat.Text != "")
                    {
                        MessageBox.Show("Ödeme Alanlarını Kontrol Ediniz!!");
                    }
                    else
                    {
                        DialogResult szlsmekydt;
                        szlsmekydt = MessageBox.Show("Sözleşme Eklemek İstediğinize Emin Misiniz", "Kaydet!!", MessageBoxButtons.YesNo);
                        if (szlsmekydt == DialogResult.Yes)
                        {
                            SqlCommand durumbilgisi = new SqlCommand("Update Araclar set Durumu=@Durumu where Plaka=@Plaka", baglanti);
                            durumbilgisi.Parameters.AddWithValue("@Plaka", cmbxmstarclr.SelectedItem);
                            durumbilgisi.Parameters.AddWithValue("@Durumu", "Kirada");

                            stsekle.ExecuteNonQuery();
                            durumbilgisi.ExecuteNonQuery();
                            
                            MessageBox.Show("Kiralama Gerçekleşti!!");
                            cmbxmstarclr.Items.Clear();
                            cmbxmstarclr.Items.Add("---Araçlar---");
                            baglanti.Close();
                            cmbxmstarclr.SelectedIndex = 0;
                            araclistele();
                            temizle();


                        }
                        else if (szlsmekydt == DialogResult.No)
                        {
                            baglanti.Close();
                        }
                    }
                }
                else
                { 
                if (dtptslmtrh.Value > dtpalstrh.Value)
                {
                    if(txttplmgn.Text!="" && txtkraucrti.Text!="" && txttplmttr.Text=="")
                    {
                        MessageBox.Show("Ödeme Alanlarını Kontrol Ediniz!!");
                    }
                    else
                    {
                        DialogResult szlsmekydt;
                        szlsmekydt = MessageBox.Show("Sözleşme Eklemek İstediğinize Emin Misiniz", "Kaydet!!", MessageBoxButtons.YesNo);
                        if (szlsmekydt == DialogResult.Yes)
                        {
                            SqlCommand durumbilgisi = new SqlCommand("Update Araclar set Durumu=@Durumu where Plaka=@Plaka", baglanti);
                            durumbilgisi.Parameters.AddWithValue("@Plaka", cmbxmstarclr.SelectedItem);
                            durumbilgisi.Parameters.AddWithValue("@Durumu", "Kirada");                           
                            durumbilgisi.ExecuteNonQuery();
                            stsekle.ExecuteNonQuery();
                            MessageBox.Show("Kiralama Gerçekleşti!!");
                            cmbxmstarclr.Items.Clear();
                            cmbxmstarclr.Items.Add("---Araçlar---");
                            baglanti.Close();
                            cmbxmstarclr.SelectedIndex = 0;
                            araclistele();
                            temizle();
                            

                        }
                        else if (szlsmekydt == DialogResult.No)
                        {
                            baglanti.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Teslim Tarihini Düzenleyiniz!!");
                }
                }
            }
            else
            {
                MessageBox.Show("Kiralama İşlemi İçin Alanların Hepsini Doldurun!!");
            }
            baglanti.Close();
        }

        private void SatisEkle_Load(object sender, EventArgs e)
        {
            araclistele();
            musterilistele();
            cmbxmstarclr.SelectedIndex = 0;
            cmbxmlst.SelectedIndex = 0;
            dtpalstrh.Enabled = false;

        }

        private void cmbxkiraskli_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kira;
            kira = cmbxkiraskli.SelectedIndex;

            switch (kira)
            {
                case 0:
                    {
                        txtkraucrti.Text = txtfiyatsaat.Text;
                        dtptslmtrh.Enabled = false;
                        txtsaat.Enabled = true;
                        txttplmttr.Text = "";
                        break;
                    }
                case 1:
                    {
                        txtkraucrti.Text = txtgnlk.Text;
                        dtptslmtrh.Enabled = true;
                      
                        txtsaat.Enabled = false;
                        txtsaat.Text = "";
                        txttplmttr.Text = "";
                        break;
                    }
                case 2:
                    {
                        txtkraucrti.Text = txthftlk.Text;
                        dtptslmtrh.Enabled = true;
                      
                        txtsaat.Enabled = false;
                        txtsaat.Text = "";
                        txttplmttr.Text = "";
                        break;
                    }
                case 3:
                    {
                        txtkraucrti.Text = txtaylk.Text;
                        dtptslmtrh.Enabled = true;
                        
                        txtsaat.Enabled = false;
                        txtsaat.Text = "";
                        txttplmttr.Text = "";
                        break;
                    }
            }
        }

        private void dtptslmtrh_ValueChanged(object sender, EventArgs e)
        {
            if (dtptslmtrh.Value >= dtpalstrh.Value)
            {
                DateTime bTarih = Convert.ToDateTime(dtptslmtrh.Text);
                DateTime kTarih = Convert.ToDateTime(dtpalstrh.Text);
                TimeSpan Sonuc = bTarih - kTarih;
                txttplmgn.Text = Sonuc.TotalDays.ToString();
            }
            else
            {
                txttplmgn.Text = "";
                MessageBox.Show("Teslim Tarihi Aliş Tarihinden Önce Olamaz!!");
                dtptslmtrh.Value = DateTime.Now;
                dtpalstrh.Value = DateTime.Now;
            }
            if (txttplmgn.Text == "0")
                txttplmgn.Text = "";
        }

        private void cmbxmstarclr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbxmstarclr.SelectedIndex==0)
            {
                txttplmgn.Text = "";
                txtkraucrti.Text = "";
                txttplmttr.Text = "";
                txtmarka.Text = "";
                txtseri.Text = "";
                txtmodel.Text = "";
                txtvtstp.Text = "";
                txtykttp.Text = "";
                txtkm.Text = "";
                txtrenk.Text = "";
                txthftlk.Text = "";
                txtgnlk.Text = "";
                txtaylk.Text = "";
                txtfiyatsaat.Text = "";
            }
            else
            {         
            baglanti.Open();
            SqlCommand txtdoldur = new SqlCommand("select Marka,Seri,Model,VitesTipi,YakitTipi,KM,Renk,FiyatiSaat,FiyatiG,FiyatiH,FiyatiA from Araclar where Plaka=@Plaka ", baglanti);

            txtdoldur.Parameters.AddWithValue("@Plaka", cmbxmstarclr.SelectedItem);

            SqlDataReader txtyaz = txtdoldur.ExecuteReader();

            if (txtyaz.Read())
            {
                txtmarka.Text = txtyaz["Marka"].ToString();
                txtseri.Text = txtyaz["Seri"].ToString();
                txtmodel.Text = txtyaz["Model"].ToString();
                txtvtstp.Text = txtyaz["VitesTipi"].ToString();
                txtykttp.Text = txtyaz["YakitTipi"].ToString();
                txtkm.Text = txtyaz["KM"].ToString();
                txtrenk.Text = txtyaz["Renk"].ToString();
                    txtfiyatsaat.Text = txtyaz["FiyatiSaat"].ToString();
                txtgnlk.Text = txtyaz["FiyatiG"].ToString();
                txthftlk.Text = txtyaz["FiyatiH"].ToString();
                txtaylk.Text = txtyaz["FiyatiA"].ToString();
            }
            txtkraucrti.Text = txtfiyatsaat.Text;
            cmbxkiraskli.SelectedIndex = 0;
            baglanti.Close();
            }


        }

        private void cmbxmlst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbxmlst.SelectedIndex==0)
            {
                txtadi.Text = "";
                txtsoyadi.Text = "";
                txttelno.Text = "";
                txtehlytno.Text = "";
            }
            else
            { 
            baglanti.Open();

            SqlCommand txtdoldur = new SqlCommand("select Adi,Soyadi,TelefonNumarasi,EhliyetNumarasi from Musteriler where TC=@TC", baglanti);

            txtdoldur.Parameters.AddWithValue("@TC", cmbxmlst.SelectedItem);

            SqlDataReader txtyaz = txtdoldur.ExecuteReader();

            if (txtyaz.Read())
            {
                txtadi.Text = txtyaz["Adi"].ToString();
                txtsoyadi.Text = txtyaz["Soyadi"].ToString();
                txttelno.Text = txtyaz["TelefonNumarasi"].ToString();
                txtehlytno.Text = txtyaz["EhliyetNumarasi"].ToString();
            }
            baglanti.Close();
            }
        }

        private void btnhspl_Click(object sender, EventArgs e)
        {
            if(txtsaat.Enabled==true && txtsaat.Text!="")
            {
                txttplmttr.Text = ((Convert.ToInt32(txtsaat.Text)) * (Convert.ToInt32(txtkraucrti.Text))).ToString();
            }
            else if (txttplmgn.Text != "" && txtkraucrti.Text != "" && txtsaat.Enabled==false)
                txttplmttr.Text = ((Convert.ToInt32(txttplmgn.Text)) * (Convert.ToInt32(txtkraucrti.Text))).ToString();
            else
            {
                MessageBox.Show("Ödeme Alanlarını Doldurunuz!");
            }





        }

        void temizle()
        {
            cmbxmstarclr.SelectedIndex = 0;
            cmbxkiraskli.SelectedIndex = -1;
            cmbxmlst.SelectedIndex = 0;
            dtpalstrh.Text = DateTime.Now.ToString();
            dtptslmtrh.Text = DateTime.Now.ToString();
            txttplmgn.Text = "";
            txtkraucrti.Text = "";
            txttplmttr.Text = "";
            txtmarka.Text = "";
            txtseri.Text = "";
            txtmodel.Text = "";
            txtvtstp.Text = "";
            txtykttp.Text = "";
            txtkm.Text = "";
            txtrenk.Text = "";
            txthftlk.Text = "";
            txtgnlk.Text = "";
            txtaylk.Text = "";
            txtadi.Text = "";
            txtsoyadi.Text = "";
            txttelno.Text = "";
            txtehlytno.Text = "";
            txtsaat.Text = "";
        }

        private void btntmzle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
