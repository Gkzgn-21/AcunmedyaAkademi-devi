using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @namespace
{
    #region Hesaplama

    namespace Hesaplama
    {
        public class Islemler
        {
            public int Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            public int Carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }
            #endregion

            #region Test

namespace TestUygulamasi
        {
            class Program
            {
                static void Main(string[] args)
                {
                    Islemler hesap = new Islemler();

                    int toplam = hesap.Topla(5, 3);
                    int carpim = hesap.Carp(4, 2);

                    Console.WriteLine("Toplam: " + toplam);
                    Console.WriteLine("Çarpım: " + carpim);
                }
            }
        }
        #endregion
    }
    }
  

