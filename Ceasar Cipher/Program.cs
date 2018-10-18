using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceasar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a shift amount");
            int shift = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a string");

            char[] inputArray = Console.ReadLine().ToCharArray();
            List<int> shifted = new List<int>();

            foreach (var i in inputArray)
            {
                Convert.ToDecimal((int)i);
                if (i == 32)
                {
                    shifted.Add(0000);
                    continue;
                }
                if (i >= 48 && i <= 57)
                {
                    shifted.Add(i + shift);
                }
                else if (i >= 65 && i <= 90)
                {
                    shifted.Add(i + shift);
                }
                else if (i >= 97 && i <= 122)
                {
                    shifted.Add(i + shift);
                }
            }
            Console.WriteLine();
            foreach (var j in shifted)
            {
                if (j == 0000)
                {
                    Console.Write("");
                }
                Console.Write((char)j);
            }
            Console.WriteLine();
        }
    }
}
