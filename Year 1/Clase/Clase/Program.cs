using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car myOtherCar = null;
            myCar = null;

            Car my3car = new Car("Nissan", "V3", 1999, "Red");
        

            Console.ReadKey();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double OriginalPrice { get; set; }

        public Car()
        {
            this.Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;        
        }
        
        public Car(string altceva, string model, int year, string color)
        {
            Make = altceva;
            Model = model;
            Year = year;
            Color = color;
        }
        

        public static void my();
    }
}
