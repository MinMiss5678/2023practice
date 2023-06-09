using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023practice
{
    internal class Ref
    {
        public ref struct RefFieldExample
        {
            private ref int number;

            public int GetNumber()
            {
                if (System.Runtime.CompilerServices.Unsafe.IsNullRef(ref number))
                {
                    throw new InvalidOperationException("The number ref field is not initialized.");
                }

                return number;
            }

            public ref struct CustomRef
            {
                public bool IsValid;
                public Span<int> Inputs;
                public Span<int> Outputs;
            }

            public readonly ref struct ConversionRequest
            {
                public ConversionRequest(double rate, ReadOnlySpan<double> values)
                {
                    Rate = rate;
                    Values = values;
                }

                public double Rate { get; }
                public ReadOnlySpan<double> Values { get; }
            }
        }
    }
}
