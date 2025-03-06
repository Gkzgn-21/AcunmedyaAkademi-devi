using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
       


        public interface IVehicle
        {
            string Brand { get; }
            double FuelConsumption { get; } 
            double CalculateTotalConsumption(int hours); 
        }

       
        public abstract class VehicleBase : IVehicle
        {
            public abstract string Brand { get; }
            public abstract double FuelConsumption { get; }

           
            public double CalculateTotalConsumption(int hours)
            {
                return FuelConsumption * hours;
            }
        }

  
        public class BMW : VehicleBase
        {
            public override string Brand => "BMW";
            public override double FuelConsumption => 80.0; 
        }

   
        public class Mercedes : VehicleBase
        {
            public override string Brand => "Mercedes";
            public override double FuelConsumption => 70.0; 
        }

     
        public class Porsche : VehicleBase
        {
            public override string Brand => "Porsche";
            public override double FuelConsumption => 60.0; 
        }

        public class Progra
        {
            public static void Main()
            {
               
                List<IVehicle> vehicles = new List<IVehicle>
        {
            new BMW(),
            new Mercedes(),
            new Porsche()
        };

              
                double totalConsumption = 0;
                int hoursDriven = 1;

                foreach (var vehicle in vehicles)
                {
                    double consumption = vehicle.CalculateTotalConsumption(hoursDriven);
                    Console.WriteLine($"{vehicle.Brand} için tüketim: {consumption} L");
                    totalConsumption += consumption;
                }

                Console.WriteLine($"Toplam tüketim: {totalConsumption} L");
            }

        }
    }
}
