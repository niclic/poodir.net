namespace Chapter02
{
    public class Listing19
    {
        public class Gear
        {
            public int Chainring { get; private set; }
            public int Cog { get; private set; }
            public int Rim { get; private set; }
            public double Tire { get; private set; }

            public Gear(int chainring, int cog, int rim, double tire)
            {
                Chainring   = chainring;
                Cog         = cog;
                Rim         = rim;
                Tire        = tire;
            }

            public double GearInches()
            {
                return (Ratio() * new Wheel(Rim, Tire).Diameter());
            }

            public double Ratio()
            {
                return (Chainring / (double)Cog);
            }
        }

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
