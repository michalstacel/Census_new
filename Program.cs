
using Census;

Console.WriteLine($"1. Add Person");
Console.WriteLine($"2. Remove Person");
Console.WriteLine($"3. Listing");

int.TryParse(Console.ReadLine(), out int readline);

List<AddPerson> person = new List<AddPerson> { };


switch (readline)
{


    case 1:

        break;

    case 2:

        break;

    case 3:

        break;

    default:
        Console.WriteLine("Wrong number");
        break;

}