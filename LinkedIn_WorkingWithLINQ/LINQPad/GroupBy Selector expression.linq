<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Change the key name or value name
// with the resultSelector


var colors = CourseLib.ColorSource.GetColors();

var groupedByColorFamily = colors.GroupBy(keySelector: x => x.ColorFamily, elementSelector: y => new{y.ColorName, y.HexValue}, resultSelector: (key, value) => new {Family=key, Colors=value});

groupedByColorFamily.Dump();
						