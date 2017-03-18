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
            //TestShuffle(myDeck);
            TestCloning(myDeck);
        }

        /// <summary>
        /// Private method to test Shuffle functionality
        /// </summary>
        /// <param name="deck"></param>
        private static void TestShuffle(Deck deck)
        {
            deck.Shuffle();

            for (int i = 0; i < 52; i++)
            {
                Card tempCard = deck.getCard(i);
                WriteLine(tempCard.ToString());
            }
            ReadKey();
        }

        /// <summary>
        /// Private method used to test Deck, Card, and Cards
        /// Cloning functionality added based on Chapter 11 
        /// Deep Copy vs. Shallow Copy
        /// </summary>
        private static void TestCloning(Deck deck)
        {
            Deck newDeck = deck.Clone() as Deck;
            WriteLine($"The first card in the original deck is: {deck.getCard(0)}");
            WriteLine($"The first card in the new deck is: {newDeck.getCard(0)}");
            deck.Shuffle();
            WriteLine($"Original deck shuffled");
            WriteLine($"The first card in the original deck is: {deck.getCard(0)}");
            WriteLine($"The first card in the new deck is: {newDeck.getCard(0)}");
            ReadKey();

        }
    }
}
