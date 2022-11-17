using Commander_Web_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander_Web_Api.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> options) : base(options)
        {

        }


        public DbSet<Command> Commands { get; set; }
    }
}
