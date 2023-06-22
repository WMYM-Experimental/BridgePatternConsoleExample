using BridgePatternConsoleExample;

var car = new Car
{
    Id = 1,
    Name = "My Car",
    Brand = "Toyota",
    Model = "Camry",
    Color = "Blue",
    Year = 2020
};

// Utilizar la implementación BasicCar para mostrar los detalles básicos del automóvil
ICar basicCar = new BasicCar(car);
basicCar.DisplayDetails();

// Utilizar la implementación DetailedCar para mostrar los detalles detallados del automóvil
ICar detailedCar = new DetailedCar(car);
detailedCar.DisplayDetails();

Console.ReadLine();
