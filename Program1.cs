using System;
class Program
{
    static void Main(string[] args)
    {
        int n = 1;
        double Proc;
        double Dop = 0;
        double Fin = 0;
        int j = 1;
        int Fact = 1;
        int k1 = 1;
        int n1 = 0;

        for (int i = 0; i < n; i++)
        {
            while (j <= k1)
            {
                Fact = Fact * j;
                j = j + 1;
            }

            Proc = Math.Pow(-1, i) * Math.Pow(Math.PI / 3, 2 * i + 1) / Fact;
            k1++;
            Dop = Math.Abs(Proc);
            if (Dop < 0.00005)
            {
                n1 = i;
                n = i;
            }
            if (Dop > 0.00005)
                n++;
        }

        Proc = 0;
        j = 1;
        k1 = 1;
        Fact = 1;

        for (int i = 0; i < n; i++)
        {
            while (j <= k1)
            {
                Fact = Fact * j;
                j = j + 1;
            }
            Proc = Math.Pow(-1, i) * Math.Pow(Math.PI / 3, 2 * i + 1) / Fact;
            Fin = Fin + Proc;
            k1 = k1 + 2;
        }

        Console.WriteLine("sin(п/3) = s = {0}",Fin);
        Console.ReadKey();
    }
}
