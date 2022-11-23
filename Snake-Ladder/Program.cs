namespace Snake_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Snake And Ladder Program");
            int StartingPosition = 0;
            int PlayerPosition = 0;
            int diceRoll; 
            Console.WriteLine("\nPress enter to Play the game");
            string play = Console.ReadLine();
            
            Random random = new Random();
            diceRoll = random.Next(1, 7);
            Console.WriteLine($"Player rolled number {diceRoll} on position {PlayerPosition}\n");

            int option = random.Next(1, 3);
            switch (option)
            {
                case 1:
                    Console.WriteLine("Player landed on a Ladder");
                    PlayerPosition += diceRoll;
                    Console.WriteLine($"Player moves to position {PlayerPosition}");
                    break;
                case 2:
                    Console.WriteLine("Player landed on a Snake");
                    PlayerPosition -= diceRoll;
                    Console.WriteLine($"Player moves to position {PlayerPosition}");
                    if (PlayerPosition < 0)
                    {
                        Console.WriteLine("No Play, Try Again");
                        PlayerPosition = 0;
                    }
                    break;
            }
        }
    }
}