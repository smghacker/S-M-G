using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarRefactoredNS
{
    public class EventsManager : IEventsManager
    {
        private List<CalendarEvent> events = new List<CalendarEvent>();

        public List<CalendarEvent> Events
        {
            get
            {
                return this.events;
            }
        }

        public void AddEvent(CalendarEvent newEvent)
        {
            this.Events.Add(newEvent);
        }

        public int DeleteEventsByTitle(string title)
        {
            var newEventsList = this.Events.RemoveAll(
                currentEvent => currentEvent.Title.ToLowerInvariant() == title.ToLowerInvariant());

            return newEventsList;
        }

        public IEnumerable<CalendarEvent> ListEvents(DateTime date, int count)
        {
            var listOfEventsAfterCertainDate = from currentEvent in this.Events
                                               where currentEvent.Date >= date
                                               orderby currentEvent.Date, currentEvent.Title, currentEvent.Location
                                               select currentEvent;

            return listOfEventsAfterCertainDate.Take(count);
        }
    }
}