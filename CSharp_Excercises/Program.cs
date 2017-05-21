using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derived via Base reference:");
            BaseClass baseRef = new DerivedClass();
            baseRef.DoSomethingVirtual();
            baseRef.DoSomethingNonVirtual();
            Console.WriteLine();

            Console.WriteLine("Derived via Derived reference:");
            DerivedClass derivedRef = new DerivedClass();
            derivedRef.DoSomethingVirtual();
            derivedRef.DoSomethingNonVirtual();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
