using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace apiEscola.Models
{
    public class Turma
    {
        public Guid TurmaId { get; set; }

        [Required(ErrorMessage = "O Campo sigla é Obrigatório")] // Campo obrigatorio
        [MaxLength(10, ErrorMessage = "O sigla deve ter no máximo 10 caracteres")] // Max de 10 caracteres
        public string? Sigla { get; set; }

        [DataType(DataType.Date, ErrorMessage = "A data informada não é válida")]
        [Required(ErrorMessage = "A data de incio do curso é obrigatorio")]
        public DateOnly DataInicio { get; set; }

        [DataType(DataType.Date, ErrorMessage = "A data informada não é válida")]
        [Required(ErrorMessage = "A data de fonal do curso é obrigatorio")]
        public DateOnly DataFim { get; set; }

        [Required(ErrorMessage = "O Campo Descriçãoo é Obrigatório")]  //Campo obrigatorio
        [StringLength(255, ErrorMessage = "O Nome deve ter no máximo 255 caracteres")]
        public string? Descricao { get; set; }


        [Required(ErrorMessage = "O campo curso é obrigatorio")]
        public Guid CursoId { get; set; }
        public Guid? Curso
        {
            get; set;
        }
    }
}