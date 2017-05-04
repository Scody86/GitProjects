// Scott Cody
// Adv. C# Thu 8 - 11
//Module3 checkZip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckZip
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] zip = new int[10] {67010, 67011, 67012,               
            67013, 67014, 67015, 67016, 67017, 67018, 67019};


            int checkZip;
            Console.WriteLine("Enter Zip Code between 67010 and 67019: ");
            string zipCode = Console.ReadLine();
            checkZip = Convert.ToInt32(zipCode);

            if (checkZip >= 67010 && checkZip <= 67014)
            {
                Console.WriteLine("\nWe would be happy to deliver to the {0} area.", checkZip);
            }
            else if (checkZip >= 67015 && checkZip <= 67019)
            {
                Console.WriteLine("I'm sorry we do not deliver to the {0} area.", checkZip);
            }
            else
            {
                Console.WriteLine("I'm sorry {0} is an invalid Zip Code. Please try again.", checkZip);
            }
            Console.Read();
        }       
    }
}
