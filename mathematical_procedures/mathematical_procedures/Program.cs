using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathematical_procedures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            string islem;


            Console.Write("Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yapmak istediğiniz işlemi giriniz (+, -, *, /): ");
            islem = Console.ReadLine();

            if (islem == "+")
            {
                Console.WriteLine($"Sonuç: {sayi1 + sayi2}");
            }
            else if (islem == "-")
            {
                Console.WriteLine($"Sonuç: {sayi1 - sayi2}");
            }
            else if (islem == "*")
            {
                Console.WriteLine($"Sonuç: {sayi1 * sayi2}");
            }
            else if (islem == "/")
            {
                if (sayi2 != 0)
                {
                    Console.WriteLine($"Sonuç: {sayi1 / sayi2}");
                }
                else
                {
                    Console.WriteLine("Hata: Sıfıra bölme hatası.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz işlem.");
            }
        }

    }
}

