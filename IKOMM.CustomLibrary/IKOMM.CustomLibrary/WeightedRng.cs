using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IKOMM.CustomLibrary
{
    public class WeightedRng
    {
        private static Random r = new Random();
        //List<double> weights = new List<double>();
        public static double[] ShittyWeighted(double[] weights)
        {
            var output = new double[weights.Length];
            for (int i = 0; i < weights.Length; i++)
            {
                output[i] = r.NextDouble() * weights[i];
            }
            return output;
        }

    }
}
