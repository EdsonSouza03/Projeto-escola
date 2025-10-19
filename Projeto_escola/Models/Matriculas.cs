using System.ComponentModel.DataAnnotations;

namespace Projeto_escola.Models
{
    public class Matricula
    {
        public int Id { get; set; }

        [Required]
        public string AlunoNome { get; set; } = string.Empty;

        [Required]
        public string DisciplinaNome { get; set; } = string.Empty;



        public DateTime DataMatricula { get; set; } = DateTime.Now;

        // 👇 Adicione o valor padrão aqui
        public string Status { get; set; } = "Ativa";
    }
}
