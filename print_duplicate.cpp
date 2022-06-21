/** 
 *    created by akash 14-06-2022
 * */

#include <bits/stdc++.h>

using namespace std;




int main()
{
    // int arr[100];
    int arr[] = {1,2,2,3,2,5,2,3};
    int check[10000]={0};
	int n = 8;
	
	/** 
	  for(int j=0; j<n; j++){
		cin>>arr[j];
	}
    */
    
    for(int i=0; i<n-1; i++){
        for(int j=i+1; j<n; j++){
            if(arr[i] == arr[j] && check[arr[i]] == 0){
                cout<<arr[i]<<endl;
                check[arr[i]] = 1;
            }
        }
    }
    

    return 0;   
}
