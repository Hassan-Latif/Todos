using Microsoft.EntityFrameworkCore;
using Todos_App.Models;

namespace Todos_App.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }
    
    }
}
