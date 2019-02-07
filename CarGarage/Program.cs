using System;

namespace CarGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var garage = new Garage();

            Console.WriteLine("1. Add a car to the garage.");
            Console.WriteLine("2. Remove a car from the garage.");
            Console.WriteLine("3. List all cars.");
            Console.WriteLine("4. Test drive a car.");
            Console.WriteLine("5. Refuel all cars.");

            string menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    Console.WriteLine("What is the Make of your car?");
                    var make = Console.ReadLine();
                    Console.WriteLine("What is the Model of your car?");
                    var model = Console.ReadLine();
                    garage.AddCar(make, model);
                    break;

                case "2":
                    int carNum = Convert.ToInt32(Console.ReadLine());
                    garage.RemoveCar(carNum); //make this in garage as new method
                    break;

                case "3":
                    garage.ListAllCars();
                    break;

                case "4":   //garage.TestDriveCar(); //make this in garage as new method
                    Console.WriteLine("1. Turn on car");
                    Console.WriteLine("2. Accelerate");
                    Console.WriteLine("3. Brake");
                    Console.WriteLine("4. Turn off car");
                    Console.WriteLine("5. Return car");
                    break;

                case "5":
                    garage.FuelAllCars();
                    break;

                default:
                    Console.WriteLine("That wasn't an option! Try again.");
                    break;
            }
        }
    }
}
