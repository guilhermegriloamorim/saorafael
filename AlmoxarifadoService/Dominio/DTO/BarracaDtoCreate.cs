using System.ComponentModel.DataAnnotations;
namespace AlmoxarifadoService.Dominio.DTO
{
   
    public class BarracaDtoCreate
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo é de preenchimento obrigatório")]
        [MaxLength(120, ErrorMessage = "O tamanho máximo de caracteres é 120.")]
        public string? Nome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo é de preenchimento obrigatório")]
        [MaxLength(255, ErrorMessage = "O tamanho máximo de caracteres é 255.")]
        public string? Descricao { get; set; }
    }
}
