//Подключение библиотеки
using Tyuiu.LeshehvaIM.Sprint0.Task5.V0.Lib;

namespace Tyuiu.LeshehvaIM.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - В = " + DataService.Subtraction(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));

            //Пример разветляющейся структуры находятся в библиотеке классов в методе Division
            Console.WriteLine("A / B = " + DataService.Division(9, 3));
            Console.ReadKey();
        }
    }
}
