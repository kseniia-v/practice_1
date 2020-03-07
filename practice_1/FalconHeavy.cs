namespace practice_1
{
    public class FalconHeavy
    {
        private Falcon width;
        private double locationLeft;
        private double locationRight;
        public string Name { get; set; }
        // in fact, the main X - calculated by Engineer + affected by random Rocket fly
        public double LocationLeft
        {
            get { return locationLeft; }
            set { locationLeft = value; }
        }
        //readonly as depends on X
        public double LocationRight 
        { 
            get { return locationRight; } 
        }
        public FalconHeavy(string name, Falcon width)
        {
            Name = name;
            this.width = width;
        }
        public void Fly(double deviation)
        {
            locationLeft *= deviation;
            locationRight = locationLeft + (int)width;
        }
    }
}
