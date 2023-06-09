using _2023practice;
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
        public interface INumber<TSelf> : IComparable
        {

        }
        static public void Main()
        {

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