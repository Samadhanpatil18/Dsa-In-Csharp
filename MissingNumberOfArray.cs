using System;
class MissingNumberOfArray
{
    static void Main()
    {

        //       Input:
        // [9,6,4,2,3,5,7,0,1]

        // Output:
        // 8
        int[] arr = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
        int sum = 0;
        int n = arr.Length;
        foreach (int num in arr)
        {

            sum += num;
        }
        long Expectedsum = n * (n + 1) / 2;

        Console.WriteLine(Expectedsum - sum);

    }
}