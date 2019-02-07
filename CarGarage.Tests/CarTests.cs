using System;
using Xunit;

namespace CarGarage.Tests
{
    public class CarTests
    {
        public string model = "testModel";
        public string make = "testMake";

        [Fact]
        public void shouldAccelerate()
        {
            // Tests Accelerate() method in Car increases Speed
            // Arrange
            var car = new Car(make, model); 

            // Act
            car.Accelerate();

            // Assert
            Assert.Equal(10, car.Speed);
        }

        [Fact]
        public void shouldConsumeFuel()
        {
            // Tests Accelerate() method reduces Fuel amount
            // Arrange
            var car = new Car(make, model); 

            // Act
            car.Accelerate();

            // Assert
            Assert.Equal(90, car.GasLevel);
        }

        [Fact]
        public void shouldRefuel()
        {
            // Tests AddFuel() method increases Fuel amount
            // Arrange
            var car = new Car(make, model);

            // Act
            car.AddFuel();

            // Assert
            Assert.Equal(100, car.GasLevel);
        }

        [Fact]
        public void shouldSlowDown()
        {
            // Tests Brake() method in Car reduces Speed amount
            // Arrange
            var car = new Car(make, model);

            // Act
            car.Brake();

            // Assert
            Assert.Equal(-10, car.Speed);
        }

        [Fact]
        public void shouldStart()
        {
            // Tests ToggleEngine() method starts car when its off
            // Arrange
            var car = new Car(make, model);
            
            // Act
            car.ToggleEngine();

            // Assert
            Assert.True(car.CarStarted);
        }

        [Fact]
        public void shouldTurnOff()
        {
            // Tests ToggleEngine() method turns car off when its on
            // Arrange
            var car = new Car(make, model);

            // Act
            car.ToggleEngine();
            car.ToggleEngine();

            // Assert
            Assert.False(car.CarStarted);
        }
    }
}
