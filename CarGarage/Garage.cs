using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> CarList { get; set; }

        public Garage()
        {
            CarList = new List<Car>();
        }

        public void AddCar(string make, string model)
        {
            CarList.Add(new Car(make, model));
        }

        public void RemoveCar(int whichCar)
        {
            CarList.RemoveAt(whichCar);
        }

        public void ListAllCars()
        {
            foreach (var car in CarList)
            {
                Console.WriteLine(car.Make + " " + car.Model);
            }
        }

        public void FuelAllCars()
        {
            foreach (var car in CarList)
            {
                car.AddFuel();
            }
        }
    }
}







