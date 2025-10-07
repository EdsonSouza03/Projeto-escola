using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Projeto_escola.Pages
{
    public class PaginaLoginModel(ILogger<IndexModel> logger) : PageModel
    {
        private readonly ILogger<IndexModel> _logger = logger;

        public void OnGet()
        {

        }
    }
}
