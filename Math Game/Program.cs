using Math_Game;

var startingMenu = new StartingMenu();

Console.WriteLine("Hello! Thank you for choosing to play my math game! It is aimed towards helping you practice your basic math skills.\nWhat is your player name?");
Console.WriteLine("---------------------------------");

var playerName = Console.ReadLine();

Console.WriteLine("---------------------------------");
Console.WriteLine($"It is nice to meet you, {playerName}.");

var currentDate = DateTime.UtcNow;
var gameHistory = new List<string>();

startingMenu.ShowMenu();  
//void StartingMenu()
//{
//    bool gameOn = true;

//    do
//    {
//        Console.WriteLine(@"What would you like to practice?
//---------------------------------
//0: Game History
//1: Addition
//2: Subtraction
//3: Multiplication
//4: Division
//5: Random
//6: Exit
//---------------------------------");
//        var practiceChoice = Console.ReadLine().Trim();
//        switch (practiceChoice)
//        {
//            case "0":
//                GetGames();
//                break;
//            case "1":
//                AdditionPractice();
//                break;
//            case "2":
//                SubtractionPractice();
//                break;
//            case "3":
//                MultiplicationPractice();
//                break;
//            case "4":
//                DivisionPractice();
//                break;
//            case "5":
//                RandomPractice();
//                break;
//            case "6":
//                Console.WriteLine("---------------------------------");
//                Console.WriteLine("See you next time!");
//                Console.WriteLine("---------------------------------");
//                Environment.Exit(0);
//                break;
//            default:
//                Console.WriteLine("---------------------------------");
//                Console.WriteLine("Invalid entry, please select a valid option from the menu!");
//                Console.WriteLine("---------------------------------");
//                continue;
//        }
//    } while (gameOn);
//}
//void GetGames()
//{
//    Console.Clear();
//    Console.WriteLine("Game History");
//    Console.WriteLine("---------------------------------");
//    foreach (var game in gameHistory)
//    {
//        Console.WriteLine(game);
//    }
//    Console.WriteLine("---------------------------------");
//}
//void AdditionPractice()
//{
//    Console.WriteLine("---------------------------------");
//    Console.WriteLine("You have chosen Addition, I hope you are ready!");
//    Console.WriteLine("---------------------------------");

//    var randomNumber = new Random();
//    int firstNumber;
//    int secondNumber;
//    int playerScore = 0;

//    for (int i = 0; i < 5; i++)
//    {
//        firstNumber = randomNumber.Next(0, 99);
//        secondNumber = randomNumber.Next(0, 99);
//        Console.WriteLine($"{firstNumber} + {secondNumber} = ??");
//        Console.WriteLine("---------------------------------");

//        var playerAnswer = Console.ReadLine().Trim();

//        if (int.Parse(playerAnswer) == firstNumber + secondNumber)
//        {
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("Good Job! Your answer is correct!");
//            Console.WriteLine("---------------------------------");
//            playerScore++;
//        }
//        else
//        {
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("Sorry, your answer is incorrect. Better luck next time!");
//            Console.WriteLine("---------------------------------");
//        }
//    }
//    AddToHistory(playerScore, "Addition");
//}
//void SubtractionPractice()
//{
//    Console.WriteLine("---------------------------------");
//    Console.WriteLine("You have chosen Subtraction, I hope you are ready!");
//    Console.WriteLine("---------------------------------");

//    var randomNumber = new Random();
//    int firstNumber;
//    int secondNumber;
//    int playerScore = 0;

//    for (int i = 0; i < 5; i++)
//    {
//        firstNumber = randomNumber.Next(0, 99);
//        secondNumber = randomNumber.Next(0, 99);
//        Console.WriteLine($"{firstNumber} - {secondNumber} = ??");
//        Console.WriteLine("---------------------------------");

//        var playerAnswer = Console.ReadLine().Trim();

//        if (int.Parse(playerAnswer) == firstNumber - secondNumber)
//        {
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("Good Job! Your answer is correct!");
//            Console.WriteLine("---------------------------------");
//            playerScore++;
//        }
//        else
//        {
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("Sorry, your answer is incorrect. Better luck next time!");
//            Console.WriteLine("---------------------------------");
//        }
//    }
//    AddToHistory(playerScore, "Subtraction");
//}
//void MultiplicationPractice()
//{
//    Console.WriteLine("---------------------------------");
//    Console.WriteLine("You have chosen Multiplication, I hope you are ready!");
//    Console.WriteLine("---------------------------------");

//    var randomNumber = new Random();
//    int firstNumber;
//    int secondNumber;
//    int playerScore = 0;

//    for (int i = 0; i < 5; i++)
//    {
//        firstNumber = randomNumber.Next(0, 9);
//        secondNumber = randomNumber.Next(0, 9);
//        Console.WriteLine($"{firstNumber} x {secondNumber} = ??");
//        Console.WriteLine("---------------------------------");

//        var playerAnswer = Console.ReadLine().Trim();

//        if (int.Parse(playerAnswer) == firstNumber * secondNumber)
//        {
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("Good Job! Your answer is correct!");
//            Console.WriteLine("---------------------------------");
//            playerScore++;
//        }
//        else
//        {
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("Sorry, your answer is incorrect. Better luck next time!");
//            Console.WriteLine("---------------------------------");
//        }
//    }
//    AddToHistory(playerScore, "Multiplication");
//}
//void DivisionPractice()
//{
//    Console.WriteLine("---------------------------------");
//    Console.WriteLine("You have chosen Division, I hope you are ready!");
//    Console.WriteLine("---------------------------------");

//    int playerScore = 0;

//    for (int i = 0; i < 5; i++)
//    {
//        var divisionNumbers = GetDivisionNumbers();
//        var firstNumber = divisionNumbers[0];
//        var secondNumber = divisionNumbers[1];

//        Console.WriteLine($"{firstNumber} / {secondNumber} = ??");
//        Console.WriteLine("---------------------------------");

//        var playerAnswer = Console.ReadLine().Trim();

//        if (int.Parse(playerAnswer) == firstNumber / secondNumber)
//        {
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("Good Job! Your answer is correct!");
//            Console.WriteLine("---------------------------------");
//            playerScore++;
//        }
//        else
//        {
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("Sorry, your answer is incorrect. Better luck next time!");
//            Console.WriteLine("---------------------------------");
//        }
//    }
//    AddToHistory(playerScore, "Division");
//}
//void RandomPractice()
//{
//    Console.WriteLine("---------------------------------");
//    Console.WriteLine("You have chosen Random, I hope you are ready for a surprise!");
//    Console.WriteLine("---------------------------------");

//    var randomNumber = new Random().Next(1, 4);
//    switch (randomNumber)
//    {
//        case 1:
//            AdditionPractice(); 
//        break;
//        case 2:
//            SubtractionPractice();
//        break;
//        case 3:
//            MultiplicationPractice();
//        break;
//        case 4:
//            DivisionPractice();
//        break;
//    }
//}
//int[] GetDivisionNumbers()
//{
//    var randomNumber = new Random();
//    var firstNumber = randomNumber.Next(1, 99);
//    var secondNumber = randomNumber.Next(1, 99);
//    var result = new int[2];

//    while (firstNumber % secondNumber != 0)
//    {
//        firstNumber = randomNumber.Next(1, 99);
//        secondNumber = randomNumber.Next(1, 99);
//    }

//    result[0] = firstNumber;
//    result[1] = secondNumber;


//    return result;
//}
//void AddToHistory(int playerScore, string gameType)
//{
//    gameHistory.Add($"{DateTime.Now} - {gameType}: {playerScore} Points");
//}