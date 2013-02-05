namespace Chapter01
{
    public class Listing03
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

            public double GearInches()
            {   
                // gear inches = wheel diameter * gear ratio
                // wheel diameter = rim diameter + twice tire diameter.
                return (Ratio() * (Rim + (Tire * 2)));
            }
        }
    }
}