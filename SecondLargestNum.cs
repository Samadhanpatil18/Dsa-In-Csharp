using System;
class SecondLargest
{
    static void Main()
    {
        int[] array = { 10, 5, 8, 20, 15 };

        int largest = int.MinValue;
        var Slargest = int.MinValue;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (array[i] > largest)
            {
                Slargest = largest;
                largest = array[i];
                // Console.WriteLine(array[array.Length]);
            }
            else
                if (array[i] < largest && array[i] > Slargest)
                {
                    Slargest = array[i];
                }

        }
        Console.WriteLine(largest);
        Console.WriteLine(Slargest);
    }

}