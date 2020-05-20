using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        public GarageDoor GarageDoor { get; set; }

        public GarageDoorOpenCommand() {}
        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.GarageDoor = garageDoor;
        }
        public void Execute()
        {
            GarageDoor?.Up();
        }

        public void Undo()
        {
            GarageDoor?.Down();
        }
    }
}
