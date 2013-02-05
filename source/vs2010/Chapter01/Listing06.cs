namespace Chapter01
{
    public class Listing06
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

            // Hide private variables, even from the class that defines them, by wrapping them in methods.
            // .NET provides properties as an easy way to create encapsulating methods.
            // If you want to make an auto-property read-only, you have to explicitly make set private.
            public double Ratio()
            {
                return (Chainring/(double) Cog);
            }
        }
    }
}
