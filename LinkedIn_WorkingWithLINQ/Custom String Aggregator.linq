<Query Kind="Statements" />

// Define a function to call from custom aggregator

// create a string from a list

List<string> foods = new List<string>{ "apple", "banana", "cherry", "durian", "eggplant", "fig", "grape", "honey", "jalapeno", "kale"};

var result = foods.Aggregate( (a,b) => $"{b}, {a}");

result.Dump();