using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_10_Ref_out_params
{
    internal class Program
    {
        public class Calculator
        {
            public void Kapinat(ref double x)
            {
                x = Math.Pow(x, -(1.0 / x));
            }
            public void Reizinasana(ref double x, ref double y)
            {
                x = x * y;
            }
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double x;
            Console.WriteLine("Ievadi x vērtību: ");
            x = double.Parse(Console.ReadLine());

            double y;
            Console.WriteLine("Ievadi y vērtību: ");
            y = double.Parse(Console.ReadLine());

            calculator.Kapinat(ref x);

            Console.WriteLine($"Rezultāts kapināšanā: {Math.Round(x, 2)}");

            calculator.Reizinasana(ref x, ref y);

            Console.WriteLine($"Rezultāts reizināšanā: {Math.Round(x, 2)}");


        }
    }
}