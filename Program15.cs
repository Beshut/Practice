using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите текст: ");
        string str = Console.ReadLine();
        var str2 = str.Replace(" ", "");
        Console.WriteLine();
        Console.WriteLine("Текст без пробелов: {0}", str2);
        Console.ReadKey();
    }
}
