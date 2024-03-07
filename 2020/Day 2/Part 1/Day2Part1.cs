using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadLines("filepath.txt").ToArray();
        int ans = 0;
        foreach (string line in lines) 
        {
            string[] parts = line.Split(' ');
            char requiredChar = parts[1][0];
            string[] range = parts[0].Split('-');
            int minimum = int.Parse(range[0]);
            int maximum = int.Parse(range[1]);
            int charCount = 0;
            foreach (char c in parts[2]) 
            {
                if (c == requiredChar) 
                {
                    charCount++;
                }
            }
            if (charCount >= minimum && charCount <= maximum)
            {
                ans++;
            }
        }
        Console.WriteLine($"The answer is: {ans}");
    }
}