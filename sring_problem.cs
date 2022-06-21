using System;
using System.Collections.Generic;

namespace Enosis_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = "1\r\n1 2\r\n1 2 3\r\n1 2 3 4";
            string inputLine1 = "Shahjalal University Of Science And Technology";
            int totalSize = 14;
            int totalSize1 = 30;
            Console.WriteLine("INPUT IS: ");
            Console.WriteLine(inputLine);
            Console.WriteLine($"Total Size : {totalSize}");
            string ans = ReturnAns(inputLine, totalSize);
            Console.WriteLine(ans);

            Console.WriteLine();
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine();

            Console.WriteLine("INPUT IS: ");
            Console.WriteLine(inputLine1);
            Console.WriteLine($"Total Size : {totalSize1}");
            string ans1 = ReturnAns1(inputLine1, totalSize1);
            Console.WriteLine(ans1);



            Console.WriteLine("-------Left to center"); 
            string experimentLeft = "1\r\n1 2\r\n1 2 3\r\n1 2 3 4";
            Console.WriteLine(experimentLeft);
            string experimentCenter = LeftToCenter(experimentLeft, totalSize);
            Console.WriteLine(experimentCenter);

            Console.WriteLine("--- Right to Left---");
            string experimentRight = "------1\r\n----1 2\r\n--1 2 3\r\n1 2 3 4";
            Console.WriteLine(experimentRight);
            string experimentLeft1 = RightToLeft(experimentRight,totalSize);
            Console.WriteLine(experimentLeft1);

            Console.WriteLine("--- Right to Center---");
            Console.WriteLine(experimentRight);
            string experimentCenter1 = RightToCenter(experimentRight, totalSize);
            Console.WriteLine(experimentCenter1);

            Console.WriteLine("---------Split method output------");
            List<string> split = SplitList("i   love   you too");
            foreach (string s in split)
                Console.WriteLine(s);

            string y6 = lineToRight(inputLine1, totalSize1);
            Console.WriteLine(y6);
        }

        public static List<string> SplitList(string text)
        {
            int j = 0;
            text += " ";
            int n = text.Length;
            List<string> ans = new List<string>();
            for (int i = 0; i < n; i++)
            {
                if (text[i] == ' ' && i != n - 1 && text[i + 1] == ' ') continue;
                if (text[i] == ' ')
                {
                    //Console.WriteLine("Entered");
                    string temp = text.Substring(j, i - j);
                    //Console.WriteLine(temp);
                    ans.Add(temp);
                    j = i + 1;
                }
            }
            return ans;
        }

        public static string RightToCenter (string inputLine,int totalSize)
        {
            string[] seperators = { "\r\n", "-" };
            string[] lines = inputLine.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            string output = "";

            foreach (string s in lines)
            {
                string empty = "";
                string ans = "";
                int padding = totalSize - s.Length;
                int i = 0;
                for (i = 0; i < padding / 2; i++)
                    empty += "-";
                ans += empty + s;

                output += ans + "\r\n";
            }
            return output;
        }
        public static string RightToLeft(string inputLine,int totalSize)
        {
            string[] seperators =  { "\r\n" ,"-" };
            string[] lines = inputLine.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            string output = "";
            
            foreach (string s in lines)
            {
                    output += s + "\r\n";  
            }
            return output;
        }

        public static string LeftToCenter(string inputLine, int totalSize)
        {
            string[] separators =  { "\r\n" };
            string[] lines = inputLine.Split(separators, StringSplitOptions.None);

            string output = "";

            foreach(string s in lines)
            {
                string empty = "";
                string ans = "";
                int padding = totalSize - s.Length;
                int i = 0;
                for (i = 0; i < padding/2; i++)
                    empty += "-";
                ans += empty + s;
                
                output += ans + "\r\n";
            }

            return output;
        }

        //Jodi Proti Line Individually Right Align Korte Bole
        public static string ReturnAns(string inputLine, int totalSize)
        {
            string[] stringSeparators  = { "\r\n" };
            string[] lines = inputLine.Split(stringSeparators, StringSplitOptions.None);
            //Console.WriteLine("Nr. Of items in list: " + lines.Length);
            string methodOutput = "";
            foreach (string s in lines)
            {
                string empty = "";
                for (int i = 0; i < totalSize - s.Length; i++)
                {
                    empty += " ";
                }
                string ans = s;
                ans = empty + s;
                methodOutput += ans + "\r\n";
                //Console.WriteLine(ans);
            }
            return methodOutput;
        }

        // Question er moto jodi Word By Word Thake Oi Gula ke Total Size er moddhe
        // Right Align kore Show korte Bole
        public static string lineToRight (string inputLine,int totalSize)
        {
            string[] separators = new string[] { " " };
            string[] words = inputLine.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string output = "";
            string line_break = "";
            for (int i = 0; i < totalSize; i++)
                line_break += " ";

            string CurrentAns = "";

            for (int index = 0; index < words.Length; index++)
            {
                string s = words[index];
                string empty = "";

                if(CurrentAns.Length == 0)
                {
                    if(s.Length<=totalSize)
                    {
                        CurrentAns += s;
                    }
                    else
                    {
                        output += line_break + "\r\n";
                    }
                }
                else
                {
                    if(CurrentAns.Length + 1 + s.Length <= totalSize)
                    {
                        CurrentAns += " " + s;

                    }
                    else
                    {
                        for (int i = 0; i < totalSize - CurrentAns.Length; i++)
                            empty += " ";
                        output += empty + CurrentAns + "\r\n";
                        CurrentAns = "";
                        index--;
                    }
                }
            }

            string emptyst = "";
            for (int i = 0; i < totalSize - CurrentAns.Length; i++)
                emptyst += " ";
            output += emptyst + CurrentAns;

            return output;
        }
        // Question er moto jodi Word By Word Thake Oi Gula ke Total Size er moddhe
        // Right Align kore Show korte Bole 
        public static string ReturnAns1(string inputLine, int totalSize)
        {
            string[] stringSeparators =  { " " };
            string[] lines = inputLine.Split(stringSeparators, StringSplitOptions.None);
            //Console.WriteLine("Nr. Of items in list: " + lines.Length);
            
            string MethodAns = "";
            string CurrentAns = "";
            for (int index = 0; index < lines.Length; index++)
            {
                string s = lines[index];

                string empty = "";
                if (CurrentAns.Length == 0)
                {
                    if (s.Length <= totalSize)
                    {
                        CurrentAns += s;
                    }
                }
                else if (CurrentAns.Length != 0)
                {
                    if (CurrentAns.Length + 1 + s.Length <= totalSize)
                    {
                        CurrentAns += " " + s;
                    }
                    else
                    {
                        CurrentAns = empty + CurrentAns;
                        MethodAns += CurrentAns + "\r\n";
                        CurrentAns = "";
                        index--;
                    }
                }

            }

            
            MethodAns += CurrentAns ;
            
            return MethodAns;
        }

        
    }
}