using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_salary
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                Dictionary<string, double> calisanMaaslari = new Dictionary<string, double>()
        {
            { "GenelMüdür", 80000.0 },
            { "Müdür", 60000.0 },
            { "Programci", 40000.0 },
            { "Stajyer", 5000.0 }
        };

                double toplamMaas = calisanMaaslari.Values.Sum();

                Console.WriteLine("Toplam maaş: " + toplamMaas);
            }
        }

    }
}


