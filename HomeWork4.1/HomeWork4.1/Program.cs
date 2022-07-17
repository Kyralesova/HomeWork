using System;

namespace HomeWork4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int line = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int column = int.Parse(Console.ReadLine());

            int[,] matrix = new int[line, column];

            Random r = new Random();

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(10);
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех чисел = {sum}");

            Console.ReadKey();
        }
    }
}
