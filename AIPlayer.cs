namespace P1Guess_the_number
{
    class AIPlayer : Player
    {
        private Random _random;

        public override int MakeGuess()
        {
            return _random.Next(1, 101);
        }

        public AIPlayer(string namePlayer) : base(namePlayer)
        {
            _random = new Random();
        }
    }
}