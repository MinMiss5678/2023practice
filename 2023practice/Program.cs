using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static public void Main()
        {
            var generic = typeof(TEST2);
            var genericAttributes = generic.GetCustomAttributes(false);
            foreach (var genericAttribute in genericAttributes)
            {
                if (genericAttribute is GenericAttribute<string>)
                {
                    Console.WriteLine(((GenericAttribute<string>)genericAttribute).TypeId);
                }
            }
        }

        private void TypeAttribute()
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

    static public class ValueFormat
    {
        static public string Thousandths<T>(this T value) where T : IComparable
        {
            var arr = value.ToString()?.Split(".");
            return $"{Convert.ToInt32(arr?[0]):N0}{(arr?.Length > 1 ? "." + arr[1] : "")}";
        }
    }
}