using System;

namespace Solution
{
    class Program
    {
        
        static int maxSubArraysCrossMid (int[] nums, int startIdx, int endIdx, int midIdx)
        {
            int sum = 0;

            int leftSum = int.MinValue;
            for (int i = midIdx; i >= startIdx; i--)
            {
                sum += nums[i];
                if (sum > leftSum)
                    leftSum = sum;
            }

            sum = 0;
            int rightSum = int.MinValue;
            for (int i = midIdx+1; i <= endIdx; i++)
            {
                sum += nums[i];
                if (sum > rightSum)
                    rightSum = sum;
            }

            return Math.Max(rightSum+leftSum, Math.Max(rightSum, leftSum));
        }
        
        
        static int maxSubArraySum(int[] nums, int startIdx, int endIdx)
        {
            if (startIdx == endIdx)
                return nums[startIdx];
            else
            {
                int midIdx = 0;

                // Finding the index of the middle element
                midIdx = (endIdx + startIdx) / 2;


                return Math.Max(Math.Max(maxSubArraySum(nums, startIdx, midIdx), maxSubArraySum(nums, midIdx + 1, endIdx)),maxSubArraysCrossMid(nums, startIdx,endIdx,midIdx));




            }
            
           
        }
        
        static void Main(string[] args)
        {

            int[] nums = { 2, 3, 4, 5, 7 };


            Console.WriteLine(maxSubArraySum(nums, 0, nums.Length - 1));
        }
    }
}
