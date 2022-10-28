using System;

class Program
{
    static void Main(string[] args)
    {
     double a,b,i1,i3;
     int j = 0;
     for (int i = 100; i<1000; i++)
     {
      i1 = i/100;
      i3 = i/10;
      a = Math.Round(i1);
      b = i-Math.Round(i3)*10;
      if (a==b)
       Console.WriteLine(i);
       }
        Console.ReadKey();
    }
}
