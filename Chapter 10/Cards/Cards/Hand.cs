using System;

namespace Cards
{
    class Hand
    {
        public const int HandSize = 13;
        private PlayingCard[] cards = new PlayingCard[HandSize];
        private int playingCardCount = 0;

        public void AddCardToHand(PlayingCard cardDealt)
        {
            if (this.playingCardCount >= HandSize)
            {
                throw new ArgumentException("Too many cards to hold");
            }

            this.cards[this.playingCardCount] = cardDealt;
            this.playingCardCount++;
            // TODO: add the specified card to the hand
        }

        public override string ToString()
        {
            string result = "";
            foreach (PlayingCard card in this.cards)
            {
                result += $"{card.ToString()}\n";
            }

            return result;
        }
    }
}