//https://leetcode.com/problems/contains-duplicate/
//Accepted
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 1, 1, 1 };
            nums = nums.Distinct().ToArray();
        }

        static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length < 2)
            {
                return false;
            }

            return !(nums.Length == nums.Distinct().ToArray().Length);

            /*
             * 
             * failed code block: time limit exceed.
            bool result = false;
            foreach (int p in nums)
            {
                if (nums.Where(x => x == p).ToArray().Length > 1)
                {
                    result = true;
                    break;
                }
            }
             * return result;
            */

        }
    }
}
