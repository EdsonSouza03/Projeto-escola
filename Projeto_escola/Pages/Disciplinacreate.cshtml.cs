using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projeto_escola.Data;
using Projeto_escola.Models;

namespace Projeto_escola.Pages
{
    public class DisciplinasCreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public DisciplinasCreateModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Disciplina Disciplina { get; set; } = new()
        {
            Nome = string.Empty,
            CargaHoraria = string.Empty,
            Professor = string.Empty
        };

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                ViewData["Mensagem"] = "Erro: Dados inválidos.";
                return Page();
            }

            _context.Disciplinas.Add(Disciplina);
            _context.SaveChanges();

            ViewData["Mensagem"] = "Disciplina cadastrada com sucesso!";
            return RedirectToPage("/Disciplinas");
        }
    }
}
