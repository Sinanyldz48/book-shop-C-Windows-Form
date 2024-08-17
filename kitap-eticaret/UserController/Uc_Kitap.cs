using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace kitap_eticaret.UserController
{
    public partial class Uc_Kitap : UserControl
    {
        SqlYonlendir veritabani = new SqlYonlendir();
        public Uc_Kitap()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }
        public void baglanti()
        {
            SqlCommand cmd = new SqlCommand("select * from Kitaplar");
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                KitapAd = rdr[1].ToString();
                Resim = rdr[4].ToString();
            }
        }
        string KitapAd;
        string Resim;
        int PanelAd = 2;
        public void PictureBoxAyarla()
        {
            var boyut = Convert.ToInt32(panel1.Size.Width);
            Panel panel2 = new Panel();
            panel2.Location = new Point(boyut + 50, 50);
            panel2.Size = new Size(150, 280);
            panel2.BackColor = Color.White;
            panel2.Visible = true;
            panel2.TabIndex = 0;
            panel2.SendToBack();
            this.Controls.Add(panel2);
            PictureBox pbx = new PictureBox();
            var panelBoyut = Convert.ToInt32(panel2.Location.Y);
            pbx.Location = new Point(panel2.Location.X+15, panel2.Location.Y);
            pbx.Size = new Size(115, 165);
            this.Controls.Add(pbx);
            pbx.SizeMode = PictureBoxSizeMode.StretchImage;
           
           
            pbx.BringToFront();
            Label lbl_KtpAdi = new Label();
            lbl_KtpAdi.Text = KitapAd;
            lbl_KtpAdi.Location = new Point(panel2.Location.X + 15, panel2.Location.Y+170 );
            lbl_KtpAdi.Size = new Size(139, 21);
            lbl_KtpAdi.ForeColor= Color.Black;
            lbl_KtpAdi.BackColor = Color.White;
            lbl_KtpAdi.Font = new Font("Segoe UI", 12,FontStyle.Bold);
            lbl_KtpAdi.TextAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(lbl_KtpAdi);
            lbl_KtpAdi.BringToFront();
            Label lbl_YazarAdi = new Label();
            lbl_YazarAdi.Text = "Yazıcı";
            lbl_YazarAdi.Location = new Point(panel2.Location.X + 15, panel2.Location.Y + 190);
            lbl_YazarAdi.Size = new Size(139, 21);
            lbl_YazarAdi.ForeColor = Color.Black;
            lbl_YazarAdi.BackColor = Color.White;
            lbl_YazarAdi.Font = new Font("Segoe UI", 10);
            lbl_YazarAdi.TextAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(lbl_YazarAdi);
            lbl_YazarAdi.BringToFront();
            Label lbl_Fiyat = new Label();
            lbl_Fiyat.Text = "20TL";
            lbl_Fiyat.Location = new Point(panel2.Location.X + 15, panel2.Location.Y + 215);
            lbl_Fiyat.Size = new Size(139, 21);
            lbl_Fiyat.ForeColor = Color.Black;
            lbl_Fiyat.BackColor = Color.White;
            lbl_Fiyat.Font = new Font("Segoe UI", 10,FontStyle.Bold);
            lbl_Fiyat.TextAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(lbl_Fiyat);
            lbl_Fiyat.BringToFront();
            Guna2GradientButton btn_satinAl =new Guna2GradientButton();
            btn_satinAl.Size = new Size(98, 28);
            btn_satinAl.Location = new Point(panel2.Location.X + 15, panel2.Location.Y + 245);
            btn_satinAl.Text = "Satın AL";
            btn_satinAl.FillColor = Color.Green;
            btn_satinAl.FillColor2 = Color.DarkBlue;
            this.Controls.Add(btn_satinAl);
            btn_satinAl.BringToFront();


        }
        private void Uc_Kitap_Load(object sender, EventArgs e)
        {
          PictureBoxAyarla();
        }
    }
}
