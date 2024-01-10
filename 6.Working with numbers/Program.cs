using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _6.Working_with_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //you can just print out numbers as below
            Console.WriteLine(5);
            //you can also use operators right in the writeline method ie +- * /
            Console.WriteLine(6 + 5);
            // modulo operator, to get the remainder of division, use %
            Console.WriteLine(5 % 2); 
            //BODMAS still applies, 4+2*3 gets 10, use brackets to change the order
            Console.WriteLine(4 + 2 * 3); 
            // whatever you do just with integers, you get an integer back
            Console.WriteLine(5 / 2); //you get 2, not 2.5!
            //if you use a decimal and an integer you always get a double 
            Console.WriteLine(5 / 2.0);//you get 2.5
            //can also give a numer to a varibale
            int num = 6; 
            // can increment or decrement by 1
            num++;
            Console.WriteLine(num); //calling methods eg the Math method, Abs means Absolute /
            //u will always get the posive number
            Console.WriteLine(Math.Abs(-40));
            //to raise to powers
            Console.WriteLine(Math.Pow(2, 2));
        }
    }
}
