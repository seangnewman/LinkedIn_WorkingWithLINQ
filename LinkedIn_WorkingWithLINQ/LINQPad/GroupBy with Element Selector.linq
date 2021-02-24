<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>


var colors = CourseLib.ColorSource.GetColors();

// use element selector to specify what properties on the members of the group

var groupedByColorFamily = colors.GroupBy( keySelector: x => x.ColorFamily, elementSelector: y => new {y.ColorName, y.HexValue});

groupedByColorFamily.Dump();