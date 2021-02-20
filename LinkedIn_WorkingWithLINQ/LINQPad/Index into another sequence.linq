<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// use a sequence of integers to designate output order in another sequence
List<int> preferredOrder = new List<int> {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

List <string> foods = new List<string> {"apple", "banana", "cherry", "durian", "eggplant", "fig", "grape", "honey","jalepeno", "kale"};

var q = from position in preferredOrder
         select new {Position = position, Word = foods.ElementAt(position)};
		 
foods.Dump();
q.Dump("Indexing into another sequence");