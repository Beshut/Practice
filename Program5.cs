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
        double f1 = a * Math.PI;
        double f2 = b * Math.E;
        double f3 = c * Math.PI * Math.E;
        double F1 = Math.Round(f1, 4, MidpointRounding.AwayFromZero);
        double F2 = Math.Round(f2, 3, MidpointRounding.AwayFromZero);
        double F3 = Math.Round(f3, 2, MidpointRounding.AwayFromZero);
        double pi1 = Math.Round(Math.PI, 4, MidpointRounding.AwayFromZero);
        double e1 = Math.Round(Math.E, 3, MidpointRounding.AwayFromZero);
        double pi2 = Math.Round(Math.PI, 2, MidpointRounding.AwayFromZero); ;
        double e2 = Math.Round(Math.E, 2, MidpointRounding.AwayFromZero); ;
        Console.WriteLine("a*PI: {0}*{1}={2:N4}  b*E: {3}*{4}={5:N3}   c*PI*E: {6}*{7}*{8}={9}", a, pi1, F1, b, e1, F2, c, pi2, e2, F3);
    }
}
