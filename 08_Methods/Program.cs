using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            //Geriye değer döndürmeyen metotlar
            //Customer --> Lİstele,ekle,sil,güncelle  
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("test");
            //    Console.WriteLine("test2");
            //    Console.WriteLine("test3");
            //    Console.WriteLine("test4");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Zamazingo");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}
            //CustomerCard("test","deneme");
            //CustomerCard("deneme", "test");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "test deneme";

            //}

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Veli";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz:");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengin giriniz:");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            int Sum(int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }

            Console.WriteLine(Sum(45, 84));
            Console.WriteLine(Sum(35, 67));
            Console.WriteLine(Sum(54, 82));
            Console.WriteLine(Sum(74, 21));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >=50)
                {
                    return student + " isimli öğrenci sınavı geçti " + "Ortalama:" + result;
                }
                else
                {
                    return student + " isimli öğrenci sınavı geçemedi " + "Ortalama:" + result;
                }
            }
            Console.WriteLine(ExamResult("Ali", 52, 14, 58));
            Console.WriteLine(ExamResult("Veli", 63, 88, 33));

            #endregion

            Console.Read();
        }
    }
}
