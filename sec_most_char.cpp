#include <bits/stdc++.h>
using namespace std;
void secondFreqChar(string s)
{
  int count[256] = {}; 
  for(int i=0; i<s.size(); i++)
  {
    count[s[i]]++; //increment the count of each character by using ASCII of character as key  
  }
  //Finding the second largest number in count array
  int first = 0, second =0;
  for(int i=0; i < 256; i++)
  {
    //If the current char count is less than first, then change both variables
    if(count[i] > count[first]) //
    {
      second = first;
      first = i;
    }
    //If it is inbetween first and second
    else if(count[i] > count[second] && count[i] != count[first])
    {
      second = i;
    }
  }
  cout<<"second most frequent character is "<<char(first)<<endl; 
  if (second != '\0')
  {
    cout<<"second most frequent character is "<<char(second)<<endl;  
  }
  else//if there is no second frequent character
  {
    cout<<"there is no second most frequent character"<<endl;
  }
  
}
int main()
{
  string s  = "akash";
  cout<<"Input string is "<<s<<endl;
  secondFreqChar(s);
}