using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите сторону a: ");
        var a = int.Parse(Console.ReadLine());
        Console.Write("Введите сторону b: ");
        var b = int.Parse(Console.ReadLine());
        Console.Write("Введите сторону c: ");
        var c = int.Parse(Console.ReadLine());
        if (a == b && b == c)
            Console.WriteLine("Треугольник равносторонний");
        else
            Console.WriteLine("Треугольник не равносторонний");
        Console.ReadKey();
    }
}
