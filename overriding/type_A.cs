using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.overriding
{
    internal class type_A
    {
        public int A {get; set;}
        public type_A(int _A)
        {
            A = _A;
        }

        public void Fun_1()
        {
            Console.WriteLine("Base class");
        }

        public void Fun_2() 
        {
            Console.WriteLine($"Type_A variable equal {A}");
        }

        public virtual void Fun_3()
        {
            Console.WriteLine("This function special for class type_A");
        }
    }
}
