using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0926
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组的三种命名方式
            int[] a = new int[10];
            int[] b = {1,2,10};
            int[] c = new int[] {1,9,5,2,4,7};
            //向数组a添加数据
            for (int i = 0; i < 10; i++)
            {
                //a[i] = i+1;
                //输入数据
                a[i]=Convert.ToInt32(Console.ReadLine());
            }


            //循环遍历数组a中的元素
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[{0}]={1}",i,a[i]);
            }

            //通foreach循环遍历数组a中的元素
            foreach (int temp in a)
            {
                Console.Write(temp);
            }


            Console.ReadKey();

        }

        //public void Swap(int a,int b)
        //{
        //    int min = a;
        //    if (a > b)
        //    {
        //        min = b;
        //    }
        //}

    }
}
