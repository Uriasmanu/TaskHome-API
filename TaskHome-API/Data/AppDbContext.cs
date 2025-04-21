using Microsoft.EntityFrameworkCore;
using TaskHome_API.Models;

namespace TaskHome_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
