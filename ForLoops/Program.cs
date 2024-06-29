using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Nedir Nasıl Kullanılır

            //For aynı while gibi bir döngüdür. Ancak kullanımı daha derli topludur
            //Başlangı, koşul ve iterasyon üçlüsünü yönetmek daha kolaydır.

            #endregion

            #region While'a tekrardan bakalım
            //int sayac = 0;
            //while (sayac <= 100)
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;
            //}
            #endregion

            #region For Kullanımı
            //for(int sayac = 0; sayac<=100; sayac++)
            //{
            //    Console.WriteLine(sayac);
            //}
            #endregion

            #region Adınızı 10 kere yazdırınız

            //for (int sayac = 0; sayac < 10; sayac++) 
            //{
            //    Console.WriteLine("Samet");
            //}

            #endregion

            #region Çarpım tablosunun 3 ler basamağını yazdırınız

            //for (int carpan = 1; carpan <11; carpan++)
            //{
            //    Console.WriteLine("3 x " + carpan + " = " + (carpan*3));
            //}

            #endregion

            #region Çarpım Tablosunu Kullanıcıadan alınan  basamağını yazdırınız

            //Console.WriteLine("Basamak giriniz: ");
            //int basamak = Convert.ToInt32(Console.ReadLine());

            //for (int carpan = 1; carpan <= 10; carpan++)
            //{
            //    Console.WriteLine(basamak + " x " + carpan + " = " + (carpan * basamak));
            //}

            #endregion

            #region Tüm Çarpım Tablosunu yazdırınız

            //for (int basamak = 1; basamak <=10; basamak++)
            //{
            //    Console.WriteLine("\n" + basamak + " lar/ler basamağı");
            //    for (int carpan = 1; carpan <= 10; carpan++)
            //    {
            //        Console.WriteLine(basamak + " x " + carpan + " = " +(basamak*carpan));
            //    }
            //}

            #endregion

            #region Konsoldan alınan sayı asal mı?
            //Console.WriteLine("Lütfen sayı giriniz: ");

            //int sayi = Convert.ToInt32(Console.ReadLine());
            //bool asalmi = true;
            //for (int i = 2; i < sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        Console.WriteLine("Sayı asal değildir.");
            //        //i=sayi;
            //        asalmi = false;
            //        break;
            //    }
            //}
            //if (asalmi == true)
            //{
            //    Console.WriteLine("Sayı asaldır.");
            //}


            #endregion
            //ödev konsoldan alınan iki sayı arasındaki asal sayıları yazdırınızı
            //konsoldan alınan 2 sayı arasındaki ikiz asalları yazdırınız (aralarında asal olmayan bir sayı olacak)

            #region Konsoldan alınan sayıların ortalamsını bulunuz;


            #endregion

            #region a - z küçük karakterli yazdırınız
            //for (int i = 97; i <= 122; i++)
            //{
            //    char karakter = (char)i;
            //    Console.WriteLine(karakter);
            //}
            #endregion

        }
    }
}
