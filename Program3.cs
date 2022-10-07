using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("x= ");
        var x = double.Parse(Console.ReadLine());
        Console.Write("y= ");
        var y = int.Parse(Console.ReadLine());
        double x1 = x * 3 / y;
        Console.WriteLine("Округленный с точностью до 4 знаков результат: {0}/{1}={2:N4}", x * 3, y, x1);
        Console.ReadKey();
    }
}
