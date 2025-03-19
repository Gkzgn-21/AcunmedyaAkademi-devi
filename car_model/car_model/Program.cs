using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_model
{
    

    public class Kapı
    {
        public int Sayısı { get; set; }
    }

    public class Pencere
    {
        public int Sayısı { get; set; }
    }

    public class Kasa
    {
        public string Tipi { get; set; }
    }

    public class Araç
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public Kapı Kapı { get; set; }
        public Pencere Pencere { get; set; }
        public Kasa Kasa { get; set; }
        public decimal Fiyat { get; set; }

        public Araç(string marka, string model, Kapı kapı, Pencere pencere, Kasa kasa, decimal fiyat)
        {
            Marka = marka;
            Model = model;
            Kapı = kapı;
            Pencere = pencere;
            Kasa = kasa;
            Fiyat = fiyat;
        }

        public void AraçBilgisi()
        {
            Console.WriteLine($"Arabanın markası {Marka}, modeli {Model}, kapı sayısı {Kapı.Sayısı}, pencere sayısı {Pencere.Sayısı}, kasası {Kasa.Tipi}, fiyatı {Fiyat} TL'dir.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kapı kapı = new Kapı { Sayısı = 4 };
            Pencere pencere = new Pencere { Sayısı = 4 };
            Kasa kasa = new Kasa { Tipi = "Sedan" };

            Araç araba = new Araç("BMW", "X5", kapı, pencere, kasa, 2000000);
            araba.AraçBilgisi();
        }
    }

}
