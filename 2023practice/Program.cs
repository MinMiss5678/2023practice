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

        public enum Stages
        {
            提案,
            審核,
            執行,
            驗收,
            結案
        }

        public static void Main()
        {
            var x = PalindromeNumber.IsPalindrome(12321);
            Console.WriteLine(x ? "true" : "false");
        }

        public static int MinInsertions(string s)
        {
            string[] strArray = s.Split("())");
            while (strArray.Length > 1)
            {
                string str = "";
                foreach (var item in strArray)
                {
                    str += item;
                }

                strArray = s.Split("())");
            }

            int count1 = strArray[0].Where(x => x == '(').Count();
            int count2 = strArray[0].Where(x => x == ')').Count();
            int answer = count1 * 2 + count2;
            return answer;

            return 0;
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