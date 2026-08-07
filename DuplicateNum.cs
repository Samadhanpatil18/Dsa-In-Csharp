using System;
using System.Collections.Generic;

class DuplicateNumInArray{
    static void Main(){
        
    
 // Given an integer array, return true if any value appears more than once.
//  Input:
// [1,2,3,1]

// Output:
// true
// This time don't use a Dictionary.
// Think about another collection in C# that stores only unique values.

// 💡 Hint: HashSet<int>.


int [] array= {1,2,3,1};

HashSet<int> seen = new HashSet<int>();

foreach(int num in array){
    if(seen.Contains(num)){
        Console.WriteLine("True");
    }else
    seen.Add(num);
}
Console.WriteLine($"{nums} This Array contains Duplicate Number");}
}
