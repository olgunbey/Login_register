using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    class Class1
    {
       public static SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QO41TLT\\SQLEXPRESS;Initial Catalog=PersonelBilgi;Integrated Security=True");
        public static void baglantikontrol(SqlConnection sqlConnection)
        {
            if(sqlConnection.State==ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        
    }
}
