using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Robber
{
    class Program
    {
        static void Main(string[] datas)
        {



        }

        public int GetMedian(int[] nums)
        {
            if (nums.Length == 0) return 0;
            else if (nums.Length == 1) return nums[0];
            else if (nums.Length >= 2)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = 0; j < nums.Length - 1 - i; j++)
                    {
                        if (nums[j] > nums[j + 1])
                        {
                            int temp = nums[j];
                            nums[j] = nums[j + 1];
                            nums[j + 1] = temp;
                        }
                    }
                }
                return nums[nums.Length / 2];
            }
            return 0;
        }

        public int Rob(int[] nums)
        {
            /*
             * 动态规划问题，大问题拆解为子问题
             * 假设n个房子，索引0到n-1，能得最大金额为f(n),有两个选择，偷第n-1个和不偷第n-1个,
             * 偷n-1，那么总金额为num[n-1]+f(n-2)
             * 不偷n-1，那么总金额为 f(n-1)
             * f(n)=max(f(n-1),num[n-1]+f(n-2))
             * 以此地推，当n=2的时候，取两个值中最大值，当n=1 的时候，直接取num[0]
             */
            //需要两个变量记录f(n-1)和f(n-2)
            if (nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return nums[0];

            int premax = nums[0];
            int currmax = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                var temp = Math.Max(currmax, premax + nums[i]);
                premax = currmax;
                currmax = temp;
            }
            return currmax;

        }
    }
}
