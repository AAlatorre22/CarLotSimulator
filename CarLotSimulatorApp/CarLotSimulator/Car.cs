using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
           
        }
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;  
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            
        }


        public int Year { get; set; }
        public string Make {get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"My {Year} {Make} {Model} has a great engine, and it sounds like {EngineNoise}!!!");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"My {Year} {Make} {Model} also has a great horn! That sounds like {HonkNoise}");
        }












    }

   
   
}
