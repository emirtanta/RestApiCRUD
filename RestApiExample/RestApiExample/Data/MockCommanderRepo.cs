using RestApiExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiExample.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        //data ekleme
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 1, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kenttle & Pan" },

                new Command { Id = 2, HowTo = "Cut bread", Line = "Get a knife", Platform = "Knife & chopping board" },

                new Command { Id = 3, HowTo = "Make cup of tea", Line = "place teabag in cup", Platform = "Kenttle & Cup" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 1, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kenttle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
