﻿namespace Fundamentals1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            StringOutputs();
            Arithmetic();
            Assignment();
            ComparisonAndConditionals();
    
        }

        private static void StringOutputs()
        {
            string semester = "I'm in Game 1377: Scripting for Game Designers.";
            Console.WriteLine(semester);
            Console.WriteLine(semester.ToUpper());
            Console.WriteLine(semester.ToLower());
            Console.WriteLine(semester.Substring(8));
            Console.WriteLine(semester.Substring(8, 3));
            Console.WriteLine(semester.Substring(8, 1));
        }

        private static void Arithmetic()
        {
            int intInput1 = Convert.ToInt32(Console.ReadLine());
            int intInput2 = Convert.ToInt32(Console.ReadLine());
            float quotient = intInput1 / intInput2;
            Console.WriteLine("The sum is " + (intInput1 + intInput2));
            Console.WriteLine("The difference is " + (intInput1 - intInput2));
            Console.WriteLine("The product is " + (intInput1 *  intInput2));
            Console.WriteLine("The quotient is " + (quotient));
            Console.WriteLine("The modulo is " + (intInput1 % intInput2));

        }

        private static void Assignment()
        {
            float? floatInput1 = Convert.ToSingle(Console.ReadLine());
            float? floatInput2 = Convert.ToSingle(Console.ReadLine());
            floatInput2 += floatInput1;
            Console.WriteLine(floatInput2);
            floatInput2 -= floatInput1;
            Console.WriteLine(floatInput2);
            floatInput2 *= floatInput1;
            Console.WriteLine(floatInput2);
            floatInput2 /= floatInput1;
            Console.WriteLine(floatInput2);
        }

        private static void ComparisonAndConditionals()
        {
            int intInput1 = Convert.ToInt32(Console.ReadLine());
            int intInput2 = Convert.ToInt32(Console.ReadLine());

            if(intInput1 == intInput2)
            {
                Console.WriteLine("intInput1 and intInput2 are equal");
            }
            else if (intInput1 < intInput2)
            {
                Console.WriteLine("intInput1 is less than intInput2");
            }
            else if (intInput1 > intInput2)
            {
                Console.WriteLine("intInput1 is more than intInput2");
            }

        }
    }
}
