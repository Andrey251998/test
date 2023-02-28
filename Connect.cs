using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace card_app
{
    internal class Connect
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R39TAAR;Initial Catalog=Tour_Base;Integrated Security=True");

        internal void OpenCon()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        internal void CloseCon()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        internal SqlConnection getConnect()
        {
            return conn;
        }
    }
}
