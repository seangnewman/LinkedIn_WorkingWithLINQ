<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Challenge

// create a query expression that outputs a sequence
// Show ColorName
// and shows a RGB color formula
// "rgb(a, b, c)" where a = redvalue, g=greenvalue, b=bluevalue
// for example

//SpringGreen, rgb(000,255,127)
// LightYellow, rgb(255, 255, 224)

// optional requirement, format number values with three place
// optional requirment, sort by Greenvalue
// example 23 is formatted as 023

var q1 = from color in CourseLib.ColorSource.GetColors()
				select new{Name = color.ColorName + ", rgb (" + color.RedValue.ToString("000") + "," + color.GreenValue.ToString("000") + "," + color.BlueValue.ToString("000") + ")"};
				
q1.Dump("Result");