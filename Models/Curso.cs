using System.ComponentModel.DataAnnotations;

namespace apiEscola.Models
{
    public class Curso
    {
        public Guid CursoId { get; set; }

        [Required(ErrorMessage = "O Campo sigla é Obrigatório")] // Campo obrigatorio 
        [MaxLength(10, ErrorMessage = "O sigla deve ter no máximo 10 caracteres")] // Max de 10 caracteres
        public string Sigla { get; set; }

        [Required(ErrorMessage = "O Campo Descriçãoo é Obrigatório")]  //Campo obrigatorio
        [StringLength(255, ErrorMessage = "O Nome deve ter no máximo 255 caracteres")]
        public string Descricao { get; set; }
    }
}
