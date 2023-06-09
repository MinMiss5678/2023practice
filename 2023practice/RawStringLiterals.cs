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

        private void Main2()
        {
            var str = """""
This raw string literal has four """", count them: """" four!
embedded quote characters in a sequence. That's why it starts and ends
with five double quotes.

You could extend this example with as many embedded quotes as needed for your text.
""""";
        }

        private void Main3()
        {
            var message = """
                "This is a very important message."
                """;
            Console.WriteLine(message);
            // output: "This is a very important message."
            // The leftmost whitespace is not part of the raw string literal
        }

        private void Main4()
        {
            var json = """
                {
                    "prop": 0
                }
                """;
        }

        private void Main5()
        {
            var shortText = """He said "hello!" this morning.""";
        }

        private void Main6()
        {
            var str1 = @"good morning"; // a string literal
            var str2 = @"c:\Docs\Source\a.txt"; // rather than "c:\\Docs\\Source\\a.txt"
            var str3 = @"""Ahoy!"" cried the captain."; // "Ahoy!" cried the captain.
        }
    }
}
