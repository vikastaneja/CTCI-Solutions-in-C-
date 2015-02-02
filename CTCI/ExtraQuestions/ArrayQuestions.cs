using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraQuestions
{
    public class ArrayQuestions
    {
        /// <summary>
        /// Find if the element is present in the array.
        /// Property of array is that each neighbor element is not more than 1 difference
        /// </summary>
        /// <param name="a">Array to be searched</param>
        /// <param name="x">Element to be searched</param>
        /// <returns>Returns the index of the element</returns>
        public static int FindElement(int[] a, int x)
        {
            if (a == null || a.Length == 0)
            {
                throw new ArgumentNullException("a");
            }

            for (int i = 0; i < a.Length; )
            {
                int jump = 1;
                if (x == a[i])
                {
                    return i;
                }

                jump = Math.Abs(x - a[i]);

                i += jump;
            }

            return -1;
        }

        /// <summary>
        /// Problem is to find the maximum sum subarray.
        /// The solution is first to find the sum in the first iteration and then slide the window.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static int LargestSumSlidingWindow(int[] arr, int size)
        {
	        if (arr == null || arr.Length == 0)
	        {
		        throw new ArgumentNullException("arr");
	        }
	
	        if (arr.Length < size)
	        {
		        throw new ArgumentException();
	        }
	
	        if (arr.Length == 1)
	        {
		        return arr[0];
	        }
	
	        int sum = 0;
	        int psum = 0;
	        bool prevSum = false;
	
	        for (int i = 0; i + size <= arr.Length; i++)
	        {
		        int tsum = 0;
	
		        if (!prevSum)
		        {
			        // Calculate the sum here
			        for (int j = i, temp = size; j < arr.Length && temp > 0; j++, temp--)
			        {
				        tsum += arr[j];
			        }
                    prevSum = true;
		        }
		        else
		        {
			        tsum = psum - arr[i - 1] + arr[i + size - 1] ;
		        }
		
		        psum = tsum;
		
		        if (tsum > sum)
			        sum = tsum;
	        }
	
	        return sum;
        }
    }
}
