using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Excercises
{
    class DerivedClass : BaseClass
    {
        public override Int32 MyProperty
        {
            get { return _x * 2; }
        }

        public override void DoSomething()
        {
            _x = 14;
        }
    }
}
