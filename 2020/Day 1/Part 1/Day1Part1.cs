using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadLines("filepath.txt").ToArray();
        int[] myInts = Array.ConvertAll(lines, s => Int32.Parse(s));
        for (int i = 0; i < myInts.Length; i++) 
        {
            for (int j = 1; j < myInts.Length; j++) 
            {
                if (myInts[i] + myInts[j] == 2020)
                {
                    Console.WriteLine($"The answer is: {myInts[i] * myInts[j]}");
                    return;
                }
            }
        }
    }
}
