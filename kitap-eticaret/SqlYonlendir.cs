using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitap_eticaret
{
    internal class SqlYonlendir
    {
        public SqlConnection Bagla()
        {
            SqlConnection amd = new SqlConnection(@"Data Source=SINAN; Initial Catalog=Kitapal; Integrated Security=True");
            amd.Open();
            return amd;
        }
    }
}
