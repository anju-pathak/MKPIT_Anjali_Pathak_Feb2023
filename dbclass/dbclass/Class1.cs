using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbclass
{
    public class Class1
    {
        public static SqlConnection con;
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=Trust1");

            return con;
        }
    }
}
