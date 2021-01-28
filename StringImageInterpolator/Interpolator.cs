using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringImageInterpolator
{
    public class Interpolator
    {

        public static List<string> Interpolate(string a, string b)
        {
            var splitA = Escape(a);
            var splitB = Escape(b);
            var output = new List<string>();
            for (int i = 0; i < splitA.Count(); i++)
            {
                output.Add($"{splitA[i]}{splitB[i]}");
            }
            //var combo = splitA.Zip(splitB, (first, second) => $"{first}{second}").ToArray();

            return output;
        }

        public static List<string> Escape(string input)
        {
            List<string> output = new List<string>();
            var line = "";
            foreach (var c in input)
            {
                if (c == '\n') {
                    line += " ";
                    output.Add(line);
                    line = "";
                }
                else
                {
                    line += c;
                }
            }
            return output;
        }
    }
}
