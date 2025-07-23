using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section014Codes.Extensions
{
    public static class StringExtensions
    {
        public static string Cut(this string obj, int count)
        {
            if (obj.Length <= count)
            {
                return obj;
            }
            else
            {
                return obj.Substring(0, count) + "...";
            }
        }
    }
}