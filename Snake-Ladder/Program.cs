﻿namespace Snake_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Snake And Ladder Program");
            int StartPosition = 0;
            int PlayerPosition = 0;
            int  WinningPosition = 100;
            int diceRoll; 
            Console.WriteLine("\nPress enter to Play the game");
            string play = Console.ReadLine();
            Console.WriteLine($"Player is at position {PlayerPosition}");

            while (PlayerPosition < WinningPosition)
            {
                Random random = new Random();
                diceRoll = random.Next(1, 7);

                Console.WriteLine($"\nPlayer rolled number {diceRoll} on position {PlayerPosition}");
                int option = random.Next(1, 3);
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nPlayer landed on a Ladder");
                        PlayerPosition += diceRoll;
                       Console.WriteLine($"Player moves to position {PlayerPosition}");
                        if (PlayerPosition > WinningPosition)
                        {
                            PlayerPosition -= diceRoll;
                            Console.WriteLine($"Player remains in position {PlayerPosition}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nPlayer landed on a Snake");
                        PlayerPosition -= diceRoll;
                        Console.WriteLine($"Player moves to position {PlayerPosition}");
                        if (PlayerPosition < 0)
                        {
                            Console.WriteLine("\nNo Play, Try Again");
                            PlayerPosition = 0;
                        }
                        break;
                }
               
            }
            if (PlayerPosition == 100)
            {
                Console.WriteLine("==========Player Wins==========");
            }
        }
    }
}