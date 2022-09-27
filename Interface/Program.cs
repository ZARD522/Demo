using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program: IMyInterface1//接口使用 interface 关键字声明，它与类的声明类似。接口声明默认是 public 的
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.Method();
            Console.ReadKey();
        }
        public void Method()
        {
            Console.WriteLine("Method() 调用.");
        }
    }
}
