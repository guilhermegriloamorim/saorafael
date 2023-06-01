using System.ComponentModel.DataAnnotations;
namespace AlmoxarifadoService.Dominio.DTO
{
    public class ItemEntradaUpdateDto
    {
        [Required]
        public DateTime? DtEntrada { get; set; }

        [Required]
        [Range(0.01, 9999.99)]
        public decimal? Quantidade { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo é de preenchimento obrigatório")]
        [MaxLength(80)]
        public string? Unidade { get; set; }

        [MaxLength(255)]
        public string? Observacao { get; set; }
    }
}
