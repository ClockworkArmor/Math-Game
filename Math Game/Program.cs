// Type a "High Level" statement here for your code
Console.WriteLine("Hello! Thank you for choosing to play my math game! It is aimed towards helping you practice your basic math skills.\nWhat is your player name?");
Console.WriteLine("---------------------------------");
var playerName = Console.ReadLine();
Console.WriteLine("---------------------------------");
Console.WriteLine($"It is nice to meet you, {playerName}.");
while (true)
{
    Console.WriteLine(@"What would you like to practice?
---------------------------------
1: Addition
2: Subtraction
3: Multiplication
4: Division
5: Random
6: Exit
---------------------------------");
    var practiceChoice = Console.ReadLine().Trim();
    switch (practiceChoice)
    {
        case "1":
            Console.WriteLine("---------------------------------");
            Console.WriteLine("You have chosen Addition, I hope you are ready!");
            Console.WriteLine("---------------------------------");
            break;
        case "2":
            Console.WriteLine("---------------------------------");
            Console.WriteLine("You have chosen Subtraction, I hope you are ready!");
            Console.WriteLine("---------------------------------");
            break;
        case "3":
            Console.WriteLine("---------------------------------");
            Console.WriteLine("You have chosen Multiplication, I hope you are ready!");
            Console.WriteLine("---------------------------------");
            break;
        case "4":
            Console.WriteLine("---------------------------------");
            Console.WriteLine("You have chosen Division, I hope you are ready!");
            Console.WriteLine("---------------------------------");
            break;
        case "5":
            Console.WriteLine("---------------------------------");
            Console.WriteLine("You have chosen Random, I hope you are ready for a surprise!");
            Console.WriteLine("---------------------------------");
            break;
        case "6":
            Console.WriteLine("---------------------------------");
            Console.WriteLine("See you next time!");
            Console.WriteLine("---------------------------------");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Invalid entry, please select a valid option from the menu!");
            Console.WriteLine("---------------------------------");
            continue;
    }
    break;
}



