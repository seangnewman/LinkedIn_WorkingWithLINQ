<Query Kind="Statements" />

var numbers = Enumerable.Range(1, 90);

var groupedResult = from number in numbers
          			 group number by number % 10;
					 
groupedResult.Dump();