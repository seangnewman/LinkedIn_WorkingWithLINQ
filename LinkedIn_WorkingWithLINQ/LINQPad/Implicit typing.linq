<Query Kind="Program" />

void Main()
{
  // C# and VB added implicit typed variables
  
  
  //compiler infers type from the assignement
  // this is essential for another feature (anonymous types)
  
  var greeting = "Hi there";
  var theChar = 'a';
  
  ShowType(greeting, nameof(greeting));
  ShowType(theChar, nameof(theChar));
  
  Console.WriteLine();
  
  //simplifies typing longer type names on the left side of declaration
  SortedDictionary<string, Guid> guids1 =  new SortedDictionary<string, Guid>();
  //versus
  var guids2 = new SortedDictionary<string, Guid>();
  
  ShowType(guids2, nameof(guids2));
  
}

// Define other methods and classes here
private static void ShowType(Object o, string nameOfParameter)
{
  Console.WriteLine($"variable name: {nameOfParameter}, implied type {o.GetType().FullName}");
}