<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Where any valid boolean expression is acceptable

// Use &&, &, ||, |, !, ^

var q1 = from color in CourseLib.ColorSource.GetColors()
			where color.ColorFamily == CourseLib.ColorFamily.Orange
				&& color.ColorName.Contains("O")
			select color;
			
//q1.Dump("&&");

var q2 = from color in CourseLib.ColorSource.GetColors()
			where color.ColorFamily == CourseLib.ColorFamily.Orange
				|| color.ColorName.Contains("Blue")
			select color;

q2.Dump("||");