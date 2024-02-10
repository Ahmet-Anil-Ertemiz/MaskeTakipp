using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas1 = new Vatandas();
            SelamVer(isim: "Engin");
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Anıl");
            SelamVer();
            int sonuc = Topla(6, 58);

            //Diziler /Arrays 

            string ogrenci1 = "Engin";
            string ogrenci2 = "Ahmet";
            string ogrenci3 = "Anıl";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Ahmet";
            ogrenciler[2] = "Anıl";

            ogrenciler = new string[4];
            ogrenciler[3] = "Attila";

            for (int i = 0; i <ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }


            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Erzincan" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person ();
            person1.FirstName = "Anıl";
            person1.LastName = "Ertemiz";
            person1.DateOfBirthYear = 2001;
            person1.NationalIdentity = 123;
           

            List<string> yeniSehirler1 = new List<string> {"Ankara 1", "İstanbul 1", "İzmir 1"};
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }


            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person1);
            

            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " +  sonuc.ToString());
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000; //dbden gelir 
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910;

           
            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }
    }

    //pascal casing 
    public class Vatandas 
    {
       public string Ad { get; set; }
       public string Soyad {  get; set; }
       public int DogumYili {  get; set; }
       public long TcNo { get; set; }
    }
}
