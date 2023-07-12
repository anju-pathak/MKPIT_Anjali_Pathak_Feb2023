using insertajax.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace insertajax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        private SqlConnection con;
        //To Handle connection related activities
        private void connection()
        {
            // string constr = ConfigurationManager.ConnectionStrings["SqlConn"].ToString();
            string constr = "server=.\\sqlexpress;integrated security=true;database=mvc";
            con = new SqlConnection(constr);

        }

        // GET: AddEmployee
        public ActionResult AddEmployee()
        {

            return View();
        }
        //Post method to add details
        [HttpPost]
        public ActionResult AddEmployee(EmpModel obj)
        {
            AddDetails(obj);

            return View();

        }

        //To add Records into database
        private void AddDetails(EmpModel obj)
        {
            connection();
            SqlCommand com = new SqlCommand("AddEmp", con);
            //addemp is the name of stored procedure
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Address", obj.Address);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
    }
}
