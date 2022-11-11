using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите до какого члена суммы проводятся вычисления: ");
        var n = int.Parse(Console.ReadLine());
        Console.Write("Введите x: ");
        var x = int.Parse(Console.ReadLine());
        double Proc;
        double Fin = 0;
        int j = 1;
        int Fact = 1;
        int[] mas = new int[n];
        for (int k = 0; k < n; k++)
        {
            while (j <= k)
            {
                Fact = Fact * j;
                j = j + 1;
            }
            mas[k] = Fact;
            Fact = 1;
            j = 1;
        }

        for (int i = 0; i < n; i++)
        {
            Proc = ((Math.Pow(i, 2) + 1) / mas[i]) * Math.Pow((double)x / 2, i);
            Fin = Fin + Proc;
        }

        Console.WriteLine("Сумма {0} членов: {1}", n, Fin);
        Console.ReadKey();
    }
}
