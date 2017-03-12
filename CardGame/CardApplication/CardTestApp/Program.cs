using static System.Console;
using CardLib.Class;

/// <summary>
/// Right click Sln and set CardTestApp as the startup project
/// </summary>
namespace CardApplication
{
    class Program
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
