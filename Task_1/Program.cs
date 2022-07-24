// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""
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
                PrintNumbers(m, n);

            }
            catch
            {
                Console.WriteLine("Введите числа согласно инструкции, иначе программа не запустится!");
            }
        }

        public static void PrintNumbers(int a, int b)
        {
            while (a > 0 && a <= b)
            {
                Console.Write($"{a} ");
                a++;
            }    
        }
    }
}     


