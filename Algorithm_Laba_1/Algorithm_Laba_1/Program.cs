using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = { 1, 3, 2, 5, 3, 4 };
            int size = table.Length;
            for (int k = 0; k < size; ++k)
            { Console.Write(table[k] + " "); }
            Console.Write("\n");
            maxNeighbour(table, size);
            for (int k = 0; k < size; k++)
            { Console.Write(table[k] + " "); }
            Console.Write("\n");    

        }

        static void maxNeighbour(int []table, int size)
        {
            int[] noninit = new int[size * 2]; 
            int q = 0;
            for (int i = 0; i < size; ++i)
            {
                while (q > 0)
                {
                    if (table[i] <= noninit[q - 1]) break;
                    table[noninit[q - 2]] = table[i];
                    q -= 2;
                }
                q += 2;
                noninit[q - 1] = table[i];
                noninit[q - 2] = i;

            }
            while (q > 0)
            {
                table[noninit[q - 2]] = 0;
                q -= 2;
            }
        }
    }
}
