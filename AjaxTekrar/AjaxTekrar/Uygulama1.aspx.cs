using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AjaxTekrar
{
    public partial class Uygulama1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static int faktHesapla(int sayi)
        {
            int sonuc = 1;
            for (int i = sayi; i > 0; i--)
            {
                sonuc *= i;
            }

            return sonuc;
        }

        //protected void btn_Click(object sender, EventArgs e)
        //{
        //    int sayi =Convert.ToInt32(txtSayi.Text);
        //    int sonuc = 1;
        //    for (int i = sayi; i >0; i--)
        //    {
        //        sonuc *= i;
        //    }

        //    lblSonuc.Text = sonuc.ToString();
        //}
    }
}