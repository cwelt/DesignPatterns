using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class StereoOnWithCDCommand : ICommand
    {
        // private instance of the receiver encapsulatd by this command 
        private Stereo<string, string, object, int> _stereo;

        public StereoOnWithCDCommand(Stereo<string, string, object, int> stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            Console.WriteLine("\tStereo is On");
            _stereo.Cd = "The White Album";
            Console.WriteLine("\tCd is set to: {0}", _stereo.Cd);
            _stereo.Volume = 27;
            Console.WriteLine("\tVolume is: {0}", _stereo.Volume);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
