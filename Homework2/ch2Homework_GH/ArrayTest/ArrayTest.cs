using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class ArrayTest
    {
        static void Main(string[] args)
        {
            int length = 0;
            double average, max = 0, min = 10000;
            double sum =0 ;
            Console.WriteLine("请输入一个正确的数组长度：");
            length = Int32.Parse(Console.ReadLine());
 
            double[] array = new double[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("请输入数组的第{0}个值：", i+1);
                bool isValue = false;
                while (!isValue)
                {
                    try
                    {
                        array[i] = Double.Parse(Console.ReadLine());
                        isValue = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("请重新输入数组的第{0}个值：", i+1);
                        //array[i] = Double.Parse(Console.ReadLine());
                    }
                }
            }          
            calculator(array, length, out min, out max, out average, out sum);

            Console.WriteLine("数组的和：{0}\n平均值：{1}\n最大值：{2}\n最小值：{3}\n", sum, average, max, min);

            Console.Read();

        }
        public static void calculator(double[] array, int length, out double min, out double max, out double average,out double sum)
        {
            sum = 0;
            min = 10000;
            max = 0;
            for(int i = 0; i < length; i++)
            {
                sum += array[i];
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            average = sum / length;

        }
    }
}
