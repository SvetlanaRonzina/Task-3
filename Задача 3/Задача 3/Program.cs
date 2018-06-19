using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {

            double X, Y;
            Console.WriteLine("Введите координату Х точки U"); 
            while (!double.TryParse(Console.ReadLine(), out X))
                Console.WriteLine("Введите рациональное число");
            Console.WriteLine("Введите координату Y точки U");
            while (!double.TryParse(Console.ReadLine(), out Y))
                Console.WriteLine("Введите рациональное число");
            if ((X * X + Y * Y <= 1) && (Y >= Math.Abs(X)))
                Console.WriteLine("U=" + Math.Sqrt ( Math.Abs(X*X-1)) + " Точка входит в область");
            else
                Console.WriteLine("U=" + (X +Y) +" Точка не входит в заданую область");

            Console.ReadLine();

        }
    }
}
