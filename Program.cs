
using Census;

// Zawsze umieszczaj swój kod w namespace'ach i klasach!
var people = new List<Person> { };
// Listy zapisujemy z dużej litery

static void menu()
{
    Console.WriteLine("1. Add Person");
    Console.WriteLine("2. Remove Person");
    Console.WriteLine("3. Listing");
    Console.WriteLine("0. Exit");
}
// Nazwy metod z dużych liter

// O takich wywołaniach pogadamy na spotkaniu. Niezbyt to estatyczne.
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
            // Nazwy zmiennych z małych liter
            int.TryParse(Console.ReadLine(), out int ToRemove);
            foreach (var item in people)
            {
                if (item.Id == ToRemove)
                    people.Remove(item);
                break;
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
        // Możesz użyć TryParse by zwalidować czy id jest liczbą
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