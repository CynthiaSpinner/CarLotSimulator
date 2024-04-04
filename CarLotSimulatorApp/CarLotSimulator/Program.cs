using System;


namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            var cynthiaLot = new CarLot();


            //Now that the Car class is created we can instanciate 3 new cars
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

            
            //Set the properties for each of the cars
            //Call each of the methods for each car
            cynthiasRover.MakeHonkNoise(cynthiasRover.HonkNoise);
            georgesToyota.MakingEngineNoise(georgesToyota.EngineNoise);
            rheasHonda.MakingEngineNoise(rheasHonda.EngineNoise);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
