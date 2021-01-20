using System;
using IKOMM.CustomLibrary;

namespace Ikomm_Academy_Dag_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] baseString = new string[] { "1", "2", "3" };
            int[] baseInt = new int[] { 1, 2, 3, 4 };
            string[] output = ArrayTools.Append(baseString, "3", "4", "5");
            int[] intArray = ArrayTools.Append(baseInt, 5,6,7,8,9);
            Console.WriteLine(ArrayTools.Stringify(output));
            Console.WriteLine(ArrayTools.Stringify(intArray));
            Console.WriteLine(ArrayTools.Stringify(ArrayTools.Range(10, -10, 2)));
        }
    }
}
