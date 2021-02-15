<Query Kind="Statements" />

// LINQ to objects works with types
// that implement IEnumerable<T>

// Array are treated specially by the CLR
// Array implements IEnumerable, not IEnumerable<T>
// But for a concreate arry CLR alters it to 
// inherit Array
// Implement IEnumerable<T>, ICollection<T> and IList<T>
// Provided the array is single dimentional and zero-lower bound

Double[] array = new Double[] {4.4, 2.2, 6.6};

var q2 = from a in array
           orderby a
		   select a;
		   
q2.Dump();