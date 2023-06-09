using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023practice
{
    internal class InitProperties
    {
        public class Person
        {
            public Person() { }

            [SetsRequiredMembers]
            public Person(string firstName) => FirstName = firstName;

            public required string FirstName { get; init; }
            //Required：修飾詞，強制物件初始時須設定此屬性的值
            //Init：在屬性使用，限制只能在物件初始化時設定值

            // Omitted for brevity.
        }
    }
}
