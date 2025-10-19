using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projeto_escola.Data;
using Projeto_escola.Models;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_escola.Pages
{
    public class AlunosModel : PageModel
    {
        private readonly AppDbContext _context;

        public AlunosModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Aluno> ListaAlunos { get; set; } = new();

        public void OnGet()
        {
            ListaAlunos = _context.Alunos.ToList();
        }

        public IActionResult OnPostDelete(int id)
        {
            var aluno = _context.Alunos.Find(id);
            if (aluno != null)
            {
                _context.Alunos.Remove(aluno);
                _context.SaveChanges();
            }

            return RedirectToPage("/Alunos");
        }
    }
}
