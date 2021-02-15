<Query Kind="Statements" />

var colors = new List<string> {"Blue", "Crimson", "Brown", "Caramel", "Copper", "Orange"};

var q = colors.Where( c => c.StartsWith("C"));

// run the query
q.Dump("First run");

colors.Add("Coral");

q.Dump("Second run");

// modify the query
var q2 = q.OrderBy( c => c);
q2.Dump("Third run");

