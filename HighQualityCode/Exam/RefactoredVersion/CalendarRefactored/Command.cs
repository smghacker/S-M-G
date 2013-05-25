using System;
using System.Linq;

namespace CalendarRefactoredNS
{
    public class Command
    {
        public string CommandName { get; set; }

        public string[] Arguments { get; set; }

        public Command(string cmdName, string[] arguments)
        {
            this.CommandName = cmdName;
            this.Arguments = arguments;
        }

        public static Command Parse(string cmd)
        {
            int endOfCmd = cmd.IndexOf(' ');

            if (endOfCmd == -1)
            {
                throw new ArgumentException("Invalid command" + cmd);
            }

            string cmdName = cmd.Substring(0, endOfCmd);

            var cmdArguments = CommandArgumentsParser(cmd, endOfCmd);

            var command = new Command(cmdName, cmdArguments);

            return command;
        }

        private static string[] CommandArgumentsParser(string cmd, int endOfCommand)
        {
            string cmdInitialArguments = cmd.Substring(endOfCommand + 1);

            var cmdArguments = cmdInitialArguments.Split('|');

            string currentCommand;
            for (int i = 0; i < cmdArguments.Length; i++)
            {
                currentCommand = cmdArguments[i];
                cmdArguments[i] = currentCommand.Trim();
            }

            return cmdArguments;
        }
    }
}