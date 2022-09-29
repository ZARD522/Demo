using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IMyInterface1//接口使用 interface 关键字声明,通常接口命令以 I 字母开头
    {
        //接口的定义中不允许声明成员变量的的修饰符，接口成员都是公有的。
        void Method();
        void SetLength(double length);
        void SetWidth(double width);

    }


    interface ITestInterface:IMyInterface1
    {
        //double GetLength();
        //double GetWidth();
        double GetArea(double length,double width);
        
    }
}
