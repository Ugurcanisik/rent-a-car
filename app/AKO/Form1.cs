using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngrs_Click(object sender, EventArgs e)
        {


            Anasayfa ansyf = new Anasayfa();
            ansyf.ShowDialog();
            this.Close();


            //if(txtklnad.Text!="" && txtsfre.Text!="")
            //{
            //    if(txtklnad.Text=="Admin" || txtklnad.Text=="ADMİN" || txtklnad.Text=="admin" && txtsfre.Text=="123")
            //    {

            //    }
            //    else
            //    {
            //        MessageBox.Show("Kullanıcı Adi veya Şifre Hatalı");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Boş Alanlanları Doldurunuz");
            //    txtsfre.Text = "";
            //    txtklnad.Text = "";
            //}
        }
    }
}
