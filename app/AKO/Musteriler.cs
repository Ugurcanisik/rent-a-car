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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(18, 40);
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=AracKiralamaOtomasyonu;Integrated Security=True");

        void databoyut()
        {
            this.dataGridView1.Columns["TC"].Width = 215;
            this.dataGridView1.Columns["Adi"].Width = 215;
            this.dataGridView1.Columns["Soyadi"].Width = 215;
            this.dataGridView1.Columns["TelefonNumarasi"].Width = 215;
            this.dataGridView1.Columns["Email"].Width = 215;
            this.dataGridView1.Columns["Adres"].Width = 215;
            this.dataGridView1.Columns["EhliyetNumarasi"].Width = 215;

        }


        void musterilistele()
        {
            baglanti.Open();
            SqlCommand listele = new SqlCommand("select TC,Adi,Soyadi,TelefonNumarasi,Email,Adres,EhliyetNumarasi from Musteriler where Silindimi='False'", baglanti);
            SqlDataAdapter musterilistele = new SqlDataAdapter(listele);
            DataTable tablola = new DataTable();
            musterilistele.Fill(tablola);
            dataGridView1.DataSource = tablola;
            baglanti.Close();
        }

        void sil()
        {
            if (dataGridView1.RowCount == 0)
                btnsil.Enabled = false;
            else
                btnsil.Enabled = true;
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            this.Width = 1564;
            this.Height = 810;
            musterilistele();
            databoyut();
            sil();
            btnresimsec.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnlstl_Click(object sender, EventArgs e)
        {
            musterilistele();
            sil();
        }

        private void txttcnosorgu_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand tcsorgu = new SqlCommand("select * from Musteriler where TC like @TC", baglanti);
            tcsorgu.Parameters.AddWithValue("@tc", txttcnosorgu.Text + "%");
            SqlDataAdapter tcnosorgu = new SqlDataAdapter(tcsorgu);
            DataTable tablo= new DataTable();
            tcnosorgu.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }



        private void btngnclle_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            if(dataGridView1.RowCount==0)
            {
                MessageBox.Show("Müşteri Ekleyiniz");
            }
            else
            { 
            if (txtadi.Text != "")
            {
                if (txttcno.Text == satir.Cells["TC"].Value.ToString() && txtadi.Text == satir.Cells["Adi"].Value.ToString() && txtsoyadi.Text == satir.Cells["Soyadi"].Value.ToString() &&
                    txttelno.Text == satir.Cells["TelefonNumarasi"].Value.ToString() && txtmail.Text == satir.Cells["Email"].Value.ToString() && txtadres.Text == satir.Cells["Adres"].Value.ToString() &&
                    txtehlytnmr.Text == satir.Cells["EhliyetNumarasi"].Value.ToString() && eskiresim==dosyayeri)
                {
                    MessageBox.Show("bütün veriler ayni ");
                }
                else
                { 
                if (txttelno.Text != "" && txttelno.Text.Count() == 14)
                {
                    if (txttcno.Text != "" && txttcno.Text.Count() == 11)
                    {
                        if (txtehlytnmr.Text != "" && txtehlytnmr.Text.Count() == 6)
                        {
                              if(txttcno.Text == satir.Cells["TC"].Value.ToString())
                                { 
                                //MessageBox.Show("tc ler ayni");
                            baglanti.Open();

                            SqlCommand guncelle = new SqlCommand("update Musteriler set Adi=@Adi , Soyadi=@Soyadi, TelefonNumarasi=@TelefonNumarasi, Adres=@Adres, Email=@Email, EhliyetNumarasi=@EhliyetNumarasi, Resim=@Resim where TC=@TC", baglanti);

                            guncelle.Parameters.AddWithValue("@TC", txttcno.Text);
                            guncelle.Parameters.AddWithValue("@Adi", txtadi.Text);
                            guncelle.Parameters.AddWithValue("@Soyadi", txtsoyadi.Text);
                            guncelle.Parameters.AddWithValue("@TelefonNumarasi", txttelno.Text);
                            guncelle.Parameters.AddWithValue("@Email", txtmail.Text);
                            guncelle.Parameters.AddWithValue("@Adres", txtadres.Text);
                            guncelle.Parameters.AddWithValue("@EhliyetNumarasi", txtehlytnmr.Text);
                                        guncelle.Parameters.AddWithValue("@Resim", dosyayeri);

                            DialogResult guncelleme;
                            guncelleme = MessageBox.Show("Müşteri Kaydını Güncellemek İstediğinize Emin Misiniz", "Güncelle!!", MessageBoxButtons.YesNo);
                            if (guncelleme == DialogResult.Yes)
                            {
                                SqlDataAdapter musterguncelle = new SqlDataAdapter(guncelle);
                                DataTable tablola = new DataTable();
                                musterguncelle.Fill(tablola);
                                dataGridView1.DataSource = tablola;
                                baglanti.Close();
                                musterilistele();
                                        temizle();
                                        databoyut();
                                        sil();
                                        MessageBox.Show("Müşteri Kaydı Guncelleme Başarılı!");
                            }
                            else if (guncelleme == DialogResult.No)
                            {
                                baglanti.Close();
                            }
                                }
                                else if(txttelno.Text == satir.Cells["TelefonNumarasi"].Value.ToString())
                                {
                                    //MessageBox.Show("telefon aynı ayni");
                                    SqlCommand guncelletc = new SqlCommand("update Musteriler set TC=@TC ,Adi=@Adi, Soyadi=@Soyadi, Adres=@Adres, Email=@Email, EhliyetNumarasi=@EhliyetNumarasi, Resim=@Resim where TelefonNumarasi=@TelefonNumarasi", baglanti);
                                    guncelletc.Parameters.AddWithValue("@TC", txttcno.Text);
                                    guncelletc.Parameters.AddWithValue("@Adi", txtadi.Text);
                                    guncelletc.Parameters.AddWithValue("@Soyadi", txtsoyadi.Text);
                                    guncelletc.Parameters.AddWithValue("@TelefonNumarasi", txttelno.Text);
                                    guncelletc.Parameters.AddWithValue("@Email", txtmail.Text);
                                    guncelletc.Parameters.AddWithValue("@Adres", txtadres.Text);
                                    guncelletc.Parameters.AddWithValue("@EhliyetNumarasi", txtehlytnmr.Text);
                                        guncelletc.Parameters.AddWithValue("@Resim", dosyayeri);

                                        DialogResult guncellemek;
                                    guncellemek = MessageBox.Show("Müşteri Kaydını Güncellemek İstediğinize Emin Misiniz", "Güncelle!!", MessageBoxButtons.YesNo);
                                    if (guncellemek == DialogResult.Yes)
                                    {
                                        SqlDataAdapter musterguncelle = new SqlDataAdapter(guncelletc);
                                        DataTable tablola = new DataTable();
                                        musterguncelle.Fill(tablola);
                                        dataGridView1.DataSource = tablola;
                                        baglanti.Close();
                                        musterilistele();
                                        temizle();
                                        databoyut();
                                        sil();
                                        MessageBox.Show("Müşteri Kaydı Guncelleme Başarılı!");
                                    }
                                    else if (guncellemek == DialogResult.No)
                                    {
                                        baglanti.Close();
                                    }
                                }
                            else if(txttcno.Text != satir.Cells["TC"].Value.ToString() && txttelno.Text != satir.Cells["TelefonNumarasi"].Value.ToString())
                                {
                                        MessageBox.Show("hem tc yi hemde telen numarasını değiştiremezsiniz");
                                        temizle();
                                }

                        }
                        else
                            MessageBox.Show("Ehliyet Numarasi 6 Haneden Oluşmalıdır");
                    }
                    else
                    {
                        MessageBox.Show("TC No 11 Haneden Oluşmalıdır");
                    }
                
                }
                else
                { 
                    MessageBox.Show("Telefon Numarasi 10 Haneden Oluşmalıdır");
                }
                }
            }
            else
            { 
                MessageBox.Show("Müşteri Seçiniz!!");
            }
            }
        }
        string eskiresim;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnresimsec.Enabled = true;
            groupBox1.Enabled = true;
            txttcno.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            txtadi.Text = dataGridView1.CurrentRow.Cells["Adi"].Value.ToString();
            txtsoyadi.Text = dataGridView1.CurrentRow.Cells["Soyadi"].Value.ToString();
            txttelno.Text = dataGridView1.CurrentRow.Cells["TelefonNumarasi"].Value.ToString();
            txtmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtehlytnmr.Text = dataGridView1.CurrentRow.Cells["EhliyetNumarasi"].Value.ToString();
            
            baglanti.Open();
            SqlCommand resim = new SqlCommand("select resim from Musteriler where TC=@TC", baglanti);
            resim.Parameters.AddWithValue("@TC", dataGridView1.CurrentRow.Cells["TC"].Value.ToString());

            SqlDataReader resimoku = resim.ExecuteReader();

            if(resimoku.Read())
            {
                pictureBox1.ImageLocation = resimoku["Resim"].ToString();
                eskiresim = resimoku["Resim"].ToString();
                dosyayeri= resimoku["Resim"].ToString();
            }
            
            baglanti.Close();
        }


        void temizle()
        {
            txttcno.Text = "";
            txtadi.Text = "";
            txtsoyadi.Text = "";
            txttcno.Text = "";
            txtadres.Text = "";
            txtehlytnmr.Text = "";
            txtmail.Text = "";
            txttelno.Text = "";
            pictureBox1.ImageLocation = null;
            databoyut();
        }


        private void btntmz_Click(object sender, EventArgs e)
        {
            temizle();
            databoyut();
            sil();
        }

        private void txttcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
           && !char.IsSeparator(e.KeyChar);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            if (satir.Cells["TC"].Value.ToString() == txttcno.Text && txttcno.Text != "")
            {
                DialogResult mstrsil;
                mstrsil = MessageBox.Show("Müşteriyi Silmek İstediğinize Emin Misiniz", "Sil!!", MessageBoxButtons.YesNo);
                if (mstrsil == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand silindimi = new SqlCommand("Update Musteriler Set Silindimi=1 where TC=@TC", baglanti);
                    silindimi.Parameters.AddWithValue("@TC", satir.Cells["TC"].Value.ToString());
                    silindimi.ExecuteNonQuery();
                    baglanti.Close();
                    temizle();
                    musterilistele();
                    sil();
                    MessageBox.Show("Müşteri Silindi");
                }
                else if (mstrsil == DialogResult.No)
                {
                    baglanti.Close();
                }
            }
            else
            {
                if (txttcno.Text == "")
                {
                    MessageBox.Show("Müşteri Seçiniz  ");
                }
                else
                    MessageBox.Show("Seçilen TC ler Farklı ");
            }

        }

        private void txtadi_TextChanged(object sender, EventArgs e)
        {

        }

        string dosyayeri;
        private void btnresimsec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            dosyayeri = openFileDialog1.FileName;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand tcsorgu = new SqlCommand("select * from Musteriler where Adi like @Adi", baglanti);
            tcsorgu.Parameters.AddWithValue("@Adi", textBox1.Text + "%");
            SqlDataAdapter tcnosorgu = new SqlDataAdapter(tcsorgu);
            DataTable tablo = new DataTable();
            tcnosorgu.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
