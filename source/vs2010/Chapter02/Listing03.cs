namespace Chapter02
{
    #region Dependency Injection

    // Using dependency injection relies on your ability to recognize that the responsibility 
    // for knowing the name of a class and the responsibility for knowing the name of a message
    // to send to that class (the name of a method to call) may belong in different objects. 
    // Just because Gear needs to send a Diameter message somewhere (call a Diameter method on 
    // some object) does not mean that Gear should know about Wheel. This leaves the question 
    // of where the responsibility for knowing about the actual Wheel class lies. For now, it’s 
    // enough to understand that this knowledge does not belong in Gear.

    #endregion
    public class Listing03
    {
        #region Explanation

        // Instead of being glued to wheel, this version of the Gear
        // class expects to be initialized with an object that has a 
        // method called Diameter.
        // C# is a statically-typed language. To better approximate Ruby,
        // we could replace the Wheel class parameter with dynamic.
        // Future listings will address this concern with an interface.

        #endregion
        public class Gear
        {
            public int Chainring { get; private set; }
            public int Cog { get; private set; }
            public Wheel Wheel { get; private set; }

            // This is a (subtle) example of Dependency Injection.
            public Gear(int chainring, int cog, Wheel wheel)
            {
                Chainring = chainring;
                Cog = cog;
                Wheel = wheel;
            }

            public double GearInches()
            {
                return (Ratio() * Wheel.Diameter());
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
