namespace Math_Game
{
    internal class StartingMenu
    {
        GameCore core = new();
        internal void ShowMenu()
        {
            bool gameOn = true;

            do
            {
                Console.WriteLine(@"What would you like to practice?
---------------------------------
0: Game History
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
                    case "0":
                        GameTools.GetGames();
                        break;
                    case "1":
                        core.AdditionPractice();
                        break;
                    case "2":
                        core.SubtractionPractice();
                        break;
                    case "3":
                        core.MultiplicationPractice();
                        break;
                    case "4":
                        core.DivisionPractice();
                        break;
                    case "5":
                        core.RandomPractice();
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
            } while (gameOn);
        }
    }
}
