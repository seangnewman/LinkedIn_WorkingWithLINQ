<Query Kind="Statements" />

// To run a subset of code
//Select a subset of code

int x = 65;
bool isLargeNumber = x > 1000;
string isLargeResult = isLargeNumber ? "Large Number" : "Small Number";

x.Dump();

// add Header
x.Dump("X value");

isLargeNumber.Dump("isLargeNumber");

isLargeResult.Dump("isLargeResult");