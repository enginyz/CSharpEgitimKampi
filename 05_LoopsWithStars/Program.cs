using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma, her satırda 10 tane yıldız olsun

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik üçgen

            //for (int i = 1; i <= 5 ; i++)
            //{
            //    for (int j = 1; j <=i ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik Üçgen

            //for (int i = 5; i >=1 ; i--)
            //{
            //    for (int j = 1; j <=i ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik ve Ters Dik Üçgen Birlikte

            //for (int i = 1; i <= 5 ; i++)
            //{
            //    for (int j = 1; j <= i ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int l = 1; l <= k; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    //boşluklar
            //    for (int j = n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Pramit

            //int n=5;

            //for (int i = n; i >= 1; i--)
            //{
            //    //boşluklar
            //    for (int j = n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1 ; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Elmas
            Console.Write("Sayı giriniz: ");
            int sayi;
            sayi = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= sayi; i++)
            {
                //boşluklar
                for (int j = sayi - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                //yıldızlar
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int p = sayi-1; p >= 1; p--)
            {
                //boşluklar
                for (int r = sayi - p; r > 0; r--)
                {
                    Console.Write(" ");
                }
                //yıldızlar
                for (int s = 1; s <= 2 * p - 1; s++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            #endregion


            Console.Read();
        }
    }
}
