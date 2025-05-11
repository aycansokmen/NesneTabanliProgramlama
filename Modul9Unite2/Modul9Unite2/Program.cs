using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9Unite2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayi = new ArrayList();
            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < 10; i++)
            {
                sayi.Add(num[i]);
            }
            sayi.RemoveAt(1);
            sayi.Insert(4, 2345);
            for (int i = 0; i < sayi.Count; i++)
            {
                Console.WriteLine(sayi[i]);
            }
        }
    }
}
