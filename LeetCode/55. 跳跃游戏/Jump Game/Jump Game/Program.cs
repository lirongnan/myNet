using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 0, 6, 9, 8, 4, 5, 0, 8, 9, 1, 2, 9, 6, 8, 8, 0, 6, 3, 1, 2, 2, 1, 2, 6, 5, 3, 1, 2, 2, 6, 4, 2, 4, 3, 0, 0, 0, 3, 8, 2, 4, 0, 1, 2, 0, 1, 4, 6, 5, 8, 0, 7, 9, 3, 4, 6, 6, 5, 8, 9, 3, 4, 3, 7, 0, 4, 9, 0, 9, 8, 4, 3, 0, 7, 7, 1, 9, 1, 9, 4, 9, 0, 1, 9, 5, 7, 7, 1, 5, 8, 2, 8, 2, 6, 8, 2, 2, 7, 5, 1, 7, 9, 6 };

            Console.WriteLine(CanJump(nums));
        }

        static bool CanJump(int[] nums)
        {
            /*
             * 找到当前位置能跳跃到的最大位置，那么当前位置到最大位置之间的位置必然可达，那么遍历中间位置能够跳跃的最大位置，
             * 如果超过当前最大位置，则继续便利中间位置，如果不能到达最大位置，那么从最大位置继续往后跳跃，直到最大位置大于数组长度
             */
            if (nums.Length == 1)
                return true;
            int maxindex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > maxindex)
                    return false;
                maxindex = Math.Max(maxindex, i + nums[i]);
                if (maxindex >= nums.Length - 1)
                    return true;
            }
            return false;
        }


    }
}
