using System;
using System.Collections.Generic;

namespace ClassesExercise1Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var caddy = new Car();
            caddy.Make = "Cadillac";
            caddy.Model = "CTS-V";
            caddy.Year = 2012;

            var merc = new Car("Mercedes", "AMG GT3 EVO", 2020);

            var cars = new List<Car>();
            cars.Add(caddy);
            cars.Add(merc);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Make} --- {car.Model} --- {car.Year}");
            }
        }
    }
}
