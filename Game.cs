namespace P1Guess_the_number
{

    class Game
    {
        public Player _player;
        public static int GeneratedRandom()
        {
            Random numRandom = new Random();
            //Genera un numero entre 1 y 100 (101 no se incluye)
            return numRandom.Next(1, 101);
        }
        public void Start()
        {
            do
            {
                int numRandom = GeneratedRandom();
                Console.WriteLine(numRandom);
                Console.WriteLine("⇩");
                Console.WriteLine($"Bienvenida al juego del mentalista {_player._namePlayer}. Deberás adivinar un número entre 1 y 100");

                Console.WriteLine("¿Cuántos intentos quieres para poder adivinar el número?");
                var numTry = Console.ReadLine();

                Console.WriteLine($"Perfecto! Tendrás {numTry} oportunidades para lograr descubir el número correcto.");
                Console.WriteLine("¡Empecemos!...Intenta adivinar el número");
                Console.WriteLine("⇩");

                for (int i = 1; i < (Int32.Parse(numTry)) + 1; i++)
                {
                    int numPlayer = Player.MakeGuess();
                    int intentos = Int32.Parse(numTry) - i;

                    if (numPlayer == numRandom)
                    {
                        Console.WriteLine("⇩");
                        if (i != 1)
                        {

                            Console.WriteLine($"¡Felicitaciones! 🎉 Has adivinado el número en {i} intentos");
                        }
                        else
                        {

                            Console.WriteLine($"¡Felicitaciones! 🎉 Has adivinado el número en {i} intento");
                        }

                        break;
                    }
                    else if (numPlayer > numRandom && intentos != 0)
                    {

                        if (intentos != 1)
                        {

                            Console.WriteLine($"El número es menor, te quedan {intentos} intentos");
                        }
                        else
                        {

                            Console.WriteLine($"El número es menor, te queda {intentos} intento");
                        }
                    }
                    else if (numPlayer < numRandom && intentos != 0)
                    {
                        if (intentos != 1)
                        {

                            Console.WriteLine($"El número es mayor, te quedan {intentos} intentos");
                        }
                        else
                        {

                            Console.WriteLine($"El número es mayor, te queda {intentos} intento");
                        }
                    }
                    if (numPlayer != numRandom && intentos == 0)
                    {
                        Console.WriteLine("⇩");
                        Console.WriteLine($"Perdiste 😢, el número era {numRandom}.");
                    }

                }
                Console.WriteLine($"¿{_player._namePlayer} quieres jugar de nuevo?(Y/N)");
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Y);

            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey(true);
        }





        public Game(Player player)
        {
            _player = player;
        }

    }

}