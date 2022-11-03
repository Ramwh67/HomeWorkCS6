using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            double[] findIntersectionPoint(double k1, double k2, double b1, double b2)
            {
               double[] array = new double[2];
               array[0] = (b2 - b1) / (k1 - k2);
               array[1] = k1 * array[0] + b1;
               return array;
            }

            Console.WriteLine("Даны два уравнения вида y=kx+b. Введите коэффициенты k и b:");
            Console.Write("k1 = ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b1 = ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("k2 = ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b2 = ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            if (k1 == k2 && b1 != b2) Console.WriteLine("Две прямые параллельны");
            else if (k1 / k2 == b1 / b2) Console.WriteLine("Две прямые совпадают");
            else
            {
                double[] IntersectionPoint = findIntersectionPoint(k1, k2, b1, b2);
                Console.WriteLine($"Точка пересечания двух прямых: ({IntersectionPoint[0]};{IntersectionPoint[1]})");
                
            }
        }
    }
}