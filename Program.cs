namespace P1Guess_the_number;

class Program
{
    static void Main(string[] args)
    {
        int numRandom = Game.GeneratedRandom();
        Console.WriteLine(numRandom);
        Console.WriteLine("Ingresa tu nombre:");
        var namePlayer = Console.ReadLine();
        Console.WriteLine("¿Cuántos intentos quieres para poder adivinar el número?");
        var numTry = Console.ReadLine();
        Console.WriteLine($"Bienvenida al juego del mentalista {namePlayer}. Tendrás {numTry} oportinidades para lograr descubir el número correcto. Intenta adivinar el número");
        for (int i = 1; i < (Int32.Parse(numTry))+1; i++)
        {
            Console.WriteLine("Ingresa el número:");
            var numPlayer = Console.ReadLine();

            if (Int32.Parse(numPlayer) == numRandom)
            {
                Console.WriteLine("Has adivinado el número");
                break;
            }
            else if (Int32.Parse(numPlayer) > numRandom)
            {
                int intentos = Int32.Parse(numTry)-i;
                Console.WriteLine($"El número es menor, te quedan {intentos} intentos");
            }
            else if (Int32.Parse(numPlayer) < numRandom)
            {
                int intentos = Int32.Parse(numTry)-i;
                Console.WriteLine($"El número es mayor, te quedan {intentos} intentos");
            }
        }
        Console.WriteLine($"El número era {numRandom}");
        Console.WriteLine("Presiona una tecla para salir...");
        Console.ReadKey(true);
    }
}
