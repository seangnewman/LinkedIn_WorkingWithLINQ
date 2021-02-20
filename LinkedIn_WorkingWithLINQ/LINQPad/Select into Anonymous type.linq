<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// select returns a sequence of the chosen type
// IEnumerable<string>, IEnumerable<Product>
//

// Transform type with anonymous type

var q = from color in CourseLib.ColorSource.GetColors()
   			orderby color.ColorName
			select new {Name = color.ColorName, Family = color.ColorFamily};
			
q.Dump("Sequence of anonymous type");
