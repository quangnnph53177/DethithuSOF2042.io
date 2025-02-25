using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dethithu
{
    public class Caculator
    {
        public int SumArray(int[] arr)
        {
            int sum = 0;
            foreach (var number in arr)
            {
                sum += number;
            }
            return sum;
        }
    }
}
