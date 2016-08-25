using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace AjaxTekrar
{
    public partial class EditorUygulama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString);

            SqlCommand com = new SqlCommand("insert into Makale (baslik,icerik)values(@baslik,@icerik)",con);

            com.Parameters.AddWithValue("baslik",txtBaslik.Text);
            com.Parameters.AddWithValue("icerik",Editor1.Content);

            if(con.State== ConnectionState.Closed){
                con.Open();
                com.ExecuteNonQuery();
                
                con.Close();
                con.Dispose();
            }

            Editor1.Content = "";
            txtBaslik.Text = "";
        }
    }
}