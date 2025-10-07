using Microsoft.EntityFrameworkCore;
using Projeto_escola.Models;

namespace Projeto_escola.Data
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
    }
}