namespace P1Guess_the_number
{
    class Player
    {
        public string _namePlayer;
        private  static int _assumptions;

        public static int MakeGuess()
        {
            Console.WriteLine("→ Ingresa el número:");
            var numPlayer = Console.ReadLine();
            SetAssumptions(Int32.Parse(numPlayer));
            return GetAssumptions ();
        }
        
        // Agregaremos un método público que nos permita consultar el último intento GetLastGuess.
        public static int GetLastGuess()
        {
            return GetAssumptions();;
        }

        private static void SetAssumptions(int value)
        {
            _assumptions = value;
        }

        private static int GetAssumptions()
        {
            return _assumptions;
        }

        public Player(string namePlayer)
        {
            _namePlayer = namePlayer;
            _assumptions = 0;
        }
    }
}
