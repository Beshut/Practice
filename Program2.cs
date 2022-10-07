using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("a= ");
        var a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        var b = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:N2}/{1:N2}={2:N2}", b, a, b / a);
        Console.ReadKey();
    }
}
