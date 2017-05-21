using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Excercises
{
    class AudioFile : IPlayable, IRecordable
    {
        public double CurrentTime => throw new NotImplementedException();

        public double CurrentRecordTime => throw new NotImplementedException();

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Recording paused");
        }

        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Record()
        {
            Console.WriteLine("Recording");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Recording stopped");
        }
    }
}
