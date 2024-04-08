using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer4
{
    /// <summary>
    /// Пример 4. Создание нескольких интерфейсов, множественное наследование интерфейсов и их реализация.
    /// </summary>
    class MyClass : IMyInterfaceA, IMyInterfaceB
    {
        public void Show()
        {
            Console.WriteLine("MyClass.Show() is completed");
        }
        void IMyInterfaceA.Show()
        {
            Console.WriteLine("Explicit interface implementation. IMyInterfaceA.Show()"); //явная реализация интерфейса
        }
        void IMyInterfaceB.Show()
        {
            Console.WriteLine("Explicit interface implementation. IMyInterfaceB.Show()"); 
        }
    }
}
