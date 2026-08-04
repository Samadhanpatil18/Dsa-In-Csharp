using System;
class ReverseSentece {
  static void Main() {
string str = " I love chatgpt ";

str = str.Trim(); 
string[] words = str.Split(' ');


// foreach (string word in words) {
//     Console.WriteLine(word); 
// }


int left = 0;
int right = words.Length-1;

while(left<right){
   
    string temp = words[left];
    words[left]=words[right];
    words[right]=temp;
    
    left++;
    right--;
    
}

string result ="";
foreach (string word in words) {
    result+=word+" " ;
}
Console.WriteLine(result);

  }
}