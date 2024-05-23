namespace P1Guess_the_number
{

    class Game
    {
        // El modificador readonly se usa para indicar que esas propiedades solo pueden establecerse en tiempo de inicialización o dentro del constructor de la clase, y no pueden modificarse después de eso.
        // Estas propiedades se inicializan una vez al inicio del juego y no deberían cambiar su valor durante la ejecución del juego.
        private readonly Player _humanPlayer;
        private readonly Player _AIPlayer;
        private readonly int _numRandom;
        private int _numTry;

        private int GeneratedRandom()
        {
            Random numRandom = new Random();
            //Genera un numero entre 1 y 100 (101 no se incluye)
            return numRandom.Next(1, 101);
        }
        public void SetPlayer(Player humanPlayer)
        {
            _humanPlayer = humanPlayer;
        }

        public void SetOpponent(Player AIPlayer)
        {
            _AIPlayer = AIPlayer;
        }

        public void SetNumberOfAttempts(int numTry)
        {
            _numTry = numTry;
        }


        public void Start()
        {
            int numRandom = GeneratedRandom();
// ocultar el numero random para ejecutar el juego al finalizar
            Console.WriteLine(numRandom);

            Console.WriteLine("⇩");
            Console.WriteLine($"Bienvenida al juego del mentalista {_humanPlayer._namePlayer}. Deberás adivinar un número entre 1 y 100");

            Console.WriteLine($"Perfecto! Tendrás {_numTry} oportunidades para lograr descubir el número correcto.");
            Console.WriteLine("¡Empecemos!...Intenta adivinar el número");
            Console.WriteLine("⇩");

            for (int i = 1; i < (_numTry + 1) * 2; i++)
            {
                Player currentPlayer = (i % 2 != 0) ? _humanPlayer : _AIPlayer;
                int intentos = _numTry - i;

                Console.WriteLine($"Intento {i}: Turno de {currentPlayer._namePlayer}.");
                int numPlayer = currentPlayer.MakeGuess();

                if (numPlayer == numRandom)
                {
                    Console.WriteLine("⇩");
                    Console.WriteLine($"¡Felicitaciones {_humanPlayer._namePlayer}! 🎉 Has adivinado el número en {i} {(i == 1 ? "intento" : "intentos")}");
                    return;
                }
                else if (numPlayer > numRandom && intentos != 0)
                {
                    Console.WriteLine($"El número es menor, te quedan {intentos} {(intentos == 1 ? "intento" : "intentos")}");
                }
                else if (numPlayer < numRandom && intentos != 0)
                {
                    Console.WriteLine($"El número es mayor, te quedan {intentos} {(intentos == 1 ? "intento" : "intentos")}");
                }
                if (numPlayer != numRandom && intentos == 0)
                {
                    Console.WriteLine("⇩");
                    Console.WriteLine($"Perdiste 😢, el número era {numRandom}.");
                }

            }
        }

        public Game(Player humanPlayer, Player AIPlayer)
        {
            _humanPlayer = humanPlayer;
            _AIPlayer = AIPlayer;
            _numRandom = GeneratedRandom();
        }
    }
}