using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reqem daxil edin:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDaxil edilmis reqem tekdirmi ?");
            if (num.IsOdd()) { Console.WriteLine("Beli\n"); } else { Console.WriteLine("Xeyr\n"); }
            Console.WriteLine("Daxil edilmis reqm cutdurmu ?");
            if (num.IsEven()) { Console.WriteLine("Beli\n"); } else { Console.WriteLine("Xeyr\n"); }
            Console.WriteLine("=================================================================================\n");
            Console.WriteLine("Soz daxil edin:");

            string str = Console.ReadLine();
            Console.WriteLine("\nTerkibinde reqem var ?");
            if (str.IsContainsDigit()) { Console.WriteLine("Beli\n"); } else { Console.WriteLine("Xeyr\n"); }
            Console.WriteLine("Capitalize olunmus :");
            Console.WriteLine(str.ToCapitalize());

            Console.WriteLine("\nSozde verilmis deyeri axtar:");
            Console.WriteLine("Deyer daxil et:");
            char test = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            foreach(var item in str.GetValueIndexes(test)) { 
            Console.WriteLine(item);
            }

        }
    }
}
