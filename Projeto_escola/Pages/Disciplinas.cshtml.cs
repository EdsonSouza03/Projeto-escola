using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projeto_escola.Data;
using Projeto_escola.Models;
using Microsoft.EntityFrameworkCore;

namespace Projeto_escola.Pages
{
    public class DisciplinasModel : PageModel
    {
        private readonly AppDbContext _context;

        public DisciplinasModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Disciplina> Disciplinas { get; set; } = new();

        public void OnGet()
        {
            Disciplinas = _context.Disciplinas.ToList();
        }

        public IActionResult OnPostDelete(int id)
        {
            var disciplina = _context.Disciplinas.FirstOrDefault(d => d.Id == id);
            if (disciplina != null)
            {
                _context.Disciplinas.Remove(disciplina);
                _context.SaveChanges();
            }
            return RedirectToPage();
        }
    }
}
