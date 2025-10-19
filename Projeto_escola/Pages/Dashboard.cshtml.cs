using Microsoft.AspNetCore.Mvc.RazorPages;
using Projeto_escola.Data;
using System.Linq;

namespace Projeto_escola.Pages
{
    public class DashboardModel : PageModel
    {
        private readonly AppDbContext _context;

        public int TotalProfessores { get; set; }
        public int TotalAlunos { get; set; }
        public int TotalDisciplinas { get; set; }
        public int TotalMatriculas { get; set; }

        public DashboardModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            TotalProfessores = _context.Professores.Count();
            TotalAlunos = _context.Alunos.Count();
            TotalDisciplinas = _context.Disciplinas.Count();
            TotalMatriculas = _context.Matriculas.Count();
        }
    }
}
