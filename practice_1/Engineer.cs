namespace practice_1
{
    public class Engineer
    {
        public string Name { get; set; }
        public Seniority Seniority;
        public Responsibility Responsibility;

        public Engineer(string name, Seniority seniority, Responsibility responsibility)
        {
            Name = name;
            this.Seniority = seniority;
            this.Responsibility = responsibility;
        }

        public double CalcStageLocation(double PlatformLocation) 
        {
            return PlatformLocation * (int)Responsibility / 100 * (int)Seniority / 3;
        }
    }
}
