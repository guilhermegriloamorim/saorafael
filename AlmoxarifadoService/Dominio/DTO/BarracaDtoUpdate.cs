using System.ComponentModel.DataAnnotations;
namespace AlmoxarifadoService.Dominio.DTO
{
    public class BarracaDtoUpdate
    {

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo é de preenchimento obrigatório")]
        [MaxLength(120, ErrorMessage = "O tamanho máximo de caracteres é 120.")]
        public string? Nome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo é de preenchimento obrigatório")]
        [MaxLength(255, ErrorMessage = "O tamanho máximo de caracteres é 120.")]
        public string? Descricao { get; set; }
    }
}
