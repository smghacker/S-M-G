using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalendarRefactoredNS;
using System.Text;

namespace CalendarTests
{
    [TestClass]
    public class CalendarEventTests
    {
        [TestMethod]
        [TestCategory("DatePropertyCalendarEvent")]
        public void DatePropertyWithValidDataTest()
        {
            DateTime date = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent singleEvent = new CalendarEvent(date, "Title", null);

            Assert.AreEqual(date, singleEvent.Date);
        }

        [TestMethod]
        [TestCategory("DatePropertyCalendarEvent")]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void DatePropertyWithEarlierDateTest()
        {
            DateTime date = new DateTime(199, 01, 02, 02, 02, 02);
            CalendarEvent singleEvent = new CalendarEvent(date, "Title", null);
        }

        [TestMethod]
        [TestCategory("DatePropertyCalendarEvent")]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void DatePropertyWithLaterDateTest()
        {
            DateTime date = new DateTime(3000, 01, 02, 02, 02, 02);
            CalendarEvent singleEvent = new CalendarEvent(date, "Title", null);
        }

        [TestMethod]
        [TestCategory("TitlePropertyCalendarEvent")]
        public void TitlePropertyWithValidDataTest()
        {
            DateTime date = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent singleEvent = new CalendarEvent(date, "Title", null);

            Assert.AreEqual("Title", singleEvent.Title);
        }

        [TestMethod]
        [TestCategory("TitlePropertyCalendarEvent")]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TitlePropertyWithNullDataTest()
        {
            DateTime date = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent singleEvent = new CalendarEvent(date, null, null);
        }

        [TestMethod]
        [TestCategory("TitlePropertyCalendarEvent")]
        public void TitlePropertyWithNullDataIsItTheCorrectExceptionTest()
        {
            DateTime date = new DateTime(2002, 01, 02, 02, 02, 02);
            string message = "";
            try
            {
                CalendarEvent singleEvent = new CalendarEvent(date, null, null);
            }
            catch (Exception exc)
            {
                message = exc.Message;
            }

            Assert.AreEqual("Title is missing\r\nParameter name: title", message);
        }

        [TestMethod]
        [TestCategory("TitlePropertyCalendarEvent")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TitlePropertyWithEmptyDataTest()
        {
            DateTime date = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent singleEvent = new CalendarEvent(date, String.Empty, null);
        }

        [TestMethod]
        [TestCategory("TitlePropertyCalendarEvent")]
        public void TitlePropertyWithEmptyDataIsItTheCorrectExceptionTest()
        {
            DateTime date = new DateTime(2002, 01, 02, 02, 02, 02);
            string message = "";
            try
            {
                CalendarEvent singleEvent = new CalendarEvent(date, String.Empty, null);
            }
            catch (Exception exc)
            {
                message = exc.Message;
            }

            Assert.AreEqual("Title shouldn't be empty", message);
        }

        private string GenerateStringWith1002Symbols()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 1002; i++)
            {
                result.Append("a");
            }

            return result.ToString();
        }

        [TestMethod]
        [TestCategory("TitlePropertyCalendarEvent")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TitlePropertyWithOverloadDataTest()
        {
            DateTime date = new DateTime(2002, 01, 02, 02, 02, 02);
            string title = GenerateStringWith1002Symbols();
            CalendarEvent singleEvent = new CalendarEvent(date, title, null);
        }

        [TestMethod]
        [TestCategory("TitlePropertyCalendarEvent")]
        public void TitlePropertyWithOverloadDataIsItTheCorrectExceptionTest()
        {
            DateTime date = new DateTime(2002, 01, 02, 02, 02, 02);
            string title = GenerateStringWith1002Symbols();
            string message = "";
            try
            {
                CalendarEvent singleEvent = new CalendarEvent(date, title, null);
            }
            catch (Exception exc)
            {
                message = exc.Message;
            }

            Assert.AreEqual("Title must be less than 1000 characters", message);
        }

        [TestMethod]
        [TestCategory("TitlePropertyCalendarEvent")]
        [ExpectedException(typeof(System.FormatException))]
        public void TitlePropertyWithForbiddenCharacters()
        {
            DateTime date = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent singleEvent = new CalendarEvent(date, "KOli |", null);
        }
    }
}
