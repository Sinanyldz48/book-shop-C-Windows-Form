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
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace kitap_eticaret.UserController
{
    public partial class UC_Anasayfa : UserControl
    {   
        SqlYonlendir baglanti = new SqlYonlendir();
        public UC_Anasayfa()
        {
            InitializeComponent();
        }
        public void Liste()
           
        {
            SqlCommand cmd = new SqlCommand("select * from Kitaplar",baglanti.Bagla());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            guna2DataGridView1.DataSource= dataTable;
        }
        private void Gizle()
        {
            pictureBox1.Hide();
            btnSat.Hide();
            lblAd.Hide();
            lblFiyat.Hide();
            lblYazar.Hide();
        }
        private void Goster()
        {
            pictureBox1.Show();
            btnSat.Show();
            lblAd.Show();
            lblFiyat.Show();
            lblSec.Show();
            lblYazar.Show();
        }

        private void UC_Anasayfa_Load(object sender, EventArgs e)
        {
            Gizle();
            Liste();
            

            
        }
        int secilen;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Goster();
            secilen = guna2DataGridView1.SelectedCells[0].RowIndex;
            pictureBox1.Load(guna2DataGridView1.Rows[secilen].Cells[6].Value.ToString()+".jpg");
            lblAd.Text = guna2DataGridView1.Rows[secilen].Cells[1].Value.ToString();
            lblYazar.Text = guna2DataGridView1.Rows[secilen].Cells[5].Value.ToString();
            lblFiyat.Text = guna2DataGridView1.Rows[secilen].Cells[3].Value.ToString()+" TL";
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
