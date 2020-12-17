using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 2, 1 };
            Console.WriteLine(SingleNumber(nums));
        }
        static int SingleNumber(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var flag = false;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        //发现相同项，如果他们不相邻，则i+1和j进行对调
                        if (j != i + 1)
                        {
                            int tmp = nums[i + 1];
                            nums[i + 1] = nums[j];
                            nums[j] = tmp;
                        }
                        i++;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    return nums[i];


            }
            return 0;
        }

        public int SingleNumber1(int[] nums)
        {
            /*
             * 抄作业，被异或运算骚到了，异或运算三大铁律
             *交换律：a ^ b ^ c <=> a ^ c ^ b
             *任何数于0异或为任何数 0 ^ n => n
             *相同的数异或为0: n ^ n => 0
             */
            int ret = 0;
            foreach (int e in nums) ret ^= e;
            return ret;
        }
    }
}
