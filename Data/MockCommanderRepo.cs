using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=1, HowTo="1) Boil an egg 1.", Line="1) Boil water put egg 1.", Platform="1) Kettle & Pan 1."},
                new Command{Id=2, HowTo="2) Boil an egg 2.", Line="2) Boil water put egg 2.", Platform="2) Kettle & Pan 2."},
                new Command{Id=3, HowTo="3) Boil an egg 3.", Line="3) Boil water put egg 3.", Platform="3) Kettle & Pan 3."},
                new Command{Id=4, HowTo="4) Boil an egg 4.", Line="4) Boil water put egg 4.", Platform="4) Kettle & Pan 4."}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=id, HowTo="Boil an egg", Line="Boil water put egg", Platform="Kettle & Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}