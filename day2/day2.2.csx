#! /usr/bin/env/ dotnet-script

// Read file into variable
string input = System.IO.File.ReadAllText("day2.txt");
string[] rounds = input.Split("\r\n");
char[] letters;
int opponent;
int self;
char selfChar;
int winScore;
char[] selfLookup =  {'X','Y','Z'};
char[] oppLookup = {'A','B','C'};

// Had to flip axis for lookup to work
int[][] winScores = {
    new int[] {3, 6, 0},
    new int[] {0, 3, 6},
    new int[] {6, 0, 3}
    };
int score;
int runningTotal = 0;

// Iterate through rounds
foreach (string round in rounds)
{
    letters = round.ToCharArray();
    opponent = Array.IndexOf(oppLookup, letters[0]);
    // Loss is 0 (0*3), Draw is 3 (1*3), Win is 6 (2*3), therefore use selflookup to get index and * by 3 to get needed score
    winScore = Array.IndexOf(selfLookup, letters[2]) * 3;
    self = Array.IndexOf(winScores[opponent], winScore);
    WriteLine($"{opponent},{self},{winScore}");
    score = (self + 1) + winScore;
    runningTotal += score;
}
WriteLine($"Total: {runningTotal}");