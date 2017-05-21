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
            AudioFile audio = new AudioFile();
            audio.Play();
            audio.Record();
            audio.Stop();
            ((IRecordable)audio).Stop();
            Console.ReadLine();
        }
    }
}
