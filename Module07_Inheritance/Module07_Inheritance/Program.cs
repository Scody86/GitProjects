// Scott Cody
// Advanced C# Thu 8 - 11
// Module 07 Inheritance

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_Inheritance
{
    public class Mamal
    {
         public bool hasBackbone = true;
         public bool hasHair = true;
         public bool canBreath = true;
    }
    public class Feline : Mamal
    {
        public bool hasClaws = true;
    }

    public class Dog : Mamal
    {
        public bool canBark = true;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Feline cFeline = new Feline();
            Dog cdog = new Dog();
        }
    }
}

/*
 * Module07 assignment question:
 * a. Any problems with the coding assignment?
 *    I did not have any problems with the assignment
 * b. What was your score in the Software Development Fundamentals assessment? 
 *    I earned a 100% on the first try! It only had one question though...
 * c. What was the most difficult concept?
 *    The most difficult part was using the delegates. The syntax will be hard 
 *    to remember but I understand its purpose.
*/
