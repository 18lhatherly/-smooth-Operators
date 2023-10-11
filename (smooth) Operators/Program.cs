using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _smooth__Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //be familiar with and be able to use:



            //------------------------------------addition------------------------------------
            
            int num1 = 15;
            int num2 = 75;
            int num3 = num1 + num2; //adding two integers
            Console.WriteLine(num3);

            double dnum1 = 5.4323423;
            double dnum2 = 29342834;
            double dnum3 = dnum1 + dnum2;
            Console.WriteLine(dnum3); //adding two real numbers

            double dnum4 = dnum2 + num1; //adding two different numerical types
            Console.WriteLine(dnum4);
            //num1 = num2 + dnum4; - this will not work because result cannot be stored in int as is real



            //------------------------------------subtraction------------------------------------
            
            num3 = num1 - num2; //subtracting two integers
            Console.WriteLine(num3);

            dnum3 = dnum1 - dnum2;
            Console.WriteLine(dnum3); //subtracting two real numbers

            dnum4 = dnum2 - num1; //subtracting two different numerical types
            Console.WriteLine(dnum4);
            //num1 = num2 - dnum4; - not an integer!



            //------------------------------------multiplication------------------------------------
           
            num3 = num1 * num2; //multiplying two integers
            Console.WriteLine(num3);

            dnum3 = dnum1 * dnum2;
            Console.WriteLine(dnum3); //multiplying two real numbers

            dnum4 = dnum2 * num1; //multiplying two different numerical types
            Console.WriteLine(dnum4);
            //num1 = num2 * dnum4; - not an integer!



            //-----------real / float division and integer division, including remainders-----------

            num1 = 7;
            num2 = 3;
            dnum3 = num1 / num2; //this is integer division as we are dividing integers
            Console.WriteLine(dnum3); //2

            dnum1 = 7;
            dnum2 = 3;
            dnum3 = dnum1 / dnum2; //this is not integer division as we are dividing doubles
            Console.WriteLine(dnum3); //2.33333...
            //type of division depends on the data type

            //the symbol for MOD is %
            Console.WriteLine(35 % 6);

            //------------------------------------exponentation------------------------------------

            //use the Math class
            Console.WriteLine(Math.Pow(2, 3)); //base then power - this returns a double
            //int result = Math.Pow(7, 8); - this would need to be casted first to an int
            int result = Convert.ToInt32(Math.Pow(7, 8));
            Console.WriteLine(result);

            int baseNum = 5;
            int exponent = 12;
            double dResult = Math.Pow(baseNum, exponent);
            Console.WriteLine(dResult);

            num1 = 4;
            Console.WriteLine(Math.Sqrt(num1));


            //---------------------------------------rounding---------------------------------------

            Console.WriteLine(Math.Round(1.234, 2)); //this will round 2 digits after the decimal point
            Console.WriteLine(Math.Round(1.234, 0)); //this will round to the nearest integer
            Console.WriteLine(Math.Round(1.6, 0)); //this will round to the nearest integer
            Console.WriteLine(Math.Round(2.5, 0)); //0.5 rounds to the nearest even integer so will still be 2
            Console.WriteLine(Math.Ceiling(2.5)); //this always rounds up (will equal 3)
            Console.WriteLine(Math.Floor(2.5)); //this always rounds down (will equal 2)

            //--------------------------------------truncation--------------------------------------

            //takes away the decimal point from a number
            Console.WriteLine(Math.Truncate(5.23543));
            Console.WriteLine(Math.Truncate(-3224.44323));

     
            Console.ReadLine();

        }
        
    }
}
