// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
    
using System;

public class HelloWorld
{
    static void Main(string[] args) {
        // Array of integers
        int[] intArray = new int[] {
            9,
            2,
            4,
            3,
            1,
            5
        };
        Console.WriteLine("Original array");
        foreach(int i in intArray) {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        // Sort array in ASC order
        Console.WriteLine("Sorted array in ASC order");
        Array.Sort(intArray);
        foreach(int i in intArray) {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Sorted array in DESC order");
        // Sort Array in DESC order
        Array.Reverse(intArray);
        foreach(int i in intArray) {
            Console.Write(i + " ");
        }
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        
        string[] strArray = new string[] { "Mahesh", "David", "Allen", "Joe", "Monica" };
        Console.WriteLine();
        Console.WriteLine("Original array");
        foreach (string str in strArray)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();
        // Sort array
        Array.Sort(strArray);
        // Read array items using foreach loop
        Console.WriteLine("Sorted array in ASC order...........");
        foreach (string str in strArray)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();
        Array.Reverse(strArray);
        Console.WriteLine("Sorted array in DESC order............");
        foreach (string str in strArray)
        {
            Console.Write(str + " ");
        }
    }
}