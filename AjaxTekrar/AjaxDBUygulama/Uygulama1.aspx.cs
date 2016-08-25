using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxDBUygulama
{
    public partial class Uygulama1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        [WebMethod]
        public static string employeesList()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString);

            SqlDataAdapter da = new SqlDataAdapter("select LastName,FirstName from Employees ", con);

            DataTable dt = new DataTable("Calisanlar");
            da.Fill(dt);

            string data = JsonConvert.SerializeObject(dt, Formatting.Indented);

            return data;
        }
    }
}