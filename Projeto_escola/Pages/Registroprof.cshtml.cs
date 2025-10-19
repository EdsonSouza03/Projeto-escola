using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projeto_escola.Data;
using Projeto_escola.Models;
using System.Linq;

namespace Projeto_escola.Pages
{
    public class RegistroprofModel : PageModel
    {
        private readonly AppDbContext _context;

        public RegistroprofModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string Usuario { get; set; }

        [BindProperty]
        public string Senha { get; set; }
        [BindProperty]
        public string Especialidade { get; set; }

        public IActionResult OnPost()
        {
            var existe = _context.Professores.FirstOrDefault(p => p.Nome == Usuario);
            if (existe != null)
            {
                ViewData["Mensagem"] = "Usuário já existe!";
                return Page();
            }

            var novoProfessor = new Professor
            {
                Nome = Usuario,
                Especialidade = Especialidade,
                Senha = Senha
            };

            _context.Professores.Add(novoProfessor);
            _context.SaveChanges();

            ViewData["Mensagem"] = "Usuário cadastrado com sucesso!";
            return Page();
        }
    }
}
