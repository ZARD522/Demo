using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入数据
            string str = Console.ReadLine();//输入一串数字以空格符隔开
            string[] strArray = str.Split(' ');//,用字符串数组去存储这些数字
            int[] intArray = new int[strArray.Length];//intArray数组的长度和strArray长度相一致
            for (int i = 0; i < strArray.Length; i++)
            {
                int number = Convert.ToInt32(strArray[i]);//字符型转换成整形
                intArray[i] = number;
            }

            // int[] intArray = new int[] { 22, 33, 11, 23, 12, 45, 76, 34 };
            BubbleSort(intArray);
            foreach(int temp in intArray)
            {
                Console.Write(temp + " ");
            }

            Console.ReadKey();

        }

        //冒泡排序
        static void BubbleSort(int[] intArray)
        {
            
            
            for (int i = 0; i < intArray.Length - 1; i++)//进行length-1轮比较
            {
                //进行比较
                for (int j = 0; j < intArray.Length - 1 - i; j++)
                {
                    if (intArray[j] > intArray[j + 1])//前面的数比后面的数字大就进行交换
                    {
                        int temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }

                }

            }
        }


    }
}

