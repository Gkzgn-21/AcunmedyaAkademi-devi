using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] sayılar = new double[5];
            double toplam = 0;

    
            for (int i = 0; i < sayılar.Length; i++)
            {
                Console.Write("Lütfen {0}. sayıyı girin: ", i + 1);
                sayılar[i] = Convert.ToDouble(Console.ReadLine());
            }
       foreach (double sayı in sayılar)
            {
                toplam += sayı;
            }

            double ortalama = toplam / sayılar.Length;
            Console.WriteLine("Girdiğiniz sayıların ortalaması: " + ortalama);
        }
    }
}
   

