using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTests
{
    [TestClass]
    public class PokerHandsCheckerTests
    {
        [TestMethod]
        public void IsValidHandRegularTest()
        {
            Hand hand =new Hand(
            new Card(CardFace.Jack,CardSuit.Diamonds),
            new Card(CardFace.Queen,CardSuit.Hearts),
            new Card(CardFace.Four,CardSuit.Spades),
            new Card(CardFace.Seven, CardSuit.Clubs),
            new Card(CardFace.Ace,CardSuit.Spades)
            );

            PokerHandsChecker pokerChecker = new PokerHandsChecker();

            Assert.IsTrue(pokerChecker.IsValidHand(hand));
        }

        [TestMethod]
        public void IsValidHandTestWithTwoSameCards()
        {
            Hand hand = new Hand(
            new Card(CardFace.Jack, CardSuit.Diamonds),
            new Card(CardFace.Queen, CardSuit.Hearts),
            new Card(CardFace.Four, CardSuit.Spades),
            new Card(CardFace.Seven, CardSuit.Clubs),
            new Card(CardFace.Seven, CardSuit.Clubs)
            );

            PokerHandsChecker pokerChecker = new PokerHandsChecker();

            Assert.IsFalse(pokerChecker.IsValidHand(hand));
        }

        [TestMethod]
        public void IsFlushWithFlushTest()
        {
            Hand hand = new Hand(
            new Card(CardFace.Jack, CardSuit.Diamonds),
            new Card(CardFace.Queen, CardSuit.Diamonds),
            new Card(CardFace.Four, CardSuit.Diamonds),
            new Card(CardFace.Seven, CardSuit.Diamonds),
            new Card(CardFace.Ace, CardSuit.Diamonds)
            );

            PokerHandsChecker pokerChecker = new PokerHandsChecker();

            Assert.IsTrue(pokerChecker.IsFlush(hand));
        }

        [TestMethod]
        public void IsFlushWithoutFlushTest()
        {
            Hand hand = new Hand(
            new Card(CardFace.Jack, CardSuit.Diamonds),
            new Card(CardFace.Queen, CardSuit.Spades),
            new Card(CardFace.Four, CardSuit.Diamonds),
            new Card(CardFace.Seven, CardSuit.Diamonds),
            new Card(CardFace.Ace, CardSuit.Diamonds)
            );

            PokerHandsChecker pokerChecker = new PokerHandsChecker();

            Assert.IsFalse(pokerChecker.IsFlush(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void IsFlushWithInvalidHand()
        {
            Hand hand = new Hand(
            new Card(CardFace.Jack, CardSuit.Diamonds),
            new Card(CardFace.Jack, CardSuit.Diamonds),
            new Card(CardFace.Seven, CardSuit.Diamonds),
            new Card(CardFace.Seven, CardSuit.Diamonds),
            new Card(CardFace.Seven, CardSuit.Diamonds)
            );

            PokerHandsChecker pokerChecker = new PokerHandsChecker();

            Assert.IsTrue(pokerChecker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void IsFourOfAKindWithExistingFour()
        {
            Hand hand = new Hand(
            new Card(CardFace.Jack, CardSuit.Diamonds),
            new Card(CardFace.Jack, CardSuit.Hearts),
            new Card(CardFace.Jack, CardSuit.Spades),
            new Card(CardFace.Jack, CardSuit.Clubs),
            new Card(CardFace.Ace, CardSuit.Spades)
            );

            PokerHandsChecker pokerChecker = new PokerHandsChecker();

            Assert.IsTrue(pokerChecker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void IsFourOfAKindWithoutExistingFour()
        {
            Hand hand = new Hand(
            new Card(CardFace.Jack, CardSuit.Diamonds),
            new Card(CardFace.Jack, CardSuit.Hearts),
            new Card(CardFace.Jack, CardSuit.Spades),
            new Card(CardFace.Ace, CardSuit.Clubs),
            new Card(CardFace.Ace, CardSuit.Spades)
            );

            PokerHandsChecker pokerChecker = new PokerHandsChecker();

            Assert.IsTrue(pokerChecker.IsFourOfAKind(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void IsFourOfAKindWithInvalidHand()
        {
            Hand hand = new Hand(
            new Card(CardFace.Jack, CardSuit.Diamonds),
            new Card(CardFace.Seven, CardSuit.Clubs),
            new Card(CardFace.Seven, CardSuit.Spades),
            new Card(CardFace.Seven, CardSuit.Diamonds),
            new Card(CardFace.Seven, CardSuit.Diamonds)
            );

            PokerHandsChecker pokerChecker = new PokerHandsChecker();

            Assert.IsTrue(pokerChecker.IsFourOfAKind(hand));
        }
    }
}
