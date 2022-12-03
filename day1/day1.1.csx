#! /usr/bin/env/ dotnet-script

// Read file into variable
string input = System.IO.File.ReadAllText("day1.txt");

// Split file by line feed carriage return
string[] numbers = input.Split("\r\n");
int calorieCount = 0;
int maxCount = 0;

// Iterate through list and compare sum of group when come across empty value
foreach (string value in numbers)
{
    if (value != "")
    {
        calorieCount += Int32.Parse(value);
    }
    else
    {
        if (calorieCount > maxCount)
        {
            maxCount = calorieCount;
        }
        calorieCount = 0;
    }
}

// Output
WriteLine(maxCount);