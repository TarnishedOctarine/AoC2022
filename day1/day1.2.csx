#! /usr/bin/env/ dotnet-script

// Read file into variable
string input = System.IO.File.ReadAllText("day1.txt");
string[] numbers = input.Split("\r\n");
int calorieCount = 0;
int[] maxCounts = {0,0,0};

// Iterate through list and compare sum of group to each value in maxCounts after each group
foreach (string value in numbers)
{
    // if val empty, then its end of group
    if (value != "")
    {
        calorieCount += Int32.Parse(value);
    }
    else
    {
        if (calorieCount > maxCounts.Min())
        {
            Array.Sort(maxCounts);
            maxCounts[0] = calorieCount;
        }
        calorieCount = 0;
    }
}
WriteLine($"sum: {maxCounts.Sum()}");