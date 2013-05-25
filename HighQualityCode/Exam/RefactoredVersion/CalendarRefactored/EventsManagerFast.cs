using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;
using MD = Wintellect.PowerCollections.MultiDictionary<string, CalendarRefactoredNS.CalendarEvent>;

namespace CalendarRefactoredNS
{
    public class EventsManagerFast : IEventsManager
    {
        private MD titlesColection = new MD(true);

        private OrderedMultiDictionary<DateTime, CalendarEvent> datesCollection = new OrderedMultiDictionary<DateTime, CalendarEvent>(true);

        public void AddEvent(CalendarEvent singleEvent)
        {
            string eventTitleLowerCase = singleEvent.Title.ToLowerInvariant();
            this.TitlesColection.Add(eventTitleLowerCase, singleEvent);
            this.DatesCollection.Add(singleEvent.Date, singleEvent);
        }

        public MD TitlesColection
        {
            get
            {
                return this.titlesColection;
            }
        }

        public OrderedMultiDictionary<DateTime, CalendarEvent> DatesCollection
        {
            get
            {
                return this.datesCollection;
            }
        }

        public int DeleteEventsByTitle(string title)
        {
            string titleLowerCase = title.ToLowerInvariant();
            var eventsToBeDeleted = this.titlesColection[titleLowerCase];
            int numberOfMatchedEvents = eventsToBeDeleted.Count;

            foreach (var currentEvent in eventsToBeDeleted)
            {
                this.DatesCollection.Remove(currentEvent.Date, currentEvent);
            }

            this.TitlesColection.Remove(titleLowerCase);

            return numberOfMatchedEvents;
        }

        public IEnumerable<CalendarEvent> ListEvents(DateTime date, int count)
        {
            //max and min value for count are 100 and 1
            if (count > 100 || count < 1)
            {
                string exMessage = String.Format("Count should be in the range {0}...{1}", 1, 100);
                throw new ArgumentOutOfRangeException(exMessage);
            }

            var listOfEventsAfterCertainDate =
                                              from currentEvent in this.DatesCollection.RangeFrom(date, true).Values
                                              select currentEvent;

            var listOfEvents = listOfEventsAfterCertainDate.Take(count);

            return listOfEvents;
        }
    }
}