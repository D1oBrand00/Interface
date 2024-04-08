using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer1
{
    /// <summary>
    /// Класс, в котором реализуется интерфейс
    /// </summary>
    class MyClass : IMyInterface
    {
        /// <summary>
        /// Console.WriteLine("MyClass.Show() ");
        /// </summary>
        public void Show()
        {
            Console.WriteLine("MyClass.Show() is emplemented");
        }
    }
}
