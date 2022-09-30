using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom";//обьявление переменной и присваивание значения типа string
            int age = 33;//обьявление переменной и присваивание значения типа int
            bool isEmployed = false; //обьявление переменной и присваивание значения типа bool
            double weight = 78.65;//обьявление переменной и присваивание значения типа double
            Console.WriteLine($"Имя: {name}");//вывод имени на экран 
            Console.WriteLine($"Возраст: {age}");//вывод возраста на экран 
            Console.WriteLine($"Вес: {weight}"); //вывод веса на экран 
            Console.WriteLine($"Работает: {isEmployed}");//вывод трудоустроен ли человек на экран 
        }
    }
}
