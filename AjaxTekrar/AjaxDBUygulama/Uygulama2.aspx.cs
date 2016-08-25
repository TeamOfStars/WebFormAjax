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
    public partial class Uygulama2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string SiparisDetayList(string customerID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("sp_FiyatTutar",con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("id",customerID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string data = JsonConvert.SerializeObject(dt, Formatting.Indented);
            return data;
        }
        [WebMethod]
        public static string[] Musteriler()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select CustomerID from Customers", ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            string[] listem = new string[dt.Rows.Count] ;
            int sayac = 0;
            foreach (DataRow item in dt.Rows)
	        {
                listem[sayac]=item[0].ToString();
                sayac++;
	        }
            return listem;
        }
    }
}