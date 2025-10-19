using Microsoft.EntityFrameworkCore;
using Projeto_escola.Models;

namespace Projeto_escola.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
