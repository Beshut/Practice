using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");//вывод на экран сообщения пользователю
            string name = Console.ReadLine();//обьявление переменной, присваивание значения типа string, введение значения переменной пользователем
            Console.Write("Введите возраст: ");//вывод на экран сообщения пользователю
            int age = Convert.ToInt32(Console.ReadLine());//обьявление переменной, присваивание значения типа int, преобразует к типу int
            Console.Write("Введите рост: ");//вывод на экран сообщения пользователю
            double height = Convert.ToDouble(Console.ReadLine());//обьявление переменной, присваивание значения типа double, преобразует к типу double
            Console.Write("Введите размер зарплаты: ");//вывод на экран сообщения пользователю
            decimal salary = Convert.ToDecimal(Console.ReadLine());//обьявление переменной, присваивание значения типа decimal, преобразует к типу decimal
            Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height} м Зарплата: {salary}$");//вывод на экран имени, возраста, роста, зарплаты
            Console.ReadKey();//ожидание нажатия клавиши
        }
    }
}
