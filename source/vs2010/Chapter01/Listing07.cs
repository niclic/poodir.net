namespace Chapter01
{
    public class Listing07
    {
        public class Gear
        {
            private readonly int _cog;

            public Gear(int cog)
            {
                _cog = cog;
            }

            // ReSharper provides the Encapsulate Field refactoring
            // to create a simple wrapper property for a read-only field.
            // You would normally use an auto-property to do this.
            public int Cog
            {
                get
                {
                    return _cog;
                }
            }
        }
    }
}
