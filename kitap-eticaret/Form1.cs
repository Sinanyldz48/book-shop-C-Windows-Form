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

namespace kitap_eticaret
{
    public partial class Form1 : Form
    {   
        SqlYonlendir bag = new SqlYonlendir();
        public Form1()
        {
            InitializeComponent();
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
            SqlCommand grskmt = new SqlCommand("select kullanici_adi,sifre from Uyeler where kullanici_adi = @kullanici and sifre = @sifre", bag.Bagla());
                grskmt.Parameters.AddWithValue("@kullanici", textBox1.Text);
                grskmt.Parameters.AddWithValue("@sifre", textBox2.Text);
                SqlDataReader reader = grskmt.ExecuteReader();
                Form3 form3 = new Form3();
                Form5 form5 = new Form5();
            
                if (reader.Read())
                {
                    if(textBox1.Text == "root" && textBox2.Text == "toor")
                    { 
                        form5.Show();
                    }
                else 
                {
                    form3.isim = textBox1.Text;
                    form3.Show();
                }
                
                }
                else
                { MessageBox.Show("Hatalı Giriş Yaptınız!\nLütfen Tekrar Deneyiniz", "Kullanıcı Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                bag.Bagla().Close();


            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Gizle";
            if (checkBox1.Checked ) { textBox2.PasswordChar = '\0'; }
            else
            { textBox2.PasswordChar = '*';
                checkBox1.Text = "Göster";
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 from2 = new Form2();
            from2.Show();
            
            
        }

        private void kapat_Click(object sender, EventArgs e)
        {
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
    }
}
