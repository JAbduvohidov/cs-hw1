using System;

namespace firstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задание 0");
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine("будьте осторожны, вам придется что-то вводить...");

            Console.WriteLine("задание 1");
            double a, b;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"результат = {Math.Sqrt(a * b)}");
            Console.WriteLine();

            Console.WriteLine("задание 2");
            double A, B, C, AC, BC;
            Console.Write("A = ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write("B = ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.Write("C = ");
            C = Convert.ToDouble(Console.ReadLine());
            AC = Math.Abs(A + C);
            BC = Math.Abs(B + C);
            Console.WriteLine($"AC={AC}\nBC={BC}\n\nAC+BC={AC + BC}");
            Console.WriteLine();

            Console.WriteLine("задание 3");
            double x1, x2, y1, y2;
            Console.Write("x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"результат = {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))}");
            Console.WriteLine();

            Console.WriteLine("задание 4");
            int number;
            Console.Write("Число: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Результат: {number % 10}{number / 10}");
            Console.WriteLine();

            Console.WriteLine("задание 5");
            int seconds;
            Console.Write("N = ");
            seconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Результат: {seconds / 60}");
            Console.WriteLine();

            Console.WriteLine("задание 6");
            int K;
            Console.Write("K = ");
            K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Номер дня недели: {K % 7}");
        }
    }
}
