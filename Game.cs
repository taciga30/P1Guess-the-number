namespace P1Guess_the_number;

class Game
{
 public static int GeneratedRandom ()
        {
 
            Random numRandom = new Random ();
 
            //Genera un numero entre 1 y 100 (101 no se incluye)
            return numRandom.Next (1,101);
            
        }
}