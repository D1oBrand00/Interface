using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myob = new MyClass();
            myob.Show();
            IMyInterfaceA interA = new MyClass();
            interA.Show();
            IMyInterfaceB interB = new MyClass();
            interB.Show();
            Console.Read();
        }
    }
}
