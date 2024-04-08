using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class MyClass : IMyInterfaceA, IMyInterfaceB
    {
        public void Show()
        {
            Console.WriteLine("MyClass.Shjow() is completed.");
            //Console.WriteLine("MyClass.Shjow() - Завершено.");
        }
        void IMyInterfaceA.Show()
        {
            Console.WriteLine("Explicit interface ")
        }
    }
}
