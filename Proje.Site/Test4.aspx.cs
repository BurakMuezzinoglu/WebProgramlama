using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.Site
{
    public partial class Test4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var liste = new Proje.Business.Tbl_Gorsel().ServisGetir();


        }

        protected void btn_ekle_Click(object sender, EventArgs e)
        {
            //Response.Redirect("/Test3.aspx?gorsel="+TextBox1.Text+"&KullaniciId="+TextBox2.Text+"");
            Response.Redirect("/Gorsel/" + TextBox1.Text + "&KullaniciId=" + TextBox2.Text + "");
        }
    }
}