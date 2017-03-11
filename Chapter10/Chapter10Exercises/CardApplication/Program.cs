using static System.Console;
using CardLib.Class;

namespace CardApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();

            for (int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.getCard(i);
                WriteLine(tempCard.ToString());
            }
            ReadKey();
        }
    }
}
