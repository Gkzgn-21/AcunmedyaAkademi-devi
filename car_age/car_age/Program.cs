using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_age
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(DurumBelirle(5));   //  Arabanız yeni
            Console.WriteLine(DurumBelirle(15));  //  Servise götürmeniz gerekebilir
            Console.WriteLine(DurumBelirle(25));  //  Arabanız hurdaya çıkabilir
            Console.WriteLine(DurumBelirle(35));  //  Ya hiç üretilmedi ya da trafikten men edilmiştir
        }

        static string DurumBelirle(int yas)
        {
            switch (yas)
            {
                case int n when (n >= 0 && n <= 10):
                    return "Arabanız yeni";
                case int n when (n > 10 && n <= 20):
                    return "Servise götürmeniz gerekebilir";
                case int n when (n > 20 && n <= 30):
                    return "Arabanız hurdaya çıkabilir";
                default:
                    return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            }
        }

    }
}
