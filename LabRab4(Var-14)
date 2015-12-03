using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab4_var14_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@"Datafiles\\in.txt");
                int MaxLength = lines[0].Length;
                string MaxLine = lines[0];
                foreach (string line in lines)
                {
                    if (line.Length > MaxLength)
                    {
                        MaxLength = line.Length;
                        MaxLine = line;
                    }
                }
                Console.WriteLine("Max line\n{0}\nLength - {1}", MaxLine, MaxLength);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            Console.Read();
        }
    }
}
