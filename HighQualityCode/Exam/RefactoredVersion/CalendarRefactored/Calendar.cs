using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CalendarRefactoredNS
{
    public class Calendar
    {
        private readonly IEventsManager eventsManager;

        public Calendar(IEventsManager eventsManager)
        {
            this.eventsManager = eventsManager;
        }

        public IEventsManager EventsManager
        {
            get
            {
                return this.eventsManager;
            }
        }

        public string ProcessCommand(Command command)
        {
            string cmdName = command.CommandName;
            int argsLen = command.Arguments.Length;

            if ((cmdName == "AddEvent") && (argsLen == 2))
            {
                return AddEventWithDateAndTitle(command);
            }
            else if ((cmdName == "AddEvent") && (argsLen == 3))
            {
                return AddEventWithDateTitleAndLocation(command);
            }
            else if ((cmdName == "DeleteEvents") && (argsLen == 1))
            {
                return DeleteEvent(command);
            }
            else if ((cmdName == "ListEvents") && (argsLen == 2))
            {
                return ListEvents(command);
            }
            else
            {
                throw new Exception("Non existing command : " + command.CommandName);
            }
        }

        private string DeleteEvent(Command command)
        {
            int countOfDeletedItems = this.EventsManager.DeleteEventsByTitle(command.Arguments[0]);

            if (countOfDeletedItems == 0)
            {
                return "No events found.";
            }

            return countOfDeletedItems + " events deleted";
        }

        private string ListEvents(Command command)
        {
            var date = DateTime.ParseExact(command.Arguments[0], "yyyy-MM-ddThh:mm:ss", CultureInfo.InvariantCulture);
            var count = int.Parse(command.Arguments[1]);
            var events = this.EventsManager.ListEvents(date, count).ToList();
            var result = new StringBuilder();

            if (!events.Any())
            {
                return "No events found";
            }

            foreach (var ev in events)
            {
                result.AppendLine(ev.ToString());
            }

            return result.ToString().Trim();
        }

        private string AddEventWithDateTitleAndLocation(Command command)
        {
            var date = DateTime.ParseExact(command.Arguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            var currentEvent = new CalendarEvent(date, command.Arguments[1], command.Arguments[2]);

            this.EventsManager.AddEvent(currentEvent);

            return "Event added";
        }

        private string AddEventWithDateAndTitle(Command command)
        {
            var date = DateTime.ParseExact(command.Arguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            var currentEvent = new CalendarEvent(date, command.Arguments[1], null);

            this.EventsManager.AddEvent(currentEvent);

            return "Event added";
        }
    }
}