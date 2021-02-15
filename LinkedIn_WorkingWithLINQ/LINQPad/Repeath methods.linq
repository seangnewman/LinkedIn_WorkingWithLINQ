<Query Kind="Statements" />

// Repeat, adds a set of repeated items to IEnumerable

// statement based way to add items
List<int> manyThrees = new List<int>();


for(int i = 0; i < 120; i++)
{
  manyThrees.Add(3);
}

manyThrees.Dump();

// Using a function is prefereable to writing statements (Funcional Programming)
var manyFives = Enumerable.Repeat<int>( 5, 200);

manyFives.Count().Dump("Count");
manyFives.Dump("Many Fives");
