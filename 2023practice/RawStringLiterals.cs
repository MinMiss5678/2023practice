using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023practice
{
    internal class RawStringLiterals
    {
        string longMessage = """
    This is a long message.
    It has several lines.
        Some are indented
                more than others.
    Some should start at the first column.
    Some have "quoted text" in them.
    """;

        private void Main()
        {
            string Longitude = "1";
            string Latitude = "2";
            var location = $$"""
   You are at {{{Longitude}}, {{Latitude}}}
   """;
        }
    }
}
