<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Use select to return a sequence of a different type

var q1 = from color in CourseLib.ColorSource.GetColors()
   			select color.BlueValue;
			
//q1.Dump("IEnumerable<int>");

var q2 = from color in CourseLib.ColorSource.GetColors()
			select color.ColorName;
			
q2.Dump("IEnumerable<string>");