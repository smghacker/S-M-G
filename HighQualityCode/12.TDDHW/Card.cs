using System;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string faceStr;
            if ((int)this.Face <= 10)
            {
                faceStr = ((int)this.Face).ToString();
            }
            else
            {
                faceStr ="" + this.Face.ToString()[0];
            }

            char suit = ' ';
            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    suit = '♣';
                    break;
                case CardSuit.Diamonds:
                    suit = '♦';
                    break;
                case CardSuit.Hearts:
                    suit = '♥';
                    break;
                case CardSuit.Spades:
                    suit = '♠';
                    break;
            }

            string cardStr = faceStr + suit;
            return cardStr;
        }
    }
}
