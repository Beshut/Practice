using System;

class Program
{
    static void Main(string[] args)
    {
     Console.Write("Введите число: ");
     var a = int.Parse(Console.ReadLine());
     double del;
     int j = 0;
     for (int i = 1; i<a; i++)
     {
      del = a%i;
      if (del == 0)
       j = j + i;
     }
     if (j == a)
      Console.WriteLine("Совершенное число");
     else
      Console.WriteLine("Не совершенное число");
        Console.ReadKey();
    }
}
