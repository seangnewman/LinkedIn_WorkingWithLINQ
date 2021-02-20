<Query Kind="Statements" />

// Let's review some principles
// LINQ query expressions can be categorized into three areas

//1. Takes a sequence, returns a new sequence containing the same element type.
//    Doubles to Doubles, Stirngs to Strings, Products to Products, etc
//    Elements are the same, but may be sorted, grouped, filtered

IEnumerable<string> colors = new List<string>{"Green", "Blush", "Yellow", "Red", "Orange", "Burgandy", "Purple", "White", "Black", "Blue", "Bronze"};

// this query takes a list of string and returns a list of strings
IEnumerable<string> q1 = from c in colors
  							select c;
							
// same here, but filtered and sorted
IEnumerable<string> q2 = from c in colors
 							where c.EndsWith("e")
							orderby c
							select c;
							
//q1.Dump("(<string>)");
//q2.Dump("(<string>)");

//2. Takes a sequence, returns a new sequence containing a different type of element

// Transforms the object into another type
// Integers to string, products to strings, etc.

// This query takes a list of strings and returns a list of ints
var q3 = from c in colors
      		select c.Length;
//q3.Dump("Word Length");
			
// 3. Takes a sequence, returns a single value
//		AKA (fold, reduce, aggregate, accumulate, etc.)
//		reduces a list of data to an aggregate value
//		min, max, sum

// This query takes a list of strings and returns a single integer
// remember to use the extension methods to perform this operation
var q4 = from c in colors
			select c.Length;
			
int count = q4.Count();

count.Dump("Word Count");