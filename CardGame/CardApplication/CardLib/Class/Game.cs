using CardLib.Collection;
using System;
using System.Linq;
using static System.Console;

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

        private void SetPlayers(Player[] newPlayers)
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
                Enumerable.Repeat(dealCardToPlayer, 7);
            }
        }

        //TODO: implement this
        public int PlayGame()
        {
            return null;
        }
    }
}
