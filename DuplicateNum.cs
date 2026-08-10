using System;
using System.Collections.Generic;

class DuplicateNumInArray
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 1 };
        bool hasDuplicate = HasDuplicate(array);
        Console.WriteLine(hasDuplicate);
    }

    public static bool HasDuplicate(int[] array)
    {        HashSet<int> seen = new HashSet<int>();

        foreach (int num in array)
        {
            if (!seen.Add(num))
            {
               Console.WriteLine("Number is present");
               return true;
            }
        }

        return false; // No duplicates found
    }
};