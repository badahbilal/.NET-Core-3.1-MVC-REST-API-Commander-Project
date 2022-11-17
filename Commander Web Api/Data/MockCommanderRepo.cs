using Commander_Web_Api.Models;
using System.Collections.Generic;

namespace Commander_Web_Api.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Plateform = "Kettle & Pan" },
                new Command { Id = 1, HowTo = "cut Bread", Line = "Get a knife", Plateform = "Knife & chopping board" },
                new Command { Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in cup", Plateform = "Lettle & cup" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Plateform = "Kettle & Pan" };
        }
    }
}
