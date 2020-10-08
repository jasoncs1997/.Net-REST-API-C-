using CommanderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPI.Data
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
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Add(cmd);


        }

        public IEnumerable<Command> GetAppCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandByID(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.id == id);
        }

        public bool SaveChanges()
        {
           return  (_context.SaveChanges() >= 0);
        }

        public void updateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
