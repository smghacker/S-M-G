using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestToStringAceOfSpades()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Spades);
            string expected = "A♠";
            string actual = card.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringTenOfDiamonds()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Diamonds);
            string expected = "10♦";
            string actual = card.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringSevenOfClubs()
        {
            Card card = new Card(CardFace.Seven, CardSuit.Clubs);
            string expected = "7♣";
            string actual = card.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringTwoOfHearts()
        {
            Card card = new Card(CardFace.Two, CardSuit.Hearts);
            string expected = "2♥";
            string actual = card.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringJackOfHearts()
        {
            Card card = new Card(CardFace.Jack, CardSuit.Hearts);
            string expected = "J♥";
            string actual = card.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
