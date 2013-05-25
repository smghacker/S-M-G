using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarRefactoredNS
{
    public interface IEventsManager
    {
        /// <summary>
        /// This method adds a calendar event to some collection
        /// </summary>
        /// <param name="newEvent">your event</param>
        void AddEvent(CalendarEvent newEvent);

        /// <summary>
        /// This method deletes all events that have the same title
        /// </summary>
        /// <param name="title">the event title</param>
        int DeleteEventsByTitle(string title);

        /// <summary>
        /// This method returns a collection of events that consists of "count" elements
        /// which are after or on certain date 
        /// </summary>
        /// <param name="date">the date from which to start</param>
        /// <param name="count">the number of events to be shown</param>
        /// <remarks>
        /// If you put bigger number than the number of events you have 
        /// method will return these that you have already
        /// </remarks>
        /// <returns>IEnumerable collection of CalendarEvents</returns>
        IEnumerable<CalendarEvent> ListEvents(DateTime date, int count);
    }
}