using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите координату x: ");
        var x = int.Parse(Console.ReadLine());
        Console.Write("Введите координату y: ");
        var y = int.Parse(Console.ReadLine());
        int xm = Math.Abs(x);
        int ym = Math.Abs(y);
        if (y == 0 || x == 0)
        {
            if (x == 0 && y <= 23 && y >= 0)
            {
                Console.WriteLine("На границе");
                return;
            }

            else
                Console.WriteLine("Нет");
        }

        if (y == ym && x != xm && y <= 23 && x >= -23 && ym>=xm)
        {
            if (ym == xm || y == 23)
                    Console.WriteLine("На границе");
            else
                Console.WriteLine("Да");
        }
        else
            Console.WriteLine("Нет");
        Console.ReadKey();
    }
}
