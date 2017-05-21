using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Excercises
{
    class DerivedClass : BaseClass
    {
        public DerivedClass()
            : base(1, 2, 3)
        {
        }

        public void DoSomething()
        {
            _b = _c = 100;
        }
    }
}
