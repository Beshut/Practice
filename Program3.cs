using System;

class Program
{
    static void Main(string[] args)
    {
        int V = 400;
        double s = 36;
        double s1 = 18;
        double S = s / 100;
        double S1 = s1 / 100;
        int Vsr = V / 2;
        double t = S / Vsr;
        double a = -(Math.Pow(V, 2)) / (2 * S);
        double V_18 = Math.Sqrt(2 * a * S1 + Math.Pow(V, 2));
        double S2 = 99 * S / 100;
        double V_99 = Math.Sqrt(2 * a * S2 + Math.Pow(V, 2));
        Console.WriteLine("Время движения: {0} с", t);
        Console.WriteLine("Ускорение: {0} м/с^2", a);
        Console.WriteLine("Скорость пули на глубине 18 см: {0} м/с", V_18);
        Console.WriteLine("Скорость пули после прохождения 99% пути: {0} м/с", V_99);
        Console.ReadKey();
    }
}
