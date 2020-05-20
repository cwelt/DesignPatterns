using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    public class CeilingFan
    {
        public String Location { get; private set; }
        public bool IsOn { get; private set; }

        public uint Speed { get; private set; }
        
        public const uint High = 3;
        public const uint Medium = 2;
        public const uint Low = 1;
        public const uint Off = 0;


        public CeilingFan(String location)
        {
            Location = location;
            Speed = Off;
        }
            
        public void TurnOn()
        {
            IsOn = true;
            Speed = CeilingFan.Medium; 
            Console.WriteLine(this);
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Ceiling Fan in {Location} is {(IsOn ? "On" : "Off")}";
        }
    }
}
