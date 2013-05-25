using System;
using System.Linq;

namespace CalendarRefactoredNS
{
    class CalendarDemo
    {
        public static void Main()
        {
            EventsManagerFast eventManager = new EventsManagerFast();
            Calendar calendar = new Calendar(eventManager);

            while (true)
            {
                string currentCommand = Console.ReadLine();

                if (currentCommand == "End" || currentCommand == null)
                {
                    break;
                }

                try
                {
                    Command cmd = Command.Parse(currentCommand);
                    string output = calendar.ProcessCommand(cmd);
                    Console.WriteLine(output);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}