using kitap_eticaret.UserController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace kitap_eticaret
{
    public partial class Form3 : Form
    {
        public string isim;

        public Form3()
        {
            InitializeComponent();
           
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront(); 
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            label1.Text = isim;
            UC_Anasayfa uc = new UC_Anasayfa();
            addUserControl(uc);
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Anasayfa uc =  new UC_Anasayfa();
            addUserControl(uc);
        }

        private void btn_Kategori_Click(object sender, EventArgs e)
        {
            UC_Kategoriler uc = new UC_Kategoriler();
            addUserControl(uc);
        }

        private void btn_bizeulas_Click(object sender, EventArgs e)
        {
            UC_BizeUlas uc = new UC_BizeUlas();
            addUserControl(uc);

        }

        private void btn_Kitap_Click(object sender, EventArgs e)
        {
            Uc_Kitap uc = new Uc_Kitap();
            addUserControl((uc));
        }

        private void btn_dersKitap_Click(object sender, EventArgs e)
        {
            Uc_Yardım uc = new Uc_Yardım();
            addUserControl((uc));
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Uc_Yardım uc_Yardım = new Uc_Yardım();
            addUserControl(uc_Yardım);
        }
    }
}
