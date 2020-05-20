using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class GarageDoorDownCommand : ICommand
    {
        public GarageDoor GarageDoor { get; set; }

        public GarageDoorDownCommand() {}
        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.GarageDoor = garageDoor;
        }
        public void Execute()
        {
            GarageDoor?.Down();
        }

        public void Undo()
        {
            GarageDoor?.Up();
        }
    }
}
