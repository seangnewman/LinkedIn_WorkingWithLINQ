<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

var colors = CourseLib.ColorSource.GetColors();


var q1 = from color in colors
		 let colorRow = new {color.ColorFamily, color.ColorName, color.RedPercent}
		 orderby colorRow.RedPercent
         group colorRow by Math.Round(colorRow.RedPercent * 100) / 100
		 into colorGroup
		
		 select new {Family= colorGroup.Key , Colors = colorGroup };
		  
		  
		
q1.Dump();