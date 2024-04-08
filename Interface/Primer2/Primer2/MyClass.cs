using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer2
{
    /// <summary>
    /// Абстрактный класс, в котором реализуется метод Show1()
    /// </summary>
    abstract class MyClass : IMyInterface
    {
        public void Show1()
        {
            //MyClass.Show1() реализован
            Console.WriteLine("MyClass.Show1() is emplemented");
        }
        public abstract void Show2();
    }
}
