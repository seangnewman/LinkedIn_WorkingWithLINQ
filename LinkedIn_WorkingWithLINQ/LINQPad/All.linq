<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// All : retusn where all elements in the input sequence
// match the given predicate

var colors = CourseLib.ColorSource.GetColors();

var numbers = new List<int> {24, 19, 16, 176 , 14, 24, -10};

var areEven = numbers.All( x => x % 2 == 0 );

areEven.Dump("All are even numbers.");

var hasTwoDigits = numbers.All( n => Math.Floor(Math.Log10(Math.Abs(n)) + 1) == 2);

hasTwoDigits.Dump("All have two digits.");



