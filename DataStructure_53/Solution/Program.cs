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
            // A recursive function which devides the input array into a left and right subarray. It continue to do so until the subarray is a single element
            // It will then compare the sum over the left subarray and right array with 
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

            // Using Devide and Conquer algorithm
            // Return the maximum of following three
            //1. Maximum subarray sum in left half(Make a recursive call)
            //2. Maximum subarray sum in right half(Make a recursive call)
            //3. Maximum subarray sum such that the subarray crosses the midpoint
            // Basically, ind the maximum sum starting from mid point and ending at some point on left of mid,
            // then find the maximum sum starting from mid + 1 and ending with some point on right of mid + 1.
            // Finally, combine the two and return the maximum among left, right and combination of both.
            int[] nums = { 2, 3, 4, 5, 7 };


            Console.WriteLine(maxSubArraySum(nums, 0, nums.Length - 1));
        }
    }
}
