using System;

namespace Discrimino
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine()) ;
            double c = double.Parse(Console.ReadLine());
            double p = 2;
            if (!(a == 0))
            {
                double d = (Math.Pow(b, p)) - (4 * a * c);
                if (d >= 0)
                {
                    if (d > 0)
                    {
                        Console.WriteLine("Квадратное уравнение имеет два различных действительных корня: " +
                      "x1 = {0:0.00}, x2 = {1:0.00}.", (((-b) + Math.Sqrt(d)) / (2 * a)), (((-b) - Math.Sqrt(d)) / (2 * a)));
                    }
                    else Console.WriteLine("Квадратное уравнение имеет два совпадающих корня: x1 = x2 = {0}.", ((-b) / (2*a)));
                }
                else Console.WriteLine("Квадратное уравнение не имеет действительных корней.");
            }
            else Console.WriteLine("'а' не может быть равно 0");
            
            Console.ReadLine();
        }
    }
}
