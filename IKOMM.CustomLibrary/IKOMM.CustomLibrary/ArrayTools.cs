using System;

namespace IKOMM.CustomLibrary
{
    public static class ArrayTools
    {
        public static T[] Append<T>(T[] inputArray, params T[] input)
        {
            int posIndex = 0;
            T[] output = new T[inputArray.Length + input.Length];
            foreach (var item in inputArray)
            {
                output[posIndex] = item;
                posIndex++;
            }
            foreach (var item in input)
            {
                output[posIndex] = item;
                posIndex++;
            }
            return output;
        }

        public static string Stringify<T>(T[] inputArray)
        {
            string outString = null;
            foreach (var item in inputArray)
            {
                outString += $"{item} ";
            }
            return outString;
        }

        public static int[] Range(int lengthOfRange, int startPoint = 0, int stepLength = 0)
        {
            int[] rangeOut = new int[lengthOfRange];
            for (int i = 0; i < lengthOfRange; i++)
            {
                rangeOut[i] = startPoint + i * stepLength;
            }
            return rangeOut;
        }
    }
}
