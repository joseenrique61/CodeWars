using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class DescendingOrder
    {
        public static int Excercise(int num)
        {
            List<int> nums = new();
            int finalNum = 0;

            while (num > 0)
            {
                nums.Add(num % 10);
                num /= 10;
            }

            nums = nums.OrderByDescending(x => x).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                finalNum += nums[i] * (int)Math.Pow(10, nums.Count - 1 - i);
            }

            return finalNum;
        }
    }
}
