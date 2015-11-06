using System;

namespace ConsoleApplication1
{
    public delegate TResult Func<T, TResult>(T t);

    class Delegate
    {
        static int factorial(int input)
      {
         int f = 1;
            if (input == 0 || input == 1)
                return 1;
            for (int i = 1; i < input + 1; i++)
                f = f * i;
           return f;
        }

        static void Main()
        {
            int value;
            while (true)
            {
                Console.WriteLine("Введите число");
                value = Int32.Parse(Console.ReadLine());
                if (value < 0)
                {
                    Console.WriteLine("Нельзя брать факториал от отрицательного числа. введите заново.");
                    continue;
                }
                break;
            }
            Func<int, int> f = factorial;
            int result = f(value);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
