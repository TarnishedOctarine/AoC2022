#! /usr/bin/env dotnet-script

// Read file into variable
string file = System.IO.File.ReadAllText("day4.txt");
string[] lines = file.Split("\r\n");

IEnumerable<int> range1;
IEnumerable<int> range2;
string[] delimLine;
string[] sect1;
string[] sect2;
IEnumerable<int> intersect;
int diff1;
int diff2;
int count = 0;

// Iterate through lines
foreach (string line in lines)
{
    // Split line into two arrays of string numbers
    delimLine = line.Split(',');
    sect1 = delimLine[0].Split('-');
    sect2 = delimLine[1].Split('-');
    // Create number of values in ranges
    diff1 = Int32.Parse(sect1[1]) - Int32.Parse(sect1[0]) + 1;
    diff2 = Int32.Parse(sect2[1]) - Int32.Parse(sect2[0]) + 1;
    // Create sets of values
    range1 = Enumerable.Range(Int32.Parse(sect1[0]), diff1);
    range2 = Enumerable.Range(Int32.Parse(sect2[0]), diff2);
    // Calc intersect
    intersect = range1.Intersect(range2).Distinct();

    // Check if intersect == either range
    if (intersect.Count() == range1.Count() || intersect.Count() == range2.Count())
    {
        count++;
    }
}
WriteLine($"Count: {count}");