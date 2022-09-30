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
            Console.WriteLine("Имя: {0} Возраст: {2} Рост: {1}м", name, height, age);//вывод на экран имени,возраста и роста человека
            Console.ReadKey();//ожидание нажатия клавиши
        }
    }
