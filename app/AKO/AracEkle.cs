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
    public partial class AracEkle : Form
    {
        List<char> txtMoneyValue;
        public AracEkle()
        {
            InitializeComponent();
            txtMoneyValue = new System.Collections.Generic.List<char>();
            //txtkm.RightToLeft = RightToLeft.Yes;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=AracKiralamaOtomasyonu;Integrated Security=True");
        private void btnekle_Click(object sender, EventArgs e)
        {
           
            string eklemetarihi = dtpeklmtrh.Value.ToString("g"); 
            baglanti.Open();

            SqlCommand aracekle = new SqlCommand("AracEkle", baglanti);
            aracekle.CommandType = CommandType.StoredProcedure;

            aracekle.Parameters.AddWithValue("@Plaka", txtplaka.Text);
            aracekle.Parameters.AddWithValue("@Marka", txtmarka.Text);
            aracekle.Parameters.AddWithValue("@Seri", txtseri.Text);
            aracekle.Parameters.AddWithValue("@Model", txtmodel.Text);
            aracekle.Parameters.AddWithValue("@VitesTipi", cmbxvt.SelectedItem);
            aracekle.Parameters.AddWithValue("@YakitTipi", cmbxyt.SelectedItem);
            aracekle.Parameters.AddWithValue("@KM", txtkm.Text);
            aracekle.Parameters.AddWithValue("@Renk", txtrenk.Text);
            aracekle.Parameters.AddWithValue("@SaseNumarasi", txtsase.Text);
            aracekle.Parameters.AddWithValue("FiyatiSaat", txtfiyatsaat.Text);
            aracekle.Parameters.AddWithValue("@FiyatiG", txtgnlk.Text);
            aracekle.Parameters.AddWithValue("@FiyatiH", txthftlk.Text);
            aracekle.Parameters.AddWithValue("@FiyatiA", txtaylk.Text);
            aracekle.Parameters.AddWithValue("@EklemeTarihi", eklemetarihi);
            aracekle.Parameters.AddWithValue("@Durumu", "Musait");
            aracekle.Parameters.AddWithValue("@Resim", dosyayeri);
            aracekle.Parameters.AddWithValue("@Silindimi", "False");

            SqlCommand karsilastir = new SqlCommand("select Plaka From Araclar Where Plaka=@plaka", baglanti);

            karsilastir.Parameters.AddWithValue("@Plaka", txtplaka.Text);

            SqlDataReader karsilastiroku = karsilastir.ExecuteReader();

            if(txtmarka.Text!=""  && txtseri.Text != "" && cmbxvt.SelectedIndex>-1 
                && cmbxyt.SelectedIndex>-1 && txtkm.Text!="" && txtrenk.Text != "" && txtgnlk.Text!="" && txthftlk.Text != "" && txtaylk.Text != "" && txtsase.Text!=""  && txtfiyatsaat.Text!="")
            {
                if (txtplaka.Text.Count() == 7 || txtplaka.Text.Count() == 8 && txtplaka.Text != "")
                {
                    if (txtmodel.Text!="" && txtmodel.Text.Count() == 4)
                    {

                        if(txtsase.Text.Count()==17 && txtsase.Text!="")
                        {
                            if(dosyayeri==null)
                            {
                                MessageBox.Show("Resim Ekleyiniz");
                            }
                            else
                            { 
                            if (karsilastiroku.Read())
                            {
                                MessageBox.Show("Bu Araç Kaydı Sistemde Var!!");
                            }
                            else
                            {
                                DialogResult kaydet;
                                kaydet = MessageBox.Show("Aracı Kaydetmek İstediğinize Emin Misiniz", "Kaydet!!", MessageBoxButtons.YesNo);
                                if (kaydet == DialogResult.Yes)
                                {
                                    karsilastiroku.Close();
                                    aracekle.ExecuteNonQuery();
                                    MessageBox.Show("Araç Kaydi Başarılı!");
                                    baglanti.Close();

                                }
                                else if (kaydet == DialogResult.No)
                                {
                                    baglanti.Close();
                                }
                            }  
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("Şase Numarası 17 haneden oluşmalıdır");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Model " + txtmodel.Text.Count() + "Basamak Olamaz 4 Basamaktan oluşmalıdır(YIL)");
                    }
                }
                else
                    MessageBox.Show("Araç Plakası 7 veya 8 Haneden Oluşabilir");

            }
            else
            {
                MessageBox.Show("Araç Kaydi İçin Alanların Hepsini Doldurunuz!!");
            }
            baglanti.Close();
            temizle();
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
            txtfiyatsaat.Text = "";
            pictureBox1.ImageLocation = null;
        }

        private void btntmlz_Click(object sender, EventArgs e)
        {
            temizle();
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
        string dosyayeri;
        private void btnresimekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            dosyayeri = openFileDialog1.FileName;
        }
    }
}
