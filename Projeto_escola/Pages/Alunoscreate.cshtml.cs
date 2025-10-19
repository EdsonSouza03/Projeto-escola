using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projeto_escola.Data;
using Projeto_escola.Models;

namespace Projeto_escola.Pages
{
    public class AlunosCreateModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public Aluno Aluno { get; set; } = new Aluno
        {
            Nome = string.Empty,
            RA = string.Empty
        };


        public AlunosCreateModel(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                ViewData["Mensagem"] = "Erro: Dados inválidos!";
                return Page();
            }

            try
            {
                _context.Alunos.Add(Aluno);
                _context.SaveChanges();

                ViewData["Mensagem"] = "Aluno cadastrado com sucesso!";
                return RedirectToPage("/Alunos");
            }
            catch (Exception ex)
            {
                ViewData["Mensagem"] = $"Erro ao salvar: {ex.Message}";
                return Page();
            }
        }
    }
}
