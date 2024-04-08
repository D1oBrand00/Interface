using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer2
{
    /// <summary>
    /// Производный класс-потомок, который наследуется от MyClass
    /// </summary>
    class ChildClass : MyClass
    {
        /// <summary>
        /// Переопределённый метод вывода информации об объекте
        /// </summary>
        public override void Show2()
        {
            Console.WriteLine("Child is completing - Show2()");
        }
    }
}
