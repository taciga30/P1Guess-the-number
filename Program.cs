namespace P1Guess_the_number
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu nombre:");
            var namePlayer = Console.ReadLine();

            do
            {
                var numTry = GetNumberOfAttempts();
                // Turno del jugador
                var humanPlayer = new HumanPlayer(namePlayer);
                var gameWithHuman = new Game(humanPlayer);
                gameWithHuman.SetNumberOfAttempts(numTry);
                gameWithHuman.Start();

                // Turno de la IA
                var aiPlayer = new AIPlayer("AI");
                var gameWithAI = new Game(aiPlayer);
                gameWithAI.SetNumberOfAttempts(numTry);
                gameWithAI.Start();

                Console.WriteLine("¿Quieres jugar de nuevo? (Y/N)");
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Y);

            Console.WriteLine("Gracias por jugar!");
            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey(true);
        }
        // var newPlayer = new HumanPlayer(namePlayer);

        // Game game = new Game();
        // game.SetPlayer(newPlayer);
        // game.Start();

        static int GetNumberOfAttempts()
        {
            Console.WriteLine("¿Cuántos intentos quieres para poder adivinar el número?");
            return int.Parse(Console.ReadLine());
        }
    }
}
