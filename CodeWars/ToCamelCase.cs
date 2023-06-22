using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ToCamelCase
    {
        public static string Excercise(string str)
        {
            bool capital = char.IsUpper(str[0]);
            str = string.Join("", str.Split(new char[] { '-', '_' }, StringSplitOptions.RemoveEmptyEntries).Select(x => char.ToUpper(x[0]) + x[1..]));

            if (capital)
            {
                return str;
            }

            if (str.Length > 0)
            {
                return char.ToLower(str[0]) + str.Substring(1);
            }

            return "";
        }
    }
}
