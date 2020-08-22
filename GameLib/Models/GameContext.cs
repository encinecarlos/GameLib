using Microsoft.EntityFrameworkCore;

namespace GameLib.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Game> Games { get; set; }
    }
}