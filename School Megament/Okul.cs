using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimSistemiUygulamasi
{
    //verinin yönetimi için metotlar
    internal class Okul
    {
        public List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public void OgrenciEkleme(string ad, string soyad, SUBE sb, DateTime tarih, int no, CINSIYET cinsiyet)
        {
            this.ogrenciler.Add(new Ogrenci(no,ad,soyad,tarih,cinsiyet,sb));
        }
        public void OgrenciSilme()
        {

        }
        public void OgrenciGuncelleme()
        {

        }
        public void NotEkleme(int no, string ders, float not)
        {
            DersNotu dn = new DersNotu(ders, not);
            //dn.DersAdi = ders;
            //dn.Not = not;

            Ogrenci o = this.ogrenciler.Where(h => h.No == no).FirstOrDefault();
            if (o!=null)
            {
                o.Notlar.Add(dn);
            }

        }
        public Okul()
        {
            SahteVeriGir();
        }
        public void SahteVeriGir()
        {
            OgrenciEkleme("Ayşe", "Bilge",SUBE.A,new DateTime(2011,07,22),1,CINSIYET.Kiz);
            OgrenciEkleme("Ayşe", "Bilge",SUBE.A,new DateTime(2011,07,22),1,CINSIYET.Kiz);
            OgrenciEkleme("Ayşe", "Bilge",SUBE.A,new DateTime(2011,07,22),1,CINSIYET.Kiz);
            OgrenciEkleme("Ayşe", "Bilge",SUBE.A,new DateTime(2011,07,22),1,CINSIYET.Kiz);
            OgrenciEkleme("Ayşe", "Bilge",SUBE.A,new DateTime(2011,07,22),1,CINSIYET.Kiz);
            OgrenciEkleme("Ayşe", "Bilge",SUBE.A,new DateTime(2011,07,22),1,CINSIYET.Kiz);
            OgrenciEkleme("Ayşe", "Bilge",SUBE.A,new DateTime(2011,07,22),1,CINSIYET.Kiz);
        }
    }
}
