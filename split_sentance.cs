// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
    
using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // string s = "INTERNATIONAL ISLAMIC UNIVERSITY CHITTAGONG";
        string s = "Shahjalal University    Of Science And Technology";
        int total_size = 20;
        string ans = splitSentance(s,total_size);
        Console.WriteLine(ans);
    }
    
    public static string splitSentance(string s, int total_stize){
        // string[] stringSeparators =  { " " };
        // string[] str_list = s.Split(stringSeparators, StringSplitOptions.None);
        // string[] str_list;
        int k=0,j=0,ind=0;
        int ln = s.Length;
        List<string> list = new List<string>();
        while(k<ln){
            while(k<ln && s[k]==' '){
                k++;
            }
            if(k>=ln)break;
            j=k+1;
            while(j<ln && s[j]!=' '){
                j++;
            }

            string ts = s.Substring(k,j-k);
            // Console.WriteLine(ts);
            // str_list[ind++]=ts;
            list.Add(ts);
            k = j;
        }
        String[] str_list = list.ToArray();
        // foreach(string ss in str_list){
        //     Console.WriteLine(ss);
        // }
        
        string ans = "";
        string current_string = "";

        for(int i=0; i<str_list.Length; i++){
            string temp = str_list[i];
            // string empty = "";
            if(current_string.Length == 0){
                if(temp.Length <= total_stize){
                    current_string += temp;
                }
            }
            else if(current_string.Length != 0){
                if(current_string.Length + 1 + temp.Length <= total_stize){
                    current_string += " " + temp;
                }
                else {
                    current_string = current_string;
                    // ans += current_string + "\r\n";
                    ans += current_string + "\n";
                    current_string = "";
                    i--;

                }
            }
        } 
        ans += current_string;
        return ans;
    }
}


// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++    
// using System;
// using System.Collections.Generic;

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         string s = "INTERNATIONAL ISLAMIC UNIVERSITY CHITTAGONG";
//         int total_size = 20;
        
//         string ans = splitSentance(s,total_size);
//         Console.WriteLine(ans);
//     }
    
//     public static string splitSentance(string s, int total_stize){
//         // string[] sep = {" "};
//         // string[] str_list = s.Split(sep, StringSplitOptions.None);
//         // string[] str_list;
//         int k=0,j=0,ind=0, ln = s.Length;
//         List<string> list = new List<string>();
//         while(k<ln){
//             while(k<ln && s[k]==' '){
//                 k++;
//             }
//             if(k>=ln)break;
//             j=k+1;
//             while(j<ln && s[j]!=' '){
//                 j++;
//             }

//             string ts = s.Substring(k,j-k);
//             // str_list[ind++]=ts;
//             list.Add(ts);
//             k = j;
//         }
//         String[] str_list = list.ToArray();


//         string res = "";
//         foreach(string s in str_list){
//             Console.WriteLine(s);
//         }
        
//         string ans = "";
//         string current_string = "";

//         for(int i=0; i<str_list.Length; i++){
//             string temp = str_list[i];
//             string empty = "";
//             if(current_string.Length == 0){
//                 if(temp.Length <= total_stize){
//                     current_string += temp;
//                 }
//             }
//             else if(current_string.Length != 0){
//                 if(current_string.Length + 1 + temp.Length <= total_stize){
//                     current_string += " " + temp;
//                 }
//                 else {
//                     current_string = empty + current_string;
//                     ans += current_string + "\r\n";
//                     current_string = "";
//                     i--;

//                 }
//             }
//         } 
//         ans += current_string;
//         return ans;
//     }
// }