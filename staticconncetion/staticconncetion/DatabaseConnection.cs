using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace staticconncetion
{ 
 static class DatabaseConnection
{
    private static string dataconnection = "server=MANISH\\SQLEXPRESS;integrated security = true;database= school;";

            public static SqlConnection GetConnection()
        {
        SqlConnection con = new SqlConnection(dataconnection);

        try
        {
            con.Open();
            return con;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
}