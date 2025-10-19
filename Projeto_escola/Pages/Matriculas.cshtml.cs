using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projeto_escola.Data;
using Projeto_escola.Models;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_escola.Pages
{
    public class MatriculasModel : PageModel
    {
        private readonly AppDbContext _context;

        public MatriculasModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Matricula> Matriculas { get; set; } = new();

        public void OnGet()
        {
            Matriculas = _context.Matriculas.ToList();
        }

        public IActionResult OnPostDelete(int id)
        {
            var matricula = _context.Matriculas.FirstOrDefault(m => m.Id == id);
            if (matricula != null)
            {
                _context.Matriculas.Remove(matricula);
                _context.SaveChanges();
            }
            return RedirectToPage();
        }
    }
}
