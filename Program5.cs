using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");//вывод на экран сообщения пользователю
            string name = Console.ReadLine();//обьявление переменной, присваивание значения типа string, введение значения переменной пользователем
            Console.WriteLine($"Привет {name}");//вывод на экран приветствия пользователю
            Console.ReadKey();//ожидание нажатия клавиши
        }
    }
}
