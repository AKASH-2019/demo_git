// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
    
using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // string inputLine = "1\r\n1 2\r\n1 2 3\r\n1 2 3 4\r\n1 2 3 4 5";
        string inputLine = "------1\r\n----1 2\r\n--1 2 3\r\n1 2 3 4";
        int totalSize = 14;
        Console.WriteLine("INPUT IS: ");
        Console.WriteLine(inputLine);
        Console.WriteLine($"Total Size : {totalSize} /n");
        
        string ans = AnsString(inputLine, totalSize);
        Console.WriteLine(ans);
    }
    
    public static string AnsString(string inputLine, int totalSize){
        string[] sep = {"\r\n", "-"};
        string[] lines = inputLine.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        string ans = "";
        foreach(string s in lines){
            // Console.WriteLine(s);
            ans += s + "\r\n";
        }
        return ans;
    }
}