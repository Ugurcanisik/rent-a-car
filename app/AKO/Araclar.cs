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
    public partial class Araclar : Form
    {
        List<char> txtMoneyValue;
        public Araclar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(18, 40);
            txtMoneyValue = new System.Collections.Generic.List<char>();
            //txtkm.RightToLeft = RightToLeft.Yes;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=AracKiralamaOtomasyonu;Integrated Security=True");

        void araclistele()
        {
            baglanti.Open();
            SqlCommand listele = new SqlCommand("select Plaka,Marka,Seri,Model,VitesTipi,YakitTipi,KM,Renk,SaseNumarasi,FiyatiSaat,FiyatiG,FiyatiH,FiyatiA,EklemeTarihi,Durumu from Araclar where Silindimi='False'", baglanti);
            SqlDataAdapter Araclistele = new SqlDataAdapter(listele);
            DataTable tablola = new DataTable();
            Araclistele.Fill(tablola);
            dataGridView1.DataSource = tablola;
            baglanti.Close();
        }


        private void txtplksrg_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand tcsorgu = new SqlCommand("select * from Araclar where Plaka like @Plaka", baglanti);
            tcsorgu.Parameters.AddWithValue("@Plaka", txtplksrg.Text + "%");
            SqlDataAdapter tcnosorgu = new SqlDataAdapter(tcsorgu);
            DataTable tablo = new DataTable();
            tcnosorgu.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btnlstl_Click(object sender, EventArgs e)
        {
            araclistele();
            databoyut();
            sil();
        }

        void databoyut()
        {
            //this.dataGridView1.Columns["Plaka"].Width = 117;
            //this.dataGridView1.Columns["Marka"].Width = 117;
            //this.dataGridView1.Columns["Seri"].Width = 117;
            //this.dataGridView1.Columns["Model"].Width = 117;
            //this.dataGridView1.Columns["VitesTipi"].Width = 117;
            //this.dataGridView1.Columns["YakitTipi"].Width = 117;
            //this.dataGridView1.Columns["Renk"].Width = 117;
            //this.dataGridView1.Columns["KM"].Width = 117;
            //this.dataGridView1.Columns["FiyatiG"].Width = 117;
            //this.dataGridView1.Columns["FiyatiH"].Width = 117;
            //this.dataGridView1.Columns["FiyatiA"].Width = 117;
            //this.dataGridView1.Columns["Durumu"].Width = 118;

        }

        void sil()
        {
            if (dataGridView1.RowCount == 0)
                btnsil.Enabled = false;
            else
                btnsil.Enabled = true;
        }

        private void Araclar_Load(object sender, EventArgs e)
        {
            this.Width = 1564;
            this.Height = 810;
            araclistele();
            databoyut();
            sil();
            groupBox1.Enabled = false;
            btnresimekle.Enabled = false;

        }

        private void btngnclle_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            if(dataGridView1.RowCount==0)
            {
                MessageBox.Show("Araç Ekleyiniz");
            }
            else
            { 
            if (txtplaka.Text == satir.Cells["Plaka"].Value.ToString() && txtmarka.Text == satir.Cells["Marka"].Value.ToString() && txtseri.Text == satir.Cells["Seri"].Value.ToString() &&
                txtmodel.Text == satir.Cells["Model"].Value.ToString() && cmbxvt.SelectedItem.ToString() == satir.Cells["VitesTipi"].Value.ToString() && cmbxyt.SelectedItem.ToString() == satir.Cells["YakitTipi"].Value.ToString() &&
                txtrenk.Text == satir.Cells["Renk"].Value.ToString() && txtkm.Text == satir.Cells["KM"].Value.ToString() && txtgnlk.Text == satir.Cells["FiyatiG"].Value.ToString() &&
                txthftlk.Text == satir.Cells["FiyatiH"].Value.ToString() && txtaylk.Text == satir.Cells["FiyatiA"].Value.ToString() && txtsase.Text==satir.Cells["SaseNumarasi"].Value.ToString() && eskiresim == dosyayeri
                && txtfiyatsaat.Text==satir.Cells["FiyatiSaat"].Value.ToString())
            {
                MessageBox.Show("Seçilen Veriler Ayni Değişiklik için Veri Değiştiriniz!!");
            }
            else
            { 
            if (txtplaka.Text != "")
                {
                if (txtplaka.Text.Count() >6 && txtplaka.Text.Count() < 9)
                {
                    if (txtmodel.Text.Count() == 4)
                    {
                                if(txtsase.Text.Count()==17)
                                {
                                    if (txtplaka.Text == satir.Cells["Plaka"].Value.ToString())
                                    {
                                        MessageBox.Show("Plakalar Ayni");
                                        baglanti.Open();

                                        SqlCommand guncelle = new SqlCommand("AracGuncelle", baglanti);
                                        guncelle.CommandType = CommandType.StoredProcedure;
                                        guncelle.Parameters.AddWithValue("@Plaka", txtplaka.Text);
                                        guncelle.Parameters.AddWithValue("@Marka", txtmarka.Text);
                                        guncelle.Parameters.AddWithValue("@Seri", txtseri.Text);
                                        guncelle.Parameters.AddWithValue("@Model", txtmodel.Text);
                                        guncelle.Parameters.AddWithValue("@Yakittipi", cmbxyt.SelectedItem);
                                        guncelle.Parameters.AddWithValue("@Vitestipi", cmbxvt.SelectedItem);
                                        guncelle.Parameters.AddWithValue("@KM", txtkm.Text);
                                        guncelle.Parameters.AddWithValue("@Renk", txtrenk.Text);
                                        guncelle.Parameters.AddWithValue("@SaseNumarasi", txtsase.Text);
                                        guncelle.Parameters.AddWithValue("FiyatiSaat", txtfiyatsaat.Text);
                                        guncelle.Parameters.AddWithValue("@FiyatiG", txtgnlk.Text);
                                        guncelle.Parameters.AddWithValue("@FiyatiH", txthftlk.Text);
                                        guncelle.Parameters.AddWithValue("@FiyatiA", txtaylk.Text);
                                        guncelle.Parameters.AddWithValue("@Resim", dosyayeri);

                                        DialogResult arcguncelle;
                                        arcguncelle = MessageBox.Show("Aracı Guncellemek İstediğinize Emin Misiniz", "Guncelle!!", MessageBoxButtons.YesNo);
                                        if (arcguncelle == DialogResult.Yes)
                                        {
                                            SqlDataAdapter aracguncelle = new SqlDataAdapter(guncelle);
                                            DataTable tablola = new DataTable();
                                            aracguncelle.Fill(tablola);
                                            dataGridView1.DataSource = tablola;
                                            baglanti.Close();
                                            araclistele();
                                            databoyut();
                                            temizle();
                                            sil();
                                            groupBox1.Enabled = false;
                                            btnresimekle.Enabled = false;
                                            MessageBox.Show("Güncelleme Başarılı");
                                        }
                                        else if (arcguncelle == DialogResult.No)
                                        {
                                            baglanti.Close();
                                        }
                                    }
                                    else if (txtsase.Text == satir.Cells["SaseNumarasi"].Value.ToString())
                                    {
                                        MessageBox.Show("Sase Aynı");
                                        baglanti.Open();
                                        SqlCommand guncelle = new SqlCommand("AracPlakaGuncelle", baglanti);
                                        guncelle.CommandType = CommandType.StoredProcedure;
                                        guncelle.Parameters.AddWithValue("@Plaka", txtplaka.Text);
                                        guncelle.Parameters.AddWithValue("@Marka", txtmarka.Text);
                                        guncelle.Parameters.AddWithValue("@Seri", txtseri.Text);
                                        guncelle.Parameters.AddWithValue("@Model", txtmodel.Text);
                                        guncelle.Parameters.AddWithValue("@Yakittipi", cmbxyt.SelectedItem);
                                        guncelle.Parameters.AddWithValue("@Vitestipi", cmbxvt.SelectedItem);
                                        guncelle.Parameters.AddWithValue("@KM", txtkm.Text);
                                        guncelle.Parameters.AddWithValue("@Renk", txtrenk.Text);
                                        guncelle.Parameters.AddWithValue("@SaseNumarasi", txtsase.Text);
                                        guncelle.Parameters.AddWithValue("FiyatiSaat", txtfiyatsaat.Text);
                                        guncelle.Parameters.AddWithValue("@FiyatiG", txtgnlk.Text);
                                        guncelle.Parameters.AddWithValue("@FiyatiH", txthftlk.Text);
                                        guncelle.Parameters.AddWithValue("@FiyatiA", txtaylk.Text);
                                        guncelle.Parameters.AddWithValue("@Resim", dosyayeri);

                                        DialogResult arcguncelle;
                                        arcguncelle = MessageBox.Show("Aracı Guncellemek İstediğinize Emin Misiniz", "Guncelle!!", MessageBoxButtons.YesNo);
                                        if (arcguncelle == DialogResult.Yes)
                                        {
                                            SqlDataAdapter aracguncelle = new SqlDataAdapter(guncelle);
                                            DataTable tablola = new DataTable();
                                            aracguncelle.Fill(tablola);
                                            dataGridView1.DataSource = tablola;
                                            baglanti.Close();
                                            araclistele();
                                            databoyut();
                                            temizle();
                                            sil();
                                            groupBox1.Enabled = false;
                                            btnresimekle.Enabled = false;
                                            MessageBox.Show("Güncelleme Başarılı");

                                        }
                                        else if (arcguncelle == DialogResult.No)
                                        {
                                            baglanti.Close();
                                        }
                                    }
                                    else if(txtsase.Text != satir.Cells["SaseNumarasi"].Value.ToString() && txtplaka.Text != satir.Cells["Plaka"].Value.ToString())
                                    {
                                        MessageBox.Show("hem plakayı hemde sase Numarasınu Değiştiremezsiniz");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Sase Numarasi 17 haneden oluşmalıdır");
                                }







                    }
                    else
                    {
                        MessageBox.Show("Model " + txtmodel.Text.Count() + "Basamak Olamaz 4 Basamaktan oluşmalıdır(YIL)");
                    }
                }
                else
                {
                    MessageBox.Show("Plaka Karakter Aralığı 7 ila 8 arasında olması gerekiyor!!");
                }

            }
            else
                {
                    MessageBox.Show("Araç Seçimi Yapınız");
                }
            }
            }
        }

        string eskiresim;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Enabled = true;
            btnresimekle.Enabled = true;
            txtplaka.Text = dataGridView1.CurrentRow.Cells["Plaka"].Value.ToString();
            txtmarka.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            txtseri.Text = dataGridView1.CurrentRow.Cells["Seri"].Value.ToString();
            txtmodel.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
            cmbxvt.SelectedItem = dataGridView1.CurrentRow.Cells["VitesTipi"].Value.ToString();
            cmbxyt.SelectedItem = dataGridView1.CurrentRow.Cells["YakitTipi"].Value.ToString();
            txtsase.Text = dataGridView1.CurrentRow.Cells["SaseNumarasi"].Value.ToString();
            txtkm.Text = dataGridView1.CurrentRow.Cells["KM"].Value.ToString();
            txtrenk.Text = dataGridView1.CurrentRow.Cells["Renk"].Value.ToString();
            txtfiyatsaat.Text = dataGridView1.CurrentRow.Cells["FiyatiSaat"].Value.ToString();
            txtgnlk.Text = dataGridView1.CurrentRow.Cells["FiyatiG"].Value.ToString();
            txthftlk.Text = dataGridView1.CurrentRow.Cells["FiyatiH"].Value.ToString();
            txtaylk.Text = dataGridView1.CurrentRow.Cells["FiyatiA"].Value.ToString();

            baglanti.Open();
            SqlCommand resim = new SqlCommand("select Resim from Araclar where Plaka=@Plaka", baglanti);
            resim.Parameters.AddWithValue("@Plaka", dataGridView1.CurrentRow.Cells["Plaka"].Value.ToString());

            SqlDataReader resimoku = resim.ExecuteReader();

            if (resimoku.Read())
            {
                pictureBox1.ImageLocation = resimoku["Resim"].ToString();
                eskiresim = resimoku["Resim"].ToString();
                dosyayeri = resimoku["Resim"].ToString();
            }

            baglanti.Close();

        }

        private void txtmrksorgu_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand markasorgu = new SqlCommand("select * from Araclar where Marka like @Marka", baglanti);
            markasorgu.Parameters.AddWithValue("@Marka", txtmrksorgu.Text + "%");
            SqlDataAdapter mrksrg = new SqlDataAdapter(markasorgu);
            DataTable tablo = new DataTable();
            mrksrg.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void txtsrisorgu_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand serisorgu = new SqlCommand("select * from Araclar where seri like @Seri", baglanti);
            serisorgu.Parameters.AddWithValue("@Seri", txtsrisorgu.Text + "%");
            SqlDataAdapter srsrg = new SqlDataAdapter(serisorgu);
            DataTable tablo = new DataTable();
            srsrg.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        void temizle()
        {
            txtplaka.Text = "";
            txtmarka.Text = "";
            txtseri.Text = "";
            txtmodel.Text = "";
            cmbxvt.SelectedIndex = -1;
            cmbxyt.SelectedIndex = -1;
            txtkm.Text = "";
            txtrenk.Text = "";
            txtgnlk.Text = "";
            txthftlk.Text = "";
            txtaylk.Text = "";
            txtsase.Text = "";
            pictureBox1.ImageLocation = null;
            txtfiyatsaat.Text = "";
        }

       
        private void txtaylk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtrenk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }


        private void txtkm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                SetValue();
                SetTextbox();
            }
            else
            {
                e.Handled = true;
            }
        }
        public void SetValue()
        {
            txtMoneyValue.Clear();
            for (int i = 0; i < txtkm.Text.Length; i++)
            {
                txtMoneyValue.Add(txtkm.Text[i]);
            }
        }
        public void SetTextbox()
        {
            string s = string.Empty;
            if (txtMoneyValue.Count >= 3)
            {
                RemovePoints();
                int pointCount = 1 + (txtMoneyValue.Count - 3) / 3;
                for (int i = 1; i <= pointCount; i++)
                {
                    int pointposition = ((txtMoneyValue.Count - 1) - (i * 1)) - ((i - 1) * 3);
                    txtMoneyValue.Insert(pointposition, '.');
                }
            }
            for (int i = 0; i < txtMoneyValue.Count; i++)
            {
                s += txtMoneyValue[i];
            }
            txtkm.Text = s;
            txtkm.SelectionStart = txtkm.Text.Length;
        }
        private void RemovePoints()
        {
            for (int i = 0; i < txtMoneyValue.Count; i++)
            {
                if (txtMoneyValue[i] == '.')
                    txtMoneyValue.RemoveAt(i);
            }
        }

        private void txtkm_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtkm.Text != "")
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtMoneyValue.Clear();
                    txtkm.Text = txtkm.Text.Substring(0, txtkm.Text.Length - 1);
                }
            }
            else
            {
                txtkm.Text = "";
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
                        
            DataGridViewRow satir = dataGridView1.CurrentRow;
            if(satir.Cells["Plaka"].Value.ToString()==txtplaka.Text && txtplaka.Text!="")
            {
                DialogResult aracsil;
                aracsil = MessageBox.Show("Aracı Silmek İstediğinize Emin Misiniz", "Sil!!", MessageBoxButtons.YesNo);
                if(aracsil == DialogResult.Yes)
                { 
                baglanti.Open();
                SqlCommand silindimi = new SqlCommand("Update Araclar Set Silindimi=1 where Plaka=@Plaka", baglanti);
                silindimi.Parameters.AddWithValue("@Plaka", satir.Cells["Plaka"].Value.ToString());
                silindimi.ExecuteNonQuery();
                baglanti.Close();
                temizle();
                araclistele();
                    sil();
                    MessageBox.Show("Araç Silindi");
                }
                else if(aracsil == DialogResult.No)
                {
                    baglanti.Close();
                }
            }
            else
            {
                if(txtplaka.Text=="")
                {
                    MessageBox.Show("Araç Seçiniz  ");
                }
                else
                MessageBox.Show("Seçilen Plakalar Farklı ");
            }
            
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
            sil();
        }
        string dosyayeri;
        private void btnresimekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            dosyayeri = openFileDialog1.FileName;

        }
    }
}


                           