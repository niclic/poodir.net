namespace Chapter01
{
    public class Listing02
    {
        public class Gear
        {
            public int Chainring { get; private set; }
            public int Cog { get; private set; }

            public Gear(int chainring, int cog)
            {
                Chainring = chainring;
                Cog = cog;
            }

            public double Ratio()
            {
                return (Chainring / (double)Cog);
            }
        }
    }
}
