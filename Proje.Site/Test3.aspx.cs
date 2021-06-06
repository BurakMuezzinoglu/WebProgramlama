using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.Site
{
    public partial class Test3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var gorsel = Request.QueryString["gorsel"].ToString();
            //var kullaniciid = Request.QueryString["KullaniciId"].ToString();
            if (RouteData.Values["GorselId"]!=null && RouteData.Values["KullaniciId"] != null)
            {
                var gorselid = RouteData.Values["GorselId"];
                var kullaniciid = RouteData.Values["KullaniciId"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = DateTime.Now.ToString();
            DropDownList1.Items.Add(TextBox1.Text);

        }
    }
}