using Commander_Web_Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace Commander_Web_Api.Data
{
    public class SqlServerCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlServerCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}
