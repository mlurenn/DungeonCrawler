public class Game
{
    private bool isRunning;

    public Game()
    {
        isRunning = false;
        //player = new Player();
    }

    // Start the game and initiate the game loop
    public void StartGame()
    {
        Console.WriteLine("================================");
        Console.WriteLine("        Dungeon Crawler         ");
        Console.WriteLine("================================");

        Console.WriteLine("Press any key to start the game...");
        Console.ReadKey();
        Console.Clear();

        isRunning = true;
        GameLoop();
    }

    // The main game loop that handles user input and game logic
    private void GameLoop()
    {
        while (isRunning)
        {
            Console.WriteLine("\nEnter a command (type 'help' for help):");
            string? input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("\nNo input detected. Please enter a command.");
                isRunning = false;
                break;
            }

            CheckInput(input);
        }
    }

    private void CheckInput(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("\nNo input detected. Please enter a command.");
            return;
        }

        switch (input.ToLowerInvariant().Trim())
        {
            case "quit":
                Console.WriteLine("\nQuitting the game...");
                isRunning = false;
                break;

            case "help":
                Console.WriteLine("\nAvailable commands:");
                Console.WriteLine("  help - Show this help message");
                Console.WriteLine("  quit - Quit the game");
                break;
            
            default:
                Console.WriteLine($"\nYou entered: {input}, but this command is not recognized.");
                Console.WriteLine("'help' for a list of commands.");
                break;
        }
    }
}