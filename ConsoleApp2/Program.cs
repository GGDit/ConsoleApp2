using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 2, 4, 6, 8, 10 };

            int sum = 0;

            for (int i = 0; i < 5; i++) sum = sum + a[i];

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
