using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projeto_escola.Data;
using Projeto_escola.Models;
using System.Linq;

namespace Projeto_escola.Pages
{
    public class PaginaLoginModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public string Usuario { get; set; }

        [BindProperty]
        public string Senha { get; set; }

        public PaginaLoginModel(AppDbContext context) => _context = context;

        public void OnGet() { }

        public IActionResult OnPost()
        {
            var usuario = _context.Professores
                .FirstOrDefault(u => u.Nome == Usuario && u.Senha == Senha);

            if (usuario != null)
            {
                // redireciona para a dashboard
                return RedirectToPage("/Dashboard");
            }

            ModelState.AddModelError(string.Empty, "Usuário ou senha inválidos.");
            return Page();
        }
    }
}
