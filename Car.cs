using System.ComponentModel.DataAnnotations;

namespace BridgePatternConsoleExample
{
    public class Car
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Model { get; set; }
        [StringLength(150)]
        public string Color { get; set; }
        [StringLength(150)]
        public string Brand { get; set; }
        [Range(1950, int.MaxValue)]
        public int Year { get; set; }
    }

    public interface ICar
    {
        void DisplayDetails();
    }

    public class BasicCar : ICar
    {
        private readonly Car _car;

        public BasicCar(Car car)
        {
            _car = car;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Basic Car Details: {_car.Brand} {_car.Model}, {_car.Year}");
        }
    }

    public class DetailedCar : ICar
    {
        private readonly Car _car;

        public DetailedCar(Car car)
        {
            _car = car;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Detailed Car Details: {_car.Brand} {_car.Model}, {_car.Year}, {_car.Color}");
        }
    }

}
