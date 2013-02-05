namespace Chapter01
{
    public class Listing16
    {
        public class Gear
        {
            public int Chainring { get; private set; }
            public int Cog { get; private set; }
            public int Rim { get; private set; }
            public double Tire { get; private set; }

            public Gear(int chainring, int cog, int rim, double tire)
            {
                Chainring = chainring;
                Cog = cog;
                Rim = rim;
                Tire = tire;
            }

            public double Ratio()
            {
                return (Chainring / (double)Cog);
            }

            // Gear is responsible for calculating gear inches, but not wheel diameter.
            public double GearInches()
            {
                return (Ratio() * Diameter());
            }

            // Extracting the calculation of wheel diameter into a separate method makes it easier to 
            // examine the class's responsibilities. Diameter can now be moved to a suitable class.
            private double Diameter()
            {
                return Rim + (Tire * 2);
            }
        }
    }
}
