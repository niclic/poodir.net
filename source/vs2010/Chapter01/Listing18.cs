using System;

namespace Chapter01
{
    public class Listing18
    {
        public class Gear
        {
            public int Chainring { get; private set; }
            public int Cog { get; private set; }
            public Wheel Wheel { get; private set; }

            public Gear(int chainring, int cog, Wheel wheel = null)
            {
                Chainring = chainring;
                Cog = cog;
                Wheel = wheel;
            }

            public double Ratio()
            {
                return (Chainring / (double)Cog);
            }

            public double GearInches()
            {
                return (Ratio() * Wheel.Diameter());
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

            public double Circumference()
            {
                return Diameter()*Math.PI;
            }
        }
    }
}
