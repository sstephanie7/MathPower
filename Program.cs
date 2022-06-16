using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double groundNumber = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(groundNumber, power));
        }
        static double MathPower(double groundNumber, double power)
        {
            double result = 0;

            result = Math.Pow(groundNumber, power);

            return result;
        }
    }
}
