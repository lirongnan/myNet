using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monotone_Increasing_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MonotoneIncreasingDigits(332));
        }

        public static int MonotoneIncreasingDigits(int N)
        {
            /*
             * 抄大佬作业，给大佬跪了，贪心算法哦
             * 从右到左，每次取两位数字，高位大于低位，则舍掉所有低位后面的数字后，减1
             */
            int i = 1;
            int res = N;
            while (i <= res / 10)
            {
                int n = res / i % 100; // 每次取两个位
                i *= 10;
                if (n / 10 > n % 10) // 比较的高一位大于底一位
                    res = res / i * i - 1; //例如1332 循环第一次变为1330-1=1329 第二次变为1300-1=1299
            }
            return res;
        }
    }
}
