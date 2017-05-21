using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Excercises
{
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
        double CurrentRecordTime { get; }
    }
}
