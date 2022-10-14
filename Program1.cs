using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите четырëхзначное число: ");
        var A = int.Parse(Console.ReadLine());
        int a = A / 1000;
        int b = (A / 100) - (a * 10);
        int c = (A / 10) - (a * 100 + b * 10);
        int d = A - a * 1000 - b * 100 - c * 10;
        Console.WriteLine("({0})({1})({2})({3})", b, a, d, c);
        Console.ReadKey();
    }
}
