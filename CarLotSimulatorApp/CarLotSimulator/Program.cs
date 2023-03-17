using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car. DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable. DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise(). DONE
            //The methods should take one string parameter: the respective noise property

            var suv = new Car();
           
            suv.Year = 2023;
            suv.Make = "Mazda";
            suv.Model = "CX-5";
            suv.EngineNoise = "whoosh";
            suv.HonkNoise = "meep meep";
            suv.IsDriveable = true;

            suv.MakeEngineNoise();
            suv.MakeHonkNoise();

            var truck = new Car(2010, "Dodge", "Ram", "ROAR", "BOOM", true);

            truck.MakeEngineNoise();
            truck.MakeHonkNoise();

            var motorcycle = new Car() 
            { Year = 2022, 
               Make = "Yamaha", 
                Model = "R1", 
                 EngineNoise = "WAAAAAAA", 
                  HonkNoise = "beep beep", 
                   IsDriveable = true };

            motorcycle.MakeEngineNoise();
            motorcycle.MakeHonkNoise();
            Console.WriteLine();


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class    var carLot = new List<Car>(); with this -->  carLot.Add(motorcycle) or this --> {motorcycle, truck, suv};
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            Console.WriteLine("<><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("Here are the cars I have in my carlot!");
            var carlot = new CarLot();
            carlot.ParkingLot = new List<Car>() {motorcycle, suv, truck};
            foreach (var car in carlot.ParkingLot)
            {
                Console.WriteLine($"{car.Year} | {car.Make} | {car.Model}");
            }
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><>");






        }
    }
}
