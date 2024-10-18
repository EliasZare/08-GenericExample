// See https://aka.ms/new-console-template for more information
using _08_GenericExample;

Console.WriteLine("Hello, World!");

//Genric Class
GenricClass<string, Test> genricClassInt = new GenricClass<string, Test>();
GenricClass<string, Test> genricClassStr  = new GenricClass<string, Test>();


//Generic Methods
Test test = new Test(myProperty:"1011");
GenricMethods.GenricMethod<Test>(test);

genricClassInt.Salary = "100";
genricClassStr.Salary = "Hundred";
Console.WriteLine(genricClassInt.Salary);
Console.WriteLine(genricClassStr.Salary);
Console.ReadKey();