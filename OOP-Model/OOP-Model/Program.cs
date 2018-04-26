using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Ferry ferry = new Ferry(new IWeightable[]
            {
                new ContainerCargo(100, 20, 20, 20, new SolidMaterial("steel", 1234, 0.5)),
                new Passenger("Ivan Ivanov", 75),
                new Passenger("Petr Ivanov", 68),
                new TankCargo(100, 20, 20, new FluidMaterial("Oil", 234)),
                new Passenger("Ivan Petrov", 79),
                new Passenger("Petr Petrov", 56),
                new Passenger("Anton Petrov", 57),
                new PlatformCargo(1000),
                new Passenger("Ivan Sidorov", 79),
                new Passenger("Petr Sidorov", 45)
            });

            ferry.Show();

            ferry.Sort();

            ferry.Show();

            Console.WriteLine("Ferry is " + (ferry.IsOverloaded() ? "" : "not ") + "overloaded.");

            Console.Read();
        }
    }
}