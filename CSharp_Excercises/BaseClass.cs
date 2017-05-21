using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Excercises
{
    public class BaseClass
    {
        public virtual void DoSomethingVirtual()
        {
            Console.WriteLine("Base.DoSomethingVirtual");
        }

        public void DoSomethingNonVirtual()
        {
            Console.WriteLine("Base.DoSomethingNonVirtual");
        }
    }
}
