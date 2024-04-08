using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer3
{
    /// <summary>
    /// Пример 3. Реализация концепции множественного наследования (класс реализует два интерфейса).
    /// </summary>
    class MyClass : IMyInterfaceA, IMyInterfaceB
    {
        public void ShowA()
        {
            Console.WriteLine("MyClass.ShowA() is competed");
        }
        public void ShowB()
        {
            Console.WriteLine("MyClass.ShowB() is competed");
        }
    }
}
