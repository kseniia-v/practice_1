namespace practice_1
{
    public class Platform
    {
        private Plate width;
        public string Location { get; set; }
        public double LocationLeft { get; set; }
        public double LocationRight { get; set; }
        public Platform(Plate width, double locationPoint, string locationName)
        {
            this.width = width;
            LocationLeft = locationPoint;
            Location = locationName;
            LocationRight = CalcLocationRight(locationPoint, width);
        }
        private double CalcLocationRight(double locationPoint, Plate width)
        {
            return locationPoint + (int)width;
        }
    }
}
