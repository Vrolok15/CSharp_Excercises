using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Excercises
{
    class DerivedClass : BaseClass
    {
        public override void DoSomething()
        {
            base.DoSomething();
            Console.WriteLine("Derived.DoSomething");
        }
    }
}
