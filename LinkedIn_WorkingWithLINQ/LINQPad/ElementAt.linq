<Query Kind="Statements" />

// ElementAt : Returns the element at a specified index

// ElementAtOrDefault : Resturns the element at a sspecified index in a sequence or a default value if the index is out of range

var fiveCount = new List<int> {0, 5, 10, 15, 20, 25, 30};

fiveCount.ElementAt(1).Dump("ElementAt 1");

fiveCount.ElementAt(4).Dump("ElementAt 1");


