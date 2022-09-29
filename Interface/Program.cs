using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program: ITestInterface//接口使用 interface 关键字声明，它与类的声明类似。接口声明默认是 public 的
    {
        static void Main(string[] args)
        {
            //double length,width;
            Program pr = new Program();
            pr.Method();
            pr.SetLength(5.0);
            pr.SetLength(6.0);
            Console.WriteLine("GetArea() 调用后："+pr.GetArea(6.0, 8.0));
            

            Console.ReadKey();
        }



        public void Method()//实现了接口  对应的方法也要实现

        {
            Console.WriteLine("Method() 调用.");
        }


        public void SetLength(double length)
        {
            
            double l=length;
            Console.WriteLine("SetLength() 调用.");
        }

        public void SetWidth(double width)
        {

            double w = width;
            Console.WriteLine("SetWidth() 调用.");
        }

      
        public double GetArea(double length, double width)
        {

            Console.WriteLine("GetArea() 调用.");
            return length * width;
            
        }

    }
}
