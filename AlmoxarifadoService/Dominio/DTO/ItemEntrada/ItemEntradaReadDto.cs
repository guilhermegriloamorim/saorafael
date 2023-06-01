namespace AlmoxarifadoService.Dominio.DTO
{
    public class ItemEntradaReadDto
    {
        public int? Id { get; set; }
        public DateTime? DtEntrada { get; set; }
        public decimal? Quantidade { get; set; }
        public string? Unidade { get; set; }
        public string? Observacao { get; set; }
        public int? ItemId { get; set; }
    }
}
