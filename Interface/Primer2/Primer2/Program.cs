using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myob = new ChildClass();
            myob.Show1();
            myob.Show2();
            Console.Read();
        }
    }
}
