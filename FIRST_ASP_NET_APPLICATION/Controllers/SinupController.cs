using FIRST_ASP_NET_APPLICATION.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIRST_ASP_NET_APPLICATION.Controllers
{
    public class SinupController : Controller
    {
        // GET: Sinup
        public ActionResult Register()
        {

            return View();
        }


        public ActionResult Submit()
        {


            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                SqlDataAdapter da = new SqlDataAdapter("insert into register(Name,Email) values('s','d'); ", con);

                DataSet ds = new DataSet();
                da.Fill(ds);

                return View();
            }
        }
        [HttpPost]
        public ActionResult Index()
        {
            string constr = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "INSERT INTO Register(Name, Email) VALUES(@Name, @Email)";
                query += " SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@Name", "ss");
                    cmd.Parameters.AddWithValue("@Country", "SS");
                    cmd.ExecuteScalar();
                    con.Close();
                }
            }

            return View();
        }
    }
}