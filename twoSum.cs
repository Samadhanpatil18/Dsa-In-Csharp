using System;
using System.Collections.Generic;
class twoSum{
    static void Main(){
     int[] num = { 2, 5,   7,11, 15 };
     int target = 9;
     
     Dictionary <int, int> map = new Dictionary<int,int>();
     
 
        //it will run up to array length
        for(int i =0; i<num.Length;i++){
         int complement = target-num[i];
             
            if(map.ContainsKey(complement)){
               
                Console.WriteLine($"Indices: {map[complement]}, {i}");
                return;
            }else
            map[num[i]]= i;  // ith index ko map[ith endex ki value add kro num array ki]
            
        }
        return;
    }
}



