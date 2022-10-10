
using Census;
using System.Xml.Linq;
using System;
using System.Linq;
using System.Collections.Generic;

var people = new List<Person> { };

static void menu()
{
    Console.WriteLine("1. Add Person");
    Console.WriteLine("2. Remove Person");
    Console.WriteLine("3. Listing");
    Console.WriteLine("0. Exit");
}

menu();

while (int.TryParse(Console.ReadLine(), out int readline))
{

    switch (readline)
    {
        case 1:
            Person p = CreatePerson();
            people.Add(p);
            Console.WriteLine($"Added {people.Count()} people");

            menu();
            break;

        case 2:
            Console.WriteLine("input an Id of variable that you want to remove:");
            int.TryParse(Console.ReadLine(), out int ToRemove);
            foreach (var item in people)
            {
                if (item.Id == ToRemove)
                    people.Remove(item);
            }
            menu();
            break;

        case 3:
            foreach (var item in people)
            {
                Console.WriteLine($"{item.Id}  {item.Name}  {item.Surname}  {item.Age}");
            }
            menu();
            break;

        default:
            Console.WriteLine("Wrong number");
            break;
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
}