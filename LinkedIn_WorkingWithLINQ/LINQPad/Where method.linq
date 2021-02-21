<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

//The where clause filters the sequence based on a predicate function
// The predicate is applied to each element in the sequence. 
// define a predicate that uses a boolean expression
// to determine what to return in filtered sequence

var q = from color in CourseLib.ColorSource.GetColors()
 			where (color.ColorFamily == CourseLib.ColorFamily.Orange)
			select color;
			
q.Dump();