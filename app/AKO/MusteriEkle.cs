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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        public int a;

        private void btniptal_Click(object sender, EventArgs e)
        {
            a = 5;
            this.Close();
        }
        string dosyayeri;
        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=AracKiralamaOtomasyonu;Integrated Security=True");
            baglanti.Open();

            SqlCommand musteriekle = new SqlCommand("MusteriEkle",baglanti);
            musteriekle.CommandType = CommandType.StoredProcedure;

            musteriekle.Parameters.AddWithValue("@TC", txttcno.Text);
            musteriekle.Parameters.AddWithValue("@Adi", txtadi.Text);
            musteriekle.Parameters.AddWithValue("@Soyadi", txtsoyadi.Text);
            musteriekle.Parameters.AddWithValue("@TelefonNumarasi", txttelno.Text);
            musteriekle.Parameters.AddWithValue("@Email", txtmail.Text);
            musteriekle.Parameters.AddWithValue("@Adres", txtadres.Text);
            musteriekle.Parameters.AddWithValue("@EhliyetNumarasi", txtehlytnmr.Text);
            musteriekle.Parameters.AddWithValue("@Resim", dosyayeri);
            musteriekle.Parameters.AddWithValue("@Silindimi", "False");

            SqlCommand karsilastir = new SqlCommand("select TC from Musteriler where TC=@TC", baglanti);

            karsilastir.Parameters.AddWithValue("@TC", txttcno.Text);

            SqlDataReader karsilastiroku = karsilastir.ExecuteReader();

            if(txtadi.Text != "" && txtsoyadi.Text != "" && txttelno.Text != "" && txtmail.Text != "" && txtadres.Text != "" && dosyayeri!=null)
            {
                if(txttelno.Text!="" && txttelno.Text.Count()==14)
                { 
                if(txttcno.Text != "" && txttcno.Text.Count()==11)
                { 
                    if(txtehlytnmr.Text != "" && txtehlytnmr.Text.Count()==6)
                    { 
                if(karsilastiroku.Read())
                {
                    MessageBox.Show("Bu Müşteri Kaydı Sistemde Var!!");
                }
                else
                {
                    DialogResult kaydet;
                    kaydet = MessageBox.Show("Müşteri Kaydetmek İstediğinize Emin Misiniz", "Kaydet!!", MessageBoxButtons.YesNo);
                    if (kaydet == DialogResult.Yes)
                    {
                        karsilastiroku.Close();
                        musteriekle.ExecuteNonQuery();
                        MessageBox.Show("Müşteri Kaydı Başarılı!");
                                
                        baglanti.Close();
                                    temizle();
                        
                    }
                    else if(kaydet == DialogResult.No)
                    {
                        baglanti.Close();
                    }

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
            else
            {
               
                MessageBox.Show("Müşteri Kaydi İçin Alanların Hepsini Doldurunuz!!");
            }

            
            

        }


        void temizle()
        {
            txttelno.Text = "";
            txttcno.Text = "";
            txtadi.Text = "";
            txtsoyadi.Text = "";
            txttcno.Text = "";
            txtadres.Text = "";
            txtehlytnmr.Text = "";
            txtmail.Text = "";
            pictureBox1.ImageLocation = null;
        }

        private void btntmzl_Click(object sender, EventArgs e)
        {
            temizle();
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

        private void txttcno_TextChanged(object sender, EventArgs e)
        {

        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
        
        }

        private void btnresimekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            dosyayeri = openFileDialog1.FileName;
            
        }

  
    }
}
