namespace P1Guess_the_number
{
abstract class Player
{
    public string _namePlayer;
    public int _assumptions;

    public abstract int MakeGuess();

    public Player(string namePlayer)
    {
        _namePlayer = namePlayer;
        _assumptions = 0;
    }
}
}
