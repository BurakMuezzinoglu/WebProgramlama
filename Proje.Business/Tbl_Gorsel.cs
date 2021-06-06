using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje.Business
{
    public class Tbl_Gorsel
    {
        public string Gorselid { get; set; }
        public string GorselAd { get; set; }
        public string Gorselİcerik { get; set; }
        public string GorselKategori { get; set; }
        public string GorselAciklama { get; set; }
        public string GorselEklenmeTarih { get; set; }




        public List<string> ServisGetir()
        {

            var servis = new Proje.Site.WebServis.Test().AdlariListele(20);
            return servis;

        }


        public List<Proje.DataAccess.Tbl_Gorsel> Listele()
        {
            Proje.DataAccess.PortfolyoSiteDBEntities ent = new DataAccess.PortfolyoSiteDBEntities();
            //ent.Database.Connection.Open();
            var sonuc = ent.Tbl_Gorsel.OrderBy(p=>p.Gorselid).ToList();
            return sonuc;

        }



        public Proje.DataAccess.Tbl_Gorsel GetByGorselid(string Gorselid)
        {
            Proje.DataAccess.PortfolyoSiteDBEntities ent = new DataAccess.PortfolyoSiteDBEntities();
            //ent.Database.Connection.Open();
            var sonuc = ent.Tbl_Gorsel.Where(p => p.GorselAd == GorselAd);
            return sonuc.FirstOrDefault();
            

        }




        public List< Proje.DataAccess.Tbl_Gorsel> GetByGorselAdveKategori(string GorselAd,string GorselKategori)
        {
            Proje.DataAccess.PortfolyoSiteDBEntities ent = new DataAccess.PortfolyoSiteDBEntities();
            //ent.Database.Connection.Open();
            var sonuc = ent.Tbl_Gorsel.Where(p => p.GorselAd.Contains(GorselAd) && p.GorselKategori.StartsWith("Moda"));
            return sonuc.ToList();


        }



        public string VeriEkleme(Proje.DataAccess.Tbl_Gorsel nesne)
        {
            Proje.DataAccess.PortfolyoSiteDBEntities ekleme = new DataAccess.PortfolyoSiteDBEntities();
            Proje.DataAccess.Tbl_Gorsel yeni = new DataAccess.Tbl_Gorsel();
            yeni.GorselAd = nesne.GorselAd;
            yeni.GorselKategori = nesne.GorselKategori;
            yeni.GorselAciklama = nesne.GorselAciklama;
            ekleme.Tbl_Gorsel.Add(yeni);
            ekleme.SaveChanges();
            var verilerigetir = Listele();


            return "1";


        }




        public string VeriGuncelle(string GorselAd,Proje.DataAccess.Tbl_Gorsel nesne)
        {
            Proje.DataAccess.PortfolyoSiteDBEntities ekleme = new DataAccess.PortfolyoSiteDBEntities();
            Proje.DataAccess.Tbl_Gorsel yeni = new DataAccess.Tbl_Gorsel();
            var aranan = ekleme.Tbl_Gorsel.Where(p => p.GorselAd == GorselAd).FirstOrDefault();


            aranan.GorselAd = nesne.GorselAd;
            aranan.GorselKategori = nesne.GorselKategori;
            aranan.GorselAciklama = nesne.GorselAciklama;
            //ekleme.Tbl_Gorsel.Add(aranan);
            ekleme.SaveChanges();
            var verilerigetir = Listele();


            return "1";


        }



        public string VeriSilme(string GorselAd, Proje.DataAccess.Tbl_Gorsel nesne)
        {
            Proje.DataAccess.PortfolyoSiteDBEntities ekleme = new DataAccess.PortfolyoSiteDBEntities();
            Proje.DataAccess.Tbl_Gorsel yeni = new DataAccess.Tbl_Gorsel();
            var aranan = ekleme.Tbl_Gorsel.Where(p => p.GorselAd == GorselAd).FirstOrDefault();


            aranan.GorselAd = nesne.GorselAd;
            aranan.GorselKategori = nesne.GorselKategori;
            aranan.GorselAciklama = nesne.GorselAciklama;
            ekleme.Tbl_Gorsel.Remove(aranan);
            ekleme.SaveChanges();
            var verilerigetir = Listele();


            return "1";


        }



    }
}
