using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalendarRefactoredNS;
using System.Collections.Generic;

namespace CalendarTests
{
    [TestClass]
    public class EventsManagerFastTest
    {
        [TestMethod]
        [TestCategory("AddEventsManagerFast")]
        public void AddEventMethodCheckTitlesCollectionRegularTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();
            DateTime date = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent singleEvent = new CalendarEvent(date, "Title", null);

            eventsManager.AddEvent(singleEvent);
            Assert.AreEqual(1, eventsManager.TitlesColection.Count);
        }

        [TestMethod]
        [TestCategory("AddEventsManagerFast")]
        public void AddEventMethodCheckDatesCollectionRegularTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();
            DateTime date = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent singleEvent = new CalendarEvent(date, "Title", null);

            eventsManager.AddEvent(singleEvent);
            Assert.AreEqual(1, eventsManager.DatesCollection.Count);
        }

        [TestMethod]
        [TestCategory("AddEventsManagerFast")]
        public void AddEventMethodWithDuplicatedTitleCheckTitlesCollectionTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();

            DateTime firstDate = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent firstEvent = new CalendarEvent(firstDate, "Title", null);


            DateTime secondDate = new DateTime(2003, 01, 02, 02, 02, 02);
            CalendarEvent secondEvent = new CalendarEvent(secondDate, "Title", null);

            eventsManager.AddEvent(firstEvent);
            eventsManager.AddEvent(secondEvent);

            Assert.AreEqual(1, eventsManager.TitlesColection.Count);
        }

        [TestMethod]
        [TestCategory("AddEventsManagerFast")]
        public void AddEventMethodWithDuplicatedTitleCheckDatesCollectionTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();

            DateTime firstDate = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent firstEvent = new CalendarEvent(firstDate, "Title", null);


            DateTime secondDate = new DateTime(2003, 01, 02, 02, 02, 02);
            CalendarEvent secondEvent = new CalendarEvent(secondDate, "Title", null);

            eventsManager.AddEvent(firstEvent);
            eventsManager.AddEvent(secondEvent);

            Assert.AreEqual(2, eventsManager.DatesCollection.Count);
        }

        [TestMethod]
        [TestCategory("AddEventsManagerFast")]
        public void AddEventMethodWithDuplicatedDateCheckTitlesCollectionTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();

            DateTime firstDate = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent firstEvent = new CalendarEvent(firstDate, "Title1", null);


            DateTime secondDate = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent secondEvent = new CalendarEvent(secondDate, "Title2", null);

            eventsManager.AddEvent(firstEvent);
            eventsManager.AddEvent(secondEvent);

            Assert.AreEqual(2, eventsManager.TitlesColection.Count);
        }

        [TestMethod]
        [TestCategory("AddEventsManagerFast")]
        public void AddEventMethodWithDuplicatedDateCheckDatesCollectionTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();

            DateTime firstDate = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent firstEvent = new CalendarEvent(firstDate, "Title1", null);


            DateTime secondDate = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent secondEvent = new CalendarEvent(secondDate, "Title2", null);

            eventsManager.AddEvent(firstEvent);
            eventsManager.AddEvent(secondEvent);

            Assert.AreEqual(1, eventsManager.DatesCollection.Count);
        }

        [TestMethod]
        [TestCategory("DeleteEventsManagerFast")]
        public void DeleteEventsByTitleMethodRegularTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();
            DateTime date = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent singleEvent = new CalendarEvent(date, "Title", null);

            eventsManager.AddEvent(singleEvent);
            int numberOfDeletedEvents = eventsManager.DeleteEventsByTitle("Title");
            Assert.AreEqual(1, numberOfDeletedEvents);
        }

        [TestMethod]
        [TestCategory("DeleteEventsManagerFast")]
        public void DeleteEventsByTitleMethodWhenSuchTitleNoExistTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();
            DateTime date = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent singleEvent = new CalendarEvent(date, "Title", null);

            eventsManager.AddEvent(singleEvent);
            int numberOfDeletedEvents = eventsManager.DeleteEventsByTitle("exam");
            Assert.AreEqual(0, numberOfDeletedEvents);
        }

        [TestMethod]
        [TestCategory("DeleteEventsManagerFast")]
        public void DeleteEventsByTitleMethodCheckTitlesCollectionTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();

            DateTime firstDate = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent firstEvent = new CalendarEvent(firstDate, "Title", null);


            DateTime secondDate = new DateTime(2003, 01, 02, 02, 02, 02);
            CalendarEvent secondEvent = new CalendarEvent(secondDate, "Title", null);

            eventsManager.AddEvent(firstEvent);
            eventsManager.AddEvent(secondEvent);

            int numberOfDeletedEvents = eventsManager.DeleteEventsByTitle("Title");

            Assert.AreEqual(2, numberOfDeletedEvents);
        }

        [TestMethod]
        [TestCategory("DeleteEventsManagerFast")]
        public void DeleteEventsByTitleMethodCheckDatesCollectionTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();

            DateTime firstDate = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent firstEvent = new CalendarEvent(firstDate, "Title1", null);

            DateTime secondDate = new DateTime(2003, 01, 02, 02, 02, 02);
            CalendarEvent secondEvent = new CalendarEvent(secondDate, "Title2", null);

            eventsManager.AddEvent(firstEvent);
            eventsManager.AddEvent(secondEvent);

            int numberOfDeletedEvents = eventsManager.DeleteEventsByTitle("Title1");

            Assert.AreEqual(1, numberOfDeletedEvents);
        }

        [TestMethod]
        [TestCategory("ListEventsManagerFast")]
        public void ListEventsWithLessElementsThanWishedTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();

            DateTime firstDate = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent firstEvent = new CalendarEvent(firstDate, "Title", null);

            DateTime secondDate = new DateTime(2003, 01, 02, 02, 02, 02);
            CalendarEvent secondEvent = new CalendarEvent(secondDate, "Title", null);

            eventsManager.AddEvent(firstEvent);
            eventsManager.AddEvent(secondEvent);

            DateTime startDate = new DateTime(2001, 01, 02, 00, 00, 00);
            IEnumerable<CalendarEvent> resultList = eventsManager.ListEvents(startDate,100);

            int count = 0;
            foreach (var ev in resultList)
            {
                count = count + 1;
            }

            Assert.AreEqual(2,count);
        }

        [TestMethod]
        [TestCategory("ListEventsManagerFast")]
        public void ListEventsWithMoreElementsThanWishedTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();

            DateTime firstDate = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent firstEvent = new CalendarEvent(firstDate, "Title", null);

            DateTime secondDate = new DateTime(2003, 01, 02, 02, 02, 02);
            CalendarEvent secondEvent = new CalendarEvent(secondDate, "Title", null);

            DateTime thirdDate = new DateTime(2003, 01, 02, 02, 02, 02);
            CalendarEvent thirdEvent = new CalendarEvent(thirdDate, "Title", null);

            eventsManager.AddEvent(firstEvent);
            eventsManager.AddEvent(secondEvent);
            eventsManager.AddEvent(thirdEvent);

            DateTime startDate = new DateTime(2001, 01, 02, 00, 00, 00);
            IEnumerable<CalendarEvent> resultList = eventsManager.ListEvents(startDate, 2);

            int count = 0;
            foreach (var ev in resultList)
            {
                count = count + 1;
            }

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        [TestCategory("ListEventsManagerFast")]
        public void ListEventsWhenNoExistTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();

            DateTime startDate = new DateTime(2001, 01, 02, 00, 00, 00);
            IEnumerable<CalendarEvent> resultList = eventsManager.ListEvents(startDate, 2);

            int count = 0;
            foreach (var ev in resultList)
            {
                count = count + 1;
            }

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        [TestCategory("ListEventsManagerFast")]
        public void ListEventsWhenAfterWishedDateNoExistTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();

            DateTime firstDate = new DateTime(2002, 01, 02, 02, 02, 02);
            CalendarEvent firstEvent = new CalendarEvent(firstDate, "Title", null);
            
            DateTime secondDate = new DateTime(2003, 01, 02, 02, 02, 02);
            CalendarEvent secondEvent = new CalendarEvent(secondDate, "Title1", null);

            DateTime thirdDate = new DateTime(2003, 01, 02, 02, 02, 02);
            CalendarEvent thirdEvent = new CalendarEvent(thirdDate, "Title2", null);

            eventsManager.AddEvent(firstEvent);
            eventsManager.AddEvent(secondEvent);
            eventsManager.AddEvent(thirdEvent);

            DateTime startDate = new DateTime(2005, 01, 02, 00, 00, 00);
            IEnumerable<CalendarEvent> resultList = eventsManager.ListEvents(startDate, 2);

            int count = 0;
            foreach (var ev in resultList)
            {
                count = count + 1;
            }

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        [TestCategory("ListEventsManagerFast")]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void ListEventWith0CountTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();

            DateTime startDate = new DateTime(2005, 01, 02, 00, 00, 00);
            IEnumerable<CalendarEvent> resultList = eventsManager.ListEvents(startDate, 0);
        }

        [TestMethod]
        [TestCategory("ListEventsManagerFast")]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void ListEventWith1000CountTest()
        {
            EventsManagerFast eventsManager = new EventsManagerFast();

            DateTime startDate = new DateTime(2005, 01, 02, 00, 00, 00);
            IEnumerable<CalendarEvent> resultList = eventsManager.ListEvents(startDate, 1000);
        }
    }
}
