using System;
using Xunit;

namespace CarGarage.Tests
{
    public class GarageTests
    {
        public string model = "testModel";
        public string make = "testMake";

        [Fact]
        public void shouldAddCarToGarage()
        {
            // Tests AddCar() method
            // Arrange
            var garage = new Garage();

            // Act
            garage.AddCar(make, model);

            // Assert
            Assert.NotEmpty(garage.CarList);
        }

        [Fact]
        public void shouldRemoveCarFromGarage()
        {
            // Tests RemoveCar() method
            // Arrange
            var garage = new Garage();

            // Act
            garage.AddCar(make, model);
            garage.RemoveCar(0); // add 1 car, then remove it & check is list is empty

            // Assert
            Assert.Empty(garage.CarList);
        }

        [Fact]
        public void shouldFuelAllCars()
        {
            // Tests FuelAllCars() method
            // Arrange
            var garage = new Garage();

            // Act
            garage.FuelAllCars();

            foreach (var car in garage.CarList)
            {
                // Assert
                Assert.Equal(100, car.GasLevel);
            }
        }

        [Fact]
        public void shouldTestDriveOneCar() //don't need to test this one
        {
            // Use the Program class to let you select a single car
            // Program class should then let you choose what you want to do with that car
            // You do not need to test user input in the Program class
        }

        [Fact]
        public void shouldListAllCarsTest()
        {
            var garage = new Garage();

            garage.ListAllCars();

            foreach (var car in garage.CarList)
            {
                Assert.True(car.ListedStats);
            }
            // Should be able to list stats of all cars
            // Create necessary method(s)
            // Garage class should provide cars
            // Program class should list all stats
        }
    }
}
