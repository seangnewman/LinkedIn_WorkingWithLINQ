<Query Kind="Statements">
  <Reference Relative="..\..\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\Sean\Source\Repos\LinkedIn_WorkingWithLINQ\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
</Query>

// OfType operator is used to return only the elements of a specific type
var q = from card in CourseLib.CardSource.GetCards()
           select card;
		   
var monstersOnly = q.OfType<CourseLib.Cards.Cyborg>();
monstersOnly.Select(c => new {c.Name, c.ListPrice, c.TypeName}).Dump();
q.OfType<ISerializable>().Dump();
//q.Dump();