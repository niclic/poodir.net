using System.Collections.Generic;
using System.Linq;

namespace Chapter01
{
    public class Listing12
    {
        // The public interface of RevealingReferences is the same (more or less) as
        // ObscuringReferences - it takes a 2D array as an initialization argument and
        // implements a Diameters method. However, the Diameters method has no knowledge
        // of the internal structure of the array, which is good.
        public class RevealingReferences
        {
            public List<Wheel> Wheels { get; private set; } 

            public RevealingReferences(int[,] data)
            {
                Wheels = Wheelify(data);
            }

            // All Diameters knows is that Wheels returns an enumerable 
            // and that each enumerated item responds to Rim and Tire.
            public List<int> Diameters()
            {
                return new List<int>(Wheels.Select(wheel => 
                    wheel.Rim + (wheel.Tire * 2)));
            }

            // All knowledge of the internal structure of the array is isolated inside the Wheelify method.
            // If the input argument changes, the code will only change in one place.
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

        // This could also be a Wheel class, but the original text uses a struct.
        // See Listing18 for an example of a Wheel class.
        public struct Wheel
        {
            public int Rim { get; private set; }
            public int Tire { get; private set; }

            public Wheel(int rim, int tire) : this()
            {
                Rim = rim;
                Tire = tire;
            }
        }
    }
}
