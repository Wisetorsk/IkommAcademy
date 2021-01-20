using System;
using System.Collections.Generic;
using System.Text;

namespace IKOMM.CustomLibrary
{
    public static class ListTools
    {
        public static string Stringify<T>(List<T> inputList) {
            string outVar = null;
            foreach (var item in inputList)
            {
                outVar += $"{item} ";
            }
            return outVar;
        }

        public static List<int> RangeList(int lengthOfRange, int startPoint = 0, int stepLength = 0)
        {
            //return;
        }
    }
}
