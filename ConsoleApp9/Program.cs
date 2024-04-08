using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Изучения интерфейсов.Пример2***\n");
            //MyClass is abstract now
            //MyClass myClassOb = new MyClass();
            MyClass myOb = new ChildClass();
            myOb.Show1();
            myOb.Show2();
            Console.ReadKey();
        }
    }
}
