using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_Module06
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Length = 10.0;
            rect.Width = 20.0;
            double area = rect.GetArea();
            Console.WriteLine("Area of rectangle: {0}", area);
            Console.ReadLine();
        }
    }

    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double GetArea()
        {
            return Length * Width;
        }
    }
}

/*
 * Assignment Questions:
 * 
 * a. Any problems running the exercise?
 *    I did not have any problems.
 * b. What was the most difficult concept of the assignment?
 *    Making sure all return statements are correct.
 * c. What was your score in the Understanding Classes video?
 *    I scored 2 out of 2.
 * d. How long did it take to complete this assignment?
 *    It took me a few hours to complete.
 */
