using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class CeilingFanOffCommand : ICommand
    {
        public CeilingFan CeilingFan { get; set; }

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }
        public void Execute()
        {
            CeilingFan?.TurnOff();
        }

        public void Undo()
        {
            CeilingFan?.TurnOn();
        }
    }
}
