using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023practice
{
    public class RomanToInt
    {
        public int RomanToInt1(string s)
        {
            Dictionary<char, int> dict = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            char[] ch = s.ToCharArray();

            int result = 0;
            int intVal, nextIntVal;

            for (int i = 0; i < ch.Length; i++)
            {
                intVal = dict[ch[i]];

                if (i != ch.Length - 1)
                {
                    nextIntVal = dict[ch[i + 1]];

                    if (nextIntVal > intVal)
                    {
                        intVal = nextIntVal - intVal;
                        i += 1;
                    }
                }
                result += intVal;
            }

            return result;
        }
    }
}
