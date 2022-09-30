using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom";//обьявление переменной и присваивание значения типа string
            int age = 34;//обьявление переменной и присваивание значения типа int
            double height = 1.7;//обьявление переменной и присваивание значения типа double
            Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}м");//вывод на экран имени,возраста и роста человека
            Console.ReadKey();//ожидание нажатия клавиши
        }
    }
}
