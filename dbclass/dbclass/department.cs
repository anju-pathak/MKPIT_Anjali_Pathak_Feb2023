using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbclass
{
    public static class department1
    {

        static SqlConnection con = Class1.getConnection();
        static string query = null;
        static SqlCommand cmd = null;
        public static string insertdepartment(string department_Name)
        {
            string res = null;
            query = "insert into department_mast values(@department_Name)";
            cmd = new SqlCommand(query,con);
    
            cmd.Parameters.AddWithValue("@department_Name",department_Name);
            con.Open();
            cmd.ExecuteNonQuery();
            res = "record inserted";
            con.Close();
            return res;
        }
      
        public static string updatedepartment(string department_Name,int department_id)
        {
            string res = null;
        
            query = "update department_mast set department_Name=@department_Name where department_id=@department_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@department_Name", department_Name);
            cmd.Parameters.AddWithValue("@department_id", department_id);
            con.Open();
            cmd.ExecuteNonQuery();
            res = "record updated";
            con.Close();
            return res;
        }
        public static string deletedepartment(int department_id)
        {
            string res = null;

            query = "delete from  department_mast where department_id=@department_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@department_id", department_id);
            con.Open();
            cmd.ExecuteNonQuery();
            res = "record delete";
            con.Close();
            return res;
        }
        public static DataSet searchdepartment(int department_id)
        {
            query = "select * from department_mast where department_id=@department_id";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@department_id", department_id);
            da.Fill(ds, "department_mast");
            return ds;

        }
    }
}
