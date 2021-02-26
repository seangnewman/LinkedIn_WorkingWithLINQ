<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

List<int> numbers = new List<int>{1, 2, 2, 1, 3, 5, 5, 6};

var q = numbers.Distinct();

numbers.Dump();
q.Dump();

// use select to specify what property to evaluate for distinct

var distinctColors = CourseLib.ColorSource.GetColors().Select(x => x.HexValue).Distinct();

distinctColors.Dump();