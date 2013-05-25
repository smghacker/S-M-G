using System;
using System.Linq;

namespace AcademyRolePlayGame
{
    class Program
    {
        static Engine GetEngineInstance()
        {
            return new AdvancedEngine();
        }

        static void Main(string[] args)
        {
            Engine engine = GetEngineInstance();

            string command = Console.ReadLine();

            while (command != "end")
            {
                engine.ExecuteCommand(command);
                command = Console.ReadLine();
            }
        }
    }
}
