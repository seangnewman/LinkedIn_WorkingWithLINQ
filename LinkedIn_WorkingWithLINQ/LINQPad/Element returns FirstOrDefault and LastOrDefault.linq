<Query Kind="Statements" />

// Returns the first or last element of a sequence

var numbers = new List<int> {50, 4,10, 3, 90, 8, -60, 7, 20, 5};

// If there is a possiblity of an empy set you will get an exception 
// use the FirstOrDefault or LastOrDefault
List<int> emptyNumbers = new List<int>();
List<string> emptyStrings = new List<string>();
List<bool> emptyBools = new List<bool>();



numbers.FirstOrDefault().Dump("Valid Sequence");
emptyNumbers.FirstOrDefault().Dump("Empty int sequence");
emptyStrings.FirstOrDefault().Dump("Empty string sequence");
emptyBools.LastOrDefault().Dump("Empty bool sequence");

