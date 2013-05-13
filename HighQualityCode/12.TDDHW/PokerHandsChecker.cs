using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if ((hand.Cards[i].Face == hand.Cards[j].Face) && 
                        (hand.Cards[i].Suit == hand.Cards[j].Suit))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            int counter = 1;
            if (IsValidHand(hand))
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = i+1; j < 5; j++)
                    {
                        if (hand.Cards[i].Face == hand.Cards[j].Face)
                        {
                            counter++;
                        }
                        if (counter == 4)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
                throw new ArgumentException("Hand is invalid", "hand");
            }
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (IsValidHand(hand))
            {
                for (int i = 1; i < 5; i++)
                {
                    if (hand.Cards[0].Suit != hand.Cards[i].Suit)
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                throw new ArgumentException("Hand is invalid", "hand");
            }
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
