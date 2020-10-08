using CommanderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
//this file is only for debugging

namespace CommanderAPI.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command { id = 0, customerName = "Huy", address = "Ha Noi", phoneNumber = "123456789", email="jasoncs1997@gmail.com" },
                new Command { id = 1, customerName = "The Anh", address = "Ha Noi", phoneNumber = "156789", email="jasoncs1934@gmail.com" }
            };
            return commands;
        }

        public Command GetCommandByID(int id)
        {
            return new Command { id = 0, customerName = "Huy", address = "Ha Noi", phoneNumber = "123456789", email="jasoncs1997@gmail.com" };

        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
