<Query Kind="Program">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

void Main()
{
	// The ColorSource data has some invalid data
	// In the ColorName and HexValue properties
	
	// 1. 
	// Write a query expression that finds ColorName values that contain hyphens ("-")
	// Also find HexValues that are not valid hexadecimal values (0-9, A - F)
	// FFFF00 is valid
	// FF34TS is invalid becuse it has an invalid char (T)
	
	// combine both these tests into a single query expression
	
	// Use this data source
	// CourseLib.ColorSource.GetColors()
	
	var q1 = from colors in CourseLib.ColorSource.GetColors()
				where( validHex(colors.HexValue) == false
				||
				colors.ColorName.Contains("-"))
				orderby colors.ColorName
				select colors;
				
	 //Console.WriteLine(validHex("ZZZZ"));
	
	 
	
	//var c = CourseLib.ColorSource.GetColors().Where( n => n.ColorName.Contains("-") ||  validHex(n.HexValue) == false).Select( n => n);
	
	q1.Dump();
	
	
}

// Define other methods and classes here
private static bool validHex(string hexValue)
{
  char[] validValues = new char[] {'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};
  
  foreach( var h in hexValue )
  {
     if( !validValues.Contains(h))
	    return false;
  }
  return true;
  
}