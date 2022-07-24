// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            int m = new Random().Next(0, 5),
                n = new Random().Next(0, 5);    
            

            int result = FunctionAckerman(m, n);
            Console.WriteLine();
            Console.WriteLine($"m = {m}; n = {n} -> A(m,n) = {result}");

        }

        public static int FunctionAckerman(int a, int b)
        {
              
            if (a == 0)
            {
                return b + 1;
            }
            else if (a > 0 && b == 0)
            {
                return FunctionAckerman(a - 1, 1);
            }
            else 
            {
                return FunctionAckerman(a - 1, FunctionAckerman(a, b - 1));
            }
        }  
    }
}     




