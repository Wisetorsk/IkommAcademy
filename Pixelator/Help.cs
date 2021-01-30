using System;
using System.Collections.Generic;
using System.Text;

namespace Pixelator
{
    public class Help
    {
        public static string HelpString { get; private set; } = "Pixellator downscales a given jpg og png\narguments: \n\t'-f'\t[filePath]\n\t'-r'\t[output X resolution] [output Y resolution]";
        public override string ToString()
        {
            return HelpString;
        }

    }
}
