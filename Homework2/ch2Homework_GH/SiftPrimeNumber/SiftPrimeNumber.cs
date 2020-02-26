using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiftPrimeNumber
{
    class SiftPrimeNumber
    {
        static void Main(string[] args)
        {
            int[] array = new int[101];
            for(int i = 0; i < 101; i++)
            {
                array[i] = i;
            }
            for(int k = 2; k < 101; k++)
            {
                for (int j = k+1; j < 101; j++)
                {

                    if (array[j] == -1)
                    {
                        continue;
                    }
                    if (array[j] % k == 0)
                    {
                        array[j] = -1;
                    }
                }
            }
            for (int i = 2; i < 101; i++)
            {
                if (array[i] != -1)
                {
                    Console.Write(array[i] + "\t");
                }
            }

            Console.Read();
        }
    }
}
