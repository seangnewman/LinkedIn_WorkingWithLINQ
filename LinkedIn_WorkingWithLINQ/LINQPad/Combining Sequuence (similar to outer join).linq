<Query Kind="Statements" />

// Join together two sequence into interesting combinations

var setA = Enumerable.Range(2, 3);
var setB = Enumerable.Range(5, 3);

var g1 = from a in setA
         from b in setB
		 group a by b into groupA
		 select groupA;
		 
g1.Dump();

var q1 = setA.Select(a => setB.Select( b => $"A: {a}, B: {b}"));
q1.Dump();

var q2 = from a in setA
		from b in setB
		select new {a, b};
		
q2.Dump();