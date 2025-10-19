namespace Projeto_escola.Models
{
    public class Disciplina
    {
        public int Id { get; set; }

        public required string Nome { get; set; }

        public required string CargaHoraria { get; set; }

        public required string Professor { get; set; }
    }
}
