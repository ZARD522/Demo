using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Succeed
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            dc.setHeight(5);
            dc.setWidth(4);
            Console.WriteLine("总面积： {0}", dc.getArea());
            Console.ReadKey();
        }
    }
}
