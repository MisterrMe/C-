using System;
namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[6] { 0, 2, 3, 2, 6, 4 };
            for (int i = 1; i < array.Length; i++)
            {
                double x = array[i];
                int j = i;
                while (x < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = x;
            }
            for (int j = 1; j < array.Length; j++)
            {
                Console.Write("{0}",array[j]);
            }
            Console.Read();
        }
    }
}
