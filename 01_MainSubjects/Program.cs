using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            #region Yazdırma Komutları

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler
            //String
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Engin";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city ;

            //customerName = "Engin";
            //customerSurname = "Yıldız";
            //customerPhone = "+90 123 123 45 67";
            //customerEmail = "deneme@deneme.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName+ " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerEmail);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------");

            //Console.WriteLine();

            //customerName = "Deneme";
            //customerSurname = "Test";
            //customerPhone = "+90 123 123 45 67";
            //customerEmail = "deneme@deneme.com";
            //district = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerEmail);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------");
            #endregion

            #region Int Değişkenler
            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 500;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 100;
            int pizzaPrice = 400;
            int lemonadePrice = 50;

            Console.WriteLine("**** Restaurant Menu Price ****");
            Console.WriteLine();
            Console.WriteLine("---- Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("---- Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("---- Kola: " + cokePrice + " TL");
            Console.WriteLine("---- Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("---- Kızartma: " + friesPrice + " TL");
            Console.WriteLine("---- Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restaurant Menu Price ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;

            hamburgerCount = 3;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");


            #endregion

            Console.Read();
        }
    }
}
