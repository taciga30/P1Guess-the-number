namespace P1Guess_the_number
{
    class HumanPlayer : Player
    {
        public override int MakeGuess()
        {
            Console.WriteLine("→ Ingresa el número:");
            var numPlayer = Console.ReadLine();
            return (Int32.Parse(numPlayer));
        }

        public HumanPlayer(string namePlayer):base(namePlayer)
        {
        }
    }
}