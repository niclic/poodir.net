namespace Chapter01
{
    public class Listing17
    {
        public class Gear
        {
            public int Chainring { get; private set; }
            public int Cog { get; private set; }
            public Wheel Wheel { get; private set; }

            public Gear(int chainring, int cog, int rim, double tire)
            {
                Chainring = chainring;
                Cog = cog;
                Wheel = new Wheel(rim, tire);
            }

            public double Ratio()
            {
                return (Chainring / (double)Cog);
            }

            // Now Wheel can calculate its own diameter. 
            // This is not the long-term goal, more an 
            // experiment in code organization.
            public double GearInches()
            {
                return (Ratio() * Wheel.Diameter());
            }
        }

        public struct Wheel
        {
            public int Rim { get; private set; }
            public double Tire { get; private set; }

            public Wheel(int rim, double tire) 
                : this()
            {
                Rim = rim;
                Tire = tire;
            }

            public double Diameter()
            {
                return Rim + (Tire * 2);
            }
        }
    }
}
