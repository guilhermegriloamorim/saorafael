using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Almoxarifado.Dominio.Model
{
    public class ItemEntrada
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        
        [Required]
        public DateTime? DtEntrada { get; set; }
        
        [Required]
        [Range(0.01, 9999.99)]
        public decimal? Quantidade { get; set; }
       
        [Required]
        [MaxLength(80)]
        public string? Unidade { get; set; }

        [MaxLength(255)]
        public string? Observacao { get; set; }

        public int? ItemId { get; set; }
        public virtual Item? Item { get; set; }
    }
}
