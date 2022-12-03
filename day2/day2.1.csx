#! /usr/bin/env/ dotnet-script

// Read file into variable
string input = System.IO.File.ReadAllText("day2.txt");
string[] rounds = input.Split("\r\n");
char[] letters;
int opponent;
int self;
char[] selfLookup =  {'X','Y','Z'};
char[] oppLookup = {'A','B','C'};
int[,] winScores = {{3, 0, 6},
                    {6, 3, 0},
                    {0, 6, 3}};
int score;
int runningTotal = 0;

// Iterate through rounds
foreach (string round in rounds)
{
    letters = round.ToCharArray();
    opponent = Array.IndexOf(oppLookup, letters[0]);
    self = Array.IndexOf(selfLookup, letters[2]);
    score = winScores[self, opponent] + (self + 1);
    runningTotal += score;
}
WriteLine($"Total: {runningTotal}");