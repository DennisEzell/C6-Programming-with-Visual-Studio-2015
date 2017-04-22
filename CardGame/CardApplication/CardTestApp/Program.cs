using static System.Console;
using CardLib.Class;
using CardLib.Enum;

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
            //TestCloning(myDeck);
            TestOperatorOverloading();
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
                Card tempCard = deck.GetCard(i);
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
            WriteLine($"The first card in the original deck is: {deck.GetCard(0)}");
            WriteLine($"The first card in the new deck is: {newDeck.GetCard(0)}");
            deck.Shuffle();
            WriteLine($"Original deck shuffled");
            WriteLine($"The first card in the original deck is: {deck.GetCard(0)}");
            WriteLine($"The first card in the new deck is: {newDeck.GetCard(0)}");
            ReadKey();
        }

        /// <summary>
        /// Private method used to test the operator overloading done in 
        /// the Card class. This functionality is based on Chapter 11 
        /// Operator Overloading @p.284
        /// </summary>
        private static void TestOperatorOverloading()
        {
            Card.isAceHigh = true;
            WriteLine("Aces are high!");
            Card.usesTrumps = true;
            Card.trump = Suit.Club;
            WriteLine("Clubs are trumps");

            Card club5 = new Card(Suit.Club, Rank.Five);
            Card clubAce = new Card(Suit.Club, Rank.Ace);
            Card heart10 = new Card(Suit.Heart, Rank.Ten);
            Card diamondAce = new Card(Suit.Diamond, Rank.Ace);
            Card dupClub5 = new Card(Suit.Club, Rank.Five);

            WriteLine($"{club5.ToString()} == {dupClub5.ToString()} ? {club5 == dupClub5}");
            WriteLine($"{club5.ToString()} != {clubAce.ToString()} ? {club5 != clubAce}");
            WriteLine($"{clubAce.ToString()}.Equals({heart10.ToString()}) ? {clubAce.Equals(heart10)}");
            WriteLine($"Card.Equals({clubAce.ToString()}, {heart10.ToString()}) ? {Card.Equals(clubAce, heart10)}");
            WriteLine($"{club5.ToString()} > {dupClub5.ToString()} ? {club5 > dupClub5}");
            WriteLine($"{club5.ToString()} <= {clubAce.ToString()} ? {club5 <= clubAce}");
            WriteLine($"{club5.ToString()} > {heart10.ToString()} ? {club5 > heart10}");
            WriteLine($"{heart10.ToString()} > {club5.ToString()} ? {heart10 > club5}");
            WriteLine($"{diamondAce.ToString()} > {heart10.ToString()} ? {diamondAce > heart10}");
            WriteLine($"{heart10.ToString()} > {diamondAce.ToString()} ? {heart10 > diamondAce}");
            ReadKey();
        }
    }
}
