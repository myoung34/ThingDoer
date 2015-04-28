using System;

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

    }
}