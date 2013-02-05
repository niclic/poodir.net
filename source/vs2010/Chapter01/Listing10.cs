using System.Collections.Generic;

namespace Chapter01
{
    public class Listing10
    {
        // Direct references into complicated structures are confusing, 
        // because they obscure what the data really is, and they are 
        // a maintenance nightmare, because every reference will need 
        // to be changed when the structure of the array changes.
        public class ObscuringReferences
        {
            public int[,] Data { get; private set; }

            // This class expects to be initialized with a two-dimensional array of rims and tires.
            // data = [[622, 20], [622, 23], [559, 30], [559, 40]];
            public ObscuringReferences(int[,] data)
            {
                Data = data;
            }

            // Diameters knows not only how to calculate diameters, 
            // but also where to find rims and tires in the array.
            // It depends upon the array’s structure, which is bad.
            public List<int> Diameters()
            {
                var diameters = new List<int>();

                for (var i = 0; i < Data.GetLength(0); i++)
                {
                    // 0 is rim, 1 is tire 
                    diameters.Add(Data[i, 0] + (Data[i, 1] * 2));
                }

                return diameters;
            }
        }
    }
}
