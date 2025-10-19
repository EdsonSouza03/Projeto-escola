using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projeto_escola.Data;
using System.Linq;

namespace Projeto_escola.Pages
{
    public class LoginModel(AppDbContext context) : PageModel
    {
        private readonly AppDbContext _context = context;

        [BindProperty]
        public string Usuario { get; set; } = string.Empty;

        [BindProperty]
        public string Senha { get; set; } = string.Empty;

        public required string MensagemErro { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var professor = _context.Professores
                .FirstOrDefault(p => p.Nome == Usuario && p.Senha == Senha);

            if (professor == null)
            {
                MensagemErro = "Usuário ou senha incorretos.";
                return Page();
            }

            // Se quiser guardar o login na sessão:
            HttpContext.Session.SetString("Usuario", professor.Nome);

            return RedirectToPage("Dashboard");
        }
    }
}
