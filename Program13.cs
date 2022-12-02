using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размерность матрицы: ");
        int n = int.Parse(Console.ReadLine());
        int[,] mas = new int[n, n];
        int min = 0;
        double b;
        int a = 0;
        int[] arr = new int[n];
        int[] arr2 = new int[n];
        Console.WriteLine();
        Console.WriteLine("Заполните матрицу:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("mas[{0},{1}]: ", i + 1, j + 1);
                mas[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (j == 0)
                    min = Math.Min(mas[i, j], mas[i, j + 1]);
                min = Math.Min(min, mas[i, j + 1]);
            }
            arr[i] = min;

            b = (double)min / 2 - (int)min / 2;
            if (b == 0)
                arr2[i] = min;

            min = 0;
        }

        Console.WriteLine();

        for (int i = 0; i < n; i++)
            Console.WriteLine("Минимальное {0} строки: {1}", i + 1, arr[i]);

        Console.WriteLine();
        Console.Write("Среди минимальных чëтные: ");

        for (int i = 0; i < arr2.Length; i++)
        {
            if (arr2[i] != 0)
            {
                if (i == arr2.Length - 1)
                {
                    Console.Write("{0}\t", arr2[i]);
                }

                if (i != arr2.Length - 1)
                    Console.Write("{0}\t", arr2[i]);
                a = a + arr[i];
            }
        }

        if (a == 0)
            Console.WriteLine("Чëтных среди минимальных значений нет");
        Console.ReadKey();
    }
}
