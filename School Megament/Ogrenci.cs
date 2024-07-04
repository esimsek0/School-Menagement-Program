using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimSistemiUygulamasi
{
    internal class Ogrenci
    {
        public int No;
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public SUBE Sube { get; set; }
        public CINSIYET Cinsiyet { get; set; }
        public Adres Adres { get; set; }
        public float Ortalama { get; }
        public DateTime DogumTarihi { get; set; }

        public List<string> Kitaplar = new List<string>();
        public List<DersNotu> Notlar = new List<DersNotu>();
        public Ogrenci(int no, string ad, string soyad, DateTime tarih, CINSIYET cins, SUBE sb)
        {
            this.No = no;
            this.Ad = ad;
            this.Sube = sb;
            this.Soyad = soyad;
            this.DogumTarihi = tarih;
            this.Cinsiyet = cins;

        }
    }
    public enum SUBE
    {
        Empty, A, B, C, D
    }
    public enum CINSIYET
    {
        Empty, Kiz, Erkek
    }
}
