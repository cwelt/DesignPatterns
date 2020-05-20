namespace CommandPattern.Receivers
{
    public class Stereo<C, D, R, V>
    {
        public string Description { get; private set; }
        public bool IsOn { get; private set; }

        public Stereo(string description)
        {
            Description = description;
        }
        public C Cd { get; set; }
        public D Dvd { get; set; }
        public R Radio { get; set; }
        public V Volume { get; set; }

        public void On() 
        {
            IsOn = true;
            System.Console.WriteLine(this);
        }
        public void Off() 
        {
            IsOn = false;
            System.Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Stereo in {Description} is {(IsOn ? "On": "Off")} Cd={Cd}, Dvd={Dvd}, Radio={Radio}, Volume={Volume}";
        }
    }
}