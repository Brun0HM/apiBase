using apiEscola.Migrations;
using System.ComponentModel.DataAnnotations;

namespace apiEscola.Models
{
    public class Matricula
    {
        public Guid MatriculaId { get; set; }
        [Required(ErrorMessage = "O campo aluno é obrigatorio")]

        public Guid? AlunoId { get; set; }
        public Aluno? Aluno { get; set; }
        [Required(ErrorMessage = "O campo Turma é obrigatorio")]


        public Guid? TurmaId { get; set; }
        public Turma? Turma { get; set; }


        [Required(ErrorMessage = "A data da matricula é obrigatoria")]
        [DataType(DataType.Date, ErrorMessage = "A data informada não é válida")]
        public DateTime Date { get; set; }

    }
}
