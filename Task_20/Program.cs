using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус R = ");
            double R = Convert.ToDouble(Console.ReadLine());
            MyDeligate myDeligate = new MyDeligate(Dlina);
            Console.WriteLine($"Длинна окружности с радиусом R = {R} равна: {myDeligate?.Invoke(R)}");
            myDeligate += Ploshad;
            Console.WriteLine($"Площадь круга с радиусом R = {R} равна: {myDeligate?.Invoke(R)}");
            myDeligate += Obem;
            Console.WriteLine($"Обьем шара с радиусом R = {R} равен: {myDeligate?.Invoke(R)}");
            Console.ReadKey();
        }
        delegate double MyDeligate(double R);
        static double Dlina(double R)
        {
            return 2 * Math.PI * R;
        }
        static double Ploshad(double R)
        {
            return Math.PI * Math.Pow(R, 2);
        }
        static double Obem(double R)
        {
            return 4 / 3 * Math.PI * Math.Pow(R, 3);
        }
    }
}
