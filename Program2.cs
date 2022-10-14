using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первую сторону: ");
        var a = int.Parse(Console.ReadLine());
        Console.Write("Введите вторую сторону: ");
        var b = int.Parse(Console.ReadLine());
        Console.Write("Введите угол между сторонами: ");
        var y_g = int.Parse(Console.ReadLine());
        double y_r = y_g * (Math.PI / 180);
        double S;
        if (y_g == 30)
            S = (0.5) * a * b * (0.5);
        else
            S = (0.5) * a * b * Math.Sin(y_r);
        Console.WriteLine("Площадь треугольника: {0}", S);
        Console.ReadKey();
    }
}
