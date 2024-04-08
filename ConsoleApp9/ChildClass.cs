using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class ChildClass : MyClass
    {
        public override void Show2()
        {
            Console.WriteLine("Child is completing - Show2().");
        }
    }
}
