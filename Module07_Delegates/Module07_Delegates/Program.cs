// Scott Cody
// Advanced C# Thu 8 - 11
// Module07 Delegate Example

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_Delegates
{
    public delegate int addNumsDelegate(int num1, int num2);

    class Program
    {
        public static int addNums(int num1, int num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            addNumsDelegate del = new addNumsDelegate(addNums);
            int solution = del(2, 3);
            Console.WriteLine("The solution is {0}.", solution);

            Console.Read();
        }
    }
}
