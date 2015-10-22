using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int iter = 0;
            int num;
            int count = 0;
            string[] sName = new string[100];
            string buffer;
            Console.WriteLine("Пожалуйста, укажите что вы хотите сделать.");
            while (iter != 7)
            {
                Console.WriteLine("\n1-Добавить нового человека. \n 2-Изменить фамилию сохраненного в списке сотрудника. \n 3-Удалить сотрудника из списка \n 4-Вывод списка сотрдников на экран \n 5-Считать список из заданного файла \n 6-Сохранить текущий список в файл \n 7-Завершить работу программы \n не вводите буквы для вашей собственной безопасности");
                iter = Int32.Parse(Console.ReadLine());
                switch (iter)
                {
                    case 1:
                        Console.WriteLine("Введите фамилию нового человека.");
                        sName[count] = Console.ReadLine();
                        count += 1;
                        continue;

                    case 2:
                        Console.WriteLine("Введите номер человека, фамилию которого вы хотите изменить.");
                        num = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Введите новую фамилию заданному сотруднику");
                        sName[num - 1] = Console.ReadLine();
                        continue;

                    case 3:
                        Console.WriteLine("Введите номер удаляемого человека");
                        num = Int32.Parse(Console.ReadLine());
                        for (int i = num; i < count - 1; i++)
                            sName[i] = sName[i + 1];
                        count -= 1;
                        continue;

                    case 4:
                        for (int i = 0; i < count; i++)
                            Console.Write("{0}\n", sName[i]);
                        continue;

                    case 5:
                        Console.WriteLine("Внимание! Все текущие преобразования будут заменены на список сотрудников сохраненный в файле. Продолжить?(1-да 0 -нет)");
                        num = Int32.Parse(Console.ReadLine());
                        StreamReader reader = new StreamReader(@"H:\file.txt");
                        if (num == 1)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                sName[count] = "";
                            }
                            count = 0;
                            buffer = "";
                            while (buffer != null)
                            {
                                buffer = reader.ReadLine();
                                sName[count] = buffer;
                                count += 1;
                            }
                            count -= 1;
                        }
                        reader.Close();
                        continue;

                    case 6:
                        Console.WriteLine("Внимание! Все текущие преобразования заменят список сотрудников сохраненный в файле. Продолжить?(1-да 0 -нет)");
                        num = Int32.Parse(Console.ReadLine());
                        StreamWriter writer = new StreamWriter(@"H:\file.txt");
                        if (num == 1)
                        {
                            for (int i = 0; i < count; i++)
                                writer.WriteLine(sName[i]);
                        }
                        writer.Close();
                        continue;

                    case 7:
                        Console.WriteLine("До новых встреч.");
                        continue;

                    default:
                        Console.WriteLine("Входные данные не верны.");
                        continue;
                }
            }
            Console.Read();
        }
    }
}
