#! /usr/bin/env dotnet-script

// Read file into variable
string file = System.IO.File.ReadAllText("day3.txt");

string[] lines = file.Split("\r\n");
int compartmentSize;
char commonChar;
string leftSide;
string rightSide;
string lower = "abcdefghijklmnopqrstuvwxyz";
string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
int prio;
int runningTotal = 0;
int x = 0;

// Iterate through lines in input
foreach (string line in lines)
{
    // Get left and right sides
    compartmentSize = line.Length / 2;
    leftSide = line.Substring(0, compartmentSize);
    rightSide = line.Substring(compartmentSize);
    // Get the common value
    char[] common = leftSide.Intersect(rightSide).ToArray();
    if (Char.IsUpper(common[0]))
    {
        prio = upper.IndexOf(common[0]) + 27;
    }
    else
    {
        prio = lower.IndexOf(common[0]) + 1;
    }
    runningTotal += prio;
}

WriteLine($"Total: {runningTotal}");