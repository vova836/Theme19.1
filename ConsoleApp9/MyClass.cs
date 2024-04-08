using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    abstract class MyClass : IMyInterface
    {
        public void Show1()
        {
            Console.WriteLine("MyClass.Show() is implemented");
        }

        public abstract void Show2();
    }
}
