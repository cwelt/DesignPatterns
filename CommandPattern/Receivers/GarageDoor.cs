using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    public class GarageDoor
    {
        private bool _isUp = false;
        private bool _isLightOn = false;
        private string _description = "";

        public GarageDoor(string description)
        {
            _description = description;
        }
        public void Up()
        {
            _isUp = true;
            Console.WriteLine(this);
        }
        public void Down()
        {
            _isUp = false;
            Console.WriteLine(this);
        }

        public void Stop()
        {
            Console.WriteLine("Door is stoped");
        }

        public void On()
        {
            _isLightOn = true;
            Console.WriteLine(this);
        }
        public void Off()
        {
            _isLightOn = false;
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(30);
            stringBuilder.Append($"Garage Door is {(_isUp ? "Open" : "Closed")}");
            stringBuilder.Append($", Light is {(_isLightOn ? "On" : "Off")}");
            return stringBuilder.ToString();
        }
    }
}
