using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.NumberOfCars++;
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
            CarLot.NumberOfCars++;

        }
        public static int CarCounter()
        {
            Console.WriteLine($" Total number of cars: {CarLot.NumberOfCars}");
            return CarLot.NumberOfCars;
        }


        public int Year { get; set; } 
        public string Make { get; set; } 
        public string Model { get; set; }
        public string EngineNoise { get; set; } 
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }
        
        public void MakingEngineNoise(string engineNoise)
        {
            Console.WriteLine($"{Make}'s engine noise sounds like... {engineNoise}");
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"{Make}'s horn noise sounds like... {honkNoise}");
        }
    }
}
