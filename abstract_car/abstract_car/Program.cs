using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_car
{
    internal class Program
    {
       
       
            // 1. Araçların temel özelliklerini içeren interface
public interface IVehicle
        {
            string Brand { get; }  // Araç Markası
            void Drive();  // Karada sürüş
            void Float();  // Denizde yüzme
            void Fly();    // Havada uçma
        }


        public abstract class VehicleBase : IVehicle
        {
            public abstract string Brand { get; }

     
            public virtual void Drive()
            {
                Console.WriteLine($"{Brand} karada çok hızlı gider.");
            }

            public abstract void Float(); 
            public abstract void Fly();  
        }

        
        public class BMW : VehicleBase
        {
            public override string Brand => "BMW";

            public override void Float()
            {
                Console.WriteLine($"{Brand} denizde yüzer.");
            }

            public override void Fly()
            {
                Console.WriteLine($"{Brand} havada uçar.");
            }
        }

        public class Mercedes : VehicleBase
        {
            public override string Brand => "Mercedes";

            public override void Float()
            {
                Console.WriteLine($"{Brand} denizde yüzer.");
            }

            public override void Fly()
            {
                Console.WriteLine($"{Brand} havada uçar.");
            }

            public override void Drive()
            {
                Console.WriteLine($"{Brand} karada güvenli bir şekilde gider.");
            }
        }


        public class Porsche : VehicleBase
        {
            public override string Brand => "Porsche";

            public override void Float()
            {
                Console.WriteLine($"{Brand} denizde yüzemez.");
            }

            public override void Fly()
            {
                Console.WriteLine($"{Brand} havada uçar.");
            }
        }

        public class Prog
        {
            public static void Main()
            {
                List<IVehicle> vehicles = new List<IVehicle>
        {
            new BMW(),
            new Mercedes(),
            new Porsche()
        };

              
                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine($"\n{vehicle.Brand} özellikleri:");
                    vehicle.Drive();
                    vehicle.Float();
                    vehicle.Fly();
                }
                 }

            }
        }
}
