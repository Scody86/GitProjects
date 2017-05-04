using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintingEstimate
{
    class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("What is the length of your room?");
            string Length = Console.ReadLine();
            int length = Convert.ToInt32(Length);

            Console.WriteLine("What is the width of your room?");
            string Width = Console.ReadLine();
            int width = Convert.ToInt32(Width);

            const int HEIGHT = 9;

            int area = (length * HEIGHT * 2) + (width * HEIGHT * 2);

            //Console.WriteLine();
            Console.ReadLine();           
        }


        private static void Calculate()
        {
            
            int totalCost =  * 6;


          
        }
    }
}
