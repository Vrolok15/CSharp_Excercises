using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Excercises
{
    class DerivedClass : BaseClass
    {
        public override void DoSomethingVirtual()
        {
            Console.WriteLine("Derived.DoSomethingVirtual");
        }

        public new void DoSomethingNonVirtual()
        {
            Console.WriteLine("Derived.DoSomethingNonVirtual");
        }
    }
}
