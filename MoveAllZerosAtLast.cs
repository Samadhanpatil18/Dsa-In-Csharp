using System;
class MoveAllZerosAtLast
{
    static void Main()
    {


        int[] arr = { 1, 0, 2, 0, 12 };
        int start = 0;
        int temp;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                temp = arr[start];
                arr[start] = arr[i];
                arr[i] = temp;
                start++;
            }
        }

        for (int j = 0; j < arr.Length; j++)
        {

            Console.WriteLine(arr[j]);
        }
    }
}