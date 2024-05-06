namespace P1Guess_the_number
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu nombre:");
            var namePlayer = Console.ReadLine();

            var newPlayer = new Player(namePlayer);

            Game game = new Game(newPlayer);
            game.Start();
            // game.playAgain();

            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
