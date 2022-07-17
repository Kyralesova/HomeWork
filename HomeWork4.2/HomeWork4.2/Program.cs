using System;

namespace HomeWork4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число, оно будет соответствовать длине вашей последовательности: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nВведите числo используя Enter: ");
                int userNumber = int.Parse(Console.ReadLine());
                A[i] = userNumber;
            }

            int min = int.MaxValue;

            for (int j = 0; j < A.Length; j++)
            {
                Console.Write($"{A[j]} ");
                if (A[j] < min) min = A[j];
            }
            Console.WriteLine($"Наименьшее число: {min}");

            Console.ReadKey();

        }
    }
}
