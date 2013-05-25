using System;
using System.Linq;

namespace CalendarRefactoredNS
{
    public class CalendarEvent : IComparable<CalendarEvent>
    {
        private readonly DateTime theEarliestPossibleDate = new DateTime(2000, 01, 01, 00, 00, 00);
        private readonly DateTime theLatestPossibleDate = new DateTime(2020, 01, 01, 00, 00, 00);

        private DateTime date = new DateTime();

        private string title = String.Empty;

        private string location = String.Empty;

        public CalendarEvent(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                if (value < theEarliestPossibleDate || value > theLatestPossibleDate)
                {
                    string message = String.Format(
                        "The data that you put is out of the range {0} ... {1}", theEarliestPossibleDate, theLatestPossibleDate);
                    throw new ArgumentOutOfRangeException(message);
                }
                else
                {
                    this.date = value;
                }
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("title", "Title is missing");
                }
                else if (value == String.Empty)
                {
                    throw new ArgumentException("Title shouldn't be empty");
                }
                else if (value.Length >= 1000)
                {
                    throw new ArgumentException("Title must be less than 1000 characters");
                }
                else if (value.IndexOf("\n") != -1 || value.IndexOf("|") != -1)
                {
                    throw new FormatException(@"Title cannot contain \n and |");
                }
                else
                {
                    this.title = value;
                }
            }
        }

        public string Location { get; set; }

        public override string ToString()
        {
            //BUG
            string form = "{0:yyyy-MM-ddTHH:mm:ss} | {1}";

            if (this.Location != null)
            {
                form += " | {2}";
            }

            string eventAsString = string.Format(form, this.Date, this.Title, this.Location);

            return eventAsString;
        }

        public int CompareTo(CalendarEvent otherEvent)
        {
            int result = DateTime.Compare(this.Date, otherEvent.Date);
            ////TODO: The Bottleneck was here and it was the foreach 
            ////i removed it
            if (result == 0)
            {
                result = string.Compare(this.Title, otherEvent.Title, StringComparison.Ordinal);
            }

            if (result == 0)
            {
                result = string.Compare(this.Location, otherEvent.Location, StringComparison.Ordinal);
            }

            return result;
        }
    }
}