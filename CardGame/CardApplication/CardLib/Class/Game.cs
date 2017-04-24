using CardLib.Collection;
using System;
using System.Linq;
using static System.Console;
using Extensions;

namespace CardLib.Class
{
    public class Game
    {
        private int currentCard;
        private Deck playDeck;
        private Player[] players;
        private Cards discardedCards;

        public Game()
        {
            currentCard = default(int);
            playDeck = new Deck(true);
            playDeck.LastCardDrawn += Reshuffle;
            playDeck.Shuffle();
            discardedCards = new Cards();
        }

        private void Reshuffle(object source, EventArgs args)
        {
            WriteLine("Discarded cards reshuffled into deck");
            (source as Deck).Shuffle();
            discardedCards = new Cards();
        }

        public void SetPlayers(Player[] newPlayers)
        {
            if(newPlayers.Length > 7)
            {
                throw new ArgumentException("A maximum of 7 players may play this game");
            }

            if(newPlayers.Length < 2)
            {
                throw new ArgumentException("A minimum of 2 players are required to play this game");
            }

            players = newPlayers;
        }

        private void DealHands()
        {
            foreach (Player player in players)
            {
                //Deal the player 7 cards
                Action dealCardToPlayer = () => player.PlayHand.Add(playDeck.GetCard(currentCard++));
                Enumerable.Repeat(dealCardToPlayer, 7).RepeatAction();
            }
        }

        public int PlayGame()
        {
            if (players == null) return -1;

            //Deal initial hands
            DealHands();
            //Initialize game vars, including an intial card to place on the table: playCard
            bool GameWon = false;
            int currentplayer;
            Card playCard = playDeck.GetCard(currentCard++);
            discardedCards.Add(playCard);

            //main game loop
            do
            {
                //Loop Through players in each game round
                foreach (var item in players.Select((player, index) => new { player, index }))
                {
                    //Write out current player, player hand, and the card on the table
                    WritePlayerInfo(item.player);
                }

                GameWon = true;
            }
            while (!GameWon);

            return 0;
        }

        private void WritePlayerInfo(Player currentPlayer)
        {
            WriteLine($"{currentPlayer.Name}'s turn.");
            WriteLine($"Current Hand: ");
            currentPlayer.PlayHand.ForEach(c => WriteLine(c.ToString()));
        }
    }
}
