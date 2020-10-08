using CommanderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPI.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAppCommands();
        Command GetCommandByID(int id);

        void CreateCommand(Command cmd);
        void updateCommand(Command cmd);
    }
}
