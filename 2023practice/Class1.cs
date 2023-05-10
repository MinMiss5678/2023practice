using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
}
