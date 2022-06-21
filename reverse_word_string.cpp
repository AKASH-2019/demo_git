/** 
 *    created by akash 14-06-2022
 * */

#include <bits/stdc++.h>

using namespace std;

int main()
{
    string s;
    // cin>>s;
    getline(cin,s);
    // cin.ignore();
    
    int ln = s.length();
    
    reverse(s.begin(), s.end());
    // cout<<s<<endl;
    int i=0;
    int j=0;
    string res="";
    while(i<ln){
		while(i<ln && s[i] == ' '){
			i++;
		}
		if(i>=ln)break;
		j=i+1;
		while(j<ln && s[j] != ' '){
			j++;
		}
		string temp = s.substr(i, j-i);
		reverse(temp.begin(), temp.end());
		if(res.length() == 0){
			res += temp;
		}else{
			res = (res + " " + temp);	
		}
		//cout<<i<<" "<<j<<endl;
		i=j;
	}
	
	cout<<res<<endl;    

    return 0;   
}
