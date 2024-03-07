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
            int charCount = 0;
            string[] parts = line.Split(' ');
            char requiredChar = parts[1][0];
            string[] range = parts[0].Split('-');
            int firstPosition = int.Parse(range[0]) - 1;
            int lastPosition = int.Parse(range[1]) - 1;
            if (parts[2][firstPosition] == requiredChar) 
            {
                charCount++;
            }
            if (parts[2][lastPosition] == requiredChar)
            {
                charCount++;
            }
            if (charCount == 1)
            {
                ans++;
            }
            
        }
        Console.WriteLine($"The answer is: {ans}");
    }
}