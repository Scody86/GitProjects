using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fortune = new string[6]
            {"Luck is coming your way.", "Financial freedome lies ahead.",
                "Something you lost will soon turn up.",
                "A vacation lies ahead.", "A raise is upon you.",
                "The one you love may draw near." };

            Random rnd = new Random();
            //string fortune1 = rnd.Next(fortune[0]);
            
            for (int i = 0; i < fortune.Length; i++)
            {

            }
        }

        static void Fortune()
        {


        }
    }
}
