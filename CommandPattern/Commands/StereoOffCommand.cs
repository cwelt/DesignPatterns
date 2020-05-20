using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class StereoOffCommand : ICommand
    {
        // private instance of the receiver encapsulatd by this command 
        private Stereo<string, string, object, int> _stereo;

        public StereoOffCommand(Stereo<string, string, object, int> stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
        }
    }
}
