using DesignPatterns.Singleton.Example;

var singleton = Singleton.GetInstance();
singleton.Message = "Hello! I am Singleton";

singleton = Singleton.GetInstance();

Console.WriteLine(singleton.Message);