using Library;
using System.Reflection.Metadata;

Builder employee1 = new Builder("Bob", "Ross", 1000, 1, false);
Worker employee2 = new Builder("James", "Hoffmann", 4000, 3);

Console.WriteLine(employee1.GetInfo());
Console.WriteLine(employee2.GetInfo());

Console.WriteLine("====================================");

employee1.Promote(100);
employee2.Promote(1000);

Console.WriteLine("====================================\n");

Console.WriteLine(employee1.GetInfo());
Console.WriteLine(employee2.GetInfo());

Console.WriteLine("====================================\n");
employee1.Greet();
var employee3 = new Builder("Ray", "Rusthip", 3000, 2, false);
var employee4 = new Builder("Abu", "Nahri", 500, 0);

var cs = new ConstructionSite<Worker>(employee1, employee2, employee3);
cs.HireEmployee(employee4);
Console.WriteLine();
cs.IncidentOccurred();
