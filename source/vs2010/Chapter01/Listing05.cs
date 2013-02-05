namespace Chapter01
{
    public class Listing05
    {
        public class Gear
        {
            private readonly int _chainring;
            private readonly int _cog;

            public Gear(int chainring, int cog)
            {
                _chainring = chainring;
                _cog = cog;
            }

            // Always wrap instance variables in accessor methods instead of directly referring to varibles,
            // like the ratio method does below.
            public double Ratio()
            {
                return (_chainring/(double) _cog);
            }
        }
    }
}
