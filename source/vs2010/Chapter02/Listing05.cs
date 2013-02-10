namespace Chapter02
{
    public class Listing05
    {   
        // The creation of Wheel is isolated in its own explicitly defined method.
        public class Gear
        {
            private Wheel _wheel;

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

            public double GearInches()
            {
                return (Ratio() * GetWheel().Diameter());
            }

            public double Ratio()
            {
                return (Chainring / (double)Cog);
            }


            // Creation of Wheel is deferred until GearInches invokes the GetWheel method.
            private Wheel GetWheel()
            {
                // I find this old-skool way clearer than the null coalescing operator,
                // especially when also assigning to the thing you are checking for null.
                if (_wheel == null)
                {
                    _wheel = new Wheel(Rim, Tire);
                }

                return _wheel;
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
