using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _20201020
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random RND = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RND.Next(10,101);
                Console.WriteLine((i+1)+". elem tartalma: " + array[i]);
            }
            Console.ReadKey();
        }
    }
}
