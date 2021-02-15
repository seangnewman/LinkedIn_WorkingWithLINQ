<Query Kind="Statements" />

var colors = new List<string> {"Blue", "Crimson", "Brown", "Caramel", "Copper", "Orange"};

var searchLetter = "B";
//potential querey
var q = from c in colors
         where c.StartsWith(searchLetter)
		 select c;
		 
// Change the search letter
searchLetter = "C";

// run the query, what do you see?
// at time of execution,  searchLetter = "C"
q.Dump("what do you see?");

// add a color to the list
colors.Add("Coral");

// run the query again, what do you see
q.Dump("second run");
