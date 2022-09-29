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

            Vector v1 = new Vector();
            v1.SetX(1.0f);
            v1.SetY(1.0f);
            v1.SetZ(1.0f);
            Console.WriteLine("向量的x： {0}", v1.GetX());
            Console.WriteLine("向量的y： {0}", v1.GetY());
            Console.WriteLine("向量的z： {0}", v1.GetZ());
            Console.WriteLine("向量的长度： {0}", v1.Length());

           
            Console.ReadKey();
        }
    }
}
