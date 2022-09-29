using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student();

            s.Code = "1001";
            s.Name = "ZARD";
            s.Age = 21;

            Console.WriteLine("Student Info: {0}", s);
            
            Console.ReadKey();

        }
    
    }
}
