using System;

namespace LR1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x, y, Fy;

            Console.Write("Введите a > ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите b > ");
            b = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите x > ");
            x = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите y > ");
            y = Convert.ToSingle(Console.ReadLine());

            Fy = a * 1 + Math.Abs(b - Math.Sin(a * 1)) * x + y;
            Console.WriteLine("\n\n");

            Console.WriteLine("Денежный формат {0:C} \n", Fy);
            Console.WriteLine("Экспоненциальный формат {0:E} \n", Fy);
            Console.WriteLine("Формат с фиксированной запятой {0:F3} \n", Fy);
            Console.WriteLine("Общий формат  {0:G} \n", Fy);
            Console.WriteLine("Числовой формат {0:N} \n", Fy);
            Console.WriteLine("Процентный формат {0:P} \n", Fy); 
        }
    }
}
