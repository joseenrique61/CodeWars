using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class XO
    {
        public static bool Excercise(string input)
        {
            int xs = 0;
            int os = 0;

            foreach (char c in input.ToLower())
            {
                if (c == 'x')
                {
                    xs++;
                }
                else if (c == 'o')
                {
                    os++;
                }
            }

            if (xs == os)
            {
                return true;
            }

            return false;
        }
    }
}
