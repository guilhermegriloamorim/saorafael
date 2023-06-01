using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Almoxarifado.Dominio.Model
{
    public class Barraca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo é de preenchimento obrigatório")]
        [MaxLength(120)]
        public string? Nome { get; set; }

        [MaxLength(255)]
        public string? Descricao { get; set; }
    }
}
