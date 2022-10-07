using Census;
using System.Xml.Linq;
using System;
using System.Linq;
using System.Collections.Generic;

Console.WriteLine($"1. Add Person");
Console.WriteLine($"2. Remove Person");
Console.WriteLine($"3. Listing");

int.TryParse(Console.ReadLine(), out int readline);

var people = new List<Person> { };



switch (readline)
{
    case 1:

        Person p = CreatePerson();

        people.Add(p);
        break;

    case 2:

        break;

    case 3:

        break;

    default:
        Console.WriteLine("Wrong number");
        break;

}
foreach (var item in people)
{
    Console.WriteLine(item.Name);
}


static Person CreatePerson()
{
    Console.WriteLine("Id ?");
    int Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Name ?");
    string Name = Console.ReadLine();
    Console.WriteLine("Surname ?");
    string Surname = Console.ReadLine();
    Console.WriteLine("Age?");
    int Age = Convert.ToInt32(Console.ReadLine());

    Person p = new Person(Id, Name, Surname, Age);
    return p;
}