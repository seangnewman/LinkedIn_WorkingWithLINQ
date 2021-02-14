<Query Kind="Statements" />

//Dump() is an extension method
//Created by the LINQPad Team

// output formatted data to the results window

int x = 65;
bool isLargeNumber = x > 1000;
string isLargeResult = isLargeNumber? "Large Number" : "Small Number";

x.Dump();

//// add header
 x.Dump("X value");
//
isLargeNumber.Dump ("isLargeNumber");
//
isLargeResult.Dump("isLargeResult");
