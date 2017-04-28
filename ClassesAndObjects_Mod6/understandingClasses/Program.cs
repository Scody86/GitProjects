// Scott Cody
// Adv. C# Tue 8 - 11
// Car Dealer Program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            
            string make = myCar.Make;
            string model = myCar.Model;
            int Year = myCar.Year;
            string color = myCar.Color;
            Console.WriteLine("Please enter the Make of the car: ");
            make = Console.ReadLine();
            Console.WriteLine("\nPlease enter the model of the car: ");
            model = Console.ReadLine();
            Console.WriteLine("\nPlease enter the year of the car: ");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease enter the color of the car: ");
            color = Console.ReadLine();
            

            Console.WriteLine("\n{0} \n{1} \n{2} \n{3}", 
                make, 
                model, 
                Year, 
                color);

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("\n{0:C}", value);

            Console.WriteLine("\nYour car is worth {0:C}.", myCar.DetermineMarketValue());

             Console.ReadLine();
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 0.0M;
            return carValue;
        }


    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
            {
                carValue = 10000;
            }
            else
                carValue = 2000;

            return carValue;
        }

    }


}
