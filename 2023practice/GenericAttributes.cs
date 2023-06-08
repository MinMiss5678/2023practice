using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023practice
{
    internal class GenericAttributes
    {
        public class TypeAttribute : Attribute
        {
            public TypeAttribute(Type t) => ParamType = t;

            public Type ParamType { get; }

        }

        [TypeAttribute(typeof(int))]
        public class TEST
        {
            public string? test1;
        }

        public class GenericAttribute<T> : Attribute { }

        [GenericAttribute<string>]
        public class TEST2
        {
            public string test2 { get; set; }
            public string test3 { get; set; }

        }

        private void Main()
        {
            var type = typeof(TEST);
            var typeAttributes = type.GetCustomAttributes(false);

            foreach (var typeAttribute in typeAttributes)
            {
                if (typeAttribute is TypeAttribute)
                {
                    Console.WriteLine(((TypeAttribute)typeAttribute).ParamType.Name);
                }
            }
        }
    }
}
