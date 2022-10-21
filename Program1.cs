using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Переменная x может принимать такие значения: -1<=x<=2, x=10");
        Console.Write("Введите x: ");
        var x = double.Parse(Console.ReadLine());
        double y;
        if (-1 <= x && x <= 2)
            y = 2 * Math.Sqrt(Math.Abs(x + 1));
        else
            y = 2 * Math.Tan(Math.Pow(Math.E, x)) - Math.Sin(x);
        Console.WriteLine("y = {0}", y);
        Console.ReadKey();
    }
}
