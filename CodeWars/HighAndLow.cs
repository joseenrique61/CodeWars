using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class HighAndLow
    {
        public static string Excercise(string numbers)
        {
            int[] result = numbers.Split(' ').Select(int.Parse).OrderByDescending(x => x).ToArray();
            return result[0].ToString() + " " + result[^1].ToString();
        }
    }
}
