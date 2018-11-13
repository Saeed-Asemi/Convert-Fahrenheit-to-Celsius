using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Fahrenheit_to_Celsius
{
    class Program
    {
        static void convert(double a)
        {
            a -= 32;
            a = a / 1.8;
            Console.WriteLine($"The number in Celsius is {(int)a}");
        }
        static void Main(string[] args)
        {
            double f = 0;
            Console.Write("Please enter a number in Fahrenheit : ");
            f = double.Parse(Console.ReadLine());
            convert(f);
            Console.ReadKey();

        }
    }
}
