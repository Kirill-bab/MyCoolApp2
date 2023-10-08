using Library;

Builder employee1 = new Builder("Bob", "Ross", 1000);
Worker employee2 = new Builder("James", "Hoffmann", 1000);

Console.WriteLine(employee1.GetInfo());
Console.WriteLine(employee2.GetInfo());

Console.WriteLine("====================================");

employee1.Promote(100);
employee2.Promote(100);

Console.WriteLine("====================================\n");


Console.WriteLine(employee1.GetInfo());
Console.WriteLine(employee2.GetInfo());
Console.ReadKey();