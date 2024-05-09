namespace P1Guess_the_number
{
class Player
{
    public string _namePlayer;
    public int _assumptions;

    public static int MakeGuess()
    {
        Console.WriteLine("→ Ingresa el número:");
            var numPlayer = Console.ReadLine();
            return (Int32.Parse(numPlayer));
    }

    public Player(string namePlayer)
    {
        _namePlayer = namePlayer;
        _assumptions = 0;
    }
}
}
