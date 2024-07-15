using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.overriding
{
    internal class type_B: type_A
    {
        public int B { get; set; }
        public type_B(int _A, int _B):base(_A)
        {
            B = _B;
        }

        // polymorphism via override using new keyword
        public new void Fun_2()
        {
            Console.WriteLine($"Type_B variable equal {B}");
        }

        // binding
        public override void Fun_3()
        {
            Console.WriteLine("This function special for class type_B");
        }
    }
}
