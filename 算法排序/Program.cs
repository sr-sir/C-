using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace 算法排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 25, 1, 5, 2, 9, 11, 2, 4 };
            //maopao(a);
            //xuanze(a);
            charu(a);
        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="a"></param>
        private static void maopao(int[] a)
        {
            bool sign = false;
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        outPut(a, "交换之前");
                        int b = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = b;
                        sign = true;
                        outPut(a, "交换之后");
                        Console.WriteLine();
                    }
                }
                if (!sign) break;
            }
            Console.WriteLine();
            outPut(a, "最后数据");
            Console.ReadKey();
        }

        private static void outPut(int[] a, string str)
        {
            Console.WriteLine(str + ":");
            foreach (var item in a)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="a"></param>
        private static void xuanze(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int sign = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[sign] > a[j])
                    {
                        sign = j;
                    }
                }
                if (sign != i)
                {
                    outPut(a, "交换之前");
                    int b = a[i];
                    a[i] = a[sign];
                    a[sign] = b;
                    outPut(a, "交换之后");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            outPut(a, "最后数据");
            Console.ReadKey();
        }

        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="a"></param>
        private static void charu(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int d = a[i];
                bool result = true;//标记已经比较到第一个位置
                for (int j = i - 1; j >= 0; j--)
                {
                    if (a[j] > d)
                    {
                        outPut(a, "移动之前");
                        a[j + 1] = a[j];
                        outPut(a, "移动之后");
                        Console.WriteLine();
                    }
                    else
                    {
                        outPut(a, "移动之前");
                        a[j + 1] = d;
                        result = false;
                        outPut(a, "插入之后");
                        break;
                    }
                }
                if (result)
                {
                    outPut(a, "插入之前");
                    a[0] = d;
                    outPut(a, "插入之后");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            outPut(a, "最后数据");
            Console.ReadKey();
        }
    }
}
