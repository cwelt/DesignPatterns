using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    public class Light 
    {
        // instance variables 
        public bool IsOn { get; private set; } = false;
        public string Description { get; private set; }

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="description"></param>
        public Light(String description)
        {
            Description = description;
        }

        public void On()
        {
            IsOn = true;
            Console.WriteLine(this);
        }
        public void Off()
        {
            IsOn = false;
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return $"Light in {Description} is {(IsOn ? "On" : "Off")}";
        }
    }
}
