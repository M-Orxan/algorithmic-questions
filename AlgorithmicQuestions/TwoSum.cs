using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicQuestions
{
    /// <summary>
    /// Question Link: https://leetcode.com/problems/two-sum/description/
    /// </summary>
    public class TwoSum
    {
        public int[] Solve(int[] nums, int target)
        {
            Dictionary<int, int> numMaps = new Dictionary<int, int>();


            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];


                if (numMaps.ContainsKey(complement))
                {
                    return new int[] { numMaps[complement], i };
                }
                numMaps[nums[i]] = i;

            }

            return new int[0];

        }
    }
}
