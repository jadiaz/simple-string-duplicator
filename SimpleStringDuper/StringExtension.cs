using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStringDuper
{
    public static class StringExtension
    {
        public static string Duplicate(this String str)
        {
            // check parameter is available
            if (String.IsNullOrEmpty(str)) throw new ArgumentNullException("str");

            // build duplicated string of characters
            StringBuilder sb = new StringBuilder();
            foreach (var chr in str.ToCharArray())
            {
                sb.Append(chr.ToString());
                sb.Append(chr.ToString());
            }

            return sb.ToString();
        }
    }
}
