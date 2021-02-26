using RestApiExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiExample.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if (cmd==null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if (cmd==null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Remove(cmd);
        }

        //tablodaki tüm değerleri getirir
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        //tablodaki id değerine göre bir değer getirir
        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
           return  (_context.SaveChanges()>=0);
        }

        //güncelleme işlemi
        public void UpdateCommand(Command cmd)
        {
            //Nothing

        }
    }
}
