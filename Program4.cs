using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 1;
        double y = Math.Sqrt(x * Math.Sin(2 * x) + Math.Pow(Math.E, -2 * x)) * (x + Math.Log(Math.Sqrt(x)));
        Console.WriteLine("y = {0}", y);
        Console.ReadKey();
    }
}
