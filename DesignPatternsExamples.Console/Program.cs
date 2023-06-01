// See https://aka.ms/new-console-template for more information
using DesignPatternsExamples.Console._01_Creational;

Console.WriteLine("#Design Pattern");
Console.WriteLine("#Creational");
Console.WriteLine("#Singleton");
var oneObject = Singleton.Instance;
var twoObject = Singleton.Instance;
Console.WriteLine($"Create two object then compare references , result is :{Object.ReferenceEquals(oneObject, twoObject)} ");
