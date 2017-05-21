using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Excercises
{
    public class BaseClass
    {
        protected Int32 _x;

        public virtual Int32 MyProperty
        {
            get { return _x; }
        }

        public virtual void DoSomething()
        {
            _x = 13;
        }

        

    }
}
