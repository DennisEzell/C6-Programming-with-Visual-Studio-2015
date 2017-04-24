using static System.Console;
using static System.Convert;
using CardLib.Class;
using CardLib.Enum;
using System.Linq;

/// <summary>
/// Right click Sln and set CardTestApp as the startup project
/// </summary>
namespace CardApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deck myDeck = new Deck();
            //TestShuffle(myDeck);
            //TestCloning(myDeck);
            //TestOperatorOverloading();
            PlayFinalGame();

        }

        /// <summary>
        /// Test method to use final version of the Card Application
        /// The finished version of the game does the following:
        ///     (1) An introduction is displayed
        ///     (2) The user is prompted for a number of players between 2 and 7
        ///     (3) An array of <see cref="Player"/> objects is set up accordingly
        ///     (4) Each Player is prompted for a name, used to intialize one <see cref="Player"/> object in the array
        ///     (5) A <see cref="Game"/> object is created and players are assigned using the <see cref="Game.SetPlayers"/> method.
        ///     (6) The Game is started using the <see cref="Game.Game"/> method
        ///     (7) The int return value of <see cref="Game.PlayGame"/> is used to display a winning message
        ///         -The value returned is the index of the winning player in the Player array
        /// </summary>
        private static void PlayFinalGame()
        {
            //Step (1): Display introduction
            WriteLine("7 Of a Kind: a new and exciting game.");
            WriteLine("To win, you must have 7 cards of the same suit in your hand.\n");

            bool inputOk = false;
            int choice = 1;

            do { inputOk = GetPlayers(ref choice);}
            while (!inputOk);
            
            //Get player names
            Player[] players = new Player[choice];
            foreach(var player in players.Select((player, index) => new { index, player }))
            {
                WriteLine($"Player {player.index}, enter your name");
                players[player.index] = new Player(ReadLine());
            }

            //Start game
            Game newGame = new Game();
            newGame.SetPlayers(players);
            int whoWon = newGame.PlayGame();
            WriteLine($"{players[whoWon].Name} has won the game");
            ReadKey();
        }

        /// <summary>
        /// Helper method to ensure proper number of players is supplied
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        private static bool GetPlayers(ref int choice)
        {
            WriteLine("How many players (2-7)?");
            string input = ReadLine();
            try
            {
                choice = ToInt32(input);
                if (choice >= 2 && choice <= 7)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
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
