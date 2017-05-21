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
            BaseClass d = new DerivedClass();
            d.DoSomething();
            Console.WriteLine(d.MyProperty.ToString());
            Console.ReadLine();
        }
    }
}
