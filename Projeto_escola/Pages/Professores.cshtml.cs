using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projeto_escola.Data;
using Projeto_escola.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Projeto_escola.Pages
{
    public class ProfessoresModel : PageModel
    {
        private readonly AppDbContext _context;

        public ProfessoresModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Professor> Professores { get; set; } = new();

        public async Task OnGetAsync()
        {
            Professores = await _context.Professores.ToListAsync();
        }
    }
}
