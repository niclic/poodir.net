namespace Chapter02
{
    // If you are so constrained that you cannot change the code to inject a Wheel 
    // into a Gear, you should isolate the creation of Wheel inside the Gear class.
    // This refactoring explicitly exposes the dependency, which can be removed later.
    public class Listing04
    {
        public class Gear
        {
            public int Chainring { get; private set; }
            public int Cog { get; private set; }
            public Wheel Wheel { get; private set; }

            // Note that a new instance of Wheel is created each time a new gear is created.
            public Gear(int chainring, int cog, int rim, double tire)
            {
                Chainring = chainring;
                Cog = cog;
                Wheel = new Wheel(rim, tire);
            }

            // The responsibility for creating a Wheel instance is removed from the Gear Inches method.
            public double GearInches()
            {
                return (Ratio() * Wheel.Diameter());
            }

            public double Ratio()
            {
                return (Chainring / (double)Cog);
            }
        }
        // Unchanged from Listing03
        public class Wheel
        {
            public int Rim { get; private set; }
            public double Tire { get; private set; }

            public Wheel(int rim, double tire)
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
