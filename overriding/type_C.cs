using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.overriding
{
    internal class type_C: type_B
    {

        public int C { get; set; }

        public type_C(int _A, int _B, int _C):base(_A, _B)
        {
            C = _C;
        }
    }
}
