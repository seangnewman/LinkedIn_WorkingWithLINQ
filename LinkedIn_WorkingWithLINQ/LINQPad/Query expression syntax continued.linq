<Query Kind="Statements" />

var colors = new List<string> {"Green", "Blush", "Yellow", "Red", "Orange", "Burgandy", "Purple", "White", "Black", "Blue", "Bronze"};


// add additional expressions

var q = from c in colors
         where c.Length > 5
		 orderby c
		 select c;
		 
q.Dump("More expressions");