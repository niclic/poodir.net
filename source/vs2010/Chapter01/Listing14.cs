using System.Collections.Generic;
using System.Linq;

namespace Chapter01
{
    public class Listing14
    {
        // Compare this class to Listing12. The method in Listing12 has two responsibilities -
        // it iterates over the wheels and it calculates the diameter of each wheel.
        // This listing simplifies the Diameters method by separating it into two methods,
        // each with one responsibility.
        public class RevealingReferences
        {
            public List<Wheel> Wheels { get; private set; }

            public RevealingReferences(int[,] data)
            {
                Wheels = Wheelify(data);
            }

            // First - iterate over the list (and finally return the list of calculated diameters).
            public List<int> Diameters()
            {
                return new List<int>(Wheels.Select(Diameter));
            }

            // Second - calculate diameter for one wheel.
            private int Diameter(Wheel wheel)
            {
                return wheel.Rim + (wheel.Tire * 2);
            }

            private List<Wheel> Wheelify(int[,] data)
            {
                var wheels = new List<Wheel>();

                for (var i = 0; i < data.GetLength(0); i++)
                {
                    // 0 is rim, 1 is tire 
                    wheels.Add(new Wheel(data[i, 0], data[i, 1]));
                }
                return wheels;
            }
        }

        public struct Wheel
        {
            public int Rim { get; private set; }
            public int Tire { get; private set; }

            public Wheel(int rim, int tire)
                : this()
            {
                Rim = rim;
                Tire = tire;
            }
        }
    }
}
