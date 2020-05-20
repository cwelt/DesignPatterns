using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class CeilingFanOnCommand : ICommand
    {
        public CeilingFan CeilingFan { get; set; }

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }
        public void Execute()
        {
            CeilingFan?.TurnOn();
        }

        public void Undo()
        {
            CeilingFan?.TurnOff();
        }
    }
}
