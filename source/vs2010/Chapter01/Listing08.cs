using System;

namespace Chapter01
{
    public class Listing08
    {
        public class Gear
        {
            private const int UnanticipatedAdjustmentFactor = Int32.MaxValue;
            private readonly int _cog;

            public Gear(int cog)
            {
                _cog = cog;
            }

            // If cog is wrapped in a method (property), you can chainge what cog means
            // by implementing your own version of the method.
            public int Cog
            {
                get
                {
                    return (_cog * UnanticipatedAdjustmentFactor);
                }
            }
        }
    }
}
