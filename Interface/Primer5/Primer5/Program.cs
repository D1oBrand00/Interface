using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myob = new MyClass();
            InterfaceA obA = myob;
            obA.ShowInterfaceA();
            InterfaceB obB = myob;
            obB.ShowInterfaceB();
            InterfaceC obC = myob;
            obC.ShowInterfaceC();
            Console.Read();
        }
    }
}
