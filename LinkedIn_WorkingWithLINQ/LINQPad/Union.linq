<Query Kind="Statements" />

// Union : merge two sequence while removing all duplicats

var numbersA = new List<int>{0,2,4,5,6,8,9,8};
var numbersB = new List<int>{1,3,5,7,8,9};

var q = numbersA.Union(numbersB);

q.Dump();
q.OrderBy(n => n).Dump("Sorted Union");