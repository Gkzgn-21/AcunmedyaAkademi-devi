using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_gasoline
{
    class Araba
    {
        public string Model { get; }
        public double YakıtTüketimi { get; }

        public Araba(string model, double yakıtTüketimi) =>
            (Model, YakıtTüketimi) = (model, yakıtTüketimi);
    }

    class Program
    {
        static void Main()
        {
            var arabalar = new List<Araba>
        {
            new Araba("Dacia", 6.5),
            new Araba("Honda Civic", 7.2),
            new Araba("Porsche", 8.0),
            new Araba("Tesla", 9.5)
        };

            arabalar.ForEach(a => Console.WriteLine($"{a.Model} - {a.YakıtTüketimi} L/100 km"));
            Console.WriteLine($"\nToplam Yakıt Tüketimi: {arabalar.Sum(a => a.YakıtTüketimi)} L/100 km");
        }
    }

}
