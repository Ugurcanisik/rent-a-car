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
    public partial class Sozlesmeler : Form
    {
        public Sozlesmeler()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(18, 40);
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=AracKiralamaOtomasyonu;Integrated Security=True");

        void datatxtdoldur()
        {
            txtkrdarclar.Text = dataGridView1.CurrentRow.Cells["MSAPlaka"].Value.ToString();
            txtmarka.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            txtseri.Text = dataGridView1.CurrentRow.Cells["Seri"].Value.ToString();
            txtmodel.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
            txtvtstp.Text = dataGridView1.CurrentRow.Cells["VitesTipi"].Value.ToString();
            txtykttp.Text = dataGridView1.CurrentRow.Cells["YakitTipi"].Value.ToString();
            txtkm.Text = dataGridView1.CurrentRow.Cells["KM"].Value.ToString();
            txtrenk.Text = dataGridView1.CurrentRow.Cells["Renk"].Value.ToString();
            txtgnlk.Text = dataGridView1.CurrentRow.Cells["FiyatiG"].Value.ToString();
            txthftlk.Text = dataGridView1.CurrentRow.Cells["FiyatiH"].Value.ToString();
            txtaylk.Text = dataGridView1.CurrentRow.Cells["FiyatiA"].Value.ToString();
            cmbxmlst.SelectedItem = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            txtadi.Text = dataGridView1.CurrentRow.Cells["Adi"].Value.ToString();
            txtsoyadi.Text = dataGridView1.CurrentRow.Cells["Soyadi"].Value.ToString();
            txttelno.Text = dataGridView1.CurrentRow.Cells["TelefonNumarasi"].Value.ToString();
            txtehlytno.Text = dataGridView1.CurrentRow.Cells["EhliyetNumarasi"].Value.ToString();
            cmbxkiraskli.SelectedItem = dataGridView1.CurrentRow.Cells["KiralamaSekli"].Value.ToString();
            dtpalstrh.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["AlisTarihi"].Value.ToString());
            dtptslmtrh.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["TeslimTarihi"].Value.ToString());
            txtsaat.Text = dataGridView1.CurrentRow.Cells["FiyatiSaat"].Value.ToString();
            txttplmgn.Text = dataGridView1.CurrentRow.Cells["ToplamGun"].Value.ToString();
            txtkraucrti.Text = dataGridView1.CurrentRow.Cells["KiraUcreti"].Value.ToString();
            txttplmttr.Text = dataGridView1.CurrentRow.Cells["ToplamTutar"].Value.ToString();
            txttoplamsaat.Text = dataGridView1.CurrentRow.Cells["ToplamSaat"].Value.ToString();

        }

        void araclistele()
        {
            baglanti.Open();

            SqlCommand araclistele = new SqlCommand("select Plaka from Araclar where durumu='Musait' and Silindimi='False'", baglanti);

            SqlDataReader arclst = araclistele.ExecuteReader();

            while (arclst.Read())
            {
                             
                    cmbxmstarclr.Items.Add(arclst["plaka"].ToString());
                
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


        void sozlesmelistele()
        {
            baglanti.Open();

            SqlCommand szlsmgtr = new SqlCommand("select MSAPlaka,Marka,Seri,Model,VitesTipi,YakitTipi,KM,Renk,FiyatiSaat,FiyatiG,FiyatiH,FiyatiA,TC,Adi,Soyadi,TelefonNumarasi,EhliyetNumarasi,KiralamaSekli,AlisTarihi,TeslimTarihi,ToplamSaat,ToplamGun,KiraUcreti,ToplamTutar from Sozlesmeler where Silindimi='False'", baglanti);

            SqlDataAdapter sozlesmegetir = new SqlDataAdapter(szlsmgtr);
            DataTable tabloekle = new DataTable();

            sozlesmegetir.Fill(tabloekle);
            dataGridView1.DataSource = tabloekle;

            baglanti.Close();
        }

        void listele()
        {
            sozlesmelistele();
            cmbxmstarclr.Items.Clear();
            cmbxmstarclr.Items.Add("---Araçlar---");
            araclistele();
            cmbxmstarclr.SelectedIndex = 0;
            sil();
        }
        
        private void btnlstl_Click(object sender, EventArgs e)
        {

            listele();

        }

        

        void sil()
        {
            if (dataGridView1.RowCount == 0)
                btnsil.Enabled = false;
            else
                btnsil.Enabled = true;
        }
        private void Satislar_Load(object sender, EventArgs e)
        {
            this.Width = 1564;
            this.Height = 810;
            araclistele();
            sozlesmelistele();
            musterilistele();
            cmbxmstarclr.SelectedIndex = 0;
            cmbxmlst.SelectedIndex = 0;
            cmbxkiraskli.SelectedIndex = 0;
            sil();
            dtpalstrh.Enabled = false;
         
        }

        private void btngnclle_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            if(dataGridView1.RowCount==0)
            {
                MessageBox.Show("Sözleşme Ekleyiniz");
            }
            else
            { 
            if (txtkrdarclar.Text!="" && cmbxmlst.SelectedIndex>-1)
            {
                    if (txttoplamsaat.Text != "" && txttplmgn.Text != "" && txtkraucrti.Text != "" && txttplmttr.Text != "")
                    {

                        if (cmbxmstarclr.SelectedIndex > 0)
                        {
                            if (cmbxmlst.SelectedItem.ToString() == satir.Cells["TC"].Value.ToString())
                            {

                                DateTime alissaat = DateTime.Now;

                                if (dtptslmtrh.Enabled == false)
                                {

                                    alissaat = DateTime.Now.AddHours(Convert.ToDouble(txttoplamsaat.Text));

                                }

                                string alistarihsaat = alissaat.ToString();

                                //MessageBox.Show(alistarihsaat);


                                //MessageBox.Show("TC ler Ayni");
                                    string AlisTarihi = dtpalstrh.Value.ToString("g");
                                    string TeslimTarihi = dtptslmtrh.Value.ToString("g");


                                    baglanti.Open();
                                    SqlCommand durumguncelle = new SqlCommand("Update Araclar set Durumu=@Durumu where Plaka=@Plaka", baglanti);
                                    durumguncelle.Parameters.AddWithValue("@Plaka", cmbxmstarclr.SelectedItem);
                                    durumguncelle.Parameters.AddWithValue("@Durumu", "Kirada");

                                    SqlCommand sozlesmedurumguncelle = new SqlCommand("Update Araclar set Durumu=@Durumu where Plaka=@Plaka ", baglanti);
                                    sozlesmedurumguncelle.Parameters.AddWithValue("@Durumu", "Musait");
                                    sozlesmedurumguncelle.Parameters.AddWithValue("@Plaka", txtkrdarclar.Text);
                                    SqlCommand szlsmeguncelle = new SqlCommand("SozlesmeGuncelle", baglanti);
                                    szlsmeguncelle.CommandType = CommandType.StoredProcedure;
                                    szlsmeguncelle.Parameters.AddWithValue("@MSAPlaka", cmbxmstarclr.SelectedItem);
                                    szlsmeguncelle.Parameters.AddWithValue("@Marka", txtmarka2.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@Seri", txtseri2.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@Model", txtmodel2.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@VitesTipi", txtvt2.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@YakitTipi", txtyt2.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@KM", txtkm2.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@Renk", txtrnk2.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@FiyatiG", txtg2.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@FiyatiH", txth2.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@FiyatiA", txta2.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@TC", cmbxmlst.SelectedItem);
                                    szlsmeguncelle.Parameters.AddWithValue("@Adi", txtadi.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@Soyadi", txtsoyadi.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@TelefonNumarasi", txttelno.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@EhliyetNumarasi", txtehlytno.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@KiralamaSekli", cmbxkiraskli.SelectedItem);
                                   
                                szlsmeguncelle.Parameters.AddWithValue("@AlisTarihi", AlisTarihi);
                                if (dtptslmtrh.Enabled == false)
                                {
                                    szlsmeguncelle.Parameters.AddWithValue("@TeslimTarihi", alistarihsaat);
                                    szlsmeguncelle.Parameters.AddWithValue("@ToplamSaat", txttoplamsaat.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@ToplamGun", "0");
                                    szlsmeguncelle.Parameters.AddWithValue("@KiraUcreti", txtkraucrti.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@ToplamTutar", txttplmttr.Text);
                                }
                                else if (dtptslmtrh.Enabled == true)
                                {
                                    szlsmeguncelle.Parameters.AddWithValue("@ToplamSaat", "0");
                                    szlsmeguncelle.Parameters.AddWithValue("@TeslimTarihi", TeslimTarihi);
                                    szlsmeguncelle.Parameters.AddWithValue("@ToplamGun", txttplmgn.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@KiraUcreti", txtkraucrti.Text);
                                    szlsmeguncelle.Parameters.AddWithValue("@ToplamTutar", txttplmttr.Text);
                                }              
                                SqlDataAdapter sozlesmegnclle = new SqlDataAdapter(szlsmeguncelle);
                                    DataTable tablola = new DataTable();
                                    sozlesmegnclle.Fill(tablola);
                                    dataGridView1.DataSource = tablola;
                                    durumguncelle.ExecuteNonQuery();
                                    sozlesmedurumguncelle.ExecuteNonQuery();
                                    baglanti.Close();
                                    sozlesmelistele();
                                    temizle();
                                    araclistele();
                                    listele();

                                    cmbxmlst.SelectedIndex = 0;
                                    MessageBox.Show("Güncelleme Başarılı");
                               
                            }
                            else
                            {

                                MessageBox.Show("hem arabayı hemde muşteriyi değiştiremezsiniz");
                            }
                        }
                        else
                        {
                            if (cmbxmstarclr.SelectedIndex == 0)
                            {
                                if (cmbxkiraskli.SelectedIndex > -1 && txttoplamsaat.Text != "" && txttplmttr.Text != "")
                                {
                                    if (txtkrdarclar.Text.ToString() == satir.Cells["MSAPlaka"].Value.ToString())
                                    {

                                        DateTime alissaat = DateTime.Now;

                                        if (dtptslmtrh.Enabled == false)
                                        {
                                            
                                            alissaat = DateTime.Now.AddHours(Convert.ToDouble(txttoplamsaat.Text));

                                        }

                                        string alistarihsaat = alissaat.ToString();

                                        //MessageBox.Show(alistarihsaat);

                                        //MessageBox.Show("Plakalar Ayni ");
                                        string AlisTarihi = dtpalstrh.Value.ToString("g");
                                        string TeslimTarihi = dtptslmtrh.Value.ToString("g");


                                        baglanti.Open();
                                        SqlCommand szlsmeguncelle = new SqlCommand("SozlesmeGuncelleTC", baglanti);
                                        szlsmeguncelle.CommandType = CommandType.StoredProcedure;
                                        szlsmeguncelle.Parameters.AddWithValue("@MSAPlaka", txtkrdarclar.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@Marka", txtmarka.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@Seri", txtseri.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@Model", txtmodel.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@VitesTipi", txtvtstp.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@YakitTipi", txtykttp.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@KM", txtkm.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@Renk", txtrenk.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@FiyatiG", txtgnlk.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@FiyatiH", txthftlk.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@FiyatiA", txtaylk.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@TC", cmbxmlst.SelectedItem);
                                        szlsmeguncelle.Parameters.AddWithValue("@Adi", txtadi.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@Soyadi", txtsoyadi.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@TelefonNumarasi", txttelno.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@EhliyetNumarasi", txtehlytno.Text);
                                        szlsmeguncelle.Parameters.AddWithValue("@KiralamaSekli", cmbxkiraskli.SelectedItem);
                                        szlsmeguncelle.Parameters.AddWithValue("@AlisTarihi", AlisTarihi);
                                        if (dtptslmtrh.Enabled == false)
                                        {
                                            szlsmeguncelle.Parameters.AddWithValue("@TeslimTarihi", alistarihsaat);
                                            szlsmeguncelle.Parameters.AddWithValue("@ToplamSaat", txttoplamsaat.Text);
                                            szlsmeguncelle.Parameters.AddWithValue("@ToplamGun", "0");
                                            szlsmeguncelle.Parameters.AddWithValue("@KiraUcreti", txtkraucrti.Text);
                                            szlsmeguncelle.Parameters.AddWithValue("@ToplamTutar", txttplmttr.Text);
                                        }
                                        else if (dtptslmtrh.Enabled == true)
                                        {
                                            szlsmeguncelle.Parameters.AddWithValue("@ToplamSaat", "0");
                                            szlsmeguncelle.Parameters.AddWithValue("@TeslimTarihi", TeslimTarihi);
                                            szlsmeguncelle.Parameters.AddWithValue("@ToplamGun", txttplmgn.Text);
                                            szlsmeguncelle.Parameters.AddWithValue("@KiraUcreti", txtkraucrti.Text);
                                            szlsmeguncelle.Parameters.AddWithValue("@ToplamTutar", txttplmttr.Text);
                                        }
                                        SqlDataAdapter sozlesmegnclle = new SqlDataAdapter(szlsmeguncelle);
                                        DataTable tablola = new DataTable();
                                        sozlesmegnclle.Fill(tablola);
                                        dataGridView1.DataSource = tablola;
                                        baglanti.Close();
                                        sozlesmelistele();
                                        temizle();
                                        araclistele();
                                        listele();
                                        MessageBox.Show("Güncelleme Başarılı");
                                        cmbxmlst.SelectedIndex = 0;

                                    }
                                }
                                else
                                {

                                }
                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("Ödeme Alanını Hesaplayınız");
                    }


                }
            else
                {
                    MessageBox.Show("Sözleşme Seçimi Yapınız");
                    temizle();
                }
            }
            }


        private void dtptslmtrh_ValueChanged(object sender, EventArgs e)
        {
            //txttoplamsaat.Text = "";
            //txttoplamsaat.Enabled = false;

            if (dtptslmtrh.Value >= dtpalstrh.Value)
            {
                DateTime bTarih = Convert.ToDateTime(dtptslmtrh.Text);
                DateTime kTarih = Convert.ToDateTime(dtpalstrh.Text);
                TimeSpan Sonuc = bTarih - kTarih;
                txttplmgn.Text = Sonuc.TotalDays.ToString();
                txttplmttr.Text = "";

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

        private void cmbxkiraskli_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kira;
            kira = cmbxkiraskli.SelectedIndex;

            switch (kira)
            {
                case 0:
                    {
                        txtkraucrti.Text = txtsaat.Text;
                        dtptslmtrh.Enabled = false;
                        txttoplamsaat.Enabled = true;
                        txttplmgn.Text = "0";
                        dtptslmtrh.Value = DateTime.Now;
                        if(cmbxmstarclr.SelectedIndex>0)
                        {
                            txtkraucrti.Text = txtsaat2.Text;
                            txttplmttr.Text = "";
                            txttplmgn.Text = "";
                            txttplmgn.Text = "0";

                        }
       

                        break;
                    }
                case 1:
                    {
                        txtkraucrti.Text = txtgnlk.Text;
                        dtptslmtrh.Enabled = true;
                        txttplmgn.Text = "";
                        txttoplamsaat.Enabled = false;
                        txttoplamsaat.Text = "0";
                        txttplmttr.Text = "";
                        dtptslmtrh.Value = DateTime.Now;
                        if (cmbxmstarclr.SelectedIndex > 0)
                        {
                            txtkraucrti.Text = txtg2.Text;
                            txttplmttr.Text = "";
                            txttplmgn.Text = "";
                        }

                        break;
                    }
                case 2:
                    {
                        txtkraucrti.Text = txthftlk.Text;
                        dtptslmtrh.Enabled = true;
                        txttplmgn.Text = "";
                        txttoplamsaat.Enabled = false;
                        txttoplamsaat.Text = "0";
                        txttplmttr.Text = "";
                        dtptslmtrh.Value = DateTime.Now;
                        if (cmbxmstarclr.SelectedIndex > 0)
                        {
                            txtkraucrti.Text = txth2.Text;
                            txttplmttr.Text = "";
                            txttplmgn.Text = "";
                        }

                        break;
                    }
                case 3:
                    {
                        txtkraucrti.Text = txtaylk.Text;
                        dtptslmtrh.Enabled = true;
                        txttplmgn.Text = "";
                        txttoplamsaat.Enabled = false;
                        txttoplamsaat.Text = "0";
                        txttplmttr.Text = "";
                        dtptslmtrh.Value = DateTime.Now;
                        if (cmbxmstarclr.SelectedIndex > 0)
                        {
                            txtkraucrti.Text = txta2.Text;
                            txttplmttr.Text = "";
                            txttplmgn.Text = "";
                        }

                        break;
                    }
            }
        }

        private void btnhspl_Click(object sender, EventArgs e)
        {
            if (txttoplamsaat.Enabled == true && txttoplamsaat.Text != "" && txtkraucrti.Text!="")
            {
                txttplmttr.Text = ((Convert.ToInt32(txttoplamsaat.Text)) * (Convert.ToInt32(txtkraucrti.Text))).ToString();
            }
            else if (txttplmgn.Text != "" && txtkraucrti.Text != "" && txttoplamsaat.Enabled == false)
                txttplmttr.Text = ((Convert.ToInt32(txttplmgn.Text)) * (Convert.ToInt32(txtkraucrti.Text))).ToString();
            else
            {
                MessageBox.Show("Ödeme Alanlarını Doldurunuz!");
            }

        }

        private void btntmzl_Click(object sender, EventArgs e)
        {


            temizle();
            sil();

        }

        void temizle()
        {
            cmbxmlst.SelectedIndex = 0;
            cmbxkiraskli.SelectedIndex = 0;
            //cmbxmstarclr.SelectedIndex = 0;
            txtmarka2.Text = "";
            txtseri2.Text = "";
            txtmodel2.Text = "";
            txtvt2.Text = "";
            txtyt2.Text = "";
            txtrnk2.Text = "";
            txtkm2.Text = "";
            txtg2.Text = "";
            txth2.Text = "";
            txta2.Text = "";
            txtkrdarclar.Text = "";
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
            txttplmgn.Text = "";
            txttoplamsaat.Text = "";
            txtsaat2.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {





            datatxtdoldur();







           
        }

       

        private void txttcsrg_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand tcsorgu = new SqlCommand("select * from Sozlesmeler where TC like @TC and Silindimi='False'", baglanti);
            tcsorgu.Parameters.AddWithValue("@tc", txttcsrg.Text + "%");
            SqlDataAdapter tcnosorgu = new SqlDataAdapter(tcsorgu);
            DataTable tablo = new DataTable();
            tcnosorgu.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void txtplksrg_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand tcsorgu = new SqlCommand("select * from Sozlesmeler where MSAPlaka like @MSAPlaka and Silindimi='False'", baglanti);
            tcsorgu.Parameters.AddWithValue("@MSAPlaka", txtplksrg.Text + "%");
            SqlDataAdapter tcnosorgu = new SqlDataAdapter(tcsorgu);
            DataTable tablo = new DataTable();
            tcnosorgu.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
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


        private void cmbxmstarclr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbxmstarclr.SelectedIndex==0)
            {
                txtmarka2.Text = "";
                txtseri2.Text = "";
                txtmodel2.Text = "";
                txtvt2.Text = "";
                txtyt2.Text = "";
                txtrnk2.Text = "";
                txtkm2.Text = "";
                txtg2.Text = "";
                txth2.Text = "";
                txta2.Text = "";
                txtsaat2.Text = "";
            }
            else
            { 
            baglanti.Open();
            SqlCommand txtdoldur = new SqlCommand("select Plaka,Marka,Seri,Model,VitesTipi,YakitTipi,KM,Renk,FiyatiSaat,FiyatiG,FiyatiH,FiyatiA from Araclar where Plaka=@Plaka", baglanti);

            txtdoldur.Parameters.AddWithValue("@Plaka", cmbxmstarclr.SelectedItem);

            SqlDataReader txtyaz = txtdoldur.ExecuteReader();

            if (txtyaz.Read())
            {
                cmbxmstarclr.SelectedItem = txtyaz["Plaka"].ToString();
                txtmarka2.Text = txtyaz["Marka"].ToString();
                txtseri2.Text = txtyaz["Seri"].ToString();
                txtmodel2.Text = txtyaz["Model"].ToString();
                txtvt2.Text = txtyaz["VitesTipi"].ToString();
                txtyt2.Text = txtyaz["YakitTipi"].ToString();
                txtkm2.Text = txtyaz["KM"].ToString();
                txtrnk2.Text = txtyaz["Renk"].ToString();
                    txtsaat2.Text = txtyaz["FiyatiSaat"].ToString();
                    txtg2.Text = txtyaz["FiyatiG"].ToString();
                txth2.Text = txtyaz["FiyatiH"].ToString();
                txta2.Text = txtyaz["FiyatiA"].ToString();
            }
            baglanti.Close();
            }
            cmbxkiraskli.SelectedIndex = 1;
            txtkraucrti.Text = txtg2.Text;
            txttplmttr.Text = "";
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            if (satir.Cells["MSAPlaka"].Value.ToString() == txtkrdarclar.Text && txtkrdarclar.Text != "")
            {
                DialogResult szlsmesil;
                szlsmesil = MessageBox.Show("Sözleşmeyi Silmek İstediğinize Emin Misiniz", "Sil!!", MessageBoxButtons.YesNo);
                if (szlsmesil == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand silindimi = new SqlCommand("Update Sozlesmeler Set Silindimi=1 where MSAPlaka=@MSAPlaka", baglanti);
                    silindimi.Parameters.AddWithValue("@MSAPlaka", satir.Cells["MSAPlaka"].Value.ToString());
                    silindimi.ExecuteNonQuery();
                    SqlCommand aracdurumu = new SqlCommand("Update Araclar set Durumu=@Durumu Where Plaka=@Plaka", baglanti);
                    aracdurumu.Parameters.AddWithValue("@Plaka", satir.Cells["MSAPlaka"].Value.ToString());
                    aracdurumu.Parameters.AddWithValue("@Durumu", "Musait");
                    aracdurumu.ExecuteNonQuery();
                    baglanti.Close();
                    temizle();
                    musterilistele();
                    sozlesmelistele();
                    MessageBox.Show("Sözleşme Silindi");
                    sil();
                    listele();
                }
                else if (szlsmesil == DialogResult.No)
                {
                    baglanti.Close();
                    listele();
                    musterilistele();
                    sozlesmelistele();
                    araclistele();
                }
            }
            else
            {
                if (txtkrdarclar.Text == "")
                {
                    MessageBox.Show("Sözleşme Seçiniz  ");
                }
                else
                    MessageBox.Show("Seçilen Plakalar Farklı ");
            }
        }
        private void txttoplamsaat_KeyPress(object sender, KeyPressEventArgs e)
        {
            dtptslmtrh.Value = DateTime.Now;
            txttplmgn.Text = "0";
            txttplmttr.Text = "";
            
            
        }
    }
}
