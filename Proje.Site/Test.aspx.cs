using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.Site
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListItem deger = new ListItem();
            deger.Text = TextBox1.Text;
            deger.Value = new Random().Next(0,50).ToString();
            drp_liste.Items.Add(deger);
        }

        protected void drp_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "Seçilen Value Değeri:" + drp_liste.SelectedValue + " -Seçilen Text Değeri:" + drp_liste.SelectedItem.Text;
        }

        protected void img_button_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}