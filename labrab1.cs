using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            double[,] mn1 = new double[3, 3];
            double[,] mn2 = new double[3, 3];
            double[,] mn3 = new double[3, 3];
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j ++)
                {
                    mn1[i,j]=rand.Next(10);
                    mn2[i,j]=rand.Next(10);
                }
            }

            Console.WriteLine("Введите число");
            value = Int32.Parse(Console.ReadLine());

            Console.Write("Матрица 1\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}", mn1[i, j] + " ");
                }
                Console.Write("\n");
            }

            Console.Write("\nМатрица 2\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}", mn2[i, j] + "");
                }
                Console.Write("\n");
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mn1[i,j]=mn1[i,j]*value;
                    mn2[i,j]=mn2[i,j]/value;
                    mn3[i,j]=mn1[i,j]+mn2[i,j];
                }
            }

            Console.Write("\nМатрица 3\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}",mn3[i,j]+" ");
                }
                Console.Write("\n");
            }
                Console.Read();
        }
    }
}
