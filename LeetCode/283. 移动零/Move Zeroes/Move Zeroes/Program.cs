using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new int[] { 0, 1, 0, 3, 12 };
            var res = MoveZeroes2(num);

            Console.WriteLine(string.Join(",", res));
        }

        public static int[] MoveZeroes(int[] nums)
        {
            /*
             * 记录第一个0所在的索引位置，从小到大循环数组，找到第一个非零数字和第一个0兑换位置
             */
            int index = -1;//
            for (int i = 0; i < nums.Length; i++)
            {
                if (index == -1)//找到第一个零
                {
                    if (nums[i] == 0)
                        index = i;
                }
                else
                {
                    if (nums[i] != 0)
                    {
                        int tmp = nums[i];
                        nums[i] = nums[index];
                        nums[index] = tmp;
                        index++;

                    }
                }

            }
            return nums;
        }

        public static int[] MoveZeroes2(int[] nums)
        {
            if (nums.Length<=1)            
                return nums;
            /*
             *index记录i前方0的个数，当不为0的时候，向前移动index个位置
             */
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    index++;
                }
                else if (index != 0)
                {
                    nums[i-index] = nums[i];
                    nums[i] = 0;

                }

            }
            return nums;
        }
    }
}
