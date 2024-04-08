using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer5
{
    /// <summary>
    /// Интерфейс, реализующий множественное наследование
    /// </summary>
    interface InterfaceC: InterfaceA, InterfaceB
    {
        void ShowInterfaceC();
    }
}
