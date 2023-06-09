using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023practice
{
    internal class UTF_8
    {
        private void Main()
        {
            ReadOnlySpan<byte> AuthWithTrailingSpace = new byte[] { 0x41, 0x55, 0x54, 0x48, 0x20 };
            ReadOnlySpan<byte> AuthStringLiteral = "AUTH "u8;
        }
    }
}
