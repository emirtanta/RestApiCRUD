using RestApiExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiExample.Data
{
    public interface ICommanderRepo
    {

        bool SaveChanges();

        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);


        //ekleme işlemi
        void CreateCommand(Command cmd);

        //güncelleme işlemi
        void UpdateCommand(Command cmd);

        //delete işlemi için
        void DeleteCommand(Command cmd);
    }
}
