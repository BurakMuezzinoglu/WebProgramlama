using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Proje.Site
{
    public partial class Test2 : System.Web.UI.Page
    {
        static public List<Proje.Business.Tbl_Gorsel> GorselListesi = new List<Business.Tbl_Gorsel>();
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //query sözdizimi
            var sonuc = from sayi in sayilar where sayi>5 select sayi;
            //foreach (var item in sonuc)
            //{
            //    list.Items.Add(item.ToString());
            //}
            //method yöntemi
            List<int> sonuc1 = sayilar.Where(p => p > 5).ToList();
            foreach (var item in sonuc1)
            {
                list.Items.Add(item.ToString());

            }

           

            for (int i = 0; i < 3; i++)
            {
                Proje.Business.Tbl_Gorsel gorsel = new Business.Tbl_Gorsel();
                gorsel.GorselAd = (i + 1).ToString() + "Görsel";
                gorsel.Gorselid = new Random().Next().ToString();
                GorselListesi.Add(gorsel);
            }

            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //List<Proje.Business.Tbl_Gorsel> sonuc = GorselListesi.Where(y => y.GorselAd == "2. Görsel").ToList();



            SqlConnection baglan = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=PortfolyoSiteDB;Integrated Security=True");
            string isim =System.Web.Configuration.WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
            SqlConnection baglan = new SqlConnection(isim);
            baglan.Open();

            string sorgu = "select * from Tbl_Gorsel";
            SqlCommand com = new SqlCommand(sorgu, baglan);

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                var ad = dr.GetValue(1).ToString();
                var no = dr.GetValue(0).ToString();
            }
            baglan.Close();


            string sorgu1 = "insert into Tbl_Gorsel values('123','test','854564')";
            string sorgu2 = "update Tbl_Gorsel set GorselAd='Deneme1' where GorselKategori='kategori1'";
            string sorgu3 = "delete from Tbl_Gorsel where GorselKategori='kategori1'";

            baglan.Open();
            SqlCommand com1 = new SqlCommand(sorgu1, baglan);
            var deger=com1.ExecuteNonQuery();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Proje.Business.Tbl_Gorsel nesne = new Business.Tbl_Gorsel();
            var sonuc = nesne.Listele();
            GridView1.DataSource = sonuc;
            GridView1.DataBind();


            Proje.Business.Tbl_Gorsel nesne = new Business.Tbl_Gorsel();
            Proje.DataAccess.Tbl_Gorsel nesne1 = new DataAccess.Tbl_Gorsel();
            nesne1.GorselAd = TextBox1.Text;
            nesne1.GorselKategori = TextBox2.Text;
            nesne1.GorselAciklama = TextBox3.Text;
            var deger = nesne.VeriEkleme(nesne1);


            Proje.Business.Tbl_Gorsel ara = new Business.Tbl_Gorsel();
            Proje.DataAccess.Tbl_Gorsel nesne2 = new DataAccess.Tbl_Gorsel();
            nesne2.GorselAd = TextBox1.Text;
            nesne2.GorselKategori = TextBox2.Text;
            nesne2.GorselAciklama = TextBox3.Text;          

            var sonuc = ara.VeriGuncelle(TextBox4.Text,nesne2);


        }
    }
}