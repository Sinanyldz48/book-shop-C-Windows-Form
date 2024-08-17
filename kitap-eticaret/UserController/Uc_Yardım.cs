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

namespace kitap_eticaret.UserController
{
    public partial class Uc_Yardım : UserControl
    {
        public Uc_Yardım()
        {
            InitializeComponent();
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void Uc_Yardım_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\xsina\OneDrive\Masaüstü\KitaplarFoto.\a.pdf");
        }
    }
}
