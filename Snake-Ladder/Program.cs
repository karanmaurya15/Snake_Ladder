namespace Snake_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Snake And Ladder Program");
            int PlayerPosition = 0;
            int diceRoll; 
            Console.WriteLine("\nPress enter to Play the game");
            string play = Console.ReadLine();
            Console.WriteLine("Player is at Start position : " + PlayerPosition);
            Random random = new Random();
            diceRoll = random.Next(1, 7);
            Console.WriteLine("\nPlayer rolled number is : " + diceRoll);
        }
    }
}