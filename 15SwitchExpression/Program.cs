string player = "James Harden";

// switch (player)
// {
//     case "Michael Jordan":
//         Console.WriteLine("GOAT");
//         break;
//     case "Lebron James":
//         Console.WriteLine("King");
//         break;
//     case "Kobe Bryant":
//         Console.WriteLine("Mamba");
//         break;
//     default:
//         Console.WriteLine("Player");
//         break;
// }

string back = player switch
{
    "Michael Jordan" => "GOAT",
    "Lebron James" => "King",
    "Kobe Bryant" => "Mamba",
    _ => "Player"
};

    Console.WriteLine(back);