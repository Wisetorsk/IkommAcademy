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
        public static double[] ShittyWeightedSet(double[] weights)
        {
            var output = new double[weights.Length];
            for (int i = 0; i < weights.Length; i++)
            {
                output[i] = r.NextDouble() * weights[i];
            }
            return output;
        }

        public static int Weighted(double[] weights)
        {
            double remainingDist = r.NextDouble() * weights.Sum();
            for (int i = 0; i < weights.Length; i++)
            {
                remainingDist -= weights[i];
                if (remainingDist < 0) return i;
            }
            return -1;
        }
    }

}
