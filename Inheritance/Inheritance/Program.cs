using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
        class Araba  // Temel sınıf 
        {
            public string Marka { get; set; }

            public Araba(string marka)
            {
                Marka = marka;
            }

            public virtual void VitesTuru()
            {
                Console.WriteLine($"{Marka} → Vites bilgisi belirtilmemiştir.");
            }
        }

        // Alt sınıflar 
        class BMW : Araba
        {
            public BMW() : base("BMW") { }

            public override void VitesTuru()
            {
                Console.WriteLine($"{Marka} → Düz viteslidir.");
            }
        }

        class Porsche : Araba
        {
            public Porsche() : base("Porsche") { }

            public override void VitesTuru()
            {
                Console.WriteLine($"{Marka} → Otomatik viteslidir.");
            }
        }

        class Mercedes : Araba
        {
            public Mercedes() : base("Mercedes") { }

            public override void VitesTuru()
            {
                Console.WriteLine($"{Marka} → Otomatik viteslidir.");
            }
        }

        class Togg : Araba
        {
            public Togg() : base("Togg") { }

            public override void VitesTuru()
            {
                Console.WriteLine($"{Marka} → Otomatik viteslidir.");
            }
        }

        class Audi : Araba
        {
            public Audi() : base("Audi") { }

            public override void VitesTuru()
            {
                Console.WriteLine($"{Marka} → Düz viteslidir.");
            }
        }

        class Toyota : Araba
        {
            public Toyota() : base("Toyota") { }

            public override void VitesTuru()
            {
                Console.WriteLine($"{Marka} → Düz viteslidir.");
            }
        }

        class Program
        {
            static void Main()
            {
                Araba[] arabalar = {
                new BMW(),
                new Porsche(),
                new Mercedes(),
                new Togg(),
                new Audi(),
                new Toyota()
             };

                foreach (var araba in arabalar)
                {
                    araba.VitesTuru();
                }
            }
        } 
        





