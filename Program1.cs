using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("a= ");
        var a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        var b = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:N3}/{1:N3}={2:N3}", a, b, a / b);
        Console.ReadKey();
    }
}
