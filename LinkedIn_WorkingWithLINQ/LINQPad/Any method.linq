<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

var colors = CourseLib.ColorSource.GetColors();

// Any : Determines whether any element of a sequence exists or satisfies a condition
//		 Stops evaluation as soon as it finds a member that satisifes
// Takes an predicate as a parameter

bool hasMatchingItem = colors.Any( w=> w.ColorName.StartsWith("C"));
hasMatchingItem.Dump("'C' found");

var q = from c in colors
        where c.ColorName.StartsWith("C")
		select c.ColorName;
		
q.Dump();

bool hasMaxBlue = colors.Any(c => c.BlueValue >= 255);
hasMaxBlue.Dump("Max Blue");