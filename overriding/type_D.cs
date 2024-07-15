using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.overriding
{
    internal class type_D: type_C
    {
        public int D { get; set; }
        public type_D(int _A, int _B, int _C, int _D): base(_A, _B, _C)
        {
            D = _D;
        }

        public new void Fun_3()
        {
            Console.WriteLine("This function special for class type_D");
        }
    }
}
