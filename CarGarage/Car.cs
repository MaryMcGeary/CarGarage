using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public int Speed { get; private set; }
        public int GasLevel { get; private set; }
        public bool CarStarted = false;
        public string Make { get; private set; }
        public string Model { get; private set; }
        public bool ListedStats = false;
        
        public Car(string make, string model)
        {
            Speed = 0; 
            GasLevel = 100; 
            Make = make;
            Model = model;
        }

        public void Accelerate()
        {
            Speed += 10;
            GasLevel -= 10;
        }

        public void Brake()
        {
            Speed -= 10;
            GasLevel -= 10;
        }

        public void AddFuel()
        {
            GasLevel = 100;
        }

        public void ToggleEngine()
        {
            CarStarted = !CarStarted;
        }

        public void ListStats()
        {
            Console.WriteLine("Speed = ", Speed);
            Console.WriteLine("GasLevel = ", GasLevel);
            Console.WriteLine("CarStarted = ", CarStarted);
            Console.WriteLine("Make = ", Make);
            Console.WriteLine("Model = ", Model, "\n");

            ListedStats = true;
        }
    }
}
