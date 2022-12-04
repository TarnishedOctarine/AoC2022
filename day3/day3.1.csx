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
string[] group;
int counter = 1;

// Iterate through lines in input
for (int i = 0; i < lines.Length; i += 3)
{
    // Get the common value
    char[] common = lines[i + 0].Intersect(lines[i + 1]).Intersect(lines[i + 2]).ToArray();
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