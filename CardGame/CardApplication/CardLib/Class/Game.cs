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
                //foreach (var item in players.Select((player, index) => new { player, index }))
                foreach(var player in players)
                {
                    //Write out current player, player hand, and the card on the table
                    WritePlayerInfo(player);
                    WriteLine("\n");
                    WriteLine($"Card in play: {playCard}");

                    bool inputOK = false;
                    do
                    {
                        WriteLine("Press T to take card in play or D to draw:");
                        string playerOption = ReadLine();
                        if (playerOption.ToLower() == "t")
                        {
                            // Add card from table to player hand.
                            WriteLine($"Drawn: {playCard}");

                            // Remove from discarded cards if possible (if deck
                            // is reshuffled it won’t be there any more)                    
                            if (discardedCards.Contains(playCard))
                            {
                                discardedCards.Remove(playCard);
                            }
                            player.PlayHand.Add(playCard);
                            inputOK = true;
                        }
                        if (playerOption.ToLower() == "d")
                        {
                            // Add new card from deck to player hand.
                            Card newCard;
                            // Only add card if it isn’t already in a player hand
                            // or in the discard pile
                            bool cardIsAvailable;
                            do
                            {
                                newCard = playDeck.GetCard(currentCard++);
                                // Check if card is in discard pile
                                cardIsAvailable = !discardedCards.Contains(newCard);
                                if (cardIsAvailable)
                                {
                                    // Loop through all player hands to see if newCard is
                                    // already in a hand.
                                    foreach (Player testPlayer in players)
                                    {
                                        if (testPlayer.PlayHand.Contains(newCard))
                                        {
                                            cardIsAvailable = false;
                                            break;
                                        }
                                    }
                                }
                            } while (!cardIsAvailable);
                            // Add the card found to player hand.
                            WriteLine($"Drawn: {newCard}");
                            player.PlayHand.Add(newCard);
                            inputOK = true;
                        }
                    } while (inputOK == false);

                    // Display new hand with cards numbered.
                    WriteLine("New hand:");
                    player.PlayHand.ForEach(c  => WriteLine($"{player.PlayHand.IndexOf(c) + 1}: {c}"));

                    // Prompt player for a card to discard.
                    inputOK = false;
                    int choice = -1;
                    do
                    {
                        WriteLine("Choose card to discard:");
                        string input = ReadLine();
                        try
                        {
                            // Attempt to convert input into a valid card number.
                            choice = Convert.ToInt32(input);
                            if ((choice > 0) && (choice <= 8))
                                inputOK = true;
                        }
                        catch
                        {
                            // Ignore failed conversions, just continue prompting.
                        }
                    } while (inputOK == false);

                    // Place reference to removed card in playCard (place the card
                    // on the table), then remove card from player hand and add
                    // to discarded card pile.
                    playCard = player.PlayHand[choice - 1];
                    player.PlayHand.RemoveAt(choice - 1);
                    discardedCards.Add(playCard);
                    WriteLine($"Discarding: {playCard}");

                    // Space out text for players
                    WriteLine();

                    // Check to see if player has won the game, and exit the player
                    // loop if so.
                    GameWon = player.HasWon();
                    if (GameWon == true)
                        break;
                }
            } while (!GameWon);

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
