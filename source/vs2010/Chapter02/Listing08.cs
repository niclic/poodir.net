namespace Chapter02
{

    #region Isolate Dependencies

    // In both Listing04 and Listing05, Gear still knows far too much about Wheel. It:
    //      => takes rim and tire as constructor arguments.
    //      => creates its own new instance of Wheel.
    //      => can calculate the gear inches of no other kind of object.
    
    // However, an improvement has been made. These coding styles reduce the number 
    // of dependencies in GearInches while publicly exposing Gear’s dependency on 
    // Wheel. They reveal dependencies instead of concealing them, lowering the 
    // barriers to reuse and making the code easier to refactor when circumstances allow. 

    // The way you manage dependencies on external class names has profound effects on 
    // your application. If you are mindful of dependencies and develop a habit of 
    // routinely injecting them, your classes will naturally be loosely coupled and 
    // can easily adapt to new requirements.

    #endregion

    public class Listing08
    {
        // In this listing I have replaced all methods on Gear and Wheel
        // with read-only properties. This can lead to a cleaner syntax,
        // althought that's the only benefit. Sugar is sweet. 
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

            public double GearInches
            {
                get
                {
                    return Ratio * Diameter;
                }
            }

            public double Ratio
            {
                get
                {
                    return Chainring / (double) Cog;
                }
            }

            // Instead of GetWheel().GetDiameter() we have Wheel.Diameter.
            private double Diameter
            {
                get
                {
                    return Wheel.Diameter;
                }
            }

            private Wheel Wheel
            {
                get
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

        public double Diameter
        {
            get
            {
                return Rim + (Tire*2);
            }
        }
    }
}
