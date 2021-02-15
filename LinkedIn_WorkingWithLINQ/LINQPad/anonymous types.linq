<Query Kind="Program" />

void Main()
{
  //Anaonymous types provide a convenient way to encapsulate
  // a set of read-only properties into a single object
  //without having to explicitly defina a type first
  // The type name is generated by the compiler
  // and is not available at the source code lvel
  // The type of each property is inferred by the compiler
  
  // Us the new operator, but don't specify a type name
  // use {} to initalize properties
  // use name/value pair within initializers to declare the property name
  
  // this is the real reason we need
  // implicitly typed local variables
  var a = new {Color = "Red", Price = 40M};
  
  ShowType(a, nameof(a));
  
}

// Define other methods and classes here
private static void ShowType(Object o, string nameOfParameter)
{
  Console.WriteLine($"variable name: {nameOfParameter}, implied type {o.GetType().FullName}");
}