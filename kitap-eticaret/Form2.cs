using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitap_eticaret
{
    public partial class Form2 : Form
    {
        SqlYonlendir bag = new SqlYonlendir();

        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        Form3 form3 = new Form3();

        private void button1_Click(object sender, EventArgs e)
        {
            if (label5.Visible==false&&textBox1.Text!=""&&textBox2.Text!=""&&textBox3.Text!=""&&textBox4.Text!=""&&textBox5.Text!="")
            {
                SqlCommand hata = new SqlCommand("select kullanici_adi,sifre from Uyeler where kullanici_adi=@kullanici and sifre=@sifre", bag.Bagla());
                hata.Parameters.AddWithValue("@kullanici", textBox1.Text);
                hata.Parameters.AddWithValue("@sifre", textBox2.Text);
                SqlDataReader dr = hata.ExecuteReader();
                if (dr.Read())
                {
                 MessageBox.Show("Kayıt başarısız");
                }
                else
                {
                    SqlCommand grskmt = new SqlCommand("insert into Uyeler(kullanici_adi,sifre,eposta,telefon) values(@kullanici,@sifre,@eposta,@telefon)", bag.Bagla());
                    grskmt.Parameters.AddWithValue("@kullanici", textBox1.Text);
                    grskmt.Parameters.AddWithValue("@sifre", textBox2.Text);
                    grskmt.Parameters.AddWithValue("@eposta", textBox4.Text);
                    grskmt.Parameters.AddWithValue("@telefon", textBox5.Text);
                    grskmt.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı Yönlendiriliyorsunuz...");
                    form3.Show();
                    this.Close();  
                }
            
                bag.Bagla().Close();
                }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Parolalar Uyuşmuyor\nLütfen Tekrar Deneyiniz!", "Kullanıcı Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Boş Alanları Doldurun", "Kullanıcı Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text!=textBox3.Text)
            {
                label5.Visible = true;
            }
            else
            { label5.Visible = false; }
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string sozlesme = "Gizlilik Sözleşmesi\r\n\r\nBu Gizlilik Sözleşmesi (\"Sözleşme\"), KitapAl, müşterilerinin ve ziyaretçilerinin kişisel bilgilerini nasıl topladığını, kullandığını, paylaştığını ve koruduğunu açıklar. Bu Sözleşme, KitapAl'ın web sitesi, mobil uygulamalar ve diğer dijital platformlarını ziyaret eden tüm kişileri kapsar.\r\n\r\nBilgi Toplama ve Kullanma\r\nKitapAl, kullanıcıların kişisel bilgilerini yasal amaçlarla toplar ve kullanır. Bu bilgiler arasında ad, soyad, iletişim bilgileri, demografik bilgiler, kullanıcı hesap bilgileri ve benzeri veriler yer alabilir. Bu bilgiler, hizmetlerimizi sağlamak, müşteri desteği sunmak, güvenlik sağlamak, içerik özelleştirmek ve pazarlama amaçlarıyla kullanılabilir.\r\n\r\nBilgi Paylaşımı\r\nKitapAl, kullanıcı bilgilerini yasal gerekliliklere uygun olarak paylaşabilir. Ayrıca, hizmet sağlayıcılar, iş ortakları veya diğer üçüncü taraflarla bilgi paylaşımı yapabiliriz, ancak bu durumda gizlilik düzenlemelerini sürdürmek için gerekli adımları atarız.\r\n\r\nÇerezler ve Benzeri Teknolojiler\r\nWeb sitemiz ve uygulamalarımız, çerezler ve benzeri teknolojileri kullanabilir. Bu teknolojiler, kullanıcı deneyimini iyileştirmek, site trafiğini analiz etmek ve reklam hizmetlerini sağlamak için kullanılabilir. Kullanıcılar, tarayıcı ayarları üzerinden çerez kullanımını yönetebilirler.\r\n\r\nGüvenlik\r\nKitapAl, kullanıcı bilgilerini korumak için endüstri standardı güvenlik önlemlerini alır. Ancak, internet üzerinden iletişimde hiçbir güvenlik önlemi tamamen güvenli değildir.\r\n\r\nDeğişiklikler\r\nBu Gizlilik Sözleşmesi, zaman içinde değişebilir. Değişiklikler web sitemizde yayınlandıktan sonra geçerli olacaktır. Kullanıcılar, değişiklikleri takip etmekten sorumludur.\r\n\r\nBu Sözleşme hakkında sorularınız veya endişeleriniz varsa, lütfen [İletişim Bilgileri] üzerinden bizimle iletişime geçin.";
            if (checkBox1.Checked ==true)
            {
                MessageBox.Show(sozlesme, "KVKK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
            {
                label5.Visible = true;
            }
            else
            { label5.Visible = false; }
        }
    }
}
