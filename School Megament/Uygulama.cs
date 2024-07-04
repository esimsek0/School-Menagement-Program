using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimSistemiUygulamasi
{
    //kullanıcı etkileşimi
    internal class Uygulama
    {
        Okul G065Okulu = new Okul();
        public void Calistir()
        {
            Menu();
            while (true)
            {
                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        break;
                    default:
                        break;
                }
            }
        }
        public void Menu()
        {

        }
        public void OgrenciEkle()
        {
            //ekrandan bilgiler alınacak..

            G065Okulu.OgrenciEkleme("", "", SUBE.A, new DateTime(2011, 12, 11), 1, CINSIYET.Empty);
        }
        public void NotEkleme()
        {
            Console.WriteLine("20 - Not Gir----------------------------------------------------------");
            Console.Write("Ögrencinin numarasi: ");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ögrencinin Adı Soyadı: ");
            Console.WriteLine("Ögrencinin Subesi: ");
            Console.WriteLine();
            Console.Write("Not eklemek istediğiniz ders: ");
            string ders = Console.ReadLine();

            Console.Write("Eklemek istediginiz not adedi: ");
            int adet = int.Parse(Console.ReadLine());
            for (int i = 0; i < adet; i++)
            {
                Console.Write(i + 1 + ". Notu girin: ");
                float not = float.Parse(Console.ReadLine());
                G065Okulu.NotEkleme(no,ders,not);
            }
            
            Console.WriteLine("Bilgiler sisteme girilmistir. ");
            Console.WriteLine();



        }
    }
}
