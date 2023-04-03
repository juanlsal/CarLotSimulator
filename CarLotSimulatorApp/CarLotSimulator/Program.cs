using System;
using System.ComponentModel;
using System.Reflection;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car(2022, "Toyota", "corrola", "Vruuuumm", "honnnk", true);
            myCar.MakeEngineNoise();
            CarLot.CarList.Add(myCar);
            myCar.MakeHonkNoise();
            var tomsCar = new Car(2012, "Mazda", "sum", "chrooom", "honk", true);
            tomsCar.MakeEngineNoise();
            tomsCar.MakeHonkNoise();
            CarLot.CarList.Add(tomsCar);
            var evasCar = new Car(1975, "mustang", "sport", "tuh tuh tuh", "beep", true);
            evasCar.MakeEngineNoise();
            evasCar.MakeHonkNoise();
            CarLot.CarList.Add(evasCar);
            
            foreach (var i in  CarLot.CarList)
            {
                Console.WriteLine($"the year is {i.Year}");
                Console.WriteLine($"the make is {i.Make}");
                Console.WriteLine($"the model is {i.Model}");
            }



        }
    }
}
