<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Query expressions must end with a select or groupby clause

var colors = CourseLib.ColorSource.GetColors();

var q = from color in colors
		group color by color.ColorFamily;
		
q.Dump();