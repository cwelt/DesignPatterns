using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class LightOffCommand : ICommand
    {
        // Instance variabe that would hold a specific light object (for exmaple, living room light)
        public Light Light { get; private set; }

        public LightOffCommand(Light Light)
        {
            this.Light = Light;
        }

        public void Execute()
        {
            Light?.Off();
        }

        public void Undo()
        {
            Light?.On();
        }
    }
}
