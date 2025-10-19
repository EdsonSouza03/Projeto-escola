using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projeto_escola.Data;
using Projeto_escola.Models; // 👈 IMPORTANTE — adiciona o namespace da sua classe Matricula

namespace Projeto_escola.Pages
{
    public class MatriculasCreateModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public Matricula Matricula { get; set; } = new Matricula(); // 👈 agora reconhece a classe

        public MatriculasCreateModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet(int? id)
        {
            if (id != null)
            {
                Matricula = _context.Matriculas.FirstOrDefault(m => m.Id == id);
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Matricula.Id == 0)
                _context.Matriculas.Add(Matricula);  // ✅ Adiciona nova
            else
                _context.Matriculas.Update(Matricula);  // ✅ Edita existente

            _context.SaveChanges();

            return RedirectToPage("/Matriculas");  // ✅ Volta pra listagem
        }
    }
}
