using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1,2,3,4};
            var numsCheck = new Dictionary<int,int>();
            bool results = new bool();
            results = false;
            
            
            // Using sort: Higher running time, less memory utilization
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    results = true;
                    break;

                }
                
            }

            // Using dictionary: Less runtime, higher memory consumption

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (numsCheck.ContainsKey(nums[i]))
            //    {
            //        results = true;
            //        break;

            //    }
            //    else
            //        numsCheck[nums[i]] = 1;



            //    var numsCheck = new Dictionary<int, int>();
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        if (numsCheck.ContainsKey(nums[i]))
            //            return true;
            //        else
            //            numsCheck[nums[i]] = 1;
            //    }

            //    return false;
            Console.WriteLine(results);

        }

            
            

    }
}
