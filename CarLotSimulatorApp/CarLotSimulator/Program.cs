using System;


namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var cynthiaLot = new CarLot();


            
            var cynthiasRover = new Car();
            cynthiasRover.Make = "Land Rover";
            cynthiasRover.Model = "Range Rover";
            cynthiasRover.Year = 2013;
            cynthiasRover.EngineNoise = "rooaar";
            cynthiasRover.HonkNoise = "Beep Beep";
            cynthiasRover.IsDrivable = true;

            cynthiaLot.ListOfCars.Add(cynthiasRover);

            var georgesToyota = new Car() 
            { 
                Make = "Toyota",
                Model = "Camry",
                Year = 2021,
                EngineNoise = "pew",
                HonkNoise = "wah",
                IsDrivable = true,
            };

            cynthiaLot.ListOfCars.Add(georgesToyota);

            var rheasHonda = new Car( 2012, "Honda", "Accord", "put put", "bang bang", true);

            cynthiaLot.ListOfCars.Add(rheasHonda);

            foreach (var item in cynthiaLot.ListOfCars)
            {
                Console.WriteLine($"Year: {item.Year} Make: {item.Make} Model: {item.Model}\n");
            }

            
            
            cynthiasRover.MakeHonkNoise(cynthiasRover.HonkNoise);
            georgesToyota.MakingEngineNoise(georgesToyota.EngineNoise);
            rheasHonda.MakingEngineNoise(rheasHonda.EngineNoise);
            
        }
    }
}
