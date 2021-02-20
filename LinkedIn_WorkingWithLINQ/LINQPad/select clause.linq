<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// select returns a sequence of the chosen type
// IEnumerable<string>, IEnumerable<Product>

// In many cases, thisis the same type as original sequence
// In this exampe, it's a list of the same type

var q  = from color in CourseLib.ColorSource.GetColors()
 			orderby color.ColorFamily
			 
			select color;
			
q.Dump();
//
//var q = from color in CourseLib.ColorSource.GetColors()
//          where color.ColorFamily == CourseLib.ColorFamily.Orange
//		  select color;
//
//