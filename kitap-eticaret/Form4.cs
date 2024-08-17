using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitap_eticaret
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            odemeKApi.Show();
            guna2Panel1.Hide();
            odemeKArt.Hide();
            odemeKArt.Text = "KAPIDA ÖDE";

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            odemeKApi.Hide();   
            odemeKArt.Show();
            guna2Panel1.Show();
            odemeKArt.Text = "ÖDEMEYİ ONAYLA";
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (txtAdres.Text == "" || txtIL.Text == "" || txtILCE.Text == "" || txtPosta.Text == "" || txtMahalle.Text == ""||guna2TextBox6.Text==""|| guna2TextBox7.Text == ""|| guna2TextBox8.Text == ""|| guna2TextBox9.Text == ""|| guna2TextBox10.Text == ""|| guna2TextBox11.Text == ""|| guna2TextBox12.Text == "")
            {
                MessageBox.Show("Boş Alanları Doldurunuz");
            }
            else
                MessageBox.Show("Ödeme Başarılı Teşekkür Ederiz");
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            if (txtAdres.Text == "" || txtIL.Text == "" || txtILCE.Text == "" || txtPosta.Text == "" || txtMahalle.Text == "" )
            {
                MessageBox.Show("Boş Alanları Doldurunuz");
            }
            else
                MessageBox.Show("Ödeme Başarılı Teşekkür Ederiz");
        }
    }
}
