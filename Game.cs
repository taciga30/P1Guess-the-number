namespace P1Guess_the_number
{
    class Game
    {
        private Player _player;
        private int TargetNumber;
        private string numTry;
        private int RandomNumberGenerator()
        {
            Random numRandom = new Random();
            //Genera un numero entre 1 y 100 (101 no se incluye)
            TargetNumber = numRandom.Next(1, 101);
            return TargetNumber;
        }

        public void Start()
        {
            
            Console.WriteLine(TargetNumber);
            Console.WriteLine("⇩");
            Console.WriteLine($"Bienvenida al juego del mentalista {_player._namePlayer}. Deberás adivinar un número entre 1 y 100");

            Console.WriteLine("¿Cuántos intentos quieres para poder adivinar el número?");
            numTry = Console.ReadLine();

            Console.WriteLine($"Perfecto! Tendrás {numTry} oportunidades para lograr descubir el número correcto.");
            Console.WriteLine("¡Empecemos!...Intenta adivinar el número");
            Console.WriteLine("⇩");

            CheckGuess();
        }
        
        // Agrega un método privado que nos va a permitir validar la predicción (CheckGuess(int guess, int targetNumber)).
        private void CheckGuess()
        {
            for (int i = 1; i < (Int32.Parse(numTry)) + 1; i++)
            {
                int guess = Player.MakeGuess();
                int numPlayer = Player.GetLastGuess();
                int intentos = Int32.Parse(numTry) - i;

                if (numPlayer == TargetNumber)
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
                else if (numPlayer > TargetNumber && intentos != 0)
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
                else if (numPlayer < TargetNumber && intentos != 0)
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
                
                else if (numPlayer != TargetNumber && intentos == 0)
                {
                    Console.WriteLine("⇩");
                    Console.WriteLine($"Perdiste 😢, el número era {TargetNumber}.");
                }
            }
        }

        // public playAgain()
        // {
        //     Console.WriteLine($"¿{nombre} quieres jugar de nuevo?(Y/N)");
        //         Console.ReadKey(true);
        // }
        public Game(Player player)
        {
            _player = player;
            RandomNumberGenerator();
        }
    }
}