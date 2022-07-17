using System;

namespace HomeWork4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Диапазон чисел начинается от 0: ");
            int a = 0;
            Console.Write("\nВведите число, конец интервала: ");
            int n = int.Parse(Console.ReadLine());

            string W;

            Random r = new Random();

            int numbs = r.Next(a, n + 1);

            Console.WriteLine("Попробуйте угадать! Введите число, если надоело нажмите Enter: ");

            while (true)
            {
                W = Console.ReadLine();
                if (W == string.Empty)
                {
                    Console.WriteLine($"Загаданное число - {numbs}");
                    break;
                }
                int numbs2 = int.Parse(W);
                if (numbs2 == numbs)
                {
                    Console.WriteLine("Поздравляю! Вы угадали!");
                    break;
                }
                else if (numbs2 > numbs)
                {
                    Console.WriteLine("Введеное число меньше загаданного. Попробуйте еще раз");
                }
                else
                {
                    Console.WriteLine("Введеное число меньше загаданного. Попробуйте еще раз");
                }
            }
            Console.ReadKey();
        }
    }

}
