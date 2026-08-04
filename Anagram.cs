 using System;
 class IsAnagram {
 static void Main(){
    
    string str1= " Listen";
    string str2= "Silent ";
    
    //lower case
    
    string str3=str1.Trim().ToLower();
    string str4=str2.Trim().ToLower();
    
    
    //length 
    
    if(str3.Length != str4.Length){
   Console.WriteLine("No");
   return;
    }
    
    
    //Create a dictionary to store character frequencies 

    
    
    Dictionary<char, int> CharCount= new Dictionary<char, int>();
    
   foreach(char c in str3){
       if(CharCount.ContainsKey(c)){
           CharCount[c]++;
           
       }else
      CharCount[c]=1;
   }
    
    
    foreach(char c in str4){
        if(! CharCount.ContainsKey(c)){
            Console.WriteLine("No");
            
        }else{
            CharCount[c]--;
        }
    }
    
    foreach (var item in CharCount)
{
    if (item.Value != 0)
    {
        Console.WriteLine("No");
        return;
    }
}

Console.WriteLine("Yes");
    
 }
}