// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите произвольное натуральное число M: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите натуральное число N больше M: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.Write($"M = {m}; N = {n}. -> ");
                SumNumbers(m, n);

            }
            catch
            {
                Console.WriteLine("Введите числа согласно инструкции, иначе программа не запустится!");
            }
        }

        public static void SumNumbers(int a, int b)
        {
            int sum = 0;
            while (a > 0 && a <= b)
            {
                sum += a;
                a++;
            }
            Console.Write($"{sum} ");    
        }
    }
}     



