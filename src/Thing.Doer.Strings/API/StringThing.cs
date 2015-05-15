using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ThingDoer.API
{
    public static class StringThing
    {
        public static string ReverseThing(this string str)
        {
            var charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string AddFoo(this string str)
        {
            return str + "foo";
        }

        public static string AddWat(this string str)
        {
            return str + "wat";
        }

        public static string SwapCase(this string str)
        {
            var finalStr = new StringBuilder();
            foreach (var character in str)
            {
                var newChar = character;
                if (char.IsLower(character))
                {
                    newChar = char.ToUpper(character);
                }
                else if (char.IsUpper(character))
                {
                    newChar = char.ToLower(character);
                }
                finalStr.Append(newChar);
            }
            return finalStr.ToString();
        }
    }
}