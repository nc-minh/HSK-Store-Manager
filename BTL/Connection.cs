using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BTL
{
    class Connection
    {
        private static string stringConnection
            = @"Data Source=MING\SQLEXPRESS;Initial Catalog=BTL_HuongSukien;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
