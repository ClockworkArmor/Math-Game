// Type a "High Level" statement here for your code
Console.WriteLine("Hello! Thank you for choosing to play my math game! It is aimed towards helping you practice your basic math skills.\nWhat is your player name?");
Console.WriteLine("---------------------------------");
string playerName = Console.ReadLine();
Console.WriteLine("---------------------------------");
Console.WriteLine($@"It is nice to meet you, {playerName}. What would you like to practice?
---------------------------------
1: Addition
2: Subtraction
3: Multiplication
4: Division
5: Random
6: Exit");
string practiceChoice = Console.ReadLine();
if (practiceChoice == "1")
{
    Console.WriteLine("You have chosen Addition, I hope you are ready!");
}
else if (practiceChoice == "2")
{
    Console.WriteLine("You have chosen Subtraction, I hope you are ready!");
}
else if (practiceChoice == "3")
{
    Console.WriteLine("You have chosen Multiplication, I hope you are ready!");
}
else if (practiceChoice == "4")
{
    Console.WriteLine("You have chosen Division, I hope you are ready!");
}
else if (practiceChoice == "5")
{
    Console.WriteLine("You have chosen Random, I hope you are ready for a surprise!");
}
else if (practiceChoice == "6")
{
    Console.WriteLine("See you next time!");
    Environment.Exit(0);
}


