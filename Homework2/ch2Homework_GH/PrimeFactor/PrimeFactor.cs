using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor
{
    class PrimeFactor
    {
        static void Main(string[] args)
        {
            int num =2;
            bool isNum = false;
            Console.Write("请输入一个整数：");
            string input = Console.ReadLine();
            while (!int.TryParse(input, out num) && num >= 2)
            {
                Console.WriteLine("请重新输入大于1的数字：");
                input = Console.ReadLine();
            }
            //另一种获得输入的方法
            //while (!isNum)
            //{
            //    try
            //    {
            //        num = Convert.ToInt32(Console.ReadLine());
            //        if (num > 1)
            //        {
            //            isNum = true;
            //            break;
            //        }
            //    }
            //    catch
            //    {
            //    }     
            //    Console.Write("请输入一个大于1整数:");
            //}
            Console.WriteLine("该数的所有质因素为：");
            while (num != 1)
            {
                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        num /= i;
                        Console.Write("{0}\t", i);
                        break;
                    }
                }
            }


            Console.Read();
        }
    }
}
