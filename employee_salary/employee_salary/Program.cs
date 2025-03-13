using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_salary
{

    class Calisan
    {
        public string Ad { get; }
        public string Soyad { get; }
        public string Meslek { get; }
        public double Maas { get; }
        public string Departman { get; }

        public Calisan(string ad, string soyad, string meslek, double maas, string departman) =>
            (Ad, Soyad, Meslek, Maas, Departman) = (ad, soyad, meslek, maas, departman);
    }

    class Program
    {
        static void Main()
        {
            var calisanlar = new List<Calisan>
        {
            new Calisan("Laçin", "Işık", "Genel Müdür", 80000, "Yönetim"),
            new Calisan("Armanç", "Bulut", "Müdür", 50000, "Satış"),
            new Calisan("Taha", "Kaya", "Programcı", 30000, "IT"),
            new Calisan("Mustafa", "Taş", "Stajyer", 20000, "Eğitim")
        };

            calisanlar.ForEach(c =>
                Console.WriteLine($"{c.Ad} {c.Soyad} - {c.Meslek} ({c.Departman}) - Maaş: {c.Maas} TL"));

            Console.WriteLine($"\nToplam Maaş: {calisanlar.Sum(c => c.Maas)} TL");
        }
    }

}
