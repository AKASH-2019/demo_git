/** 
 *    created by akash 14-06-2022
 * */

#include <bits/stdc++.h>

using namespace std;

int main()
{
    
    for(int i=1;i<20;i++){
		if(i%10 == 0){
			cout<<i<<" ";
			continue;
		}
		if(i>10){
			cout<<10-i%10<<" ";
			continue;
		}
		
		cout<<i%10<<" ";
	}
    

    return 0;   
}
