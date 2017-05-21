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
        {
            // _a = 1; It's set to private in Base Class, thus not accessible
            _b = 2;
            _c = 3;
        }

        public void DoSomething()
        {
            _b = _c = 100;
        }
    }
}
