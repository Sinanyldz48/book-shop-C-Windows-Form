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
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;


namespace kitap_eticaret
{
    public partial class Form5 : Form
    {
        SqlYonlendir baglanti = new SqlYonlendir();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Liste();
            SqlCommand cmd = new SqlCommand("select kitap_adi,fiyat from Kitaplar",baglanti.Bagla());
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                chart1.Series["Kitap-Fiyat"].Points.AddXY(rdr[0].ToString(), rdr[1].ToString());
            }

        }
        public void Liste()

        {
            SqlCommand cmd = new SqlCommand("select * from Kitaplar", baglanti.Bagla());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtKitapId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSayfa.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtFoto.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtTur.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtYazar.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        private void txtTemizleyici()
        {
            txtKitapId.Clear();
            txtAd.Clear();
            txtSayfa.Clear();
            txtFiyat.Clear();
            txtFoto.Clear();
            txtTur.Clear();
            txtYazar.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTemizleyici();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand silKomut = new SqlCommand("delete from Kitaplar where kitap_id = @KitapId",baglanti.Bagla());
            silKomut.Parameters.AddWithValue("@KitapId", dataGridView1.CurrentRow.Cells[0].Value);
            silKomut.ExecuteNonQuery();
            Liste();
            txtTemizleyici();

        }


        private void Ekle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtFiyat.Text == "" || txtFoto.Text == "" || txtSayfa.Text == "" || txtTur.Text == "" || txtYazar.Text == "")
            {
                MessageBox.Show("Boş Alanları Doldurunuz");
            }
            else
            {
                SqlCommand ekleKomut = new SqlCommand("insert into Kitaplar(kitap_adi,sayfa_sayisi,fiyat,foto,kategori_ad,yazarAdi) values(@kitapAdi,@sayfa,@fiyat,@foto,@kategori,@yazar)", baglanti.Bagla());
                ekleKomut.Parameters.AddWithValue("@kitapAdi", txtAd.Text);
                ekleKomut.Parameters.AddWithValue("@sayfa", txtSayfa.Text);
                ekleKomut.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                ekleKomut.Parameters.AddWithValue("@foto", txtFoto.Text);
                ekleKomut.Parameters.AddWithValue("@kategori", txtTur.Text);
                ekleKomut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                ekleKomut.ExecuteNonQuery();
                Liste();
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelleKomut = new SqlCommand("update Kitaplar set kitap_adi=@kitapAdi,sayfa_sayisi=@sayfa,fiyat=@fiyat,foto=@foto,kategori_ad=@kategori,yazarAdi=@yazar where kitap_id = @KitapId",baglanti.Bagla());
            guncelleKomut.Parameters.AddWithValue("KitapId",txtKitapId.Text);
            guncelleKomut.Parameters.AddWithValue("@kitapAdi", txtAd.Text);
            guncelleKomut.Parameters.AddWithValue("@sayfa", txtSayfa.Text);
            guncelleKomut.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
            guncelleKomut.Parameters.AddWithValue("@foto", txtFoto.Text);
            guncelleKomut.Parameters.AddWithValue("@kategori", txtTur.Text);
            guncelleKomut.Parameters.AddWithValue("@yazar", txtYazar.Text);
            guncelleKomut.ExecuteNonQuery();
            Liste();
        }

       

        private void k(object sender, EventArgs e)
        {

        }

        private void txtSayfa_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSayfa.Text, out _))
            {
                txtSayfa.Clear();
            }
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFiyat.Text,out _))
            {
                txtFiyat.Text = "";
            }
        }
    }
}
