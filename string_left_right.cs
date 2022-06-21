// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
    
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string inputLine = "1\r\n1 2\r\n1 2 3\r\n1 2 3 4\r\n1 2 3 4 5";
        int totalSize = 14;
        Console.WriteLine("INPUT IS: ");
        Console.WriteLine(inputLine);
        Console.WriteLine($"Total Size : {totalSize} /n");
        // string[] lines = inputLine.Split("\r\n",StringSplitOptions.None);
        // foreach(string s in lines){
        //     Console.WriteLine(s.Length);
        // }
        string ans = AnsString(inputLine, totalSize);
        Console.WriteLine(ans);
    }
    
    public static string AnsString(string inputLine, int totalSize){
        string[] lines = inputLine.Split("\r\n", StringSplitOptions.None);
        // Console.WriteLine(lines[lines.Length-1].Length);
        int lastLine = lines[lines.Length-1].Length;
        string ans = "";
        foreach(string s in lines){
            int space = (lines[lines.Length-1].Length - s.Length);
            string empty="";
            space += lastLine;
            // for (int i = 0; i < totalSize - s.Length; i++)
            // {
            //     empty += " ";
            // }
            for(int i=0;i<space; i++){
                empty += " ";
            }
            string temp = empty + s;
            ans += temp + "\r\n";
        }
        return ans;
    }
}