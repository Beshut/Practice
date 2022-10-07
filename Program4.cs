using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("a= ");
        var a = int.Parse(Console.ReadLine());
        Console.Write("b= ");
        var b = int.Parse(Console.ReadLine());
        Console.Write("c= ");
        var c = int.Parse(Console.ReadLine());
        double f1 = a / Math.PI;
        double f2 = c / Math.E;
        double F1 = Math.Round(f1, 4, MidpointRounding.AwayFromZero);
        double F2 = Math.Round(f2, 3, MidpointRounding.AwayFromZero);
        double pi = Math.Round(Math.PI, 4, MidpointRounding.AwayFromZero);
        double e = Math.Round(Math.E, 3, MidpointRounding.AwayFromZero);
        Console.WriteLine("a/PI={0}/{1}={2:N4}   a+b+c={3}+{4}+{5}={6}   c/E={7}/{8}={9}", a, pi, F1, a, b, c, a+b+c, c, e, F2);
        Console.ReadKey();
    }
}
