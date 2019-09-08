using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.LeetCode
{
    public class Problem1TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] _returnValue = null;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[j] + nums[i]== target)
                    {
                        _returnValue =  new int[] { i, j };
                    }
                }
            }
            return _returnValue;
           
           // throw new IllegalArgumentException("No two sum solution");

            //int[] indices = new int[2];
            //int counter = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (i != j)
            //        {
            //            if (nums[i] + nums[j] == target)
            //            {
            //                indices[0] = i;
            //                indices[1] = j;
            //                counter++;
            //                break;
            //            }
            //        }
                   
            //    }
            //    if (counter == 1)
            //    {
            //        break;
            //    }
            //}
            //return indices;
        }
    }
}
