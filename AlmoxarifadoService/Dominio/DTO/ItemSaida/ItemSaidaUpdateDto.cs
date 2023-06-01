using System.ComponentModel.DataAnnotations;
namespace AlmoxarifadoService.Dominio.DTO   
{
    public class ItemSaidaUpdateDto
    {
        [Required]  
        public DateTime? DtSaida { get; set; }
        [Required]
        [Range(0.01, 9999.99)]
        public decimal? Quantidade { get; set; }
        [Required]
        [MaxLength(80)]
        public string? Unidade { get; set; }
        [Required]
        public int? BarracaId { get; set; }
        [MaxLength(255)]
        public string? Observacao { get; set; }
    }
}
