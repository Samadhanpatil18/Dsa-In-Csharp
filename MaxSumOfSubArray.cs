using System;
class MaxSumOfSubArray
{

    //Brute Force Approach
    static void Main()
    {
        int[] arr = { 3, -4, 5, 4, -1, 7, -8 };
        int n = arr.Length;
        int MaxSum = int.MinValue;
        for (int start = 0; start < n; start++)
        {
            int CurrentSum = 0;
            for (int end = start; end < n; end++)
            {

                CurrentSum += arr[end];
                MaxSum = Math.Max(CurrentSum, MaxSum);

            }
        }
        Console.WriteLine(MaxSum);
    }
}
