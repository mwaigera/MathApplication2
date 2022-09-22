using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary2;



namespace MathApplication2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare class from math library .dll

            Class1 math = new Class1();

            // declare variables and use methods from mathlibrary

            float Subtract = math.Subtract(5, 2);
            float multiply = math.Multiply(5, 2);
            float divide = math.Divide(5,2);
            
            float addition = math.Addition(5,2);

            Console.WriteLine("this application use function from maths.dll to do simple calculations");

            // print results on screen

            Console.WriteLine(Subtract);
            Console.WriteLine(multiply);
            Console.WriteLine(divide);
            Console.WriteLine(addition);



            Console.ReadLine();


        }
    }
}
